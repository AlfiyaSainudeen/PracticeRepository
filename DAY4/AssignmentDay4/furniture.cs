using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay4_1
{
   

    class Furniture
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string FurnitureType { get; set; }
        public int Qty { get; set; }
        public decimal TotalAmt { get; set; }
        public string PaymentMode { get; set; }

        public virtual void GetData()
        {
            Console.WriteLine("Enter OrderId:");
            OrderId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter OrderDate (yyyy-MM-dd):");
            OrderDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter FurnitureType (Chair/Cot):");
            FurnitureType = Console.ReadLine();

            Console.WriteLine("Enter Quantity:");
            Qty = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Total Amount:");
            TotalAmt = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter PaymentMode (credit/debit card):");
            PaymentMode = Console.ReadLine();
        }

        public void ShowData()
        {
            Console.WriteLine($"OrderId: {OrderId}");
            Console.WriteLine($"OrderDate: {OrderDate:yyyy-MM-dd}");
            Console.WriteLine($"FurnitureType: {FurnitureType}");
            Console.WriteLine($"Quantity: {Qty}");
            Console.WriteLine($"Total Amount: {TotalAmt}");
            Console.WriteLine($"PaymentMode: {PaymentMode}");
        }
    }

    class Chair : Furniture
    {
        public string ChairType { get; set; }
        public string Purpose { get; set; }
        public string MaterialType { get; set; }
        public string MaterialColor { get; set; }
        public decimal Rate { get; set; }

        public override void GetData()
        {
            base.GetData();

            Console.WriteLine("Enter ChairType (Wood/Steel/Plastic):");
            ChairType = Console.ReadLine();

            Console.WriteLine("Enter Purpose (Home/Office):");
            Purpose = Console.ReadLine();

            if (ChairType == "Wood")
            {
                Console.WriteLine("Enter WoodType (Teak Wood/Rose Wood):");
                MaterialType = Console.ReadLine();
            }
            else if (ChairType == "Steel")
            {
                Console.WriteLine("Enter SteelType (Gray Steel/Green Steel/Brown Steel):");
                MaterialType = Console.ReadLine();
            }
            else if (ChairType == "Plastic")
            {
                Console.WriteLine("Enter PlasticColor (Green/Red/Blue/White):");
                MaterialColor = Console.ReadLine();
            }

            Console.WriteLine("Enter Rate:");
            Rate = decimal.Parse(Console.ReadLine());
        }

        public new void ShowData()
        {
            base.ShowData();

            Console.WriteLine($"ChairType: {ChairType}");
            Console.WriteLine($"Purpose: {Purpose}");

            if (ChairType == "Wood" || ChairType == "Steel")
            {
                Console.WriteLine($"MaterialType: {MaterialType}");
            }
            else if (ChairType == "Plastic")
            {
                Console.WriteLine($"MaterialColor: {MaterialColor}");
            }

            Console.WriteLine($"Rate: {Rate}");
        }
    }

    class Cot : Furniture
    {
        public string CotType { get; set; }
        public string MaterialType { get; set; }
        public string Capacity { get; set; }
        public decimal Rate { get; set; }

        public override void GetData()
        {
            base.GetData();

            Console.WriteLine("Enter CotType (Wood/Steel):");
            CotType = Console.ReadLine();

            if (CotType == "Wood" || CotType == "Steel")
            {
                Console.WriteLine("Enter MaterialType (Teak Wood/Rose Wood/Gray Steel/Green Steel/Brown Steel):");
                MaterialType = Console.ReadLine();
            }

            Console.WriteLine("Enter Capacity (Single/Double):");
            Capacity = Console.ReadLine();

            Console.WriteLine("Enter Rate:");
            Rate = decimal.Parse(Console.ReadLine());
        }

        public new void ShowData()
        {
            base.ShowData();

            Console.WriteLine($"CotType: {CotType}");

            if (CotType == "Wood" || CotType == "Steel")
            {
                Console.WriteLine($"MaterialType: {MaterialType}");
            }

            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Rate: {Rate}");
        }
    }

    class furniture
    {
        static void Main()
        {
            Console.WriteLine("Enter details for Chair:");
            Chair chair = new Chair();
            chair.GetData();

            Console.WriteLine("\nEnter details for Cot:");
            Cot cot = new Cot();
            cot.GetData();

            Console.WriteLine("\nChair Details:");
            chair.ShowData();

            Console.WriteLine("\nCot Details:");
            cot.ShowData();
        }
    }
   
}
