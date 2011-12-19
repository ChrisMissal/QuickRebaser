using System;
using Moq;
using NUnit.Framework;
using QuickRebaser.Specifications;

namespace QuickRebaser.Tests
{
    [TestFixture]
    public class CommitLineBuilderBaseTests
    {
        private static Mock<ISpecification<string>> specification;

        [SetUp]
        public void SetUp()
        {
            specification = new Mock<ISpecification<string>>();
        }

        [TestCase(true, true)]
        [TestCase(false, false)]
        public void IsQualified_should_return_result_from_Specification(bool isSpecified, bool expected)
        {
            const string line = "line";
            specification.Setup(x => x.IsSatisfiedBy(line)).Returns(isSpecified);
            var builder = new TestCommitLineBuilderBase();

            builder.IsQualified(line).ShouldBe(expected);
        }

        public class TestCommitLineBuilderBase : CommitLineBuilderBase
        {
            protected override ISpecification<string> Specification
            {
                get { return specification.Object; }
            }

            public override CommitLine Build(string line)
            {
                throw new NotImplementedException();
            }
        }
    }
}