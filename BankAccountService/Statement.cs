using System;

namespace BankAccountService
{
    public class Statement
    {
        private Amount amount;
        private DateTime date;
        private StatementType type;

        public Statement(Amount amount, StatementType type)
        {
            this.amount = amount;
            this.date = DateTime.Now;
            this.type = type;
        }

        public Amount Amount { get; }
        public DateTime Date { get; }
        public StatementType Type { get; }

        public override string ToString()
        {
            return $"Amount: {amount.Value}  Date: {date}  Type: {type}";
        }
    }
}