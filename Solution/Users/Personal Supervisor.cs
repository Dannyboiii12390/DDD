﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class PersonalSupervisor : Person
    {



        public PersonalSupervisor(string name) : base(name)
        {

        }

        public override void bookMeeting(Meeting meeting)
        {
            throw new NotImplementedException();
        }
    }
}
