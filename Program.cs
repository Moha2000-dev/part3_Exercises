namespace part3_Exercises
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nChoose an Array Exercise:");
                Console.WriteLine("1. Even or Odd");
                Console.WriteLine("2. Largest Number");
                Console.WriteLine("3. Celsius to Fahrenheit");
                Console.WriteLine("4. Discount Calculator");
                Console.WriteLine("5. Grading System");
                Console.WriteLine("6. Swap Numbers");
                Console.WriteLine("7. Days to Weeks Converter");
                Console.WriteLine("8. Electricity Bill Calculator");
                Console.WriteLine("9. Simple Calculator");
                Console.WriteLine("10. Basic ATM System");
                Console.WriteLine("11. Geometric Calculator");
                Console.WriteLine("12. Factorial Calculator");
                Console.WriteLine("13. Sum of Odd and Even Numbers");
                Console.WriteLine("14. Scientific Calculator");
                Console.WriteLine("15. Print Pattern");
                Console.WriteLine("16. Print Pyramid Pattern");
                Console.WriteLine("17. Print Diamond Pattern");
                Console.WriteLine("18. Guessing Game");
                Console.WriteLine("Enter 0 to exit.");

                int exerciseNumber = int.Parse(Console.ReadLine());
                if (exerciseNumber == 0)
                {
                    break;
                }
                switch (exerciseNumber)
                {
                    case 1:
                        Console.WriteLine("Enter a number:");
                        int number = int.Parse(Console.ReadLine());
                        evenOdd(number);
                        break;
                    case 2:
                        Console.WriteLine("Enter three numbers:");
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        int c = int.Parse(Console.ReadLine());
                        largestNumber(a, b, c);
                        break;
                    case 3:
                        Console.WriteLine("Enter temperature in Celsius:");
                        double celsius = double.Parse(Console.ReadLine());
                        celciusToFarenheit(celsius);
                        break;
                    case 4:
                        Console.WriteLine("Enter price:");
                        double price = double.Parse(Console.ReadLine());
                        discountCalculator(price);
                        break;
                    case 5:
                        Console.WriteLine("Enter score:");
                        int score = int.Parse(Console.ReadLine());
                        gradingSystem(score);
                        break;
                    case 6:
                        Console.WriteLine("Enter two numbers to swap:");
                        int x = int.Parse(Console.ReadLine());
                        int y = int.Parse(Console.ReadLine());
                        swapNumbers(ref x, ref y);
                        break;
                    case 7:
                        Console.WriteLine("Enter number of days:");
                        int days = int.Parse(Console.ReadLine());
                        daysToWeeks(days);
                        break;
                    case 8:
                        Console.WriteLine("Enter electricity units consumed:");
                        int units = int.Parse(Console.ReadLine());
                        electricityBillCalculator(units);
                        break;
                    case 9:
                        Console.WriteLine("Enter two numbers and an operation (+, -, *, /):");
                        int num1 = int.Parse(Console.ReadLine());
                        int num2 = int.Parse(Console.ReadLine());
                        string operation = Console.ReadLine();
                        simpleCalculator(num1, num2, operation);
                        break;
                    case 10:
                        Console.WriteLine("Enter your choice (1: Deposit, 2: Withdraw, 3: Transfer):");
                        string choice = Console.ReadLine();
                        ATM(choice);
                        break;
                    case 11:
                        Console.WriteLine("Enter your choice (1: Circle, 2: Rectangle, 3: Triangle):");
                        string geometricChoice = Console.ReadLine();
                        geometricCalculator(geometricChoice);
                        break;
                    case 12:
                        Console.WriteLine("Enter a number to calculate its factorial:");
                        int factorialNumber = int.Parse(Console.ReadLine());
                        factorial(factorialNumber);
                        break;
                    case 13:
                        Console.WriteLine("Enter a number to calculate the sum of odd and even numbers:");
                        int sumNumber = int.Parse(Console.ReadLine());
                        sumOfOddAndEven(sumNumber);
                        break;
                    case 14:
                        Console.WriteLine("Enter an operation (sin, cos, tan, log, exp):");
                        string scOperation = Console.ReadLine();
                        Console.WriteLine("Enter two numbers:");
                        double scNum1 = double.Parse(Console.ReadLine());
                        double scNum2 = double.Parse(Console.ReadLine());
                        scCalculator(scOperation, scNum1, scNum2);
                        break;
                    case 15:
                        Console.WriteLine("Enter a number to print a pattern:");
                        int patternNumber = int.Parse(Console.ReadLine());
                        printPattern(patternNumber);
                        break;
                    case 16:
                        Console.WriteLine("Enter a number to print a pyramid pattern:");
                        int pyramidNumber = int.Parse(Console.ReadLine());
                        printPyramid(pyramidNumber);
                        break;
                    case 17:
                        Console.WriteLine("Enter a number to print a diamond pattern:");
                        int diamondNumber = int.Parse(Console.ReadLine());
                        printDiamond(diamondNumber);
                        break;
                    case 18:
                        Console.WriteLine("Enter a number to guess:");
                        int numberToGuess = int.Parse(Console.ReadLine());
                        guessingGame(numberToGuess);
                        break;
                    default:
                        Console.WriteLine("Invalid exercise number.");
                        break;
                }
            }







        }
        public static void printAnsers(string anser)
        {

            Console.WriteLine("your anser  is " + anser);

        }
        public static void printAnsers(int anser)
        {
            Console.WriteLine("your anser  is " + anser);
        }
        public static void printAnsers(double anser)
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
        //7. dyaes to weeks conventer
        public static void daysToWeeks(int days)
        {
            int weeks = days / 7;
            int remainingDays = days % 7;
            printAnsers("weeks is " + weeks);
            printAnsers("remaining days is " + remainingDays);
        }
        // 8 elctricity bill calculator 100 give 0.5 $ 101-300 0.75 $ 301+1 1$
        public static void electricityBillCalculator(int units)
        {
            double bill = 0;
            if (units <= 100)
            {
                bill = units * 0.5;
            }
            else if (units <= 300)
            {
                bill = units * 0.75;
            }
            else
            {
                bill = units * 1;
            }
            printAnsers("the bill is " + bill);
        }
        // 9. simple calculator 
        public static void simpleCalculator(int a, int b, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    if (b != 0)
                    {
                        result = (double)a / b;
                    }
                    else
                    {
                        printAnsers("cannot divide by zero");
                        return;
                    }
                    break;
                default:
                    printAnsers("invalid operation");
                    return;
            }
            printAnsers("the result is " + result);
        }
        //basice Atm System 
        public static void ATM(string choice)
        {
            switch (choice) {

                case "1":
                    Console.WriteLine("Enter the amount to deposit:");
                    double depositAmount = double.Parse(Console.ReadLine());
                    printAnsers("You have deposited: " + depositAmount);
                    break;
                case "2":
                    Console.WriteLine("Enter the amount to withdraw:");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    printAnsers("You have withdrawn: " + withdrawAmount);
                    break;
                case "3":
                    Console.WriteLine("Enter the amount to transfer:");
                    double transferAmount = double.Parse(Console.ReadLine());
                    printAnsers("You have transferred: " + transferAmount);
                    break;
                default:
                    printAnsers("exitng");
                    break;


            }
        
        
        }
        //geometric calculator 
        public static void geometricCalculator(string input ) {
            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter the radius of the circle:");
                    double radius = double.Parse(Console.ReadLine());
                    double area = Math.PI * Math.Pow(radius, 2);
                    printAnsers("The area of the circle is: " + area);
                    break;
                case "2":
                    Console.WriteLine("Enter the length and width of the rectangle:");
                    double length = double.Parse(Console.ReadLine());
                    double width = double.Parse(Console.ReadLine());
                    double rectangleArea = length * width;
                    printAnsers("The area of the rectangle is: " + rectangleArea);
                    break;
                case "3":
                    Console.WriteLine("Enter the base and height of the triangle:");
                    double baseLength = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    double triangleArea = 0.5 * baseLength * height;
                    printAnsers("The area of the triangle is: " + triangleArea);
                    break;





            }
        
        
        
        
        }
        public static void factorial(int n)
        {
            if (n < 0)
            {
                printAnsers("factorial is not defined for negative numbers");
                return;
            }
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            printAnsers("the factorial of " + n + " is " + result);
        }

        // sum of odd and even number 
        public static void sumOfOddAndEven(int n)
        {
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
                else
                {
                    oddSum += i;
                }
            }
            printAnsers("the sum of even numbers is " + evenSum);
            printAnsers("the sum of odd numbers is " + oddSum);
        }
        //scientific calculator
        public static void scCalculator(string operation, double a, double b)
        {
            double result = 0;
            switch (operation)
            {
                case "sin":
                    result = Math.Sin(a);
                    break;
                case "cos":
                    result = Math.Cos(a);
                    break;
                case "tan":
                    result = Math.Tan(a);
                    break;
                case "log":
                    result = Math.Log(a);
                    break;
                case "exp":
                    result = Math.Exp(a);
                    break;
                default:
                    printAnsers("invalid operation");
                    return;
            }
            printAnsers("the result is " + result);
        }
        // Print pattern (for loop)
        public static void printPattern(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        // Print a Pyramid Pattern 
        public static void printPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        // Print a Diamond Pattern
        public static void printDiamond(int n)
        {
            // Print upper half
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // Print lower half
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //gussing game with helper 
        public static void guessingGame(int numberToGuess)
        {
            int guess;
            int attempts = 0;
            do
            {
                Console.WriteLine("Enter your guess:");
                guess = int.Parse(Console.ReadLine());
                attempts++;
                if (guess < numberToGuess)
                {
                    printAnsers("too low");
                }
                else if (guess > numberToGuess)
                {
                    printAnsers("too high");
                }
            } while (guess != numberToGuess);
            printAnsers("Congratulations! You guessed the number in " + attempts + " attempts.");
        }

    }


}
