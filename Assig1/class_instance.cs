using System;
using System.Collections.Generic;
using System.Text;

namespace Assig1
{
    class class_instance
    {
        public int class_id;
        public int group_id;
        public string day;
        public string start_time;
        public string end_time;
        public string room;

        public class_instance(int in_class_id, int in_group_id, string in_day, string in_start_time, string in_end_time, string in_room)
        {
            class_id = in_class_id;
            group_id = in_group_id;
            day = in_day;
            start_time = in_start_time;
            end_time = in_end_time;
            room = in_room;
        }
    }
}
