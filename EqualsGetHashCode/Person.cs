using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsGetHashCode
{
    class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string CityOfBirth { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PassportNumber { get; set; }

        public Person(string fn, string sn, string cob, DateTime dob)
        {
            FirstName = fn;
            SecondName = sn;
            CityOfBirth = cob;
            DateOfBirth = dob;
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }

            return (FirstName == ((Person)obj).FirstName) &&
                (SecondName == ((Person)obj).SecondName) &&
                (DateOfBirth == ((Person)obj).DateOfBirth) &&
                (CityOfBirth == ((Person)obj).CityOfBirth);
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^
                SecondName.GetHashCode() ^
                CityOfBirth.GetHashCode() ^
                DateOfBirth.GetHashCode();
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Person p1, Person p2)
        {
            if (ReferenceEquals(p1, p2))
            {
                return true;
            }
            if (p1 is null || p2 is null)
            {
                return false;
            }
            return p1.Equals(p2);
        }
    }
}
