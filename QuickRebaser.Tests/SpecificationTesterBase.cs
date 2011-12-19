using System;
using System.Collections;
using NUnit.Framework;
using QuickRebaser.Specifications;

namespace QuickRebaser.Tests
{
    public abstract class SpecificationTesterBase<T> where T : ISpecification<string>
    {
        public T GetSpecification()
        {
            return Activator.CreateInstance<T>();
        }

        public abstract IEnumerable GetTestLines { get; }

        [TestCaseSource("GetTestLines")]
        public void Test_lines_should_return_expected_satisfaction(string line, bool expected)
        {
            var specification = GetSpecification();
            var result = specification.IsSatisfiedBy(line);
            result.ShouldBe(expected);
        }
    }
}