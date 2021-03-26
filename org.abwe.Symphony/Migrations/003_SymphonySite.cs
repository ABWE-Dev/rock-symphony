using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Rock.Plugin;

namespace org.abwe.Symphony.Migrations
{
    [MigrationNumber(6, "1.6.0")]
    class SymphonySite : Migration
    {
        public override void Up()
        {
            return;  // DON'T DO ANYTHING FOR NOW
            System.Diagnostics.Debug.WriteLine("executing migration for LG symphony site");

            RockMigrationHelper.AddSite("Symphony - Live Global", "", "Symphony", "986BE559-65DA-40BF-A49B-ADDEE1215F13");
            //TODO -- figure out how to add site icon and site logo

            // Site:Symphony - Live Global
            RockMigrationHelper.AddLayout("986BE559-65DA-40BF-A49B-ADDEE1215F13","Blank","Blank","","682D7AEB-A820-473B-9105-BD658BB5240C");
            // Site:Symphony - Live Global
            RockMigrationHelper.AddLayout("986BE559-65DA-40BF-A49B-ADDEE1215F13","Dialog","Dialog","","38E907F0-3475-44FA-B964-11B5201C8609");
            // Site:Symphony - Live Global
            RockMigrationHelper.AddLayout("986BE559-65DA-40BF-A49B-ADDEE1215F13","Error","Error","","4C75D028-321E-463C-818B-F0B43416BAB3");
            // Site:Symphony - Live Global
            RockMigrationHelper.AddLayout("986BE559-65DA-40BF-A49B-ADDEE1215F13","FullWidth","Full Width","","643ED200-747A-4F28-8660-6DE9B72D2D06");
            // Site:Symphony - Live Global
            RockMigrationHelper.AddLayout("986BE559-65DA-40BF-A49B-ADDEE1215F13","Homepage","Homepage","","5AABCC9B-556E-48E6-840C-B46E7264A310");
            // Site:Symphony - Live Global
            RockMigrationHelper.AddLayout("986BE559-65DA-40BF-A49B-ADDEE1215F13","LeftSidebar","Left Sidebar","","9535128E-A842-46CA-9E1F-6AE5E80673F4");
            // Site:Symphony - Live Global
            RockMigrationHelper.AddLayout("986BE559-65DA-40BF-A49B-ADDEE1215F13","PersonDetail","Person Detail","","CA118F07-217B-4182-AA60-576C204E9E6A");
            // Site:Symphony - Live Global
            RockMigrationHelper.AddLayout("986BE559-65DA-40BF-A49B-ADDEE1215F13","RightSidebar","Right Sidebar","","7C0B9A1A-E631-49BF-BD50-DA6BFC81B1CA");
            // Site:Symphony - Live Global
            RockMigrationHelper.AddLayout("986BE559-65DA-40BF-A49B-ADDEE1215F13","Splash","Splash","","CE298A9D-AF14-4BD1-890C-8CD51F149C9C");
            // Site:Symphony - Live Global
            RockMigrationHelper.AddLayout("986BE559-65DA-40BF-A49B-ADDEE1215F13","ThreeColumn","Three Column","","C3B9A2ED-C01C-462D-8684-5EE20E0ACC95");

            RockMigrationHelper.AddPage(true, "986BE559-65DA-40BF-A49B-ADDEE1215F13", "643ED200-747A-4F28-8660-6DE9B72D2D06", "Live Global Symphony Home Page", "", "983638E8-25C9-4DBC-A117-C07463A98B53", "");
            Sql("UPDATE [Site] set [DefaultPageId] = (SELECT [Id] FROM [Page] where [Guid] ='983638E8-25C9-4DBC-A117-C07463A98B53') WHERE Id = '986BE559-65DA-40BF-A49B-ADDEE1215F13'");
            // Add Page Partners to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "983638E8-25C9-4DBC-A117-C07463A98B53","643ED200-747A-4F28-8660-6DE9B72D2D06","Partners","","4BD7F1A3-F70F-4556-80B7-82EA09D9C966","fa fa-people-carry");
            // Add Page ManagePartners to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "4BD7F1A3-F70F-4556-80B7-82EA09D9C966","682D7AEB-A820-473B-9105-BD658BB5240C","ManagePartners","","54503BEF-FDCD-4042-AF52-924043EB2188","");
            // Add Page Partner Directory to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "54503BEF-FDCD-4042-AF52-924043EB2188","643ED200-747A-4F28-8660-6DE9B72D2D06","Partner Directory","","31EA7AEE-E361-43B8-B6F2-D787CBFC6824","fa fa-address-book");
            // Add Page Partner Opportunities to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "54503BEF-FDCD-4042-AF52-924043EB2188","643ED200-747A-4F28-8660-6DE9B72D2D06","Partner Opportunities","","384CF90F-5B05-4D5E-92D2-96C9F1EBB395","fa fa-map");
            // Add Page Partner Communication to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "4BD7F1A3-F70F-4556-80B7-82EA09D9C966","643ED200-747A-4F28-8660-6DE9B72D2D06","Partner Communication","","7423C29B-8680-45DD-8B3F-DE1C1D1B26BE","");
            // Add Page Partner Inbox to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "7423C29B-8680-45DD-8B3F-DE1C1D1B26BE","643ED200-747A-4F28-8660-6DE9B72D2D06","Partner Inbox","","EC7F02AD-B351-4554-A002-56CB0D1A444B","fa fa-inbox");
            // Add Page Team to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "983638E8-25C9-4DBC-A117-C07463A98B53","643ED200-747A-4F28-8660-6DE9B72D2D06","Team","","85B49AE6-AC36-47D5-8499-897B40CE61D4","fa fa-users");
            // Add Page Applicants to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "983638E8-25C9-4DBC-A117-C07463A98B53","643ED200-747A-4F28-8660-6DE9B72D2D06","Applicants","","03B74F63-7780-4D2D-A38D-ED5E4E712B72","fa fa-user-plus");
            // Add Page Finances to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "983638E8-25C9-4DBC-A117-C07463A98B53","643ED200-747A-4F28-8660-6DE9B72D2D06","Finances","","FB386744-0A95-4AA1-9397-227234A3625B","fa fa-hand-holding-usd");
            // Add Page Connections to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "983638E8-25C9-4DBC-A117-C07463A98B53","643ED200-747A-4F28-8660-6DE9B72D2D06","Connections","","116E8FF0-3CC7-4D68-841D-93086810453B","fa fa-comments");
            // Add Page Tools to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "983638E8-25C9-4DBC-A117-C07463A98B53","643ED200-747A-4F28-8660-6DE9B72D2D06","Tools","","89A79B66-8D9A-4A01-8ECA-0974BF96C65F","fa fa-tools");
            // Add Page Dashboards to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "89A79B66-8D9A-4A01-8ECA-0974BF96C65F","643ED200-747A-4F28-8660-6DE9B72D2D06","Dashboards","","FE1D1678-8617-456C-A905-2B545EE41529","");
            // Add Page My Dashboard to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "FE1D1678-8617-456C-A905-2B545EE41529","643ED200-747A-4F28-8660-6DE9B72D2D06","My Dashboard","","49E8AB52-077E-478D-B2B8-7E5463E94399","");
            // Add Page Resources to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "89A79B66-8D9A-4A01-8ECA-0974BF96C65F","643ED200-747A-4F28-8660-6DE9B72D2D06","Resources","","F732DA2C-64E5-4D75-878F-C6D98F70FD29","");
            // Add Page Wiki to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "F732DA2C-64E5-4D75-878F-C6D98F70FD29","643ED200-747A-4F28-8660-6DE9B72D2D06","Wiki","","AAFC6DCC-D40C-4405-BB1A-7E6CF46AD66A","");
            // Add Page Churches to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "F732DA2C-64E5-4D75-878F-C6D98F70FD29","643ED200-747A-4F28-8660-6DE9B72D2D06","Churches","","FD4022A6-16CD-4A37-B5A0-74AE21994660","fa fa-church");
            // Add Page Countries to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "F732DA2C-64E5-4D75-878F-C6D98F70FD29","643ED200-747A-4F28-8660-6DE9B72D2D06","Countries","","3AB6AFB8-D55A-40C0-8200-E0926648BDAC","fa fa-globe-africa");
            // Add Page Reporting to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "89A79B66-8D9A-4A01-8ECA-0974BF96C65F","643ED200-747A-4F28-8660-6DE9B72D2D06","Reporting","","5664DCB2-7F54-4656-9E9F-56C563562FCF","");
            // Add Page Reports to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "5664DCB2-7F54-4656-9E9F-56C563562FCF","643ED200-747A-4F28-8660-6DE9B72D2D06","Reports","","94C4E698-8227-4249-ACA9-CABF66C28C6A","");
            // Add Page Team Member Profile to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "85B49AE6-AC36-47D5-8499-897B40CE61D4","CA118F07-217B-4182-AA60-576C204E9E6A","Team Member Profile","","6967A172-1B08-4784-B9F3-25698DE1DB80","");
            // Add Page Edit Person to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "6967A172-1B08-4784-B9F3-25698DE1DB80","643ED200-747A-4F28-8660-6DE9B72D2D06","Edit Person","","690EE7E0-8781-4F96-BA62-AEE1EFDEFCCA","");
            // Add Page Edit Family to Site:Symphony - Live Global
            RockMigrationHelper.AddPage( true, "6967A172-1B08-4784-B9F3-25698DE1DB80","643ED200-747A-4F28-8660-6DE9B72D2D06","Edit Family","","41E9CD89-B942-4668-9A08-D3E5E4A0685E","");
            Sql("UPDATE [Page] set PageTitle = 'Symphony', InternalName = 'Live Global Symphony Home Page', BrowserTitle = 'Symphony' where [Guid] ='983638E8-25C9-4DBC-A117-C07463A98B53'");
            Sql("UPDATE [Page] set PageTitle = 'Manage', InternalName = 'ManagePartners', BrowserTitle = 'Manage' where [Guid] ='54503BEF-FDCD-4042-AF52-924043EB2188'");
            Sql("UPDATE [Page] set PageTitle = 'Opportunities', InternalName = 'Partner Opportunities', BrowserTitle = 'Opportunities' where [Guid] ='384CF90F-5B05-4D5E-92D2-96C9F1EBB395'");
            Sql("UPDATE [Page] set PageTitle = 'Communication', InternalName = 'Partner Communication', BrowserTitle = 'Communication' where [Guid] ='7423C29B-8680-45DD-8B3F-DE1C1D1B26BE'");
            Sql("UPDATE [Page] set PageTitle = 'Inbox', InternalName = 'Partner Inbox', BrowserTitle = 'Inbox' where [Guid] ='EC7F02AD-B351-4554-A002-56CB0D1A444B'");
            // Add Page Route for Edit Person
            RockMigrationHelper.AddPageRoute("690EE7E0-8781-4F96-BA62-AEE1EFDEFCCA","Person/{PersonId}/TeamMemberEdit","37D25345-ED52-4CBF-8C86-F75BBF610548");
            // Add Page Route for Edit Person
            RockMigrationHelper.AddPageRoute("690EE7E0-8781-4F96-BA62-AEE1EFDEFCCA","Person/{PersonId}","386B060B-CC35-4D51-B9BB-3BC6C91690E8");
            // Add/Update BlockType Lava Tester
            RockMigrationHelper.UpdateBlockType("Lava Tester","Allows you to pick a person, group, workflow instance, or registration entity and test your lava.","~/Plugins/com_centralaz/Utility/LavaTester.ascx","com_centralaz > Utility","E32C203C-8091-45C1-B7D2-9950A6FB480B");
            // Add/Update Mobile Block Type:Structured Content View
            RockMigrationHelper.UpdateMobileBlockType("Structured Content View", "Displays a structured content channel item for the user to view and fill out.", "Rock.Blocks.Types.Mobile.Cms.StructuredContentView", "Mobile > Cms", "577F652B-00E1-440D-80A0-B74B4FBE9162");
            // Add/Update Mobile Block Type:Communication View
            RockMigrationHelper.UpdateMobileBlockType("Communication View", "Displays a communication to the user.", "Rock.Blocks.Types.Mobile.Communication.CommunicationView", "Mobile > Communication", "05C4A292-0549-4818-BC3A-CAD5FF207C0B");
            // Add/Update Mobile Block Type:Calendar Event Item Occurrence View
            RockMigrationHelper.UpdateMobileBlockType("Calendar Event Item Occurrence View", "Displays a particular calendar event item occurrence.", "Rock.Blocks.Types.Mobile.Events.CalendarEventItemOccurrenceView", "Mobile > Events", "CAB8651A-9510-4FC8-B483-221534120200");
            // Add/Update Mobile Block Type:Event Item Occurrence List By Audience Lava
            RockMigrationHelper.UpdateMobileBlockType("Event Item Occurrence List By Audience Lava", "Block that takes an audience and displays calendar item occurrences for it using Lava.", "Rock.Blocks.Types.Mobile.Events.EventItemOccurrenceListByAudienceLava", "Mobile > Events", "BED45197-68F0-48BB-90D1-D61DE7E0E269");
            // Add Block Page Menu to  Site: Symphony - Live Global
            RockMigrationHelper.AddBlock( true, null,null, Guid.Parse("986BE559-65DA-40BF-A49B-ADDEE1215F13"), Guid.Parse("CACB9D1A-A820-4587-986A-D66A69EE9948"), "Page Menu","Navigation",@"",@"",0,"8AFCF7AE-3A02-40D7-A0E3-A04359086B5D"); 
            // Add Block Login Status to  Site: Symphony - Live Global
            RockMigrationHelper.AddBlock( true, null,null, Guid.Parse("986BE559-65DA-40BF-A49B-ADDEE1215F13"), Guid.Parse("04712F3D-9667-4901-A49D-4507573EF7AD"), "Login Status","Login",@"",@"",0,"22C8C964-AAD8-4702-9812-902F90923B3F"); 
            // Add Block Person Bio to Layout: Person Detail, Site: Symphony - Live Global
            RockMigrationHelper.AddBlock( true, null, Guid.Parse("CA118F07-217B-4182-AA60-576C204E9E6A"), Guid.Parse("986BE559-65DA-40BF-A49B-ADDEE1215F13"), Guid.Parse("0F5922BB-CD68-40AC-BF3C-4AAB1B98760C"), "Person Bio","IndividualDetail",@"",@"<script>    $( ""dl.demographics"" ).remove();    let urlParams = new URLSearchParams(window.location.search);    $( ""a[accesskey='I']"" ).attr(""href"", ""/Person/"" + urlParams.get(""PersonId"") + ""/TeamMemberEdit"");</script>",0,"B7903C20-68B8-4542-88A7-A7A9E13A148D"); 
            // Add Block Team Family Members to Layout: Person Detail, Site: Symphony - Live Global
            RockMigrationHelper.AddBlock( true, null, Guid.Parse("CA118F07-217B-4182-AA60-576C204E9E6A"), Guid.Parse("986BE559-65DA-40BF-A49B-ADDEE1215F13"), Guid.Parse("FC137BDA-4F05-4ECE-9899-A249C90D11FC"), "Team Family Members","FamilyDetail",@"",@"<script>    $( ""div.person-info > small"" ).filter(function() {return parseInt($(this).text()) > 21}).remove();</script>",0,"DBA3AFB9-5410-4519-9EF0-8D5770241645"); 
            // Add Block Notes to Page: Group Viewer, Site: Rock RMS
            RockMigrationHelper.AddBlock( true,Guid.Parse( "4E237286-B715-4109-A578-C1445EC02707"),null, Guid.Parse("C2D29296-6A87-47A9-A753-EE4E9159C4C4"), Guid.Parse("2E9F32D4-B4FC-4A5F-9BE1-B2E3EA624DD3"), "Notes","Main",@"",@"",2,"76711CA0-C2BF-4BAF-96B6-5D24B037A44E"); 
            // Add Block Partner Details to Page: Extended Attributes, Site: Rock RMS
            RockMigrationHelper.AddBlock( true, Guid.Parse("1C737278-4CBA-404B-B6B3-E3F0E05AB5FE"),null, Guid.Parse("C2D29296-6A87-47A9-A753-EE4E9159C4C4"), Guid.Parse("D70A59DC-16BE-43BE-9880-59598FA7A94C"), "Partner Details","SectionB2",@"",@"",3,"5155EB4D-A7B4-45C7-85F9-3F3C049E80B3"); 
            // Add Block My Partners to Page: Partner Directory, Site: Symphony - Live Global 
            RockMigrationHelper.AddBlock( true, Guid.Parse("31EA7AEE-E361-43B8-B6F2-D787CBFC6824"),null, Guid.Parse("986BE559-65DA-40BF-A49B-ADDEE1215F13"), Guid.Parse("1B172C33-8672-4C98-A995-8E123FF316BD"), "My Partners","Main",@"",@"",0,"BFF95BE3-C4E1-42F2-A08E-3AF3521C1A87"); 
            // Add Block All Partners to Page: Partner Directory, Site: Symphony - Live Global
            RockMigrationHelper.AddBlock( true, Guid.Parse("31EA7AEE-E361-43B8-B6F2-D787CBFC6824"),null, Guid.Parse("986BE559-65DA-40BF-A49B-ADDEE1215F13"), Guid.Parse("3D7FB6BE-6BBD-49F7-96B4-96310AF3048A"), "All Partners","Main",@"",@"",1,"DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7"); 
            // Add Block Person Directory to Page: Team, Site: Symphony - Live Global
            RockMigrationHelper.AddBlock( true, Guid.Parse("85B49AE6-AC36-47D5-8499-897B40CE61D4"),null, Guid.Parse("986BE559-65DA-40BF-A49B-ADDEE1215F13"), Guid.Parse("FAA234E0-9B34-4539-9987-F15E3318B4FF"), "Person Directory","Main",@"",@"",0,"D6D7CF54-EB86-4AA1-B656-FB6EBFBD473F"); 
            // Add Block Redirect to Page: Wiki, Site: Symphony - Live Global
            RockMigrationHelper.AddBlock( true, Guid.Parse("AAFC6DCC-D40C-4405-BB1A-7E6CF46AD66A"),null, Guid.Parse("986BE559-65DA-40BF-A49B-ADDEE1215F13"), Guid.Parse("B97FB779-5D3E-4663-B3B5-3C2C227AE14A"), "Redirect","Feature",@"",@"",0,"5E497E71-3860-48AE-9957-7784239F4F7C"); 
            // Add Block Block Type List to Page: Block Type List, Site: Rock RMS
            RockMigrationHelper.AddBlock( true, Guid.Parse("58C692A6-3818-493B-80CE-19A8DAAA0675"),null, Guid.Parse("C2D29296-6A87-47A9-A753-EE4E9159C4C4"), Guid.Parse("78A31D91-61F6-42C3-BB7D-676EDC72F35F"), "Block Type List","Main",@"",@"",0,"188A0994-375F-447E-93C3-A3D92BBF45BD"); 
            // Add Block Edit Person to Page: Edit Person, Site: Symphony - Live Global
            RockMigrationHelper.AddBlock( true,Guid.Parse("690EE7E0-8781-4F96-BA62-AEE1EFDEFCCA"),null, Guid.Parse("986BE559-65DA-40BF-A49B-ADDEE1215F13"), Guid.Parse("0A15F28C-4828-4B38-AF66-58AC5BDE48E0"), "Edit Person","Main",@"",@"",0,"C8982F0A-5D4C-4FC4-8B6E-B25441F639EA"); 
            // Add Block Edit Family to Page: Edit Family, Site: Symphony - Live Global
            RockMigrationHelper.AddBlock( true, Guid.Parse("41E9CD89-B942-4668-9A08-D3E5E4A0685E"),null, Guid.Parse("986BE559-65DA-40BF-A49B-ADDEE1215F13"), Guid.Parse("B4EB68FE-1A73-40FD-8236-78C9A015BDDE"), "Edit Family","Main",@"",@"",0,"47557E71-E9E8-434E-92F9-B9F235FF0BC7"); 
            // Add Block Lava Tester to Page: Lava Tester, Site: Rock RMS
            RockMigrationHelper.AddBlock( true, Guid.Parse("6A588BAA-9A93-4D4F-9700-2B6FF638296B"),null, Guid.Parse("C2D29296-6A87-47A9-A753-EE4E9159C4C4"), Guid.Parse("E32C203C-8091-45C1-B7D2-9950A6FB480B"), "Lava Tester","Main",@"",@"",0,"E1A62FA0-AC3B-4EF5-B7B1-B20F1D5AAD8C"); 
            // update block order for pages with new blocks if the page,zone has multiple blocks

            // Update Order for Page: Extended Attributes,  Zone: SectionB2,  Block: Attribute Values
            Sql( @"UPDATE [Block] SET [Order] = 2 WHERE [Guid] = '8DA21ED3-E4BC-483C-8B22-A041FEEE8FF4'"  );
            // Update Order for Page: Extended Attributes,  Zone: SectionB2,  Block: Childhood Information
            Sql( @"UPDATE [Block] SET [Order] = 1 WHERE [Guid] = '441F849F-37C2-4709-B9BB-417204AF3168'"  );
            // Update Order for Page: Extended Attributes,  Zone: SectionB2,  Block: Partner Details
            Sql( @"UPDATE [Block] SET [Order] = 3 WHERE [Guid] = '5155EB4D-A7B4-45C7-85F9-3F3C049E80B3'"  );
            // Update Order for Page: Extended Attributes,  Zone: SectionB2,  Block: Visit Information
            Sql( @"UPDATE [Block] SET [Order] = 0 WHERE [Guid] = '8E86FDCD-4189-4EA4-8370-24ABD6463516'"  );
            // Update Order for Page: Group Viewer,  Zone: Main,  Block: Group Member List
            Sql( @"UPDATE [Block] SET [Order] = 1 WHERE [Guid] = 'BA0F3E7D-1C3A-47CB-9058-893DBAA35B89'"  );
            // Update Order for Page: Group Viewer,  Zone: Main,  Block: GroupDetailRight
            Sql( @"UPDATE [Block] SET [Order] = 0 WHERE [Guid] = '88344FE3-737E-4741-A38D-D2D3A1653818'"  );
            // Update Order for Page: Group Viewer,  Zone: Main,  Block: Notes
            Sql( @"UPDATE [Block] SET [Order] = 2 WHERE [Guid] = '76711CA0-C2BF-4BAF-96B6-5D24B037A44E'"  );
            // Update Order for Page: Partner Directory,  Zone: Main,  Block: All Partners
            Sql( @"UPDATE [Block] SET [Order] = 1 WHERE [Guid] = 'DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7'"  );
            // Update Order for Page: Partner Directory,  Zone: Main,  Block: My Partners
            Sql( @"UPDATE [Block] SET [Order] = 0 WHERE [Guid] = 'BFF95BE3-C4E1-42F2-A08E-3AF3521C1A87'"  );
            // Attribute for BlockType: Group List:core.CustomGridEnableStickyHeaders
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "3D7FB6BE-6BBD-49F7-96B4-96310AF3048A", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "core.CustomGridEnableStickyHeaders", "core.CustomGridEnableStickyHeaders", "core.CustomGridEnableStickyHeaders", @"", 0, @"False", "597FCEDD-9FF1-4C3C-BCCC-2835E68A9B6F" );
            // Attribute for BlockType: Communication View:Enabled Lava Commands
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "05C4A292-0549-4818-BC3A-CAD5FF207C0B", "4BD9088F-5CC6-89B1-45FC-A2AAFFC7CC0D", "Enabled Lava Commands", "EnabledLavaCommands", "Enabled Lava Commands", @"The Lava commands that should be enabled.", 1, @"", "ECD7DC94-5216-478E-9AEA-54230C0EB5CA" );
            // Attribute for BlockType: Communication View:Template
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "05C4A292-0549-4818-BC3A-CAD5FF207C0B", "CCD73456-C83B-4D6E-BD69-8133D2EB996D", "Template", "Template", "Template", @"The template to use when rendering the content.", 0, @"39B8B16D-D213-46FD-9B8F-710453806193", "4996A3E2-0985-4238-9C92-5E765F34E5C1" );
            // Attribute for BlockType: Calendar Event Item Occurrence View:Template
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "CAB8651A-9510-4FC8-B483-221534120200", "CCD73456-C83B-4D6E-BD69-8133D2EB996D", "Template", "Template", "Template", @"The template to use when rendering the event.", 1, @"6593D4EB-2B7A-4C24-8D30-A02991D26BC0", "4663C6A1-7764-4E7B-A518-E2B8C3D0DAA6" );
            // Attribute for BlockType: Calendar Event Item Occurrence View:Registration Url
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "CAB8651A-9510-4FC8-B483-221534120200", "9C204CD0-1233-41C5-818A-C5DA439445AA", "Registration Url", "RegistrationUrl", "Registration Url", @"The base URL to use when linking to the registration page.", 0, @"", "1EF2C95E-2B9E-40F1-9460-17FA3A76A7F0" );
            // Attribute for BlockType: Event Item Occurrence List By Audience Lava:List Title
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "BED45197-68F0-48BB-90D1-D61DE7E0E269", "9C204CD0-1233-41C5-818A-C5DA439445AA", "List Title", "ListTitle", "List Title", @"The title to make available in the lava.", 0, @"Upcoming Events", "38DB8D72-B578-4D37-84E5-4A1D64E5CC7B" );
            // Attribute for BlockType: Event Item Occurrence List By Audience Lava:Enabled Lava Commands
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "BED45197-68F0-48BB-90D1-D61DE7E0E269", "4BD9088F-5CC6-89B1-45FC-A2AAFFC7CC0D", "Enabled Lava Commands", "EnabledLavaCommands", "Enabled Lava Commands", @"The Lava commands that should be enabled for this block, only affects Lava rendered on the server.", 9, @"", "616F5FDB-C90A-4391-9D76-A209A7F26BF3" );
            // Attribute for BlockType: Event Item Occurrence List By Audience Lava:Lava Template 
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "BED45197-68F0-48BB-90D1-D61DE7E0E269", "CCD73456-C83B-4D6E-BD69-8133D2EB996D", "Lava Template", "LavaTemplate", "Lava Template", @"The template to use when rendering event items.", 8, @"", "5A214D1B-DB34-49D6-BF9C-1B826626B952" );
            // Attribute for BlockType: Event Item Occurrence List By Audience Lava:Use Campus Context 
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "BED45197-68F0-48BB-90D1-D61DE7E0E269", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Use Campus Context", "UseCampusContext", "Use Campus Context", @"Determine if the campus should be read from the campus context of the page.", 4, @"False", "D3BE4DDB-7B94-43B6-AA43-E0BC93ED780F" );
            // Attribute for BlockType: Event Item Occurrence List By Audience Lava:Max Occurrences
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "BED45197-68F0-48BB-90D1-D61DE7E0E269", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Max Occurrences", "MaxOccurrences", "Max Occurrences", @"The maximum number of occurrences to show.", 6, @"5", "AB10376E-2D85-4653-B5ED-8BDBB6DC335A" );
            // Attribute for BlockType: Event Item Occurrence List By Audience Lava:Event Detail Page
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "BED45197-68F0-48BB-90D1-D61DE7E0E269", "BD53F9C9-EBA9-4D3F-82EA-DE5DD34A8108", "Event Detail Page", "DetailPage", "Event Detail Page", @"The page to use for showing event details.", 7, @"", "86761225-811E-44DF-A046-2304FD231B69" );
            // Attribute for BlockType: Event Item Occurrence List By Audience Lava:Audience
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "BED45197-68F0-48BB-90D1-D61DE7E0E269", "59D5A94C-94A0-4630-B80A-BB25697D74C7", "Audience", "Audience", "Audience", @"The audience to show calendar items for.", 1, @"", "6F4329EE-DB30-436C-B340-E93C0F1C3F2A" );
            // Attribute for BlockType: Event Item Occurrence List By Audience Lava:Campuses
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "BED45197-68F0-48BB-90D1-D61DE7E0E269", "69254F91-C97F-4C2D-9ACB-1683B088097B", "Campuses", "Campuses", "Campuses", @"List of which campuses to show occurrences for. This setting will be ignored if 'Use Campus Context' is enabled.", 3, @"", "ECCFC722-CFFE-443C-B3E7-A603B624E5EF" );
            // Attribute for BlockType: Event Item Occurrence List By Audience Lava:Date Range
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "BED45197-68F0-48BB-90D1-D61DE7E0E269", "55810BC5-45EA-4044-B783-0CCE0A445C6F", "Date Range", "DateRange", "Date Range", @"Optional date range to filter the occurrences on.", 5, @",", "E1705D80-E904-41C6-B4D0-5F492E1AF1BB" );
            // Attribute for BlockType: Event Item Occurrence List By Audience Lava:Calendar 
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "BED45197-68F0-48BB-90D1-D61DE7E0E269", "EC0D9528-1A22-404E-A776-566404987363", "Calendar", "Calendar", "Calendar", @"Filters the events by a specific calendar.", 2, @"", "7CD245D3-113A-40F0-B127-F5EC1D908271" );
            // Attribute for BlockType: Lava Tester:Enabled Lava Commands
            RockMigrationHelper.AddOrUpdateBlockTypeAttribute( "E32C203C-8091-45C1-B7D2-9950A6FB480B", "4BD9088F-5CC6-89B1-45FC-A2AAFFC7CC0D", "Enabled Lava Commands", "EnabledLavaCommands", "Enabled Lava Commands", @"The Lava commands that should be enabled.", 0, @"", "D242F025-FF2C-4102-B99E-39A413D2B04D" );
            // Add Block Attribute Value
            //   Block: Block Type List
            //   BlockType: Block Type List
            //   Block Location: Page=Block Types, Site=Rock RMS
            //   Attribute: core.CustomGridEnableStickyHeaders
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("BBE02100-9648-4CC2-8376-1F28A9A77A1E","6C2CC882-6569-43D0-A01A-8DCCABC9D57E",@"False");

            // Add Block Attribute Value
            //   Block: Redirect
            //   BlockType: Redirect
            //   Block Location: Page=Wiki, Site=Symphony - Live Global
            //   Attribute: Permanent Redirect
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("5E497E71-3860-48AE-9957-7784239F4F7C","A61FF3BD-06F0-4AB4-AD6B-2BC7C83CB0FD",@"False");

            // Add Block Attribute Value
            //   Block: Redirect
            //   BlockType: Redirect
            //   Block Location: Page=Wiki, Site=Symphony - Live Global
            //   Attribute: Url
            //   Attribute Value: https://wiki.liveglobal.org/login            
            RockMigrationHelper.AddBlockAttributeValue("5E497E71-3860-48AE-9957-7784239F4F7C","964D33F4-27D0-4715-86BE-D30CEB895044",@"https://wiki.liveglobal.org/login");

            // Add Block Attribute Value
            //   Block: Redirect
            //   BlockType: Redirect
            //   Block Location: Page=Wiki, Site=Symphony - Live Global
            //   Attribute: Redirect When
            //   Attribute Value: 1            
            RockMigrationHelper.AddBlockAttributeValue("5E497E71-3860-48AE-9957-7784239F4F7C","F09F2F0C-9FB0-4BC2-818C-FAD25900CF26",@"1");

            // Add Block Attribute Value
            //   Block: Person Directory
            //   BlockType: Person Directory
            //   Block Location: Page=Team, Site=Symphony - Live Global
            //   Attribute: Data View
            //   Attribute Value: b622f945-b151-4b8b-85b2-1b58088503ca            
            RockMigrationHelper.AddBlockAttributeValue("D6D7CF54-EB86-4AA1-B656-FB6EBFBD473F","7D79BC2D-211D-433A-BB21-955D7CB281CD",@"b622f945-b151-4b8b-85b2-1b58088503ca");

            // Add Block Attribute Value
            //   Block: Person Directory
            //   BlockType: Person Directory
            //   Block Location: Page=Team, Site=Symphony - Live Global
            //   Attribute: Show By
            //   Attribute Value: Family            
            RockMigrationHelper.AddBlockAttributeValue("D6D7CF54-EB86-4AA1-B656-FB6EBFBD473F","33A23D44-4A05-475D-96CA-D45EB582C1E8",@"Family");

            // Add Block Attribute Value
            //   Block: Person Directory
            //   BlockType: Person Directory
            //   Block Location: Page=Team, Site=Symphony - Live Global
            //   Attribute: Show All People
            //   Attribute Value: True            
            RockMigrationHelper.AddBlockAttributeValue("D6D7CF54-EB86-4AA1-B656-FB6EBFBD473F","E0799820-4319-4C46-8E88-7F136F2B928F",@"True");

            // Add Block Attribute Value
            //   Block: Person Directory
            //   BlockType: Person Directory
            //   Block Location: Page=Team, Site=Symphony - Live Global
            //   Attribute: First Name Characters Required
            //   Attribute Value: 0            
            RockMigrationHelper.AddBlockAttributeValue("D6D7CF54-EB86-4AA1-B656-FB6EBFBD473F","DF2BBE9E-920B-43E6-A3E1-4D0DA9FB3734",@"0");

            // Add Block Attribute Value
            //   Block: Person Directory
            //   BlockType: Person Directory
            //   Block Location: Page=Team, Site=Symphony - Live Global
            //   Attribute: Last Name Characters Required
            //   Attribute Value: 1            
            RockMigrationHelper.AddBlockAttributeValue("D6D7CF54-EB86-4AA1-B656-FB6EBFBD473F","7CA0B843-6557-4A75-9046-9196441A0AEC",@"1");

            // Add Block Attribute Value
            //   Block: Person Directory
            //   BlockType: Person Directory
            //   Block Location: Page=Team, Site=Symphony - Live Global
            //   Attribute: Show Email
            //   Attribute Value: True            
            RockMigrationHelper.AddBlockAttributeValue("D6D7CF54-EB86-4AA1-B656-FB6EBFBD473F","326CF336-26C9-4479-83F7-B316B9C6AABE",@"True");

            // Add Block Attribute Value
            //   Block: Person Directory
            //   BlockType: Person Directory
            //   Block Location: Page=Team, Site=Symphony - Live Global
            //   Attribute: Show Address
            //   Attribute Value: True            
            RockMigrationHelper.AddBlockAttributeValue("D6D7CF54-EB86-4AA1-B656-FB6EBFBD473F","550DF59B-7BD6-4ECE-B52B-A1F1288007A9",@"True");

            // Add Block Attribute Value
            //   Block: Person Directory
            //   BlockType: Person Directory
            //   Block Location: Page=Team, Site=Symphony - Live Global
            //   Attribute: Show Phones
            //   Attribute Value: 407e7e45-7b2e-4fcd-9605-ecb1339f2453            
            RockMigrationHelper.AddBlockAttributeValue("D6D7CF54-EB86-4AA1-B656-FB6EBFBD473F","AF86E220-50D5-41BB-8EB8-98635CECB00A",@"407e7e45-7b2e-4fcd-9605-ecb1339f2453");

            // Add Block Attribute Value
            //   Block: Person Directory
            //   BlockType: Person Directory
            //   Block Location: Page=Team, Site=Symphony - Live Global
            //   Attribute: Show Birthday
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("D6D7CF54-EB86-4AA1-B656-FB6EBFBD473F","093433C9-7AB4-481A-ACF4-4218844A897D",@"False");

            // Add Block Attribute Value
            //   Block: Person Directory
            //   BlockType: Person Directory
            //   Block Location: Page=Team, Site=Symphony - Live Global
            //   Attribute: Show Gender
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("D6D7CF54-EB86-4AA1-B656-FB6EBFBD473F","33B29E31-8F54-4719-876D-9A85F5E7F9A8",@"False");

            // Add Block Attribute Value
            //   Block: Person Directory
            //   BlockType: Person Directory
            //   Block Location: Page=Team, Site=Symphony - Live Global
            //   Attribute: Max Results
            //   Attribute Value: 1500            
            RockMigrationHelper.AddBlockAttributeValue("D6D7CF54-EB86-4AA1-B656-FB6EBFBD473F","6EC21276-BDB2-4E5B-99F3-37104B4AD82A",@"1500");

            // Add Block Attribute Value
            //   Block: Person Directory
            //   BlockType: Person Directory
            //   Block Location: Page=Team, Site=Symphony - Live Global
            //   Attribute: Show Grade
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("D6D7CF54-EB86-4AA1-B656-FB6EBFBD473F","16091C4E-6206-444F-B239-A28F58B8D78B",@"False");

            // Add Block Attribute Value
            //   Block: Person Directory
            //   BlockType: Person Directory
            //   Block Location: Page=Team, Site=Symphony - Live Global
            //   Attribute: Show Envelope Number
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("D6D7CF54-EB86-4AA1-B656-FB6EBFBD473F","789C82A6-0758-4512-A4DA-F7E85F1750AB",@"False");

            // Add Block Attribute Value
            //   Block: Person Directory
            //   BlockType: Person Directory
            //   Block Location: Page=Team, Site=Symphony - Live Global
            //   Attribute: Person Profile Page
            //   Attribute Value: 6967a172-1b08-4784-b9f3-25698de1db80            
            RockMigrationHelper.AddBlockAttributeValue("D6D7CF54-EB86-4AA1-B656-FB6EBFBD473F","3DC389F3-C229-4CC0-B7D5-AF9AAB7EA38E",@"6967a172-1b08-4784-b9f3-25698de1db80");

            // Add Block Attribute Value
            //   Block: Person Bio
            //   BlockType: Person Bio
            //   Block Location: Layout=Person Detail, Site=Symphony - Live Global
            //   Attribute: Enable Call Origination
            //   Attribute Value: True            
            RockMigrationHelper.AddBlockAttributeValue("B7903C20-68B8-4542-88A7-A7A9E13A148D","5E066824-0ECE-46D1-B1B3-98E9D8D2FD5B",@"True");

            // Add Block Attribute Value
            //   Block: Person Bio
            //   BlockType: Person Bio
            //   Block Location: Layout=Person Detail, Site=Symphony - Live Global
            //   Attribute: Social Media Category
            //   Attribute Value: dd8f467d-b83c-444f-b04c-c681167046a1            
            RockMigrationHelper.AddBlockAttributeValue("B7903C20-68B8-4542-88A7-A7A9E13A148D","FD51EC2E-D660-4B79-95C7-39214D4BEA8E",@"dd8f467d-b83c-444f-b04c-c681167046a1");

            // Add Block Attribute Value
            //   Block: Person Bio
            //   BlockType: Person Bio
            //   Block Location: Layout=Person Detail, Site=Symphony - Live Global
            //   Attribute: Allow Following
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("B7903C20-68B8-4542-88A7-A7A9E13A148D","D52AD5E1-41B6-45D2-8979-4C04619A86EE",@"False");

            // Add Block Attribute Value
            //   Block: Person Bio
            //   BlockType: Person Bio
            //   Block Location: Layout=Person Detail, Site=Symphony - Live Global
            //   Attribute: Enable Impersonation
            //   Attribute Value: True            
            RockMigrationHelper.AddBlockAttributeValue("B7903C20-68B8-4542-88A7-A7A9E13A148D","A57178A8-A531-42D2-BCC6-90204ADB7A40",@"True");

            // Add Block Attribute Value
            //   Block: Person Bio
            //   BlockType: Person Bio
            //   Block Location: Layout=Person Detail, Site=Symphony - Live Global
            //   Attribute: Impersonation Start Page
            //   Attribute Value: 983638e8-25c9-4dbc-a117-c07463a98b53            
            RockMigrationHelper.AddBlockAttributeValue("B7903C20-68B8-4542-88A7-A7A9E13A148D","98066864-F4C0-4997-87BB-A35DD8916421",@"983638e8-25c9-4dbc-a117-c07463a98b53");

            // Add Block Attribute Value
            //   Block: Person Bio
            //   BlockType: Person Bio
            //   Block Location: Layout=Person Detail, Site=Symphony - Live Global
            //   Attribute: Display Anniversary Date
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("B7903C20-68B8-4542-88A7-A7A9E13A148D","D6B98FBE-A10E-4C29-B033-1BF949391212",@"False");

            // Add Block Attribute Value
            //   Block: Person Bio
            //   BlockType: Person Bio
            //   Block Location: Layout=Person Detail, Site=Symphony - Live Global
            //   Attribute: Display Tags
            //   Attribute Value: True            
            RockMigrationHelper.AddBlockAttributeValue("B7903C20-68B8-4542-88A7-A7A9E13A148D","9217579B-C0DE-4D2F-BBE3-DE75E2D239E1",@"True");

            // Add Block Attribute Value
            //   Block: Person Bio
            //   BlockType: Person Bio
            //   Block Location: Layout=Person Detail, Site=Symphony - Live Global
            //   Attribute: Display Graduation
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("B7903C20-68B8-4542-88A7-A7A9E13A148D","59C6A71C-7064-4D23-A5D5-04FA8F1B3456",@"False");

            // Add Block Attribute Value
            //   Block: Person Bio
            //   BlockType: Person Bio
            //   Block Location: Layout=Person Detail, Site=Symphony - Live Global
            //   Attribute: Badges
            //   Attribute Value: 66972bff-42cd-49ab-9a7a-e1b9deca4ebf            
            RockMigrationHelper.AddBlockAttributeValue("B7903C20-68B8-4542-88A7-A7A9E13A148D","8E11F65B-7272-4E9F-A4F1-89CE08E658DE",@"66972bff-42cd-49ab-9a7a-e1b9deca4ebf");

            // Add Block Attribute Value
            //   Block: Person Bio
            //   BlockType: Person Bio
            //   Block Location: Layout=Person Detail, Site=Symphony - Live Global
            //   Attribute: Display Country Code
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("B7903C20-68B8-4542-88A7-A7A9E13A148D","879ED630-23C8-429D-A064-32168DB8057C",@"False");

            // Add Block Attribute Value
            //   Block: Person Bio
            //   BlockType: Person Bio
            //   Block Location: Layout=Person Detail, Site=Symphony - Live Global
            //   Attribute: Display Middle Name
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("B7903C20-68B8-4542-88A7-A7A9E13A148D","384EA763-B8E5-4A41-997F-ACD1B002AF8D",@"False");

            // Add Block Attribute Value
            //   Block: Team Family Members
            //   BlockType: Group Members
            //   Block Location: Layout=Person Detail, Site=Symphony - Live Global
            //   Attribute: Group Type
            //   Attribute Value: 790e3215-3b10-442b-af69-616c0dcb998e            
            RockMigrationHelper.AddBlockAttributeValue("DBA3AFB9-5410-4519-9EF0-8D5770241645","F988BC15-4D12-4D37-9690-770394FDCB24",@"790e3215-3b10-442b-af69-616c0dcb998e");

            // Add Block Attribute Value
            //   Block: Team Family Members
            //   BlockType: Group Members
            //   Block Location: Layout=Person Detail, Site=Symphony - Live Global
            //   Attribute: Group Edit Page
            //   Attribute Value: 41e9cd89-b942-4668-9a08-d3e5e4a0685e            
            RockMigrationHelper.AddBlockAttributeValue("DBA3AFB9-5410-4519-9EF0-8D5770241645","C12B3192-4B51-4733-AE9F-8D2D46B82DA9",@"41e9cd89-b942-4668-9a08-d3e5e4a0685e");

            // Add Block Attribute Value
            //   Block: Team Family Members
            //   BlockType: Group Members
            //   Block Location: Layout=Person Detail, Site=Symphony - Live Global
            //   Attribute: Auto Create Group
            //   Attribute Value: True            
            RockMigrationHelper.AddBlockAttributeValue("DBA3AFB9-5410-4519-9EF0-8D5770241645","26018994-D9DD-4F3A-BE69-719AF5EB866F",@"True");

            // Add Block Attribute Value
            //   Block: Team Family Members
            //   BlockType: Group Members
            //   Block Location: Layout=Person Detail, Site=Symphony - Live Global
            //   Attribute: Show County
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("DBA3AFB9-5410-4519-9EF0-8D5770241645","93B16E1C-1E23-490F-8EBD-72F4CB8EC760",@"False");

            // Add Block Attribute Value
            //   Block: My Partners
            //   BlockType: Group List Personalized Lava
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Inactive Parameter Name
            //   Attribute Value: showinactivegroups            
            RockMigrationHelper.AddBlockAttributeValue("BFF95BE3-C4E1-42F2-A08E-3AF3521C1A87","97206743-85EF-4DB5-B19C-21D48F9FEB07",@"showinactivegroups");

            // Add Block Attribute Value
            //   Block: My Partners
            //   BlockType: Group List Personalized Lava
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Display Inactive Groups
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("BFF95BE3-C4E1-42F2-A08E-3AF3521C1A87","16BD94BD-C7E5-4366-97C4-D12FE9BBA641",@"False");

            // Add Block Attribute Value
            //   Block: My Partners
            //   BlockType: Group List Personalized Lava
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Initial Active Setting
            //   Attribute Value: 1            
            RockMigrationHelper.AddBlockAttributeValue("BFF95BE3-C4E1-42F2-A08E-3AF3521C1A87","3C97D277-3B19-44BD-A38A-EEF3047E2B50",@"1");

            // Add Block Attribute Value
            //   Block: My Partners
            //   BlockType: Group List Personalized Lava
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Cache Duration
            //   Attribute Value: 3600            
            RockMigrationHelper.AddBlockAttributeValue("BFF95BE3-C4E1-42F2-A08E-3AF3521C1A87","CCA08E73-78F6-46A5-831F-7BEB8C213ACD",@"3600");

            // Add Block Attribute Value
            //   Block: My Partners
            //   BlockType: Group List Personalized Lava
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Detail Page
            //   Attribute Value: 6967a172-1b08-4784-b9f3-25698de1db80            
            RockMigrationHelper.AddBlockAttributeValue("BFF95BE3-C4E1-42F2-A08E-3AF3521C1A87","13921BE2-C0D4-4FD6-841F-36022B56DB54",@"6967a172-1b08-4784-b9f3-25698de1db80");

            // Add Block Attribute Value
            //   Block: My Partners
            //   BlockType: Group List Personalized Lava
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Lava Template
            //   Attribute Value: {% include '~~/Assets/Lava/GroupListSidebar.lava' %}            
            RockMigrationHelper.AddBlockAttributeValue("BFF95BE3-C4E1-42F2-A08E-3AF3521C1A87","C7EC3847-7419-4364-98E8-09FE42A04A76",@"{% include '~~/Assets/Lava/GroupListSidebar.lava' %}");

            // Add Block Attribute Value
            //   Block: My Partners
            //   BlockType: Group List Personalized Lava
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Include Group Types
            //   Attribute Value: 521c4e33-00f7-4576-97d6-07d79bdfe725            
            RockMigrationHelper.AddBlockAttributeValue("BFF95BE3-C4E1-42F2-A08E-3AF3521C1A87","81D7C7A0-5469-419A-9A4D-149511DB7271",@"521c4e33-00f7-4576-97d6-07d79bdfe725");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Display Member Count Column
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","FDD84597-E3E8-4E91-A72F-C6538B085310",@"False");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Limit to Active Status
            //   Attribute Value: all            
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","B4133552-42B6-4053-90B9-33B882B72D2D",@"all");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Display Group Path
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","6F229535-B44E-44C2-A9AF-28244600E244",@"False");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Limit to Security Role Groups
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","1DAD66E3-8859-487E-8200-483C98DE2E07",@"False");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Detail Page
            //   Attribute Value: 4e237286-b715-4109-a578-c1445ec02707            
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","8E57EC42-ABEE-4D35-B7FA-D8513880E8E4",@"4e237286-b715-4109-a578-c1445ec02707");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Display Filter
            //   Attribute Value: True            
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","7E0EDF09-9374-4AC4-8591-30C08D7F1E1F",@"True");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Include Group Types
            //   Attribute Value: 495f3bc8-3a3a-4490-a807-8079daedf03b,4399f64a-cb65-438e-b510-58b92c1b909c            
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","5164FF88-A53B-4982-BE50-D56F1FE13FC6",@"495f3bc8-3a3a-4490-a807-8079daedf03b,4399f64a-cb65-438e-b510-58b92c1b909c");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Display Group Type Column
            //   Attribute Value: True            
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","951D268A-B2A8-42A2-B1C1-3B854070DDF9",@"True");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Display Description Column
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","A0E1B2A4-9D86-4F57-B608-FC7CC498EAC3",@"False");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Display System Column
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","766A4BFA-D2D1-4744-B30D-637A7E3B9D8F",@"False");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Display Active Status Column
            //   Attribute Value: True            
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","FCB5F8B3-9C0E-46A8-974A-15353447FCD7",@"True");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Display Security Column
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","2DDD4FD0-5E03-4271-B8EF-728DECA10018",@"False");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Set Panel Title
            //   Attribute Value: All Partners            
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","E861BE97-59F3-4A9C-8F9E-8F45798DF26C",@"All Partners");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Set Panel Icon
            //   Attribute Value:             
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","A03E361B-3F13-41C4-B92F-59A42C261569",@"");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Allow Add
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","FD470B89-C053-411E-BB22-C064E2C15E43",@"False");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Root Group
            //   Attribute Value: 59dc7320-d560-4676-9abb-0157ea0aaadb            
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","AC22E9D0-B37C-4F3E-9EB6-CA94CBCA3873",@"59dc7320-d560-4676-9abb-0157ea0aaadb");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: Group Picker Type
            //   Attribute Value: Dropdown            
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","77307E9F-CE10-4285-A0A5-418D324A4576",@"Dropdown");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: core.EnableDefaultWorkflowLauncher
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","D7AE5225-28BF-4954-9D04-782AC76CBF4E",@"False");

            // Add Block Attribute Value
            //   Block: All Partners
            //   BlockType: Group List
            //   Block Location: Page=Partner Directory, Site=Symphony - Live Global
            //   Attribute: core.CustomGridEnableStickyHeaders
            //   Attribute Value: True            
            RockMigrationHelper.AddBlockAttributeValue("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7","597FCEDD-9FF1-4C3C-BCCC-2835E68A9B6F",@"True");

            // Add Block Attribute Value
            //   Block: Partner Details
            //   BlockType: Attribute Values
            //   Block Location: Page=Extended Attributes, Site=Rock RMS
            //   Attribute: Use Abbreviated Name
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("5155EB4D-A7B4-45C7-85F9-3F3C049E80B3","51693680-B03C-468B-A771-CD8C103D0B1B",@"False");

            // Add Block Attribute Value
            //   Block: Partner Details
            //   BlockType: Attribute Values
            //   Block Location: Page=Extended Attributes, Site=Rock RMS
            //   Attribute: Show Category Names as Separators
            //   Attribute Value: False            
            RockMigrationHelper.AddBlockAttributeValue("5155EB4D-A7B4-45C7-85F9-3F3C049E80B3","EF57237E-BA12-488A-9585-78466E4C3DB5",@"False");

            // Add Block Attribute Value
            //   Block: Partner Details
            //   BlockType: Attribute Values
            //   Block Location: Page=Extended Attributes, Site=Rock RMS
            //   Attribute: Block Icon
            //   Attribute Value: fa fa-people-carry            
            RockMigrationHelper.AddBlockAttributeValue("5155EB4D-A7B4-45C7-85F9-3F3C049E80B3","DF437D92-FB5A-4625-851A-24F79412A337",@"fa fa-people-carry");

            // Add Block Attribute Value
            //   Block: Partner Details
            //   BlockType: Attribute Values
            //   Block Location: Page=Extended Attributes, Site=Rock RMS
            //   Attribute: Block Title
            //   Attribute Value: Partner Details            
            RockMigrationHelper.AddBlockAttributeValue("5155EB4D-A7B4-45C7-85F9-3F3C049E80B3","ADBFBED7-2A61-49ED-93EC-AF48B0247F34",@"Partner Details");

            // Add Block Attribute Value
            //   Block: Partner Details
            //   BlockType: Attribute Values
            //   Block Location: Page=Extended Attributes, Site=Rock RMS
            //   Attribute: Category
            //   Attribute Value: ea6a9657-80b7-4573-a408-409ad8cd95b2            
            RockMigrationHelper.AddBlockAttributeValue("5155EB4D-A7B4-45C7-85F9-3F3C049E80B3","EC43CF32-3BDF-4544-8B6A-CE9208DD7C81",@"ea6a9657-80b7-4573-a408-409ad8cd95b2");
        }
        public override void Down()
        {
            // Enabled Lava Commands Attribute for BlockType: Lava Tester            
            RockMigrationHelper.DeleteAttribute("D242F025-FF2C-4102-B99E-39A413D2B04D");
            // Enabled Lava Commands Attribute for BlockType: Event Item Occurrence List By Audience Lava            
            RockMigrationHelper.DeleteAttribute("616F5FDB-C90A-4391-9D76-A209A7F26BF3");
            // Lava Template Attribute for BlockType: Event Item Occurrence List By Audience Lava            
            RockMigrationHelper.DeleteAttribute("5A214D1B-DB34-49D6-BF9C-1B826626B952");
            // Event Detail Page Attribute for BlockType: Event Item Occurrence List By Audience Lava            
            RockMigrationHelper.DeleteAttribute("86761225-811E-44DF-A046-2304FD231B69");
            // Max Occurrences Attribute for BlockType: Event Item Occurrence List By Audience Lava            
            RockMigrationHelper.DeleteAttribute("AB10376E-2D85-4653-B5ED-8BDBB6DC335A");
            // Date Range Attribute for BlockType: Event Item Occurrence List By Audience Lava            
            RockMigrationHelper.DeleteAttribute("E1705D80-E904-41C6-B4D0-5F492E1AF1BB");
            // Use Campus Context Attribute for BlockType: Event Item Occurrence List By Audience Lava            
            RockMigrationHelper.DeleteAttribute("D3BE4DDB-7B94-43B6-AA43-E0BC93ED780F");
            // Campuses Attribute for BlockType: Event Item Occurrence List By Audience Lava            
            RockMigrationHelper.DeleteAttribute("ECCFC722-CFFE-443C-B3E7-A603B624E5EF");
            // Calendar Attribute for BlockType: Event Item Occurrence List By Audience Lava            
            RockMigrationHelper.DeleteAttribute("7CD245D3-113A-40F0-B127-F5EC1D908271");
            // Audience Attribute for BlockType: Event Item Occurrence List By Audience Lava            
            RockMigrationHelper.DeleteAttribute("6F4329EE-DB30-436C-B340-E93C0F1C3F2A");
            // List Title Attribute for BlockType: Event Item Occurrence List By Audience Lava            
            RockMigrationHelper.DeleteAttribute("38DB8D72-B578-4D37-84E5-4A1D64E5CC7B");
            // Template Attribute for BlockType: Calendar Event Item Occurrence View            
            RockMigrationHelper.DeleteAttribute("4663C6A1-7764-4E7B-A518-E2B8C3D0DAA6");
            // Registration Url Attribute for BlockType: Calendar Event Item Occurrence View            
            RockMigrationHelper.DeleteAttribute("1EF2C95E-2B9E-40F1-9460-17FA3A76A7F0");
            // Enabled Lava Commands Attribute for BlockType: Communication View            
            RockMigrationHelper.DeleteAttribute("ECD7DC94-5216-478E-9AEA-54230C0EB5CA");
            // Template Attribute for BlockType: Communication View            
            RockMigrationHelper.DeleteAttribute("4996A3E2-0985-4238-9C92-5E765F34E5C1");
            // core.CustomGridEnableStickyHeaders Attribute for BlockType: Group List            
            RockMigrationHelper.DeleteAttribute("597FCEDD-9FF1-4C3C-BCCC-2835E68A9B6F");
            // Remove Block: Notes, from Page: Group Viewer, Site: Rock RMS            
            RockMigrationHelper.DeleteBlock("76711CA0-C2BF-4BAF-96B6-5D24B037A44E");
            // Remove Block: Partner Details, from Page: Extended Attributes, Site: Rock RMS            
            RockMigrationHelper.DeleteBlock("5155EB4D-A7B4-45C7-85F9-3F3C049E80B3");
            // Remove Block: Edit Family, from Page: Edit Family, Site: Symphony - Live Global            
            RockMigrationHelper.DeleteBlock("47557E71-E9E8-434E-92F9-B9F235FF0BC7");
            // Remove Block: Edit Person, from Page: Edit Person, Site: Symphony - Live Global            
            RockMigrationHelper.DeleteBlock("C8982F0A-5D4C-4FC4-8B6E-B25441F639EA");
            // Remove Block: Lava Tester, from Page: Lava Tester, Site: Rock RMS            
            RockMigrationHelper.DeleteBlock("E1A62FA0-AC3B-4EF5-B7B1-B20F1D5AAD8C");
            // Remove Block: All Partners, from Page: Partner Directory, Site: Symphony - Live Global            
            RockMigrationHelper.DeleteBlock("DEF6CBB4-0447-41B7-AC0C-4AEA43E35FD7");
            // Remove Block: My Partners, from Page: Partner Directory, Site: Symphony - Live Global            
            RockMigrationHelper.DeleteBlock("BFF95BE3-C4E1-42F2-A08E-3AF3521C1A87");
            // Remove Block: Team Family Members, from , Layout: Person Detail, Site: Symphony - Live Global            
            RockMigrationHelper.DeleteBlock("DBA3AFB9-5410-4519-9EF0-8D5770241645");
            // Remove Block: Person Bio, from , Layout: Person Detail, Site: Symphony - Live Global            
            RockMigrationHelper.DeleteBlock("B7903C20-68B8-4542-88A7-A7A9E13A148D");
            // Remove Block: Person Directory, from Page: Team, Site: Symphony - Live Global            
            RockMigrationHelper.DeleteBlock("D6D7CF54-EB86-4AA1-B656-FB6EBFBD473F");
            // Remove Block: Block Type List, from Page: Block Type List, Site: Rock RMS            
            RockMigrationHelper.DeleteBlock("188A0994-375F-447E-93C3-A3D92BBF45BD");
            // Remove Block: Redirect, from Page: Wiki, Site: Symphony - Live Global            
            RockMigrationHelper.DeleteBlock("5E497E71-3860-48AE-9957-7784239F4F7C");
            // Delete BlockType Lava Tester            
            RockMigrationHelper.DeleteBlockType("E32C203C-8091-45C1-B7D2-9950A6FB480B"); // Lava Tester
            // Delete BlockType Event Item Occurrence List By Audience Lava            
            RockMigrationHelper.DeleteBlockType("BED45197-68F0-48BB-90D1-D61DE7E0E269"); // Event Item Occurrence List By Audience Lava
            // Delete BlockType Calendar Event Item Occurrence View            
            RockMigrationHelper.DeleteBlockType("CAB8651A-9510-4FC8-B483-221534120200"); // Calendar Event Item Occurrence View
            // Delete BlockType Communication View            
            RockMigrationHelper.DeleteBlockType("05C4A292-0549-4818-BC3A-CAD5FF207C0B"); // Communication View
            // Delete BlockType Structured Content View            
            RockMigrationHelper.DeleteBlockType("577F652B-00E1-440D-80A0-B74B4FBE9162"); // Structured Content View
            // Delete Page Lava Tester from Site:Rock RMS            
            RockMigrationHelper.DeletePage("6A588BAA-9A93-4D4F-9700-2B6FF638296B"); //  Page: Lava Tester, Layout: Full Width, Site: Rock RMS
            // Delete Page Edit Family from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("41E9CD89-B942-4668-9A08-D3E5E4A0685E"); //  Page: Edit Family, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page Edit Person from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("690EE7E0-8781-4F96-BA62-AEE1EFDEFCCA"); //  Page: Edit Person, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page Team Member Profile from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("6967A172-1B08-4784-B9F3-25698DE1DB80"); //  Page: Team Member Profile, Layout: Person Detail, Site: Symphony - Live Global
            // Delete Page Block Type List from Site:Rock RMS            
            RockMigrationHelper.DeletePage("58C692A6-3818-493B-80CE-19A8DAAA0675"); //  Page: Block Type List, Layout: Full Width, Site: Rock RMS
            // Delete Page Reports from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("94C4E698-8227-4249-ACA9-CABF66C28C6A"); //  Page: Reports, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page Reporting from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("5664DCB2-7F54-4656-9E9F-56C563562FCF"); //  Page: Reporting, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page Countries from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("3AB6AFB8-D55A-40C0-8200-E0926648BDAC"); //  Page: Countries, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page Churches from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("FD4022A6-16CD-4A37-B5A0-74AE21994660"); //  Page: Churches, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page Wiki from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("AAFC6DCC-D40C-4405-BB1A-7E6CF46AD66A"); //  Page: Wiki, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page Resources from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("F732DA2C-64E5-4D75-878F-C6D98F70FD29"); //  Page: Resources, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page My Dashboard from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("49E8AB52-077E-478D-B2B8-7E5463E94399"); //  Page: My Dashboard, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page Dashboards from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("FE1D1678-8617-456C-A905-2B545EE41529"); //  Page: Dashboards, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page Tools from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("89A79B66-8D9A-4A01-8ECA-0974BF96C65F"); //  Page: Tools, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page Connections from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("116E8FF0-3CC7-4D68-841D-93086810453B"); //  Page: Connections, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page Finances from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("FB386744-0A95-4AA1-9397-227234A3625B"); //  Page: Finances, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page Applicants from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("03B74F63-7780-4D2D-A38D-ED5E4E712B72"); //  Page: Applicants, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page Team from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("85B49AE6-AC36-47D5-8499-897B40CE61D4"); //  Page: Team, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page Partner Inbox from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("EC7F02AD-B351-4554-A002-56CB0D1A444B"); //  Page: Partner Inbox, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page Partner Communication from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("7423C29B-8680-45DD-8B3F-DE1C1D1B26BE"); //  Page: Partner Communication, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page Partner Opportunities from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("384CF90F-5B05-4D5E-92D2-96C9F1EBB395"); //  Page: Partner Opportunities, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page Partner Directory from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("31EA7AEE-E361-43B8-B6F2-D787CBFC6824"); //  Page: Partner Directory, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page ManagePartners from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("54503BEF-FDCD-4042-AF52-924043EB2188"); //  Page: ManagePartners, Layout: Blank, Site: Symphony - Live Global
            // Delete Page Partners from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("4BD7F1A3-F70F-4556-80B7-82EA09D9C966"); //  Page: Partners, Layout: Full Width, Site: Symphony - Live Global
            // Delete Page Live Global Symphony Home Page from Site:Symphony - Live Global            
            RockMigrationHelper.DeletePage("983638E8-25C9-4DBC-A117-C07463A98B53"); //  Page: Live Global Symphony Home Page, Layout: Full Width, Site: Symphony - Live Global
            RockMigrationHelper.DeleteLayout("C3B9A2ED-C01C-462D-8684-5EE20E0ACC95"); //  Layout: Three Column, Site: Symphony - Live Global
            RockMigrationHelper.DeleteLayout("CE298A9D-AF14-4BD1-890C-8CD51F149C9C"); //  Layout: Splash, Site: Symphony - Live Global
            RockMigrationHelper.DeleteLayout("7C0B9A1A-E631-49BF-BD50-DA6BFC81B1CA"); //  Layout: Right Sidebar, Site: Symphony - Live Global
            RockMigrationHelper.DeleteLayout("CA118F07-217B-4182-AA60-576C204E9E6A"); //  Layout: Person Detail, Site: Symphony - Live Global
            RockMigrationHelper.DeleteLayout("9535128E-A842-46CA-9E1F-6AE5E80673F4"); //  Layout: Left Sidebar, Site: Symphony - Live Global
            RockMigrationHelper.DeleteLayout("5AABCC9B-556E-48E6-840C-B46E7264A310"); //  Layout: Homepage, Site: Symphony - Live Global
            RockMigrationHelper.DeleteLayout("643ED200-747A-4F28-8660-6DE9B72D2D06"); //  Layout: Full Width, Site: Symphony - Live Global
            RockMigrationHelper.DeleteLayout("4C75D028-321E-463C-818B-F0B43416BAB3"); //  Layout: Error, Site: Symphony - Live Global
            RockMigrationHelper.DeleteLayout("38E907F0-3475-44FA-B964-11B5201C8609"); //  Layout: Dialog, Site: Symphony - Live Global
            RockMigrationHelper.DeleteLayout("682D7AEB-A820-473B-9105-BD658BB5240C"); //  Layout: Blank, Site: Symphony - Live Global

        }
    }
}



