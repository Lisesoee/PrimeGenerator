using System;
using System.Collections.Concurrent;
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

            for (long i = first; i <= last; i++)
            {

                if (isPrimeNumber(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
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
            Object lockObject = new Object();

            Parallel.ForEach(
                Partitioner.Create(first, last),
                (range) =>
                {
                    for (long i = range.Item1; i < range.Item2; i++)
                    {
                        if (isPrimeNumber(i))
                        {
                            lock (lockObject)
                            {
                                primes.Add(i);
                            }
                        }
                    }
                });

            primes.Sort();

            return primes;
        }

        public Task<List<long>> GetPrimesSequentialAsync(long first, long last)
        {
            return Task.Factory.StartNew(() =>
            {
                return GetPrimesSequential(first, last);
            });
        }

        public Task<List<long>> GetPrimesParallelAsync(long first, long last)
        {
            return Task.Factory.StartNew(() =>
            {
                return GetPrimesParallel(first, last);
            });
        }
    }
}
