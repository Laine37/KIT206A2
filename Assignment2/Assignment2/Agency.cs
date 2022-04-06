using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tut5
{
    abstract class Agency
    {
        private const string db = "kit206";
        private const string user = "kit206";
        private const string pass = "kit206";
        private const string server = "alacritas.cis.utas.edu.au";

        private static MySqlConnection conn;

        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }

        private static MySqlConnection GetConnection()
        {
            if(conn == null)
            {
                string connectionString = $"Database={db}; Data Source={server}; User Id={user}; Password={pass};";

                conn = new MySqlConnection(connectionString);
            }
            return conn;
        }

        public static List<TrainingSession> LoadTrainingSessions(int ID)
        {
            List<TrainingSession> trainingSessions = new List<TrainingSession>();

            MySqlDataReader rdr = null;

            try
            {
                GetConnection();
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("select title, year, type, available " +
                    "from publication as pub, researcher_publication as respub " +
                    "where pub.doi = respub.doi and researcher_id=?id", conn);

                cmd.Parameters.AddWithValue("id", ID);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    TrainingSession e = new TrainingSession { Title = rdr.GetString(0), Certified = rdr.GetDateTime(3), Year = rdr.GetInt32(1), ModeType = ParseEnum<Mode>(rdr.GetString(2)) };
                    trainingSessions.Add(e);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error connecting to database: " + e);
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return trainingSessions;
        }

        public static List<Employee> LoadAll()
        {
            List<Employee> employees = new List<Employee>();

            MySqlDataReader rdr = null;

            try
            {
                GetConnection();
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("select id, given_name, family_name from researcher", conn);

                rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    Employee e = new Employee { Id = rdr.GetInt32(0), Name = rdr.GetString(1) + rdr.GetString(2) };
                    employees.Add(e);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error connecting to database: " + e);
            }
            finally
            {
                if(rdr != null)
                {
                    rdr.Close();
                }
                if(conn != null)
                {
                    conn.Close();
                }
            }

            return employees;
        }
    }
}
