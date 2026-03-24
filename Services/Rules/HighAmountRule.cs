using FraudDetection.Models;

namespace FraudDetection.Services
{
    public class HighAmountRule : IFraudRule
    {
        public string? Check(Transaction tx, List<Transaction> history)
        {
            return tx.Amount > 10000 ? "High amount" : null;
        }
    }
}
