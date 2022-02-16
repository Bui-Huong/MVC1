using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC1.Data;
using MVC1.Models;

namespace MVC1.Services
{
    public class MemberService : IMemberService
    {
        public List<Member> GetMaleMembers()
        {
            return MemberData.Members.Where(m => m.Gender == Enum.Gender.Male).ToList();
        }

        public Tuple<List<Member>, List<Member>, List<Member>> GetMemberByYear(int year)
        {
            var lessThan2000=MemberData.Members.Where(m=>m.DateOfBirth.Year<year).ToList();
            var greaterThan2000=MemberData.Members.Where(m=>m.DateOfBirth.Year>year).ToList();
            var bornIn2000=MemberData.Members.Where(m=>m.DateOfBirth.Year==year).ToList();
            return Tuple.Create(lessThan2000, greaterThan2000, bornIn2000);
        }

        public Member OldestMember()
        {
            return MemberData.Members.Where(m=>m.DateOfBirth.Year==MemberData.Members.Max(x=>x.DateOfBirth.Year)).FirstOrDefault();
        }
        
    }
}