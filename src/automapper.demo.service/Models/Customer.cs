using System;

namespace automapper.demo.service.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public BankAccount CheckingAccount { get; set; }
    }
}
