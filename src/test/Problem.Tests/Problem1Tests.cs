using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Problem.Tests
{
    [TestFixture]
    public class Problem1Tests
    {
        [Test]
        public void Problem1Sample()
        {
            int result = Problem1.Solve(10);
            Assert.That(result, Is.EqualTo(23));
        }

        [Test]
        public void Problem1Solution()
        {
            int result = Problem1.Solve(1000);
            Assert.That(result, Is.EqualTo(233168));
        }
    }
}
