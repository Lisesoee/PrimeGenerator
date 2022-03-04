using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrimeGenerator2
{
    class PrimeGenerator
    {

        public List<long> GetPrimesSequential(long first, long last)
        {
            List<long> primes = new List<long>();
           
            for (long i = first; i < last; i++)
            {
                if (isPrimeNumber(i))
                {
                    primes.Add(i);
                }
                i++;                
            }            
            return primes;

            // TODO: fix issue where 2 is not added to the list when given range 1..50
        }

        private bool isPrimeNumber(long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }                    
            }                

            return true;
        }

        public List<long> GetPrimesParallel(long first, long last)
        {
            List<long> primes = new List<long>();

            // TODO: Make parallel (needs locking or concurrent collection)
            
            for (long i = first; i < last; i++)
            {
                if (isPrimeNumber(i))
                {
                    primes.Add(i);
                }
                i++;
            }

            // TODO: Make list sorted (as if it was generated sequentially)

            return primes;
        }
        
    }
}
