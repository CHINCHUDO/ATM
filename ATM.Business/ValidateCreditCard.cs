using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace ATM.Business
{
    class ValidateCreditCard
    {
        public static void main(String[] args)
        {
            //Initiliaze a Credit Card 
            CreditCard ccard = new CreditCard();

            //Setting the ccard numbers
            List<int> userNumbers = ccard.Numbers;

            Console.Write("Enter numbers(Up to 13 or 16): ");

            int userNumsSize = TextBox1.Text.Size();

            //Warn the user of possible error 
            if(userNumsSize != 13 || userNumsSize != 16)
            {
                MessageDialog userwarning = new MessageDialog("Error: Numbers didn't meet the criteria");
                userwarning.ShowAsync();
            }

            //Add the numbers to the array
            userNumbers.Add(Convert.ToInt32(TextBox1.Text));


             // Getting the last num of the array
            int checkDigit = userNumbers[userNumbers.Count - 1];

            //Start logic here

            // multiply each num by 2
            for (int i = 0; i < userNumbers.Count() - 1; i += 2)
            {
                userNumbers[i] = userNumbers.ElementAt(i) * 2;
            }

            foreach (int x in userNumbers)
            {
                Console.Write(x + " ");
            }


            //Sum single integers
            for (int i = 0; i < userNumbers.Count() - 1; i++)
            {
                if (userNumbers.ElementAt(i) >= 10)
                {
                    int newOne = sumSingle(userNumbers.ElementAt(i));
                    userNumbers[i] = newOne;
                }
            }

            Console.Write();

            //Print it to the screen
            foreach (int number in userNumbers)
            {
                Console.Write(number + " ");
            }

            int sum = 0;

            //Sum all numbers in the array except the last number
            for (int i = 0; i < userNumbers.Count - 1; i++)
            {
                sum += userNumbers.ElementAt(i);
            }

            //Print it to the screen
            Console.Write("\n\nSum of numbers: " + sum);
            Console.Write(checkDigit);

            int finalsum = sum + checkDigit;

            //Print the final sum
            Console.Write("Sum with checkDigit: " + finalsum);


            //Print out if valid card

            if (isDivisibleByTen(finalsum))
            {
                MessageDialog validCCard = new MessageDialog("Valid credit card");
                validCCard.ShowAsync();
            }
            MessageDialog invalidCCard = new MessageDialog("Invalid credit card");
            invalidCCard.ShowAsync();

        }

        //Sum digits in single number
        public static int sumSingle(int singleInt)
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

        //Verify if the number it's divisible by 10
        public static bool isDivisibleByTen(int number)
        {
            if (number % 10 != 0) {
                return false;
            }
            return true;
        }
    }
}
