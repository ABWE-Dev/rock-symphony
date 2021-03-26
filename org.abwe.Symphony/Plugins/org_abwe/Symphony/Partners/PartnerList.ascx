<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PartnerList.ascx.cs" Inherits="RockWeb.Plugins.org_abwe.Symphony.PartnerList" %>

<asp:UpdatePanel ID="upnlPartners" runat="server">
    <ContentTemplate>

        <Rock:NotificationBox ID="nbWarningMessage" runat="server" NotificationBoxType="Danger" Visible="true" />

        <asp:Panel ID="pnlPartnerList" CssClass="panel panel-block" runat="server">

            <div class="panel-heading">
                <h1 class="panel-title"><i class="fa fa-people-carry"></i> Partner List</h1>
            </div>
            <div class="panel-body">

                <div class="grid grid-panel">
                    <!-- TODO add country and my partners filters-->
                    <Rock:GridFilter ID="gfPartnerFilter" runat="server">
                        <Rock:RockTextBox ID="tbPartnerName" runat="server" Label="Partner"></Rock:RockTextBox>
                        <Rock:RockCheckBoxList ID="cblStatusFilter" runat="server" Label="Status" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Active" Value="Active"></asp:ListItem>
                            <asp:ListItem Text="Potential" Value="Potential"></asp:ListItem>
                            <asp:ListItem Text="Inactive" Value="Inactive"></asp:ListItem>
                        </Rock:RockCheckBoxList>
                    </Rock:GridFilter>

                    <Rock:ModalAlert ID="mdGridWarning" runat="server" />
                    <Rock:Grid ID="gPartnerList" runat="server" RowItemText="Partner" EmptyDataText="No Partneres Found" AllowSorting="true" OnRowSelected="gPartnerList_RowSelected" >
                        <Columns>
                            <Rock:RockBoundField DataField="PartnerName" HeaderText="Partner" SortExpression="PartnerName" />
                            <Rock:RockBoundField DataField="PartnerOrganization" HeaderText="Partner Orgnaization" SortExpression="PartnerOrganization"/>
                            <Rock:RockBoundField DataField="PrimaryMinistry" HeaderText="Primary Ministry" ColumnPriority="DesktopSmall" />
                            <Rock:RockBoundField DataField="PrimaryCountry" HeaderText="Primary Country" ColumnPriority="DesktopSmall" SortExpression="PrimaryCountry"/>
                            <Rock:DateField DataField="LatestUpdateDate" HeaderText="Date of Latest Update" ColumnPriority="DesktopSmall" SortExpression="LatestUpdateDate"/>
                            <Rock:BoolField DataField="IsMyPartner" HeaderText="My Partner" SortExpression="IsMyPartner"/>
                        </Columns>
                    </Rock:Grid>

                </div>

            </div>

        </asp:Panel>

    </ContentTemplate>
</asp:UpdatePanel>
