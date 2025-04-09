namespace part3_Exercises
{
    internal class Program
    {
        public static void printAnsers(string anser)
        {
            
            Console.WriteLine("your anser  is " +anser);
           
        }
        public static void printAnsers(int anser)
        {
            Console.WriteLine("your anser  is " + anser);
        }

        // 1. Write a method that takes an integer as a parameter and prints
        // "Even" if the number is even, and "Odd" if the number is odd.
        public static void evenOdd(int a)
        {
            if (a % 2 == 0)
            {
                printAnsers("Even");
            }
            else
            {
                printAnsers("Odd");
            }
        }
        // 2.write a mtode that take 3 numbers  as input and return the largest number
        public static void largestNumber(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                printAnsers("a is the largest number");
            }
            else if (b > a && b > c)
            {
                printAnsers("b is the largest number");
            }
            else
            {
                printAnsers("c is the largest number");
            }
        }
        // 3. tempretuer culculator from celcius to farenheit
        public static void celciusToFarenheit(double c)
        {
            double f = (c * 9 / 5) + 32;
            printAnsers("the tempreture in farenheit is " + f);
        }
        // 4. simples discount calculator if above 100 aplly 10% discount other wiseno discounts 
        public static void discountCalculator(double price)
        {
            if (price > 100)
            {
                double discount = price * 0.1;
                double finalPrice = price - discount;
                printAnsers("the final price after discount is " + finalPrice);
            }
            else
            {
                printAnsers("no discount");
            }
        }
        // 5. grading system  take a score and return the grade 
        public static void gradingSystem(int score)
        {
            if (score >= 90)
            {
                printAnsers("A");
            }
            else if (score >= 80)
            {
                printAnsers("B");
            }
            else if (score >= 70)
            {
                printAnsers("C");
            }
            else if (score >= 60)
            {
                printAnsers("D");
            }
            else
            {
                printAnsers("F");
            }
        }
        // 6. swap two numbers 
        public static void swapNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            printAnsers("a is " + a);
            printAnsers("b is " + b);
        }
         
        static void Main(string[] args)
        {
            
        }
    }
}
