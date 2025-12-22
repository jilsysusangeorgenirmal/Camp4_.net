using System.Diagnostics.Metrics;

namespace ConsoleAppAsignmentConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //A
            Console.WriteLine("===Voter Eligibility Checker===");
            Console.WriteLine("Minimum voting age is 18 years");
            Console.WriteLine("--------------------------------");
            byte age = 0;
            while (true)
            {
                Console.Write("Enter your age (0-255):");
                //get age value as input
                string input = Console.ReadLine();

                if (byte.TryParse(input, out age))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid! Please enter a number between 0 and 255");
                }
            }
                //age conditioning
                if (age >= 18)
                {
                    Console.WriteLine($"Age:{age}");
                    Console.WriteLine("Congratulations!!You are eligible to caste your vote");
                }
                else Console.WriteLine($"Sorry, you are not eligible to vote yet.");
                Console.WriteLine("======================================================");
        //========================================================================================
            //B
                int xPoint, yPoint = 0;
                while (true)
                {
                    Console.Write("Enter the x-axis point (-100 to 100):");
                    //get x coordinate point as input
                    string inputXAxis = Console.ReadLine();
                
                    //tryparse to typecast, if sucessfull returns true, else false
                    if(int.TryParse(inputXAxis, out xPoint))
                    {
                        break;
                    }
                    else
                    {   //display invalid entry message
                        Console.WriteLine("Invalid! Please enter a number between -100  and 100");
                    }
                }
                while (true)
                {
                    Console.Write("Enter the y-axis point (-100 to 100):");
                    //get y coordinate point as input
                    string inputYAxis = Console.ReadLine();

                    if (int.TryParse(inputYAxis, out yPoint))
                    {
                        break;
                    }
                    else
                    {   // display invalid entry message
                        Console.WriteLine("Invalid! Please enter a number between -100  and 100");
                    }
                }

                //first quadrant 
                if (xPoint > 0 && yPoint > 0)
                {
                    Console.WriteLine("Entered x, y coordinate points are in 1st quadrant");
                }
                //second quadrant 
                else if (xPoint < 0 && yPoint > 0)
                {
                    Console.WriteLine("Entered x, y coordinate points are in 2nd quadrant");
                }
                //third quadrant
                else if (xPoint < 0 && yPoint < 0)
                {
                    Console.WriteLine("Entered x, y coordinate points are in 3rd quadrant");
                }
                //fourth quadrant
                else
                {
                    Console.WriteLine("Entered x, y coordinate points are in 4th quadrant");
                }
                Console.WriteLine("======================================================");
         //============================================================================================
               //C
                int roll = 0;
                float marksFirst, marksSecond, marksThird = 0.0f;
                while (true)
                {
                    Console.Write("Enter the student rollno:");
                    //get roll no. as input value
                    string rollInput = Console.ReadLine();
                    if (int.TryParse(rollInput, out roll))
                    {
                        break;
                    }
                    else Console.WriteLine("Invalid entry!! Enter only digits 0 to 50");
                }
                Console.Write("Enter the student name:");
                //get name as input value
                var name_input = Console.ReadLine();
                var name = char.ToUpper(name_input[0]) + name_input.Substring(1);
                while (true)
                {
                    Console.Write("Enter the student first subject mark (0 to 100):");
                    //get first mark as input value
                    marksFirst = float.Parse(Console.ReadLine());
                    if (marksFirst >=0 && marksFirst <=100){
                        break;
                    }
                    else Console.WriteLine("Invalid entry!! Enter only digits 0 to 100");
                }
                while (true)
                {
                    Console.Write("Enter the student second subject mark (0 to 100):");
                    //get second mark as input value
                    marksSecond = float.Parse(Console.ReadLine());
                    if (marksSecond >= 0 && marksSecond <= 100)
                        {
                            break;
                        }
                        else Console.WriteLine("Invalid entry!! Enter only digits 0 to 100");
                }
                while (true)
                {
                    Console.Write("Enter the student third subject mark (0 to 100):");
                    //get third mark as input value
                    marksThird = float.Parse(Console.ReadLine());
                    if (marksThird >= 0 && marksThird <= 100)
                        {
                            break;
                        }
                        else Console.WriteLine("Invalid entry!! Enter only digits 0 to 100");
                }

                float total = marksFirst + marksSecond + marksThird;
                Console.WriteLine("Total marks for " + name + " is " + total);
                //percentage in range 0 to 100%
                float percentage = (total / 300) * 100;
                Console.WriteLine("Total percentage for " + name + " is " + percentage);
                //percentage to grade 
                if (percentage >= 90)
                {
                    Console.WriteLine("Grade:A");
                }
                else if (percentage >= 70 && percentage < 90)
                {
                    Console.WriteLine("Grade:B");
                }
                else if (percentage >= 60 && percentage < 70)
                {
                    Console.WriteLine("Grade:C");
                }
                else if (percentage >= 50 && percentage < 60)
                {
                    Console.WriteLine("Grade:D");
                }
                else if (percentage >= 40 && percentage < 50)
                {
                    Console.WriteLine("Grade:E");
                }
                else Console.WriteLine("Grade:F");
                Console.WriteLine("======================================================");
            
          //==========================================================================================
            //D

            float markMaths, markPhysics, markChemistry = 0.0f;
            while (true)
            {
                // enter maths marks as input
                Console.Write("Enter Maths mark range 0 to 100:");
                markMaths = float.Parse(Console.ReadLine());
                if (markMaths >= 0 && markMaths <= 100)
                {
                    break;
                }
                else Console.WriteLine("Invalid entry!! Enter only digits 0 to 100");
            }
            while (true)
            {
                //enter physics as input
                Console.Write("Enter Physics mark range 0 to 100:");
                markPhysics = float.Parse(Console.ReadLine());
                if (markPhysics >= 0 && markPhysics <= 100)
                {
                    break;
                }
                else Console.WriteLine("Invalid entry!! Enter only digits 0 to 100");
            }
            while (true)
            {
                //enter chemistry as input
                Console.Write("Enter Chemistry mark range 0 to 100:");
                markChemistry = float.Parse(Console.ReadLine());
                if (markChemistry >= 0 && markChemistry <= 100)
                {
                    break;
                }
                else Console.WriteLine("Invalid entry!! Enter only digits 0 to 100");
            }

            float totalMarks = markMaths + markPhysics + markChemistry;

            if((markMaths>=65 && markPhysics>=55 && markChemistry>=50 && totalMarks>=180) || (totalMarks >= 140))
            {
                Console.WriteLine("Congratulation! You are eliglble of admission for the professional course!");
            }
            else Console.WriteLine("Sorry! You are not eliglble of admission for the professional course!");
            Console.WriteLine("======================================================");
            */
        //==========================================================================================
            //E
            byte choice = 0;
            char continueChoiceShape = 'n';
            do
            {
                Console.WriteLine("enter the number to find area of respective shapes:\n" +
                    "1. Circle\n" +
                    "2. Square\n" +
                    "3. Triangle\n" +
                    "4. Reactangle\n ");
           
                choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter radius of the circle:");
                        float radius = float.Parse(Console.ReadLine());
                        Console.WriteLine("Area of circle: " + (3.14 * radius * radius));
                        break;
                    case 2:
                        Console.Write("Enter side of the square:");
                        float side = float.Parse(Console.ReadLine());
                        Console.WriteLine("Area of square: " + (side * side));
                        break;
                    case 3:
                        Console.Write("Enter height of the triangle:");
                        float height = float.Parse(Console.ReadLine());
                        Console.Write("Enter breadth of the triangle:");
                        float breadth = float.Parse(Console.ReadLine());
                        Console.WriteLine("Area of triangle: " + (0.5 * breadth * height));
                        break;
                    case 4:
                        Console.Write("Enter length of the rectangle:");
                        float lengthRectangle = float.Parse(Console.ReadLine());
                        Console.Write("Enter breadth of the rectangle:");
                        float breadthRectangle = float.Parse(Console.ReadLine());
                        Console.WriteLine("Area of rectangle: " + (lengthRectangle * breadthRectangle));
                        break;
                    default:
                        Console.WriteLine("Invalid choice....!");
                        break;
                }
                Console.WriteLine("Do you want to continue:(y to continue,n to exit)");
                continueChoiceShape = Convert.ToChar(Console.ReadLine());
            } while (continueChoiceShape == 'y');
            Console.WriteLine("======================================================");
       //==========================================================================================
            //F
            //menudriven
            int firstNumber, secondNumber = 0;
            char continueChoice = 'n';

            do
            {
                //input first and econd numbers
                Console.Write("Enter your first number:");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your second number:");
                secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(); //blank line

                ////Display menu options
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");

                Console.WriteLine("Enter your choice:");
                //Get choice from the user
                int choiceCalculation = Convert.ToInt32(Console.ReadLine());

                //calculations logic
                switch (choiceCalculation)
                {
                    case 1:
                        Console.WriteLine("Sum is:" + (firstNumber + secondNumber));
                        break;
                    case 2:
                        Console.WriteLine("Difference is:" + (firstNumber - secondNumber));
                        break;
                    case 3:
                        Console.WriteLine("Product is:" + (firstNumber * secondNumber));
                        break;
                    case 4:
                        Console.WriteLine("Quotient is:" + (firstNumber / secondNumber));
                        break;
                    default:
                        Console.WriteLine("Invalid choice....!");
                        break;
                }
                Console.WriteLine("Do you want to continue:(y to continue,n to exit)");
                continueChoice = Convert.ToChar(Console.ReadLine());
            } while (continueChoice == 'y');
            Console.WriteLine("======================================================");
     //=========================================================================================
            //G
            Console.Write("Enter the customer id:");
            int customerID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the customer name:");
            var customerName = Console.ReadLine();
            Console.Write("Enter the unit the customer consumed:");
            float customerUnit = float.Parse(Console.ReadLine());

            if (customerUnit <= 199)
            {
                Console.WriteLine("Charge: " + (customerUnit * 1.20));
            }
            else if (customerUnit >= 200 && customerUnit < 400)
            {
                Console.WriteLine("Charge: " + (customerUnit * 1.50));
            }
            else if (customerUnit >= 400 && customerUnit < 600)
            {
                Console.WriteLine("Charge: " + (customerUnit * 1.80));
            }
            else Console.WriteLine("Charge: " + (customerUnit * 2.00));

            Console.WriteLine("======================================================");
      //=========================================================================================
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
         
        }
    }
}
