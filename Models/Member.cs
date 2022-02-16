using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC1.Enum;

namespace MVC1.Models
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public int Age { get { return DateOfBirth.Year - DateTime.Now.Year; } }
        public bool IsGraduated { get; set; }
        public string MemberInfo
        {
            get
            {
                return String.Format("{0} {1} {2}", FirstName, LastName, Gender.ToString());
            }
        }
    }
}