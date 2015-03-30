namespace _02.Bank
{
    public class DepositClass : Account, IDeposit, IWithdraw
    {
        public DepositClass(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal ClaculateInterest(int period)
        {
            if (this.Balance < 1000)
            {
                throw new System.ArgumentException("Balance is less than 1000");
            }
            return base.ClaculateInterest(period);
        }
        public void Deposit(decimal ammount)
        {
            this.Balance += ammount;
        }

        public void Withdraw(decimal ammount)
        {
            if (ammount > this.Balance)
            {
                throw new System.ArgumentOutOfRangeException("Not enough money!");
            }
            this.Balance -= ammount;
        }
    }
}
