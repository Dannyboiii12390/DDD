using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class Meeting
    {
        private PersonalSupervisor PS;
        private Student ST;
        private DateTime datetime;

        public Meeting (PersonalSupervisor pPS, Student pST, DateTime pDateTime)
        {
            PS = pPS;
            ST = pST;
            datetime = pDateTime;

        }

        public override string ToString()
        {
            return $"({datetime.ToString()}), Personal Supervisor: {PS.name}, Student: {ST.name}";
        }

    }
}
