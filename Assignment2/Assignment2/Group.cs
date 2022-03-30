using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Group
    {
        private string groupName;
        private string ID;

        public Group(string name, string id)
        {
            //check database for same id if there is, 
            {
                //groupName = database.name;
            }

            groupName = name;
            ID = id;
        }

        public bool setGroupName(string inName)
        {
            //goto database and set the group name

            return false;//(groupNameFromDatabase == inName);
        }
        public string getGroupName(string ID)
        {
            return "Noname"; //get the name from the database
        }
    }
}
