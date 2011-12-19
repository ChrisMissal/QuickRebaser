using System.Collections;
using NUnit.Framework;
using QuickRebaser.Specifications;

namespace QuickRebaser.Tests
{
    [TestFixture]
    public class FixupLineSpecificationTests : SpecificationTesterBase<FixupLineSpecification>
    {
        public override IEnumerable GetTestLines
        {
            get
            {
                yield return new TestCaseData("f aabbcc I typed a message", true);
                yield return new TestCaseData("fixup aabbcc You typed a message", true);
            }
        }
    }
}