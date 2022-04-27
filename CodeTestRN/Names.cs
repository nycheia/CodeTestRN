using System;
using System.Text;

namespace CodeTestRN
{
    public class Names
    {
        public string firstName { get; set; }
        public string lastName { get; set; }


        public Names(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string ToString()
        {
            return string.Format("{0} {1}", firstName, lastName);
        }
    }
}
