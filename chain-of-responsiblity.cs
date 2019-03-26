using System;

namespace ChainofResponsiblity
{
    public class Invoice
    {
        public int Amount;
        public DateTime PurchaceDate;
    }

    public abstract class Handler
    {
        public Handler Next;
        protected int LowerLimit, HigherLimit;
        public Handler(int LowerLimit, int HigherLimit)
        {
            this.LowerLimit = LowerLimit;
            this.HigherLimit = HigherLimit;
        }
        public abstract void Handle(Invoice invoice);
    }

    public class LowInvoiceHandler : Handler
    {
        public LowInvoiceHandler(int LowerLimit, int HigherLimit) : base(LowerLimit, HigherLimit)
        {
        }

        public override void Handle(Invoice invoice)
        {
            if(invoice.Amount >= LowerLimit && invoice.Amount <= HigherLimit)
            {
                // handle
                Console.WriteLine("LowInvoiceHandler Handle");
            }
            else if (this.Next != null)
            {
                Next.Handle(invoice);
            }
            else
                Console.WriteLine("No other Handler Available");
        }
    }

    public class MediumInvoiceHandler : Handler
    {
        public MediumInvoiceHandler(int LowerLimit, int HigherLimit) : base(LowerLimit, HigherLimit)
        {
        }

        public override void Handle(Invoice invoice)
        {
            if (invoice.Amount >= LowerLimit && invoice.Amount <= HigherLimit)
            {
                // handle
                Console.WriteLine("MediumInvoiceHandler Handle");
            }
            else if (this.Next != null)
            {
                Next.Handle(invoice);
            }
            else
                Console.WriteLine("No other Handler Available");
        }
    }

    public class HighInvoiceHandler : Handler
    {
        public HighInvoiceHandler(int LowerLimit, int HigherLimit) : base(LowerLimit, HigherLimit)
        {
        }

        public override void Handle(Invoice invoice)
        {
            if (invoice.Amount >= LowerLimit && invoice.Amount <= HigherLimit)
            {
                // handle
                Console.WriteLine("HighInvoiceHandler Handle");
            }
            else if(this.Next != null)
            {
                Next.Handle(invoice);
            }
            else
                Console.WriteLine("No other Handler Available");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LowInvoiceHandler handler_low = new LowInvoiceHandler(1, 10);
            MediumInvoiceHandler handler_medium = new MediumInvoiceHandler(11, 20);
            HighInvoiceHandler handler_high = new HighInvoiceHandler(21, 50);

            handler_medium.Next = handler_high;
            handler_low.Next = handler_medium;

            handler_low.Handle(new Invoice() { Amount = 45, PurchaceDate = DateTime.Now });

            Console.ReadKey();
        }
    }
}
