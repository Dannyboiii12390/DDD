using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class Student : Person
    {
        private PersonalSupervisor ps;
        public List<Meeting> meetingList { get; private set; }
        public List<Log> logList { get; private set; }


        public Student(string name, PersonalSupervisor pPS, List<Meeting> pMeetingList, List<Log> pLogList) : base(name)
        {
            ps = pPS;
            meetingList = pMeetingList;
            logList = pLogList;

        }

        public override void bookMeeting(Meeting meeting)
        {
            meetingList.Add(meeting);
        }
        public void AddLog(Log log)
        {
            logList.Add(log);
        }

        public string GetLogs()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Log log in logList) 
            {
                sb.AppendLine($"{name}: {log.ToString()}");
            }
            return sb.ToString();
        }
        public string GetMeetings() 
        {
            StringBuilder sb = new StringBuilder();
            foreach (Meeting meeting in meetingList) 
            {
                sb.AppendLine($"{meeting.ToString()}") ;
            };
            return sb.ToString();
        }

    }

}
