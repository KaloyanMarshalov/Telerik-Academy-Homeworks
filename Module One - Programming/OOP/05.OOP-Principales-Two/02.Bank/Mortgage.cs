namespace _02.Bank
{
    public class Mortgage : Account, IDeposit
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }
        public override decimal ClaculateInterest(int period)
        {
            if (this.Customer is IndividualCustomer)
            {
                if (period > 6)
                {
                    return base.ClaculateInterest(period);

                }
                else
                {
                    return 0;
                }
            }
            else if (this.Customer is CompanyCustomer)
            {
                if (period >= 12)
                {
                    return base.ClaculateInterest(period);
                }
                else
                {
                    return base.ClaculateInterest(period) / 2;
                }
            }
            else
            {
                throw new System.InvalidCastException("Not a valid Customer");
            }
        }
        public void Deposit(decimal ammount)
        {
            this.Balance += ammount;
        }
    }
}
