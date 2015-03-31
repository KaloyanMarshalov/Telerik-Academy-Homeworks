namespace _02.Bank
{
    using System.Collections.Generic;
    public class Bank
    {
        public Bank(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public List<Account> accounts{ get; set; }
    }
}
