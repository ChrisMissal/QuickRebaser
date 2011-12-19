using System.Collections;
using NUnit.Framework;

namespace QuickRebaser.Tests
{
    [TestFixture]
    public class CommentLineBuilderTests : CommitLineBuilderTests<CommentLineBuilder, CommentLine>
    {
        [TestCaseSource("GetTestLines")]
        public void CommentLines_should_equal_string_lines(string line)
        {
            var builder = GetBuilder();
            var commitLine = builder.Build(line);
            Assert.That(commitLine.Line, Is.EqualTo(line));
        }

        public override IEnumerable GetTestLines
        {
            get
            {
                yield return @"# Rebase 0044323..e14506e onto 0044323";
                yield return @"#";
                yield return @"# Commands:";
                yield return @"#  p, pick = use commit";
                yield return @"#  r, reword = use commit, but edit the commit message";
                yield return @"#  e, edit = use commit, but stop for amending";
                yield return @"#  s, squash = use commit, but meld into previous commit";
                yield return @"#  f, fixup = like ""squash"", but discard this commit's log message";
                yield return @"#";
                yield return @"# If you remove a line here THAT COMMIT WILL BE LOST.";
                yield return @"# However, if you remove everything, the rebase will be aborted.";
                yield return @"#";
            }
        }
    }
}