using System;
using NUnit.Framework;

namespace NUnitFrameWork
{
    class AutomationClass
    {
        [SetUp]
        public void ProgrameSetUp()
        {
            Console.Out.WriteLine("SetUP Function");

        }
        [Test]
        public void ProgrameTest()
        {

            Console.WriteLine("Test Function");
            

        }
        [TearDown]
        public void ProgrameTeardown()
        {
            Console.Out.WriteLine("Teardown Function");

        }


    }
}
