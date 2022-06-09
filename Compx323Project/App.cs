using Compx323Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compx323Project
{
    public enum DatabaseType
    {
        Oracle,
        MongoDb
    }

    public static class App
    {
        public static IDataService DataService { get; set; }

        public static string ActiveUserName { get; set; }

        public static void StartDatabase(DatabaseType databaseType, string address)
        {
            if (databaseType == DatabaseType.MongoDb)
                DataService = new MongoDataService();
            else
                DataService = new OracleDataService();

            DataService.Initialise(address);
        }
    }
}
