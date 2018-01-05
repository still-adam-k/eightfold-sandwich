using System;
using System.Collections.Generic;
using System.Text;
using Events;

namespace EventSourcing_interactive {
    public class SampleScenario{
        public static List<DirectDebitEvent> ScenarioEvents => new List<DirectDebitEvent>() {
            new DirectDebitCreated {
                CustomerId = Guid.Parse("4ff57ddd-4cb6-e511-80ee-3863bb358fa0"),
                AccountNumber = "11223344",
                SortCode = "556677",
                PayerNamer = "Uncle Ben",
                MandateReference = "SP-HACVQO-YF6B",
                Timestamp = DateTime.Parse("2017-06-01T12:43:28.2363434Z")
            },
            new DirectDebitActivated {
                MandateReference = "SP-HACVQO-YF6B",
                Timestamp = DateTime.Parse("2017-06-15T12:43:27.3486165Z")
            },
            new PaymentSent {
                Amount = 27m,
                PaymentReference = "ORD-70998-Y5X8F3",
                ToSendOn = DateTime.Parse("2017-07-15T12:05:03.4995873Z"),
                MandateReference = "SP-HACVQO-YF6B",
                Timestamp = DateTime.Parse("2017-07-14T12:05:03.4995873Z")
            },
            new PaymentConfirmed {
                PaymentReference = "ORD-70998-Y5X8F3",
                MandateReference = "SP-HACVQO-YF6B",
                Timestamp = DateTime.Parse("2017-07-21T10:00:05.15819Z")
            },
            new DirectDebitAccountTransferred {
                NewAccountNumber = "99009900",
                NewSortCode = "887788",
                MandateReference = "SP-HACVQO-YF6B",
                Timestamp = DateTime.Parse("2017-08-15T09:00:16.6343352Z")
            },
            new DirectDebitActivated {
                MandateReference = "SP-HACVQO-YF6B",
                Timestamp = DateTime.Parse("2017-08-29T12:43:27.3486165Z")
            },
            new PaymentSent {
                Amount = 13.5m,
                PaymentReference = "ORD-71000-S5M8W1",
                ToSendOn = DateTime.Parse("2017-09-28T10:30:14.4471754Z"),
                MandateReference = "SP-HACVQO-YF6B",
                Timestamp = DateTime.Parse("2017-09-28T10:30:14.4471754Z")
            }, 
            new PaymentFailed {
                PaymentReference = "ORD-71000-S5M8W1",
                MandateReference = "SP-HACVQO-YF6B",
                Timestamp = DateTime.Parse("2017-10-05T10:00:05.15819Z")
            },
            new DirectDebitCancelled {
                CancelledOn = DateTime.Parse("2017-10-05T00:00:00"),
                Reason = "Cancelled by payer",
                MandateReference = "SP-HACVQO-YF6B",
                Timestamp = DateTime.Parse("2017-10-05T10:00:05.15819Z")
            },
            new DirectDebitReinstated {
                ReinstatedOn = DateTime.Parse("2017-12-02T00:00:00"),
                MandateReference = "SP-HACVQO-YF6B",
                Timestamp = DateTime.Parse("2017-12-05T10:00:19.381111Z")
            }
        };
    }
}
