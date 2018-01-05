using System;
using System.Collections.Generic;
using System.Text;
using Events; 

namespace Events
{
    public class DirectDebitEvent
    {
        public string MandateReference { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class DirectDebitCreated : DirectDebitEvent {
        public string AccountNumber { get; set; }
        public string SortCode { get; set; }
        public string PayerNamer { get; set; }
        public Guid CustomerId { get; set; }
    }

    public class DirectDebitActivated : DirectDebitEvent {
    }

    public class PaymentSent : DirectDebitEvent {
        public decimal Amount { get; set; }
        public string PaymentReference { get; set; }
        public DateTime ToSendOn { get; set; }
    }

    public class PaymentConfirmed : DirectDebitEvent {
        public string PaymentReference { get; set; }
    }

    public class DirectDebitAccountTransferred : DirectDebitEvent {
        public string NewAccountNumber { get; set; }
        public string NewSortCode { get; set; }

    }

    public class PaymentFailed : DirectDebitEvent {
        public string PaymentReference { get; set; }
    }

    public class DirectDebitCancelled : DirectDebitEvent {
        public DateTime CancelledOn { get; set; }
        public string Reason { get; set; }
    }

    public class DirectDebitReinstated : DirectDebitEvent {
        public DateTime ReinstatedOn { get; set; }
    }
}
