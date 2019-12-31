using System.Runtime.Serialization;

namespace BankAccountService
{
    [DataContract]
    public class Amount
    {
        public Amount(double amount)
        {
            this.Value = amount;

        }
        [DataMember]
        public double Value { get; set; }

        internal static bool IsValid(Amount amount)
        {
            return amount != null && amount.Value >= 0;
        }

    }
}