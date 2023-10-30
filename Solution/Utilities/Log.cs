using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    
    public class Log
    {
        DateTime datetime;
        string contents;

        public Log(DateTime pDatetime, string pContents)
        {
            datetime = pDatetime;
            contents = pContents;

        }
        public override string ToString()
        {
            return $"({datetime.ToString()}) {contents}";
        }


    }
}
