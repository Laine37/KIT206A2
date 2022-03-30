using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Student
    {
        private string studentID;
        private string gname;
        private string fname;
        private string title;
        private string campus;
        private string groupID;
        private string email;
        private string image;
        private studyCategory category;

        public string Gname { get => gname; }
        public string Fname { get => fname; set => fname = value; }

        public enum studyCategory
        {
            Masters,
            Bachelors
        }

        public Student(string id, string title, string campus, string groupID, string email, string image, studyCategory category)
        {
            //search database for student id
            //studentID = id;
            //gname = database.gname
            //fname = database.fname
            this.title = title;
            this.campus = campus;
            this.groupID = groupID;
            this.email = email;
            this.image = image;
            this.category = category;
        }

        public void setGroupID(string id)
        {
            groupID = id;
        }
        public void setImage(string image)
        {
            this.image = image;
        }
        //getters for everything
    }
}
