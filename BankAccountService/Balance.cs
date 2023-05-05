using System.Runtime.Serialization;

namespace BankAccountService
{
    //Balance
    [DataContract]
    public class Balance
    {
        public Balance(double balance)
        {
            this.Value = balance;
        }
        [DataMember]
        public double Value { get; set; }

        public static bool BalanceIsPositive(Balance balance, Amount amount)
        {
            if ((balance.Value - amount.Value) >= 0)
                return true;
            return false;
        }

        public static Balance operator +(Balance balance, Amount amount)
        {
            if (amount != null)
                return new Balance(balance.Value + amount.Value);
            return balance;
        }

        public static Balance operator -(Balance balance, Amount amount)
        {
            if (amount != null)
                return new Balance(balance.Value - amount.Value);
            return balance;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value == (obj as Balance).Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}