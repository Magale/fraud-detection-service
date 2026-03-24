using FraudDetection.Models;

namespace FraudDetection.Services
{
    public class FraudEngine
    {
        private readonly IEnumerable<IFraudRule> _rules;

        public FraudEngine(IEnumerable<IFraudRule> rules)
        {
            _rules = rules;
        }

        public (bool, string) Evaluate(Transaction tx, List<Transaction> history)
        {
            var reasons = _rules
                .Select(rule => rule.Check(tx, history))
                .Where(r => r != null)
                .ToList();

            return (reasons.Any(), string.Join(", ", reasons));
        }
    }
}
