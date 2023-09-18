namespace Arithmetic_Operators
{
    internal class Program
    {
        public const int HDBS = 512;
        static void Main(string[] args)
        {
            Circumfrence(5);
            Console.WriteLine("");
            Area(2);
            Console.WriteLine("");
            Console.WriteLine(Divisible(8, 4));
            Triangle(3, 4);
            Console.WriteLine("");
            Students(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("");
            DiskSize(6);
            Console.WriteLine("");
            PocketMoney(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));



        }

        static void Circumfrence(double radius) 
        {
        double Number = (radius*2*Math.PI);
            Console.WriteLine(Math.Round(Number, 2));
        }

        static void Area(double radius)
        {
         double Number = (radius * radius * Math.PI);
            Console.WriteLine(Math.Round(Number, 2));
        }

        static Boolean Divisible(int Num, int Num2) 
        { 
        if (Num % Num2 == 0)
            {
                return true;
            }
        else
            {
                return false;
            }
        }

        static void Triangle(int SideA, int SideB)
        {
            Console.WriteLine(Math.Sqrt(SideB*SideB + SideA*SideA));
        }

        static void Students(int Students, int Books) 
        {
            
            double Number = Books / Students;
            double Amount = Math.Floor(Number);
            Console.WriteLine($"Students get {Amount} books each and their are {Books % Students} books left");
        
        }

        static void DiskSize(int Size)
        {
            int Size2 = Size*1024;
            Console.WriteLine(Size2/HDBS);

        }

        static void PocketMoney(int Money, int Percentage)
        {
         
         
            double AmountPerWeek = Money * (Percentage/100.0);
            Console.WriteLine($"Amount saved a week: {AmountPerWeek}");
            Console.WriteLine($"Amount saved a year: {AmountPerWeek*52}");


        }



        





    }
}