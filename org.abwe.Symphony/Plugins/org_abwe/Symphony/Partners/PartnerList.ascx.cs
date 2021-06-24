// <copyright>
// Copyright by ABWE
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rock;
using Rock.Attribute;
using Rock.Data;
using Rock.Model;
using Rock.Security;
using Rock.Utility;
using Rock.Web.Cache;
using Rock.Web.UI;
using Rock.Web.UI.Controls;

namespace RockWeb.Plugins.org_abwe.Symphony
{
    [DisplayName( "Partner List" )]
    [Category( "org_abwe > Symphony > Partners" )]
    [Description( "Lists set of Partners based on permission level and provides some basic filtering" )]

    #region Block Attributes

    [LinkedPage(
        "Detail Page",
        Key = AttributeKey.DetailPage,
        Order = 0 )]

    #endregion Block Attributes
    public partial class PartnerList : RockBlock, ICustomGridColumns
    {
        #region Attribute Keys

        private static class AttributeKey
        {
            public const string DetailPage = "DetailPage";
        }

        #endregion Attribute Keys

        #region Control Methods

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit( EventArgs e )
        {
            base.OnInit( e );

            bool canEdit = IsUserAuthorized( Authorization.EDIT );

            gfPartnerFilter.ApplyFilterClick += gfPartnerFilter_ApplyFilterClick;
            gfPartnerFilter.DisplayFilterValue += gfPartnerFilter_DisplayFilterValue;

            gPartnerList.DataKeyNames = new string[] { "Id" };
            gPartnerList.Actions.ShowAdd = canEdit;
            gPartnerList.Actions.ShowExcelExport = true;
            gPartnerList.Actions.AddClick += gPartnerList_AddClick;
            gPartnerList.GridRebind += gPartnerList_GridRebind;
            // gPartnerList.PersonIdField = "Id";
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Load" /> event.
        /// </summary>
        /// <param name="e">The <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad( e );

            if ( !Page.IsPostBack )
            {
                BindFilter();
                BindGrid();
            }
        }

        #endregion Control Methods

        #region Events

        /// <summary>
        /// Handles the DisplayFilterValue event of the gfPartnerFilter control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="Rock.Web.UI.Controls.GridFilter.DisplayFilterValueArgs"/> instance containing the event data.</param>
        private void gfPartnerFilter_DisplayFilterValue( object sender, Rock.Web.UI.Controls.GridFilter.DisplayFilterValueArgs e )
        {
            if (e.Key == "Partner Name")
            {
                return;
            } else if ( e.Key == "Status")
            {
                e.Value = ResolveValues(e.Value, cblStatusFilter);
            }
        }

        /// <summary>
        /// Handles the ApplyFilterClick event of the gfPartnerFilter control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void gfPartnerFilter_ApplyFilterClick( object sender, EventArgs e )
        {
            gfPartnerFilter.SaveUserPreference( "Partner Name", tbPartnerName.Text );
            gfPartnerFilter.SaveUserPreference("Status", cblStatusFilter.SelectedValues.AsDelimited(";"));

            // If it's there, strip the SearchTerm parameter from the query string and reload.
            if ( !string.IsNullOrWhiteSpace( PageParameter( "SearchTerm" ) ) )
            {
                var parameters = System.Web.HttpUtility.ParseQueryString( Request.Url.Query );
                parameters.Remove( "SearchTerm" );
                string url = Request.Url.AbsolutePath + ( parameters.Count > 0 ? "?" + parameters.ToString() : string.Empty );
                Response.Redirect( url );
            }
            else
            {
                BindGrid();
            }
        }

        /// <summary>
        /// Handles the GridRebind event of the gPartnerList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void gPartnerList_GridRebind( object sender, EventArgs e )
        {
            BindGrid();
        }

        /// <summary>
        /// Handles the AddClick event of the gPartnerList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void gPartnerList_AddClick( object sender, EventArgs e )
        {
            var parms = new Dictionary<string, string>();
            parms.Add( "GroupId", "0" );
            NavigateToLinkedPage( AttributeKey.DetailPage, parms );
        }

        /// <summary>
        /// Handles the RowSelected event of the gPartnerList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="Rock.Web.UI.Controls.RowEventArgs"/> instance containing the event data.</param>
        protected void gPartnerList_RowSelected( object sender, Rock.Web.UI.Controls.RowEventArgs e )
        {
            var parms = new Dictionary<string, string>();
            var PartnerId = e.RowKeyId;
            parms.Add( "GroupId", PartnerId.ToString() );
            NavigateToLinkedPage( AttributeKey.DetailPage, parms );
        }

        #endregion Events

        #region Internal Methods

        /// <summary>
        /// Binds the filter.
        /// </summary>
        private void BindFilter()
        {
            var rockContext = new RockContext();

            // Partner Name Filter
            tbPartnerName.Text = gfPartnerFilter.GetUserPreference( "Partner Name" );
            string statusSelections = gfPartnerFilter.GetUserPreference("Status");
            if (!string.IsNullOrWhiteSpace(statusSelections))
            {
                cblStatusFilter.SetValues(statusSelections.Split(';').ToList());
            } else
            {
                cblStatusFilter.ClearSelection();
            }

        }

        /// <summary>
        /// Binds the grid.
        /// </summary>
        private void BindGrid()
        {
            var rockContext = new RockContext();
            var partnerGroupType = GroupTypeCache.Get(org.abwe.Symphony.SystemGuids.GroupType.GROUPTYPE_PARTNERSHIP.AsGuid());
            var primaryTeamMemberRole = partnerGroupType.Roles.FirstOrDefault(
                r => r.Guid.Equals(org.abwe.Symphony.SystemGuids.GroupTypeRole.GROUPROLE_PRIMARY_TEAM_MEMBER.AsGuid())
            );
            var secondaryTeamMemberRole = partnerGroupType.Roles.FirstOrDefault(
                r => r.Guid.Equals(org.abwe.Symphony.SystemGuids.GroupTypeRole.GROUPROLE_SECONDARY_TEAM_MEMBER.AsGuid())
            );
            var partnerOrganizationGroupType = GroupTypeCache.Get(org.abwe.Symphony.SystemGuids.GroupType.GROUPTYPE_PARTNER_ORG.AsGuid());

            // QUESTION:  is security required here based on view all partners role or membership in partnership group???
            var PartnerQueryable = new GroupService(rockContext).GetByGroupTypeId(partnerGroupType.Id);
                // do not include partner organizations because team members do not belong to orgs so security won't work

            var PartnerNameFilter = string.Empty;

            // Use the name passed in the page parameter if given
            if ( !string.IsNullOrWhiteSpace( PageParameter( "SearchTerm" ) ) )
            {
                gfPartnerFilter.Visible = false;
                PartnerNameFilter = PageParameter( "SearchTerm" );
            }
            else
            {
                // Partner Name Filter
                PartnerNameFilter = gfPartnerFilter.GetUserPreference( "Partner Name" );
            }

            if ( !string.IsNullOrWhiteSpace( PartnerNameFilter ) )
            {
                PartnerQueryable = PartnerQueryable.Where( a => a.Name.Contains( PartnerNameFilter ) );
            }

            var statusFilters = cblStatusFilter.SelectedValues;
            if (!statusFilters.Any())
            {
                statusFilters.Add("Active");  // default to filtering active partner
            }
            var activeRecordStatusValueId = DefinedValueCache.Get(Rock.SystemGuid.DefinedValue.PERSON_RECORD_STATUS_ACTIVE.AsGuid()).Id;
            var inactiveRecordStatusValueId = DefinedValueCache.Get(Rock.SystemGuid.DefinedValue.PERSON_RECORD_STATUS_INACTIVE.AsGuid()).Id;
            var potentialRecordStatusValueId = DefinedValueCache.Get(org.abwe.Symphony.SystemGuids.DefinedValue.RECORD_STATUS_POTENTIAL.AsGuid()).Id;
            List<int> statusFilterIds = new List<int>();
            foreach (var sf in statusFilters)
            {
                if (sf == "Active")
                {
                    statusFilterIds.Add(activeRecordStatusValueId);
                } else if (sf == "Inactive")
                {
                    statusFilterIds.Add(inactiveRecordStatusValueId);
                } else if (sf == "Potential" )
                {
                    statusFilterIds.Add(potentialRecordStatusValueId);
                }

            }

            PartnerQueryable = PartnerQueryable.Where(p => statusFilterIds.Contains(p.StatusValueId ?? 0));


            var partners = new List<PartnerSelectInfo>();
            var definedValueService = new DefinedValueService(rockContext);
            var contentChannelItemService = new ContentChannelItemService(rockContext);
            int partnerUpdatesChannelTypeId = new ContentChannelService(rockContext).GetId(org.abwe.Symphony.SystemGuids.ContentChannel.PARTNER_UPDATES.AsGuid()) ?? 0;

            Dictionary<int, DateTime> latestUpdateDates = new Dictionary<int, DateTime>();
            var partnerUpdates = contentChannelItemService.Queryable()
                .Where(a => a.ContentChannelId == partnerUpdatesChannelTypeId);
            foreach (var pu in partnerUpdates)
            {
                pu.LoadAttributes();
                int puGroupId = pu.GetAttributeValue("GroupId").AsInteger();
                
                DateTime updateDate;
                if (latestUpdateDates.TryGetValue(puGroupId, out updateDate))
                {
                    if (pu.StartDateTime > updateDate)
                    {
                        latestUpdateDates[puGroupId] = pu.StartDateTime;
                    }
                } else
                {
                    latestUpdateDates.Add(puGroupId, pu.StartDateTime);
                }
            }

            foreach (var p in PartnerQueryable)
            {
                p.LoadAttributes();
                string partnerIdStr = p.Id.ToString();
                if (p.IsAuthorized( Authorization.VIEW, CurrentPerson))
                {
                    DateTime? lud = null;
                    if (latestUpdateDates.ContainsKey(p.Id)) {
                        lud = new DateTime();
                        lud = latestUpdateDates[p.Id];
                    }

                    partners.Add(new PartnerSelectInfo
                    {
                        Id = p.Id,
                        PartnerOrganizationId = p.ParentGroup.GroupTypeId == partnerOrganizationGroupType.Id ? p.ParentGroup.Id : 0,
                        PartnerName = p.Name,
                        PartnerOrganization = p.ParentGroup.GroupTypeId == partnerOrganizationGroupType.Id ? p.ParentGroup.Name : "",
                        PrimaryMinistry = p.Description,
                        PrimaryCountry = p.GetAttributeValue("PrimaryCountryOfService") == "" ? "" : definedValueService.Get(p.GetAttributeValue("PrimaryCountryOfService").AsGuid()).Description,
                        LatestUpdateDate = lud,
                        IsMyPartner = Convert.ToBoolean(p.Members
                           .Where(m => (m.GroupRoleId == primaryTeamMemberRole.Id || m.GroupRoleId == secondaryTeamMemberRole.Id) &&
                                        m.PersonId == CurrentPerson.Id)
                           .Count())
                    });
                }
            }
            var partnerSelectQry = partners.AsQueryable();
            SortProperty sortProperty = gPartnerList.SortProperty;
            if (sortProperty != null)
            {
                partnerSelectQry = partnerSelectQry.Sort(sortProperty);
            }
            else
            {
                partnerSelectQry = partnerSelectQry.OrderBy(q => q.PartnerName);
            }

            gPartnerList.EntityTypeId = EntityTypeCache.Get<Group>().Id;
            gPartnerList.DataSource = partnerSelectQry.ToList();
            gPartnerList.DataBind();
            
        }


        /// <summary>
        /// Resolves the values.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <param name="listControl">The list control.</param>
        /// <returns></returns>
        private string ResolveValues(string values, System.Web.UI.WebControls.CheckBoxList checkBoxList)
        {
            var resolvedValues = new List<string>();

            foreach (string value in values.Split(';'))
            {
                var item = checkBoxList.Items.FindByValue(value);
                if (item != null)
                {
                    resolvedValues.Add(item.Text);
                }
            }

            return resolvedValues.AsDelimited(", ");
        }

        #endregion Internal Methods

        /// </summary>
        /// <seealso cref="Rock.Utility.RockDynamic" />
        private class PartnerSelectInfo : RockDynamic
        {
            public int Id { get; set; }  // partnership ID
            public int? PartnerOrganizationId { get; set; }
            public string PartnerName { get; set; }
            public string PartnerOrganization { get; set; }
            public string PrimaryMinistry { get; set; }
            public string PrimaryCountry { get; set; }
            public DateTime? LatestUpdateDate { get; set; }
            public bool IsMyPartner { get; set; }
        }
    }
}
