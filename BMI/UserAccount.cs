using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class UserAccount
    {
        public string user_first;
        public string user_last;
        public string test = "HERE";

        public void person(string firstname, string lastname)
        {
            //this.user_first = firstname;
            //this.user_last = lastname;
            //{ return $"{firstname} {lastname}"; }
        }

        public string firstname(string first)
        {
            this.user_first = first;
            return user_first;
        }
        public string lastname(string last)
        {
            this.user_last = last;
            return user_last;
        }
    }
}
