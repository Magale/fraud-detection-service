using FraudDetection.Models;

namespace FraudDetection.Services
{
    public class CategoryRule : IFraudRule
    {
        public string? Check(Transaction tx, List<Transaction> history)
        {
            return (tx.Category.ToLower() == "crypto" || tx.Category.ToLower() == "gambling")
                ? "Risky category" : null;
        }
    }
}
