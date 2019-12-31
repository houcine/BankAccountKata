using System.ServiceModel;

namespace BankAccountService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class BankAccountService : IBankAccountService
    {
        Account account = new Account();

        public void Deposit(Amount amount)
        {
            account.Deposit(amount);

        }

        public void Withdraw(Amount amount)
        {
            account.Withdraw(amount);
        }

        public string PrintStatements()
        {
            return account.PrintStatements();
        }
    }
}
