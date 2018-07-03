using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class BankAccount
    {
        public string Name { get; set; }
        public float Balance { get; set; }
        public string AnimalType { get; set; }
        public int ID { get; set; }
        public bool IsKing { get; set; }
        public bool IsGood { get; set; }

        public BankAccount(string Name, float Balance, string AnimalType, int ID, bool IsKing, bool IsGood)
        {
            this.Name = Name;
            this.Balance = Balance;
            this.AnimalType = AnimalType;
            this.ID = ID;
            this.IsKing = IsKing;
            this.IsGood = IsGood;
        }
    }
}
