using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public abstract class Person
    {
        private static int staticID = 0;
        public string name { get; protected set; }
        public int ID { get; protected set; }

        public Person(string pName)
        { 
            name = pName;
            ID = staticID;
            staticID++;
        }
        public Person(string pName, int pID)
        {
            name = pName;
            ID = pID;
        }




        public abstract void bookMeeting(Meeting meeting);


    }
}
