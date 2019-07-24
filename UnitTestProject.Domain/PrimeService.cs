using System;

namespace UnitTestProject.Domain
{
    public class PrimeService : IPrimeService
    {
        public bool IsPrime(int number)
        {
            if (IsFalseCondition(number))
            {
                return false;
            }
            else
            {
                var boundary = (int)Math.Floor(Math.Sqrt(number));
                for (int i = 3; i <= boundary; i += 2)
                {
                    if (number % i == 0)
                        return false;
                }
                return true;
            }
        }

        private bool IsFalseCondition(int number)
        {
            if (number == 2)
                return false;
            if (number < 2 || IsEven(number))
                return true;
            return false;
        }

        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
