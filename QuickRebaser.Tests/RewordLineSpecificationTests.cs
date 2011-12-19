using System.Collections;
using NUnit.Framework;
using QuickRebaser.Specifications;

namespace QuickRebaser.Tests
{
    [TestFixture]
    public class RewordLineSpecificationTests : SpecificationTesterBase<RewordLineSpecification>
    {
        public override IEnumerable GetTestLines
        {
            get
            {
                yield return new TestCaseData("r abcdef message", true);
                yield return new TestCaseData("reword defabc messaging", true);
            }
        }
    }
}