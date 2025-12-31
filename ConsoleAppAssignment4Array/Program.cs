using System.Xml;

namespace ConsoleAppAssignment4Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A
           
            int[] num = new int[] { 8, 9, 3, 6, 1, 22, 9, 8, 3, 6 };
            int[] unique = new int[num.Length];
            int counter = 0;
            bool exists = false;
            int countDuplicate = 0;
            int j = 0;

            foreach(int i in num)
            {
                for(j=0; j<unique.Length;j++)
                {
                    if (unique[j] ==i)
                    {
                        exists = true;
                        countDuplicate++;// count the duplicate elements in array
                        break;
                    }
                }
                if (!exists)
                {
                    //if duplicate eleemnt not exist, then add the element inside unique array
                    unique[counter] = i;
                    counter++;
                }
            }
            Console.WriteLine("Count of duplicate elements in an array: " + countDuplicate);
         //-----------------------------------------------------------------------------------
            //B
            
            for(int pass=0; pass<unique.Length-1; pass++)
            {
                for(int  j1=0; j1<unique.Length-1;j1++)
                {
                    if (unique[j1] > unique[j1 + 1])
                    {
                        //bubble sorting
                        int d = unique[j1];
                        unique[j1] = unique[j1 + 1];
                        unique[j1 + 1] = d;
                    }
                }
            }
            for(int k=0; k<unique.Length; k++)
            {
                Console.Write(unique[k] + "\t");
            }
            Console.WriteLine("\nThe minimum element of array: " + unique[0]);
            Console.WriteLine("The maximum element of array: " + unique[unique.Length-1]);
           
        //--------------------------------------------------------------------------------------
            //C

            int[] num1 = new int[] { 8, 9, 3, 6, 1, 22, 9, 8, 3, 6 };
            int[] oddNum = new int[num1.Length];
            int[] evenNum = new int[num1.Length];
            int counterOdd=0, counterEven = 0;

            for(int i=0; i<num1.Length; i++)
            {
                if (num1[i]%2==0)
                {
                    //even numbers stored in evenNum array
                    evenNum[counterEven] = num1[i];
                    counterEven++;
                }
                else
                {
                    ////odd numbers stored in oddNum array
                    oddNum[counterOdd] = num1[i];
                    counterOdd++;
                }
            }
            Console.WriteLine("Even intergers are:");
            for(int j2=0; j2<(evenNum.Length); j2++)
            {
                //displays the even numbers
                Console.Write(evenNum[j2] + " ");
            }
            Console.WriteLine("\nOdd intergers are:");
            for (int k = 0; k <(oddNum.Length); k++)
            {
                //displays odd numbers
                Console.Write(oddNum[k] + " ");
            }
            
        //------------------------------------------------------------------------
            //D

            int[] num2 = new int[] { 8, 9, 3, 6, 1, 22, 9, 8, 3, 6 };

            for (int pass1 = 0; pass1 < num2.Length - 1; pass1++)
            {
                for (int i = 0; i < (num2.Length - 1); i++)
                {
                    if (num2[i] < num2[i + 1])
                    {// deccreasing order bubble sorting
                        int t = num2[i];
                        num2[i] = num2[i + 1];
                        num2[i + 1] = t;
                    }
                }
            }
            Console.WriteLine();
            for(int j3=0; j3<(num2.Length); j3++)
            {
                //displaying each value of array
                Console.Write(num2[j3] + " ");
            }
          
        //------------------------------------------------------------------------
            //E
            //(jilsy way)
            int[] nums = new int[] { 1,2,3,4,6,7,8 };
            Console.Write("\nEnter the new element to be inserted:");
            //input value to be inserted into sorted array
            int num3 = int.Parse(Console.ReadLine());

            //array nums resize to Length+1 to allocate new value
            Array.Resize(ref nums, nums.Length + 1);
            //add new element as last value of array
            nums[nums.Length - 1] = num3;

            // sort the array, so that the new element will be in sorted position
            for (int pass = 0; pass < nums.Length - 1; pass++)
            {
                for (int j4 = 0; j4 < nums.Length - 1; j4++)
                {
                    if (nums[j4] > nums[j4 + 1])
                    {//bubble sorting
                        int d = nums[j4];
                        nums[j4] = nums[j4 + 1];
                        nums[j4 + 1] = d;
                    }
                }
            }
            for (int k = 0; k < nums.Length; k++)
            {
                //displaying the elements of array
                Console.Write(nums[k] + "\t");
            }

       //------------------------------------------------------------------
            //F

            int[] arr = { 10, 20, 30, 40, 50 };

            Console.Write("Enter the position to delete (1 to {0}): ", arr.Length);
            int pos = int.Parse(Console.ReadLine());

            if (pos < 1 || pos > arr.Length)
            {
                //invalid posititon are rejected and returned
                Console.WriteLine("Invalid position!");
                return;
            }

            // new array should be old array length -1
            int[] newArr = new int[arr.Length - 1];

            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == pos - 1)   // skip the element which need to be deleted
                    continue;

                newArr[j] = arr[i];
                j++;
            }

            //displaying array after deleting required element
            Console.WriteLine("Array after deletion:");
            foreach (int n in newArr)
                Console.Write(n + " ");
        //------------------------------------------------------------------
            //H

            int[,] a = { { 1, 2 }, { 3, 4 } };
            int[,] b = { { 5, 6 }, { 7, 8 } };
            int[,] c = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j5 = 0; j5 < 2; j5++)
                {
                    //matrix addition computation
                    c[i, j5] = a[i, j5] + b[i, j5];
                }
            }
         //------------------------------------------------------------------
            //I

            int[,] a1 = { { 1, 2 }, { 3, 4 } };
            int[,] b1 = { { 2, 0 }, { 1, 2 } };
            int[,] c1 = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j6 = 0; j6 < 2; j6++)
                {
                    //intialise the c[i,j] to zero
                    c1[i, j6] = 0;

                    for (int k = 0; k < 2; k++)
                    {
                        //multiplication of matrix
                        c1[i, j6] += a1[i, k] * b1[k, j6];
                    }
                }
            }

        //--------------------------------------------------------------
            Console.WriteLine("press any key..");
            Console.ReadKey();
        }
    }
}
