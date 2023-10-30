using Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod] 
        public void bookMeetingTest() 
        {
            DateTime now = DateTime.Now;
            PersonalSupervisor ps = new PersonalSupervisor("The Supervisor");
            List<Meeting> meetingList = new List<Meeting>();
            List<Log> logs = new List<Log>();
            Student st = new Student("Daniel", ps, meetingList, logs);
            Meeting meeting = new Meeting(ps, st, now);
            meetingList.Add(meeting);
            st.bookMeeting(meeting);

            Assert.AreEqual(meetingList, st.meetingList);
        }
        [TestMethod]
        public void GetLogsTest()
        {
            DateTime now = DateTime.Now;
            PersonalSupervisor ps = new PersonalSupervisor("The Supervisor");
            List<Meeting> meetingList = new List<Meeting>();
            List<Log> logs = new List<Log>();
            Student st = new Student("Daniel", ps, meetingList, logs);
            Log log = new Log(now, "First Log");
            st.AddLog(log);
            logs.Add(log);

            Assert.AreEqual(logs, st.logList);

        }

    }
}
