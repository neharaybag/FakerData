using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace FakerData
{
    
    public class Sample
    {
        [Test]
        public void FakerTests()
        {
            DataGenerator dataGenerator = new DataGenerator();
            Console.WriteLine(dataGenerator.GetFirstName());
            Console.WriteLine(dataGenerator.GetLastName());
            Console.WriteLine(dataGenerator.GetFullName());
            Console.WriteLine(dataGenerator.GetEmail());
            Console.WriteLine(dataGenerator.GetMobileNumber());
            Console.WriteLine(dataGenerator.GetPostCode());
            Console.WriteLine(dataGenerator.GetRandomDate());
            Console.WriteLine(dataGenerator.GetRandomMonth());
            Console.WriteLine(dataGenerator.GetRandomYear());
        }
    }
}
