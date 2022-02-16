using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC1.Enum;
using MVC1.Models;

namespace MVC1.Data
{
    public static class MemberData
    {
        public static List<Member> Members = new List<Member>(){
            new Member{
                FirstName = "Bui",
                LastName = "Huong",
                Gender = Gender.Male,
                DateOfBirth = new DateTime(1999,6,26),
                PhoneNumber = "0338559513",
                BirthPlace = "Ha Noi",
                IsGraduated = false,
            },
            new Member{
                FirstName = "Nguyen",
                LastName = "Loc",
                Gender = Gender.Female,
                DateOfBirth = new DateTime(2000,6,26),
                PhoneNumber = "0338559513",
                BirthPlace = "Bac Ninh",
                IsGraduated = true,
            },
            new Member{
                FirstName = "Pham",
                LastName = "Thang",
                Gender = Gender.Other,
                DateOfBirth = new DateTime(2001,6,26),
                PhoneNumber = "0338559513",
                BirthPlace = "Hai Duong",
                IsGraduated = false,
            },
        };

        public static IEnumerable<object> Member { get; internal set; }
    }
}