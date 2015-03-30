namespace _02.Bank
{
    public abstract class Account
    {
        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }
        public virtual decimal ClaculateInterest(int period)
        {
            return period * this.InterestRate;
        }
    }
}
