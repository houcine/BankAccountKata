using System.Collections.Generic;
using System.Text;

namespace BankAccountService
{

    public class Account
    {
        private List<Statement> statementsList;

        public Balance Balance { get; set; }
        public Account()
        {
            Balance = new Balance(0);
            statementsList = new List<Statement>();
        }

        public void Deposit(Amount amount)
        {
            if (Amount.IsValid(amount))
            {
                Balance += amount;
                statementsList.Add(new Statement(amount, StatementType.DEPOSIT));
            }

        }

        public void Withdraw(Amount amount)
        {

            if (Amount.IsValid(amount) && Balance.BalanceIsPositive(Balance, amount))
            {

                Balance -= amount;
                statementsList.Add(new Statement(amount, StatementType.WITHDRAWAL));
            }
        }

        public string PrintStatements()
        {
            StringBuilder resultString = new StringBuilder();
            foreach (var statement in statementsList)
            {
                resultString.AppendLine(statement.ToString());
            }
            resultString.AppendLine($"Balance : {Balance.Value}");

            return resultString.ToString();
        }

    }
}