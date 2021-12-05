using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAP
{

    class Student
    {
        public string familyName;
        public string givenName;
        public string title;
        public string schoolUnit;
        public string campus;
        public string email;
        public string jobTitle;
        public DateTime commencedWithInst;
        public DateTime commencedCurrentPos;

        public float tenure;
        public float publications;
        public int id;
        public Gender gender;

        /*
         * Task 2.2.3
         */
        public override string ToString()
        {
            return familyName + "\t" + id + "\t" + gender;
        }

    }
}
