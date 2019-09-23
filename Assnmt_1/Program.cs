using System;
using System.Collections.Generic;

namespace Assnmt_1
{
    class Program
    {


        static void Main(string[] args)
        {
            printSelfDevidingNumbers(5, 22);
            printseries(5);
            printTraingle(9);
            int[] J = { 1, 3 };
            int[] S = { 1, 3, 3, 2, 2, 2, 2, 2 };
            numJewelsInStones(J, S);
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] b = { 1, 2, 5, 7, 8, 9, 10 };
            getLargestSubArray(a, b);
        }

        //Q1

        public static void printSelfDevidingNumbers(int a, int b)
        {
            try
            {
                List<int> digitList = new List<int>();
                List<int> selfDeviceNums = new List<int>();

                // fo fiureout the between nos
                for (int i = a + 1; i < b; i++)
                {
                    digitList.Add(i);
                }

                //to figureout selfdivide nos of between nos
                for (int k = 0; k < digitList.Count; k++)
                {
                    var num = digitList[k];
                    var isTrue = IsSelfDevide(num);
                    if (isTrue)
                        selfDeviceNums.Add(num);
                    else
                        continue;

                }
                Console.WriteLine(String.Join(", ", selfDeviceNums));
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("There is error in method printSelfDevidingNumbers: " + e.Message);
            }
        }

        // Function to check if all digits 
        // of n divide it or not 
        static bool IsSelfDevide(int n)
        {
            int temp = n;
            while (temp > 0)
            {

                // Taking the digit of the 
                // number into digit var. 
                int digit = temp % 10;
                if (!(checkDivisibility(n, digit)))
                    return false;

                temp = temp / 10;
            }
            return true;
        }

        static bool checkDivisibility(int n, int digit)
        {
            // If the digit divides the number 
            // then return true else return false. 
            return (digit != 0 && n % digit == 0);
        }

        //Q2

        public static void printseries(int n)
        {

            try
            {
                for (int i = 1; i <= n; i++)
                {
                    //to print series nos
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i);

                        if (j != n)
                            Console.Write(",");
                    }

                }
                Console.Read();
            }

            catch (Exception e)
            {
                Console.WriteLine("There is error in method printseries: " + e.Message);
            }
        }

        //Q3

        public static void printTraingle(int n)
        {

            try
            {
                int i, j, k;

                for (i = 1; i <= n; i++)
                {
                    for (k = i; k > 0; k--) //Loop to write appropriate spacing for the triangle
                    {
                        Console.Write(" ");
                    }

                    for (j = 2 * n - (2 * i - 1); j > 0; j--) //Loop to write the proper number of stars
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");

                }
                Console.Read();
            }

            catch (Exception e)
            {
                Console.WriteLine("There is error in method printTraingle: " + e.Message);
            }
        }

        //Q4

        public static void numJewelsInStones(int[] arr1, int[] arr2)
        {
            try
            {
                List<int> digitList = new List<int>();

                for (int i = 0; i < arr1.Length; i++)
                {
                    //to find out jewels from stones
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr1[i] == arr2[j])
                        {
                            digitList.Add(i);
                        }
                    }
                }
                Console.WriteLine("numJewelsInStones: " + digitList.Count);
                Console.Read();
            }

            catch (Exception e)
            {
                Console.WriteLine("There is error in method numJewelsInStones: " + e.Message);
            }

        }

        //Q5

        public static void getLargestSubArray(int[] arr1, int[] arr2)
        {
            try
            {
                List<int> currentArray = new List<int>();
                List<int> prevArray = new List<int>();
                int j, k = 0;

                //for each no from array1
                for (int i = 0; i < arr1.Length; i++)
                {
                    j = 0;
                    k = i;

                    //to find out sub array
                    for (j = 0; j < arr2.Length && k < arr1.Length; j++)
                    {
                        if (arr1[k] == arr2[j])
                        {
                            currentArray.Add(arr1[k]);
                            k++; //to get next element from array1
                        }
                        else if (currentArray.Count >= 1)
                        {
                            //to findout max subarray
                            if (currentArray.Count > 1 && prevArray.Count <= currentArray.Count)
                            {
                                prevArray = currentArray;
                                j--;
                            }
                            currentArray = new List<int>();
                            k = i;
                        }
                    }

                    //to findout max subarray
                    if (currentArray.Count > 1 && prevArray.Count <= currentArray.Count)
                    {
                        prevArray = currentArray;

                    }

                    currentArray = new List<int>();

                }


                Console.WriteLine(String.Join(", ", prevArray));
                Console.ReadKey();
            }

            catch (Exception e)
            {
                Console.WriteLine("There is error in method getLargestSubArray: " + e.Message);
            }
        }

    }
}



