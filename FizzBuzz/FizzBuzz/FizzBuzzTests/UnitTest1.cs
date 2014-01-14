using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzTests
{
        [TestFixture]
        public class FizzBuzzTests
        {
            [TestCase(1,"1")]
            [TestCase(2,"2")]
            [TestCase(3,"Fizz")]
            [TestCase(5,"Buzz")]
            [TestCase(6,"Fizz")]
            [TestCase(10,"Buzz")]
            [TestCase(15,"FizzBuzz")]
            public void Translate(int input, string expected)
            {
                string result = Translator.Translate(input);
                Assert.That(result, Is.EqualTo(expected));
            }
        }
}

