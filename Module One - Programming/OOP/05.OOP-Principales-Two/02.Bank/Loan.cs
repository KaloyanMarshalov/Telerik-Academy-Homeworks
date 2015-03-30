namespace _02.Bank
{
    public class Loan : Account, IDeposit
    {
        public Loan(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }
        public override decimal ClaculateInterest(int period)
        {
            if (this.Customer is IndividualCustomer && period > 3)
            {
                return base.ClaculateInterest(period);
            }
            else if (this.Customer is CompanyCustomer && period > 2)
            {

                return base.ClaculateInterest(period);
            }
            else
            {
                return 0;
            }
        }
        public void Deposit(decimal ammount)
        {
            this.Balance += ammount;
        }
    }
}
