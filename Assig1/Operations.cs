using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Assig1
{
    class Test
    {

    }

    class Operations
    {

        //finish MeetingList
        ///constructor database request. Load them into a meeting list. Use ToString to present them to the list

        //finish functionality

        //restraints

        private static bool reportingErrors = false;
        private const string db = "kit206";
        private const string user = "kit206";
        private const string pass = "kit206";
        private const string server = "alacritas.cis.utas.edu.au";
        private static MySqlConnection conn = null;

        private static MySqlConnection GetConnection()
        {
            if (conn == null)
            {
                //Note: This approach is not thread-safe
                string connectionString = String.Format("Database={0};Data Source={1};User Id={2};Password={3}", db, server, user, pass);
                conn = new MySqlConnection(connectionString);
            }
            return conn;
        }

        public static List<Meeting> LoadMeetings()
        {
            List<Meeting> meetings = new List<Meeting>();

            MySqlConnection conn = GetConnection();
            MySqlDataReader rdr = null;

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("select meeting_id, group_id, day, start_time, end_time from meeting", conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //Note that in your assignment you will need to inspect the *type* of the
                    //employee/researcher before deciding which kind of concrete class to create.
                    meetings.Add(new Meeting(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5)));
                }
            }
            catch (MySqlException e)
            {
                ReportError("loading meetings", e);
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

            return meetings;
        }

        public static List<Group> LoadGroups()
        {
            List<Group> groups = new List<Group>();

            MySqlConnection conn = GetConnection();
            MySqlDataReader rdr = null;

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("select group_id, group_name from studentGroup", conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //Note that in your assignment you will need to inspect the *type* of the
                    //employee/researcher before deciding which kind of concrete class to create.
                    groups.Add(new Group(rdr.GetInt32(0), rdr.GetString(1)));
                }
            }
            catch (MySqlException e)
            {
                ReportError("loading groups", e);
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

            return groups;
        }

        static public void AddClass(class_instance in_class)
        {
            MySqlConnection conn = GetConnection();
            MySqlDataReader rdr = null;

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from class where group_id='" + in_class.group_id.ToString() + "'", conn);
                rdr = cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                ReportError("cleaning classes", e);
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

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into class(class_id,group_id,day,start_time,end_time,room) values('" + in_class.class_id + "','" + in_class.group_id + "','" + in_class.day + "','" + in_class.end_time + "','" + in_class.start_time + "','" + in_class.room + "')", conn);
                rdr = cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                ReportError("adding class", e);
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
        }

        static public void CancelMeeting(int in_meeting_id)
        {
            MySqlConnection conn = GetConnection();
            MySqlDataReader rdr = null;

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from class where group_id='" + in_meeting_id + "'", conn);
                rdr = cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                ReportError("cleaning classes", e);
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
        }

        private static void ReportError(string msg, Exception e)
        {
            if (reportingErrors)
            {
                MessageBox.Show("An error occurred while " + msg + ". Try again later.\n\nError Details:\n" + e,
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public static int GroupNameToID(List<Group> groups, string in_name)
        {
            string temp = groups[0].ToString();
            int index = 0;
            for (; temp != in_name && index < groups.Count; ++index) temp = groups[index + 1].ToString();
            return index;
        }
    }
}
