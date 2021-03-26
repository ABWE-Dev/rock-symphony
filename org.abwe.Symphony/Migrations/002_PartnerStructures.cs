using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rock.Plugin;

namespace org.abwe.Symphony.Migrations
{
    [MigrationNumber(5, "1.6.0")]
    class PartnerStructures : Migration
    {
        public override void Up()
        {
            return;  // DON'T DO ANYTHING FOR NOW
            // new defined type and new defined values
            System.Diagnostics.Debug.WriteLine("Executing Partner Structures migration");
            RockMigrationHelper.AddDefinedType("Financial", "Legal Agreement Type", "", "BA6C1726-0D08-47AA-89D0-E10FB6EED704", @"");
            RockMigrationHelper.UpdateDefinedValue("BA6C1726-0D08-47AA-89D0-E10FB6EED704", "Affidavit", "Affidavit with a team member", "A1824021-F243-44B4-AD77-5EFFFD986770", false);
            RockMigrationHelper.UpdateDefinedValue("BA6C1726-0D08-47AA-89D0-E10FB6EED704", "Another Foundation", "Agreement with another foundation", "AEF6FBCF-DE18-4B79-9D0F-688656DE6D7A", false);
            RockMigrationHelper.UpdateDefinedValue("BA6C1726-0D08-47AA-89D0-E10FB6EED704", "Local NGO", "Agreement with a local NGO", "34714F2C-362C-49A6-84A9-47292C5471CF", false);
            RockMigrationHelper.UpdateDefinedValue("BA6C1726-0D08-47AA-89D0-E10FB6EED704", "None", "No partnership established", "27792E35-57FA-44DF-B3CA-374DBFAB8B60", false);
            RockMigrationHelper.UpdateDefinedValue("BA6C1726-0D08-47AA-89D0-E10FB6EED704", "Non-financial", "Non-financial partnership", "15EFF88E-6401-46FB-B9D9-09DBAD6F707F", false);
            RockMigrationHelper.UpdateDefinedValue("BA6C1726-0D08-47AA-89D0-E10FB6EED704", "Stipend", "Stipend agreement with an individual", "C4DC6B3D-A957-4433-B5DD-BFA9E2A94F58", false);

            //Inactive Group Reasons
            RockMigrationHelper.UpdateDefinedValue("EB5D9839-F770-4E22-8B56-0B09397307D9", "Potential Partnership", "Currently exploring a potential partnering relationship", "6B00B0D3-9E76-4F9F-BF49-075CA3ED896C", false);
            RockMigrationHelper.UpdateDefinedValue("EB5D9839-F770-4E22-8B56-0B09397307D9", "Retired", "", "5C270727-806E-4AB5-A4A7-05E11E139B26", false);

            //Record Status
            RockMigrationHelper.UpdateDefinedValue("8522BADD-2871-45A5-81DD-C76DA07E2E7E", "Potential", "Denotes an individual or organization who is being evaluated for future partnership or some other connection to our organization.", "8ACC0F47-D88B-4B5B-BECF-5E6DCED49350", false);

            //Title
            RockMigrationHelper.UpdateDefinedValue("4784CD23-518B-43EE-9B97-225BF6E07846", "Pastor", "", "B9EE285F-4EBA-4062-B7F8-5125D25CDFCD", false);

            // new Partner Group Attribute Category
            RockMigrationHelper.UpdateGroupAttributeCategory("Partner", "fa fa-people-carry", "", "4fbd055b-f3ad-4147-b520-ad8447c49406", 0);
            RockMigrationHelper.UpdatePersonAttributeCategory("Partner", "fa fa-people-carry", "", "ea6a9657-80b7-4573-a408-409ad8cd95b2", 0);

            // Family Group Type Group Attributes
            RockMigrationHelper.AddGroupTypeGroupAttribute("790E3215-3B10-442B-AF69-616C0DCB998E", "97F8157D-A8C8-4AB3-96A2-9CB2A9049E6D", "Family Photo", @"", 0, null, "CE5745FB-B48C-484F-8F56-E99451DB429B", "Family Photo");
            RockMigrationHelper.AddGroupTypeGroupAttribute("790E3215-3B10-442B-AF69-616C0DCB998E", "7525C4CB-EE6B-41D4-9B64-A08048D5A5C0", "Faces Security Protocol", @"Is it safe to publish faces on external communication?", 1, "Safe", "677E6B3F-60B9-40C8-AE3F-FA518AD3D053", "Faces Security");
            RockMigrationHelper.AddGroupTypeGroupAttribute("790E3215-3B10-442B-AF69-616C0DCB998E", "7525C4CB-EE6B-41D4-9B64-A08048D5A5C0", "Names Security Protocol", @"Is it safe to publish names on external communications?", 2, "Safe", "CB489EBD-96BB-4236-900E-D3448091E771", "Names Security");
            RockMigrationHelper.AddGroupTypeGroupAttribute("790E3215-3B10-442B-AF69-616C0DCB998E", "7525C4CB-EE6B-41D4-9B64-A08048D5A5C0", "Location Security Protocol", @"Is it safe to publish location information on external communications?", 3, "Safe", "5D0EA23E-1431-4A46-B949-2ACA39AA7A5B", "Location Security");
            RockMigrationHelper.AddGroupTypeGroupAttribute("790E3215-3B10-442B-AF69-616C0DCB998E", "59D5A94C-94A0-4630-B80A-BB25697D74C7", "Countries of Service", @"", 4, "", "468FABA3-77D1-44EA-BE85-E1CCF7CCB873", "Countries of Service");

            // Partner Organization group
            RockMigrationHelper.UpdateGroupType("Partner Organization", "An entire organization such as a missions agency or team of people. Internal team members will have partnership relationships with individuals or families within this external partner organization.",
                "Partner", "Partner Contact", "00f3ac1c-71b9-4ee5-a30e-4c48c8a0bf1f", false, true, true, "", 0, null, 0, null, "495F3BC8-3A3A-4490-A807-8079DAEDF03B", false);
            RockMigrationHelper.AddGroupTypeGroupAttribute("495F3BC8-3A3A-4490-A807-8079DAEDF03B", "C0D0D7E2-C3B0-4004-ABEA-4BBFAD10D5D2", "Ministry Website", @"The partner's web address", 0, "", "08681395-6360-4517-84A0-4DA5F1863F56", "Ministry Website");
            RockMigrationHelper.AddGroupTypeGroupAttribute("495F3BC8-3A3A-4490-A807-8079DAEDF03B", "59D5A94C-94A0-4630-B80A-BB25697D74C7", "Countries Served", @"", 1, "", "D0385689-D00B-41B3-BD89-E3F9420E6887", "Countries");
            RockMigrationHelper.AddGroupTypeGroupAttribute("495F3BC8-3A3A-4490-A807-8079DAEDF03B", "3D045CAE-EA72-4A04-B7BE-7FD1D6214217", "Email", @"", 2, "", "18CF5942-2C6E-4B64-9406-AE521F81F629", "Email");
            RockMigrationHelper.AddGroupTypeGroupAttribute("495F3BC8-3A3A-4490-A807-8079DAEDF03B", "DD7ED4C0-A9E0-434F-ACFE-BD4F56B043DF", "Ministry Plans", @"A description of the current ministry activities and plans for the future", 3, "", "B7DF44BB-729E-439F-9AE6-9759F3C7603C", "MinistryPlans");
            RockMigrationHelper.AddGroupTypeGroupAttribute("495F3BC8-3A3A-4490-A807-8079DAEDF03B", "DD7ED4C0-A9E0-434F-ACFE-BD4F56B043DF", "About", @"The mission and vision of the organization", 4, "", "0C2D170B-5E8A-4290-BBFB-7C3866DD70AB", "About");
            RockMigrationHelper.UpdateGroupTypeRole("495F3BC8-3A3A-4490-A807-8079DAEDF03B", "Ministry Contact", "A general contact person for this partner",
                0, null, null, "837f378a-d1d8-47c0-8cee-95bc555a304a", false, false, true);
            RockMigrationHelper.UpdateGroupTypeRole("495F3BC8-3A3A-4490-A807-8079DAEDF03B", "Executive Director", "",
                0, null, null, "9290c255-b23e-4c0f-9fad-fcdd03a473fd", false, false, false);
            RockMigrationHelper.UpdateGroupTypeRole("495F3BC8-3A3A-4490-A807-8079DAEDF03B", "Director", "",
                0, null, null, "58b37a1a-aea7-4c37-ae2e-d3d60bbf7cb3", false, false, false);
            RockMigrationHelper.UpdateGroupTypeRole("495F3BC8-3A3A-4490-A807-8079DAEDF03B", "Principal", "",
                0, null, null, "ee07b202-8a49-4180-91e8-999039f9aba9", false, false, false);
            RockMigrationHelper.UpdateGroupTypeRole("495F3BC8-3A3A-4490-A807-8079DAEDF03B", "President", "",
                0, null, null, "250a90f2-170e-4117-b8a1-a8eedb421b02", false, false, false);
            RockMigrationHelper.UpdateGroupTypeRole("495F3BC8-3A3A-4490-A807-8079DAEDF03B", "Treasurer", "",
                0, null, null, "0f9881a2-3227-43cc-8e91-a4e4e7bdfebf", false, false, false);
            RockMigrationHelper.UpdateGroupTypeRole("495F3BC8-3A3A-4490-A807-8079DAEDF03B", "Board Member", "",
                0, null, null, "4b2c30b4-1d3c-45ae-a8b0-7bd92b2285f0", false, false, false);


            // Partnership
            RockMigrationHelper.UpdateGroupType("Partnership", "The direct relationship between an external individual or family and a set of team members.The external individual may be part of a larger partner organization.",
                "Partnership", "Member", "00f3ac1c-71b9-4ee5-a30e-4c48c8a0bf1f", false, true, true, "", 0, null, 0, null, "4399F64A-CB65-438E-B510-58B92C1B909C", false);
            RockMigrationHelper.AddGroupTypeGroupAttribute("4399F64A-CB65-438E-B510-58B92C1B909C", "59D5A94C-94A0-4630-B80A-BB25697D74C7", "Legal Agreement Type", @"", 0, "", "0E003FC2-F7AC-45D5-A4E2-489DAC432A72", "Legal Agreement Type");
            RockMigrationHelper.AddGroupTypeGroupAttribute("4399F64A-CB65-438E-B510-58B92C1B909C", "C0D0D7E2-C3B0-4004-ABEA-4BBFAD10D5D2", "Public URL", @"The link to our organization's page regarding this partner.", 1, "", "E6C2761D-ACA0-41F8-9DD4-3BAD7DCC72C8", "Public URL");
            RockMigrationHelper.AddGroupTypeGroupAttribute("4399F64A-CB65-438E-B510-58B92C1B909C", "DD7ED4C0-A9E0-434F-ACFE-BD4F56B043DF", "Ministry Description", @"", 2, "", "07FC4C36-3EF5-4883-BA71-AC7AA5404C0A", "MinistryDescription");
            RockMigrationHelper.UpdateGroupTypeRole("4399F64A-CB65-438E-B510-58B92C1B909C", "Primary Partner Contact", "",
                0, null, 1, "bd7ff69c-c6ef-489a-ae8b-69d6846f8c7e", false, false, true);
            RockMigrationHelper.UpdateGroupTypeRole("4399F64A-CB65-438E-B510-58B92C1B909C", "Primary Team Member", "",
                0, null, 1, "3b887804-7f53-42d0-a30e-ffb7a3245924", false, true, false);
            RockMigrationHelper.UpdateGroupTypeRole("4399F64A-CB65-438E-B510-58B92C1B909C", "Secondary Partner Contact", "",
                0, null, null, "3d838446-50da-406d-8446-e6bb589bb9a8", false, false, false);
            RockMigrationHelper.UpdateGroupTypeRole("4399F64A-CB65-438E-B510-58B92C1B909C", "Secondary Team Member", "",
                0, null, null, "69c1afad-9325-4635-ab7c-09f7a03957f6", false, false, false);

            List<string> categoryList = new List<string> { "EA6A9657-80B7-4573-A408-409AD8CD95B2" };
            RockMigrationHelper.AddOrUpdatePersonAttributeByGuid( @"36167F3E-8CB2-44F9-9022-102F171FBC9A", categoryList, @"Testimony", @"Testimony", @"Testimony", @"", @"", 31048, @"", @"0F275600-F0F6-4D6A-BC71-B681C76FDE8B" );
            RockMigrationHelper.AddAttributeQualifier( @"0F275600-F0F6-4D6A-BC71-B681C76FDE8B", @"allowhtml", @"True", @"47AD4E96-AA88-42CE-BEFC-4F7F5BA468FC" );
            RockMigrationHelper.AddAttributeQualifier( @"0F275600-F0F6-4D6A-BC71-B681C76FDE8B", @"ispassword", @"False", @"947B258E-03BC-4D41-A9EE-A895087DB06A" );
            RockMigrationHelper.AddAttributeQualifier( @"0F275600-F0F6-4D6A-BC71-B681C76FDE8B", @"maxcharacters", @"", @"8A4BDBCF-E31B-447D-8699-A9D3BE2D3807" );
            RockMigrationHelper.AddAttributeQualifier( @"0F275600-F0F6-4D6A-BC71-B681C76FDE8B", @"numberofrows", @"", @"AD1A4A01-CACF-4CE7-B01F-CB95584518D4" );
            RockMigrationHelper.AddAttributeQualifier( @"0F275600-F0F6-4D6A-BC71-B681C76FDE8B", @"showcountdown", @"False", @"C684C66B-25AA-4D0C-8292-ACA0BBFDA26A" );

            RockMigrationHelper.AddOrUpdatePersonAttributeByGuid( @"59D5A94C-94A0-4630-B80A-BB25697D74C7", categoryList, @"Countries of Service", @"Countries of Service", @"CountriesofService", @"", @"", 31049, @"", @"AD5C8CD3-5F84-4FA3-A6FB-53843FBD8F28" );
            RockMigrationHelper.AddAttributeQualifier( @"AD5C8CD3-5F84-4FA3-A6FB-53843FBD8F28", @"AllowAddingNewValues", @"False", @"BB549176-3442-4D7E-A45E-6F64BB3613B7" );
            RockMigrationHelper.AddAttributeQualifier( @"AD5C8CD3-5F84-4FA3-A6FB-53843FBD8F28", @"definedtype", @"45", @"B6F70CC2-803C-46B3-B009-7732DE77FE37" );
            RockMigrationHelper.AddAttributeQualifier( @"AD5C8CD3-5F84-4FA3-A6FB-53843FBD8F28", @"displaydescription", @"True", @"5F294383-2977-4BAC-859B-827DB69B81E1" );
            RockMigrationHelper.AddAttributeQualifier( @"AD5C8CD3-5F84-4FA3-A6FB-53843FBD8F28", @"enhancedselection", @"True", @"FBBF3634-298E-4AE6-B3B9-3028E4DE8C36" );
            RockMigrationHelper.AddAttributeQualifier( @"AD5C8CD3-5F84-4FA3-A6FB-53843FBD8F28", @"includeInactive", @"False", @"91AE3FC4-E27A-4026-BAB5-AFF0810634B8" );
            RockMigrationHelper.AddAttributeQualifier( @"AD5C8CD3-5F84-4FA3-A6FB-53843FBD8F28", @"RepeatColumns", @"", @"BFCFCC51-77C3-4F89-883E-1AF4397E2E9C" );
            RockMigrationHelper.AddAttributeQualifier( @"AD5C8CD3-5F84-4FA3-A6FB-53843FBD8F28", @"allowmultiple", @"True", @"39C19089-5C77-4ACE-B6D1-FBEB7F3E02E4" );

            RockMigrationHelper.UpdateNoteType("Partnership Note", "Rock.Model.Group", true, "a75cea72-40ff-485a-96f4-6606e0d1b1ec", false, "fa fa-sticky-note", false);
        }

        public override void Down()
        {
            RockMigrationHelper.DeleteDefinedValue("15EFF88E-6401-46FB-B9D9-09DBAD6F707F"); // Non-financial
            RockMigrationHelper.DeleteDefinedValue("27792E35-57FA-44DF-B3CA-374DBFAB8B60"); // None
            RockMigrationHelper.DeleteDefinedValue("34714F2C-362C-49A6-84A9-47292C5471CF"); // Local NGO
            RockMigrationHelper.DeleteDefinedValue("A1824021-F243-44B4-AD77-5EFFFD986770"); // Affidavit
            RockMigrationHelper.DeleteDefinedValue("AEF6FBCF-DE18-4B79-9D0F-688656DE6D7A"); // Another Foundation
            RockMigrationHelper.DeleteDefinedValue("C4DC6B3D-A957-4433-B5DD-BFA9E2A94F58"); // Stipend
            RockMigrationHelper.DeleteDefinedType("BA6C1726-0D08-47AA-89D0-E10FB6EED704"); // Legal Agreement Type

            RockMigrationHelper.DeleteDefinedValue("6B00B0D3-9E76-4F9F-BF49-075CA3ED896C"); // Potential Partnership
            RockMigrationHelper.DeleteDefinedType("EB5D9839-F770-4E22-8B56-0B09397307D9"); // Inactive Group Reasons

            RockMigrationHelper.DeleteDefinedType("8522BADD-2871-45A5-81DD-C76DA07E2E7E"); // Record Status

            RockMigrationHelper.DeleteDefinedValue("B9EE285F-4EBA-4062-B7F8-5125D25CDFCD"); // Pastor

            RockMigrationHelper.DeleteAttribute("CE5745FB-B48C-484F-8F56-E99451DB429B");    // GroupType - Group Attribute, Family: Family Photo
            RockMigrationHelper.DeleteAttribute("677E6B3F-60B9-40C8-AE3F-FA518AD3D053");    // GroupType - Group Attribute, Family: Faces Security Protocol
            RockMigrationHelper.DeleteAttribute("CB489EBD-96BB-4236-900E-D3448091E771");    // GroupType - Group Attribute, Family: Names Security Protocol
            RockMigrationHelper.DeleteAttribute("5D0EA23E-1431-4A46-B949-2ACA39AA7A5B");    // GroupType - Group Attribute, Family: Location Security Protocol
            RockMigrationHelper.DeleteAttribute("468FABA3-77D1-44EA-BE85-E1CCF7CCB873");    // GroupType - Group Attribute, Family: Countries of Service


            RockMigrationHelper.DeleteAttribute("08681395-6360-4517-84A0-4DA5F1863F56");    // GroupType - Group Attribute, Partner Organization: Ministry Website
            RockMigrationHelper.DeleteAttribute("D0385689-D00B-41B3-BD89-E3F9420E6887");    // GroupType - Group Attribute, Partner Organization: Countries Served
            RockMigrationHelper.DeleteAttribute("18CF5942-2C6E-4B64-9406-AE521F81F629");    // GroupType - Group Attribute, Partner Organization: Email
            RockMigrationHelper.DeleteAttribute("B7DF44BB-729E-439F-9AE6-9759F3C7603C");    // GroupType - Group Attribute, Partner Organization: Ministry Plans
            RockMigrationHelper.DeleteAttribute("0C2D170B-5E8A-4290-BBFB-7C3866DD70AB");    // GroupType - Group Attribute, Partner Organization: About

            RockMigrationHelper.DeleteAttribute("0E003FC2-F7AC-45D5-A4E2-489DAC432A72");    // GroupType - Group Attribute, Partnership: Legal Agreement Type
            RockMigrationHelper.DeleteAttribute("E6C2761D-ACA0-41F8-9DD4-3BAD7DCC72C8");    // GroupType - Group Attribute, Partnership: Public URL
            RockMigrationHelper.DeleteAttribute("07FC4C36-3EF5-4883-BA71-AC7AA5404C0A");    // GroupType - Group Attribute, Partnership: Ministry Description
        }

    }
}

