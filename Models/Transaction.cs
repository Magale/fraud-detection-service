namespace FraudDetection.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string TransactionId { get; set; }
        public string UserId { get; set; }
        public double Amount { get; set; }
        public string Category { get; set; }
        public DateTime Timestamp { get; set; }
        public string Location { get; set; }

        public bool IsFraud { get; set; }
        public string? FraudReason { get; set; }
    }
}
