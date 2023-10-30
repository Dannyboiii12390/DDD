using Solution;
using System;


namespace Unit_Tests
{
    [TestClass]
    public class MenuTests
    {
        [TestMethod]
        public void AddOptionTest1()
        {
            Menu menu = new Menu();
            menu.AddOption("Book Meeting");
            Assert.AreEqual("1. Book Meeting\n", menu.ToString());
        }
        [TestMethod]
        public void AddOptionTest2()
        {
            Menu menu = new Menu();
            menu.AddOption("Book Meeting");
            menu.AddOption("Enter Log");
            Assert.AreEqual("1. Book Meeting\n2. Enter Log\n", menu.ToString());

        }
    }

    [TestClass]
    public class LogTests
    {
        [TestMethod]
        public void ToStringTests1()
        {
            DateTime dateTime = DateTime.Now;
            Log log = new Log(dateTime, "First log");
            string logstring = log.ToString();
            Assert.AreEqual($"({dateTime.ToString()}) First log", logstring);
        }
        
    }
    [TestClass]
    public class MeetingTests
    {
        [TestMethod]
        public void ToStringTests2()
        {
            DateTime date = DateTime.Now;
            PersonalSupervisor ps = new PersonalSupervisor("Mr Supervisor");
            List<Meeting> meetings = new List<Meeting>();
            List<Log> logs = new List<Log>();
            Student st = new Student("Daniel Howe", ps, meetings, logs);
            Meeting meeting = new Meeting(ps, st, date);
            Assert.AreEqual($"({date.ToString()}), Personal Supervisor: {ps.name}, Student: {st.name}", meeting.ToString());

        }

    }

}