using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SimbaController : Controller
    {
        [HttpGet]
        [Route("simba")]
        public IActionResult Simba()
        {
            return View(ListOfClients.bankAccounts);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Simba(int Index)
        {
            if (ListOfClients.bankAccounts[Index].IsKing)
            {
                ListOfClients.bankAccounts[Index].Balance += 100;
            }

            else
            {
                ListOfClients.bankAccounts[Index].Balance += 10;
            }
            return View(ListOfClients.bankAccounts);
        }

    }
}