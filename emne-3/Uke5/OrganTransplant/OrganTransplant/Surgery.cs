using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganTransplant
{
    internal class Surgery
    {
        public Person Recipient { get; set; }
        public Person Donor { get; set; }

        
        public Surgery(Person recipient, Person donor)
        { 
            Recipient = recipient;
            Donor = donor;
        }

        public void KidneyTransplant()
        {
            Console.WriteLine("---Kidney transplant---");
            if (Donor.Kidneys == 2)
            {
                Console.WriteLine($"{Donor.Name} has two kidneys");
                Recipient.Kidneys += 1;
                Donor.Kidneys -= 1;
            }
            else
            {
                Console.WriteLine($"{Donor.Name} does not have enouth kidneys");
                return;
            }
            Console.WriteLine("surgery was a succsess");
            Console.WriteLine($"{Recipient.Name} now has {Recipient.Kidneys} kidneys.");
            Console.WriteLine($"And {Donor.Name} has {Donor.Kidneys} kidneys");
        }

    }
}
