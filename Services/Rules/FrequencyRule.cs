using FraudDetection.Models;

namespace FraudDetection.Services
{
    public class FrequencyRule : IFraudRule
    {
        public string? Check(Transaction tx, List<Transaction> history)
        {
            var count = history.Count(t => t.UserId == tx.UserId &&
                (tx.Timestamp - t.Timestamp).TotalSeconds < 60);

            return count > 3 ? "High frequency" : null;
        }
    }
}
