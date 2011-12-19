using System;
using System.Collections;
using NUnit.Framework;

namespace QuickRebaser.Tests
{
    public abstract class CommitLineBuilderTests<TBuilder, TLine> where TBuilder : ICommitLineBuilder
    {
        protected TBuilder GetBuilder()
        {
            return Activator.CreateInstance<TBuilder>();
        }

        public abstract IEnumerable GetTestLines { get; }

        [TestCaseSource("GetTestLines")]
        public void Test_lines_should_be_correct_type(string line)
        {
            var builder = GetBuilder();
            var commitLine = builder.Build(line);
            Assert.That(commitLine, Is.AssignableFrom<TLine>());
        }
    }
}