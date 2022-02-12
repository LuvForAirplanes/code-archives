using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pronect.UserAccountServer.DbContext.Migrations
{
    public class InitialSeedData
    {
        public static void InitialSeeding(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("user_accounts",
                new string[] { "id", "license_key", "password", "date_acquired", "owners_name", "devices", "watched_devices" },
                new object[,] {
                    {"id1", "dummy-licen-sekey-00000-00000", "dummy", "4/21/2018", "Stupid User", "", "" }
            });
        }
    }
}
