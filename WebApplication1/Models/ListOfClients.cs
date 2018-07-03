using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers;

namespace WebApplication1.Models
{
    public class ListOfClients
    {
        public static List<BankAccount> bankAccounts = new List<BankAccount>
        {
            new BankAccount("Simba", 2000, "Lion", 1, true, true),
            new BankAccount("Mufasa", 5000, "Lion", 2, false, true),
            new BankAccount("Pumbaa", 30, "Hog", 3, false, true),
            new BankAccount("Scar", 55, "Lion", 4, false, false),
            new BankAccount("Rafiki", 300, "Mandrill", 5, false, true)
        };
    }
}
