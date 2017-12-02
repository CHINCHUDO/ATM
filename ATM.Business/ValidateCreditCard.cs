using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Business
{
    class ValidateCreditCard
    {
        public static void main(String[] args)
        {
            Scanner userin = new Scanner(System.in);

            List<int> userNumbers = new List<int>(); //Initializing array
            int arrSize = 0;

            //do {
            Console.Write("Enter numbers(Up to 13 or 16): ");

            userNumbers.Add(userin.nextInt());
            while (userin.hasNextInt())
            {
                userNumbers.Add(userin.nextInt());
            }
            arrSize = userNumbers.Count();


             // Getting the last num of the array
            int item = userNumbers[userNumbers.Count - 1];

            //Start logic here

            // multiply each num by 2
            for (int i = 0; i < userNumbers.Count() - 1; i += 2)
            {
                userNumbers.set(i, userNumbers.get(i) * 2);
            }

            foreach (int x in userNumbers)
            {
                Console.Write(x + " ");
            }


            //Sum single integers
            for (int i = 0; i < userNumbers.Count() - 1; i++)
            {
                if (userNumbers.get(i) >= 10)
                {
                    int newOne = sumSingle(userNumbers.get(i));
                    userNumbers.set(i, newOne);
                }
            }

            Console.Write();

            foreach (int number in userNumbers)
            {
                Console.Write(number + " ");
            }

            int sum = 0;
            for (int i = 0; i < userNumbers.C() - 1; i++)
            {
                sum += userNumbers.get(i);
            }

            Console.Write("\n\nSum of numbers: " + sum);
            Console.Write(checkDigit);

            int finalsum = sum + checkDigit;

            Console.Write("Sum with checkDigit: " + finalsum);

            bool isDivisibleBy10 = finalsum % 10 == 0;

            if (isDivisibleBy10)
            {
                Console.Write("Credit card is valid");
            }
            Console.Write("Credit card not valid");

        }


        public static int sumSingle(Integer singleInt)
        {

            int y = singleInt;
            int sum = 0;

            while (y != 0)
            {
                sum = sum + (y % 10);
                y = y / 10;
            }
            //what happens if the sum is equal to 10 tho? (like 55)

            return sum;
        }
    }
}
