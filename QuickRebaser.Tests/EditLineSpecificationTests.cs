using System.Collections;
using NUnit.Framework;
using QuickRebaser.Specifications;

namespace QuickRebaser.Tests
{
    [TestFixture]
    public class EditLineSpecificationTests : SpecificationTesterBase<EditLineSpecification>
    {
        public override IEnumerable GetTestLines
        {
            get
            {
                yield return new TestCaseData("e ffddee your message goes here", true);
                yield return new TestCaseData("edit ffddee your message goes here", true);
            }
        }
    }
}