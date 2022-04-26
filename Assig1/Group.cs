using System;
using System.Collections.Generic;
using System.Text;

namespace Assig1
{
    class Group
    {
        public int group_id;
        public string group_name;

        public Group(int in_group_id, string in_group_name)
        {
            group_id = in_group_id;
            group_name = in_group_name;
        }

        public override string ToString()
        {
            return group_name;
        }
    }
}
