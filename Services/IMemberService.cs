using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC1.Models;

namespace MVC1.Services
{
    public interface IMemberService
    {
        List<Member> GetMaleMembers();
        Member OldestMember();
        Tuple< List<Member>,List<Member>,List<Member>> GetMemberByYear(int year);
    }
}