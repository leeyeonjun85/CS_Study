using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Oracle_ODP
{
    class GettingStarted
    {
        public static string user = "testuser1";
        public static string pwd = "0330";
        public static string db = "localhost:1521/XEPDB1";

        static void Main()
        {
            string conStringUser = $"User Id={user};Password={pwd};Data Source={db};";

            using (OracleConnection con = new OracleConnection(conStringUser))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        con.Open();
                        Console.WriteLine("Successfully connected to Oracle Database as " + user);
                        Console.WriteLine();

                        //Retrieve sample data
                        cmd.CommandText = "SELECT description, done FROM todoitem";
                        OracleDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            if (reader.GetBoolean(1))
                                Console.WriteLine(reader.GetString(0) + " is done.");
                            else
                                Console.WriteLine(reader.GetString(0) + " is NOT done.");
                        }


                        reader.Dispose();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}