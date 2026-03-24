using FraudDetection.Models;

namespace FraudDetection.Services
{
    public interface IFraudRule
    {
        string? Check(Transaction tx, List<Transaction> history);
    }
}
