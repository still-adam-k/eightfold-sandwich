using System;
using System.Collections.Generic;
using Events;
using Newtonsoft.Json;

namespace EventSourcing_interactive {
//Event sourcing overview:
//Instead of storing current state of our data(eg. in normalized form in DB), we store the series of changes that happend(events/messages). 
//Current state has to be inferred from the event stream.

/*
Direct debit rules:
- We need active direct debit mandate to request payments
- Mandate becomes active in 10 working days after creation
- Mandate can be transferred to another bank - it takes another 10 days to activate
- Customer can cancel or reinstate their mandate - cancellation does deactivate mandate, but after reinstation we don't need to wait 10 days
- Payment will be confirmed or failed within 5 working days of requesting
*/
 
    class Program {
        static void Main(string[] args) {
            // Assume messages are stored in proper order and produce valid domain state
            var directDebitEvents = SampleScenario.ScenarioEvents;
            //show scenario messages
            directDebitEvents.ForEach(e => Console.WriteLine($"{e.GetType().FullName} {JsonConvert.SerializeObject(e, Formatting.Indented)}"));

            
            Console.ReadKey();
        }

        //Tasks!
        public static int Number_of_payments_requested(List<DirectDebitEvent> events) {
            throw new NotImplementedException();
        }

        public static int Number_of_successfull_payments(List<DirectDebitEvent> events) {
            throw new NotImplementedException();
        }
        
        public static string Current_customer_account_number(List<DirectDebitEvent> events) {
            throw new NotImplementedException();
        }

        public static decimal Total_amount_of_money_taken_from_customer_account(List<DirectDebitEvent> events) {
            throw new NotImplementedException();
        }

        public static bool Direct_debit_is_active(List<DirectDebitEvent> events) {
            throw new NotImplementedException();
        }
    }
}
