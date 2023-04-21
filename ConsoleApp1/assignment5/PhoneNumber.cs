using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A.assignment5
{
    public class PhoneNumber
    {
        public string name;
        public List<String> phones = new List<String>();

        public PhoneNumber(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public List<String> Phones
        {
            get { return phones; }
            set { this.phones = value; }
        }
    }
}
