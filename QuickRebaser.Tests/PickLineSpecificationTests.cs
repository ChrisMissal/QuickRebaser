using System.Collections;
using NUnit.Framework;
using QuickRebaser.Specifications;

namespace QuickRebaser.Tests
{
    [TestFixture]
    public class PickLineSpecificationTests : SpecificationTesterBase<PickLineSpecification>
    {
        public override IEnumerable GetTestLines
        {
            get
            {
                yield return new TestCaseData("p ffddee your message goes here", true);
                yield return new TestCaseData("pick ffddee your message goes here", true);
            }
        }
    }
}