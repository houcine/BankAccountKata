using System;
using System.Runtime.Serialization;

namespace BankAccountService
{
    [Serializable]
    internal class NegativeAmountException : Exception
    {
        public NegativeAmountException()
        {
        }

        public NegativeAmountException(string message) : base(message)
        {
        }

        public NegativeAmountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeAmountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}