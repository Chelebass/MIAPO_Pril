using System;
namespace ConsoleApp2
{
    class MiClass
    {
        static void Main()
        {
            Console.WriteLine("Введите число 1");
            double num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите число 2");
            double num2 = Convert.ToInt32(Console.ReadLine());

            double numRes = 0;
            
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1) + \n2) * \n 3) - \n 4) /");
            
            string choosedItem = Console.ReadLine();

            switch (choosedItem)
            {
                case "+":
                    numRes = returnPlus(num1, num2);
                    break;
                
                case "*":
                    numRes = returnUmn(num1, num2);
                    break;
                    
                case "-":
                    numRes = returnMin(num1, num2);
                    break;
                
                case "/":
                    numRes = returnDel(num1, num2);
                    break;
            }
            
            Console.WriteLine(numRes);
        }
        public static double returnDel(double a, double b)
        {
            double aANDb = a / b;
            return aANDb;
        }


        public static double returnMin(double a, double b)
        {
            double aANDb = a - b;
            return aANDb;
        }

        public static double returnPlus(double a, double b)
        {
            double aANDb = a + b;
            return aANDb;
        }

        public static double returnUmn(double a, double b)
        {
            double aANDb = a * b;
            return aANDb;
        }
    }
}