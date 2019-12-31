using System.ServiceModel;

namespace BankAccountService
{
    [ServiceContract]
    public interface IBankAccountService
    {
        [OperationContract]
        string PrintStatements();
        [OperationContract]
        void Deposit(Amount amount);
        [OperationContract]
        void Withdraw(Amount amount);

    }

}
