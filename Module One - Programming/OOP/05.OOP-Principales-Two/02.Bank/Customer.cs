﻿namespace _02.Bank
{
    public abstract class Customer
    {
        public Customer(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }
}
