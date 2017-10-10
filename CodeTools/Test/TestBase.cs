using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace CodeTools.Tests
{    
    public class TestBase
    {
        [TestFixtureSetUp]
        public virtual void Start()
        {
            Console.WriteLine("Application Begin;");          
        }

        [TestFixtureTearDown]
        public virtual void Stop()
        {
            Console.WriteLine("Application Stop;");
        }
    }
}
