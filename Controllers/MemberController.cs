using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC1.Services;

namespace MVC1.Controllers
{
    public class MemberController : Controller
    {
        private readonly IMemberService _memberService;
        private readonly ILogger<MemberController> _logger;

        public MemberController(ILogger<MemberController> logger, IMemberService memberService)
        {
            _logger = logger;
            _memberService = memberService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MaleMembers(){
            return Ok(_memberService.GetMaleMembers());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
        public IActionResult OldestMember(){
            return Ok();
        }
        public IActionResult GetMemberByYear(int year){
            return Ok(_memberService.GetMemberByYear(year));
        }
        public IActionResult ExportExcelFile(){
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[2]{new DataColumn("First name"), new DataColumn("Last name")});
            foreach(MemberModel person in _facade.GetAllPeople()){
                table.Rows.Add(person.FirstName, person.LastName);
            }
            using (XLWorkbook wb = new XLWorkbook()){
                wb.Worksheet.Add(table);
                using(MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(),"appication/vnd.openxmlformats-officedocument.spreadsheet.sheet","Grid.xlsx");
                }
            }
            return;
        }

    }
}