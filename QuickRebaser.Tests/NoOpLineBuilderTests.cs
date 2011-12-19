using System.Collections;
using NUnit.Framework;

namespace QuickRebaser.Tests
{
    [TestFixture]
    public class NoOpLineBuilderTests : CommitLineBuilderTests<NoOpLineBuilder, NoOpLine>
    {
        [TestCaseSource("GetTestLines")]
        public void NoOpLines_should_equal_string_lines(string line)
        {
            var builder = GetBuilder();
            var commitLine = builder.Build(line);
            Assert.That(commitLine.Line, Is.EqualTo(line));
        }

        public override IEnumerable GetTestLines
        {
            get
            {
                yield return "";
                yield return "noop";
            }
        }
    }
}