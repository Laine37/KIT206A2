using System;
using System.Collections.Generic;
using System.Text;

namespace Assig1
{
    class Meeting
    {
        int meeting_id;
        int group_id;
        string day;
        string start_time;
        string end_time;
        string room;

        public Meeting(int in_meeting_id, int in_group_id, string in_day, string in_start_time, string in_end_time, string in_room)
        {
            meeting_id = in_meeting_id;
            group_id = in_group_id;
            day = in_day;
            start_time = in_start_time;
            end_time = in_end_time;
            room = in_room;
        }

        public override string ToString()
        {
            return day + " | " + start_time + " | " + end_time;
        }
    }
}
