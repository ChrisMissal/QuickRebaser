using System.Collections;
using NUnit.Framework;
using QuickRebaser.Specifications;

namespace QuickRebaser.Tests
{
    [TestFixture]
    public class SquashLineSpecificationTests : SpecificationTesterBase<SquashLineSpecification>
    {
        public override IEnumerable GetTestLines
        {
            get
            {
                yield return new TestCaseData("s abccdd gooooo!", true);
                yield return new TestCaseData("squash abccdd hahaha!", true);
            }
        }
    }
}