using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibary.DataAccess;
using System.Configuration;
 
namespace TrackerLibary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database,bool textFiles)
        {
            if (database)
            {
                // TODO - Setup the SQL Connector Properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql); 
            }
            if (textFiles)
            {
                // Create the Text Connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }

        }
        public static string CnnString(string name) {
           return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
