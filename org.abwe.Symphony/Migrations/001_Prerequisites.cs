using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rock.Plugin;

namespace org.abwe.Symphony.Migrations
{
    [MigrationNumber(4, "1.12.0")]
    class Prerequisites : Migration
    {
        public override void Up()
        {
            return;  // DON'T DO ANYTHING FOR NOW
            System.Diagnostics.Debug.WriteLine("executing prerequisite Migration for Partners");

            // Connection Status
            RockMigrationHelper.UpdateDefinedValue("2E6540EA-63F0-40FE-BE50-F2A84735E600", "Contact", "", "D0DFDE54-C29A-4091-BF12-2B3244F4295E", false);
            RockMigrationHelper.UpdateDefinedValue("2E6540EA-63F0-40FE-BE50-F2A84735E600", "Missionary", "", "AB98E828-A6D8-4D99-B9C1-9F43CB6E3201", false);
            RockMigrationHelper.UpdateDefinedValue("2E6540EA-63F0-40FE-BE50-F2A84735E600", "Staff", "", "CBCDF616-10C3-425B-A39E-AC3101FA11DE", false);
            RockMigrationHelper.UpdateDefinedValue("2E6540EA-63F0-40FE-BE50-F2A84735E600", "Volunteer", "", "77FE6890-CAB5-4094-BDEB-44453F912FA9", false);

            // Record Status
            RockMigrationHelper.UpdateDefinedValue("8522BADD-2871-45A5-81DD-C76DA07E2E7E", "Potential", "Denotes an individual or organization who is being evaluated for future partnership or some other connection to our organization.", "8ACC0F47-D88B-4B5B-BECF-5E6DCED49350", false);

        }
        public override void Down()
        {
            System.Diagnostics.Debug.WriteLine("Symphony prereq migration Down() not implemented");
        }
    }
}
