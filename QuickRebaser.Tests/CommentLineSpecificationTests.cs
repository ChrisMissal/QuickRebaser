using System.Collections;
using NUnit.Framework;
using QuickRebaser.Specifications;

namespace QuickRebaser.Tests
{
    [TestFixture]
    public class CommentLineSpecificationTests : SpecificationTesterBase<CommentLineSpecification>
    {
        public override IEnumerable GetTestLines
        {
            get
            {
                yield return new TestCaseData(null, false);
                yield return new TestCaseData("", false);
                yield return new TestCaseData("  ", false);
                yield return new TestCaseData("a", false);
                yield return new TestCaseData("1", false);
                yield return new TestCaseData("#", true);
            }
        }
    }
}