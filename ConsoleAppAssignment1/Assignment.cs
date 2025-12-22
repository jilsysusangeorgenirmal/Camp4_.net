namespace ConsoleAppAssignment1
{
    internal class Assignment
    {
        static void Main(string[] args)
        {
            //A
            byte count = 0;
            // giving chance of 3 for correct username and password
            while (count < 3)
            {
                Console.Write("Enter userid:");
                var userid = Console.ReadLine();
                //checks if username is user
                if (userid != "user")
                {
                    count += 1;
                    Console.WriteLine("Wrong userid!!");
                }
                else
                {
                    Console.Write("Enter password:");
                    var password = Console.ReadLine();
                    //checks if password is password
                    if (password != "password")
                    {
                        count += 1;
                        Console.WriteLine("Wrong password!");
                    }
                    else
                    {
                        Console.WriteLine("Sucessfully logged in!!");
                        break;
                    }
                }

            }
            if (count == 3)
            {
                //3 attempst over. Display message
                Console.WriteLine("3 wrong attemps!! User is rejected");
            }
            Console.WriteLine("===========================================");          
        //========================================================================
            //B

            //input number to be displayed in triangle
            Console.Write("Enter the number to be displayed inside triangle:");
            int num = int.Parse(Console.ReadLine());
            // input the row count of triangle
            Console.Write("Enter the width of triangle:");
            int row = int.Parse(Console.ReadLine());

            for (int i = 1; i <= row; i++) 
            {
                for (int j = 1; j<= i; j++)
                {
                    Console.Write(num);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("===========================================");           
        //========================================================================
            //C
            
            //input distance in km
            Console.Write("Enter the distance in km:");
            float distance = float.Parse(Console.ReadLine());
            //input time in hours
            Console.Write("Enter the time in hour:");
            float time = float.Parse(Console.ReadLine());
            float speed = distance / time;
            //calculating speed in miles/hour
            double speedMiles = ((distance * 0.621) / time);
            //display result
            Console.WriteLine($"The calculated speed for km/hour :{speed}");
            Console.WriteLine($"The calculated speed for miles/hour :{speedMiles}");
            Console.WriteLine("===========================================");
        //=======================================================================
            //D

            int yValue = 0;
            while (true)
            {
                Console.Write("Enter y value from -5 to 5 range:");
                //input y value
                yValue = int.Parse(Console.ReadLine());

                //check if yValue is in range -5 to 5
                if (yValue >= -5 && yValue <= 5)
                {
                    break;
                }
                else Console.WriteLine("Enter value is not in range of -5 to 5");
            }
            
            int result = (yValue * yValue) + (2 * yValue) + 1;
            Console.WriteLine($"The result computation for y value {yValue} is " + result);
            Console.WriteLine("===========================================");
         //==================================================================================
            Console.WriteLine("press any key...");
            Console.ReadKey();
        }
    }
}
