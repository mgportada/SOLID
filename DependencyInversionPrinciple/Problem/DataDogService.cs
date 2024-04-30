using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Problem
{
    public class DataDogService
    {
        public void Log(string message)
        {
            Console.WriteLine($"DataDog: {message}");
        }
    }
}
