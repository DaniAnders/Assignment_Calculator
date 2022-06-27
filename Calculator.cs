using System;
namespace Assignment_Calculator
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public double Add(params double[] n)
        { 
            double sum = 0;
            if(n.Length == 1)
            {
                Console.WriteLine("Please input two or more values!");
                sum = n[0];
            }else
            {   for(int i = 0; i < n.Length; i++)
                {
                    sum += n[i];
                }
            }
            Console.WriteLine($"The sum of values {string.Join(" + ", n)} is: {sum}");
            return sum;


        }



        public double Sub(params double[] n)
        {
            double sub = 0;
            if (n.Length == 1)
            {
                Console.WriteLine("Please input two or more values!");
                sub = n[0];
            }
            else
            {
                foreach (double number in n)
                {
                    sub = Math.Abs(sub) - number;
                }
            }
            Console.WriteLine($"The subtraction of values {string.Join(" - ", n)} is: {sub}");
            return sub;

        }






        public double Mult(params double[] n)
        {
            double mult = 1;
            if (n.Length == 1)
            {
                Console.WriteLine("Please input two or more values!");
                mult = n[0];
            }
            else
            {
                for (int i = 0; i < n.Length; i++)
                {
                    mult *= n[i];
                }
            }
            Console.WriteLine($"The multiplication of {string.Join(" * ", n)} is: {mult}");
            return mult;
        }


        public double Div()
        {
            double res = 0;
            Console.WriteLine("Please enter the first value: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second value: ");
            double n2 = double.Parse(Console.ReadLine());

            if (n1.Equals(0) || n2.Equals(0))
            {
                Console.WriteLine("You are trying divide by zero! Please try again with a valid value.");

            }
            else
            {
                res = n1 / n2;
                Console.WriteLine($"The result of division is: {res}");
            }

            return res;
        }



        public double[] GetInput()
        {
            Console.WriteLine("Enter values separated by comma: ");
            string[] input = Console.ReadLine().Split(',');
            double[] values = input.Select(double.Parse).ToArray();

            return values;
        }


        public int Remainder()
        {
            Console.WriteLine("Enter the dividend: ");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the divisor: ");
            int divisor = int.Parse(Console.ReadLine());
            int quotient = Math.DivRem(dividend, divisor, out int remainder);

            Console.WriteLine($"The dividend is : {dividend}\nThe divisor is : {divisor}\nThe quotient is : {quotient}\nThe remainder is : {remainder}\n");

            return remainder;
        }

        public double Fact()
        {
            double res = 1;
            Console.WriteLine("Input a value ");
            double value = double.Parse(Console.ReadLine());
            double inputedNumber = value;
            while (value != 1)
            {
                res = res * value;
                value = value - 1;
            }
            Console.WriteLine($"The factorial of {inputedNumber} is: {res}");

            return res;
        }



        public void MainMenu()
        {

            bool showMenu = true;
            double[] input = { };

            do
            {
                Console.WriteLine("\n-------Calculator--------\n");
                Console.WriteLine("\nPlease select an option: \n");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Remainder");
                Console.WriteLine("6. Factorial");
                Console.WriteLine("0. Quit");
                int.TryParse(Console.ReadLine(), out int option);


                switch (option)
                {
                    case 0:
                        showMenu = false;
                        Console.Clear();
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n---Addition---\n");
                        input = GetInput();
                        Add(input);
                        Console.ReadLine();
                        showMenu = true;
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n---Subtraction---\n");
                        input = GetInput();
                        Sub(input);
                        Console.ReadLine();
                        showMenu = true;
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n---Multiplication---\n");
                        input = GetInput();
                        Mult(input);
                        Console.ReadLine();
                        showMenu = true;
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n---Division---\n");
                        Div();
                        Console.ReadLine();
                        showMenu = true;
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("\n---Remainder---\n");
                        Remainder();
                        Console.ReadLine();
                        showMenu = true;
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("\n---Factorial---\n");
                        Fact();
                        Console.ReadLine();
                        showMenu = true;
                        break;
                    default:
                        showMenu = true;
                        break;

                }

            } while (showMenu);



        }




    }
}

