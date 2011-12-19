using System.Collections;
using NUnit.Framework;
using QuickRebaser.Specifications;

namespace QuickRebaser.Tests
{
    [TestFixture]
    public class NoopLineSpecificationTests : SpecificationTesterBase<NoOpLineSpecification>
    {
        public override IEnumerable GetTestLines
        {
            get
            {
                yield return new TestCaseData("noop", true);
                yield return new TestCaseData("", true);
                yield return new TestCaseData("pick aaaaaa blah", false);
            }
        }
    }
}