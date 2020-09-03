using System;
namespace ChallengeSets
{
    public class ChallengeSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            //throw new NotImplementedException();
            if ( num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            //throw new NotImplementedException();

            double sum = 0;
            sum = minuend - subtrahend
            return sum;

        }

        public int Add(int number1, int number2)
        {
            // throw new NotImplementedException();
            double sum = 0;
            sum = minuend + subtrahend
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            //throw new NotImplementedException();
            if (number1 < number)
            {
                return number1;
            } else
            {
                return number2;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            // throw new NotImplementedException();
            long multSum = 0;
            multSum = factor1 * factor2;
            return multSum;
        }

        public string GetGreeting(string nameOfPerson)
        {
            //throw new NotImplementedException();

            //if nameOfPerson != "" ?
            return (nameOfPerson == "") ? "Hello" : $"hello, {nameOfPerson }";

        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
