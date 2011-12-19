using System.Collections;
using NUnit.Framework;

namespace QuickRebaser.Tests
{
    [TestFixture]
    public class EditLineBuilderTests : CommitLineBuilderTests<EditLineBuilder, EditLine>
    {
        public override IEnumerable GetTestLines
        {
            get
            {
                yield return "e 40f48d3 edited";
                yield return "edit 40f48d3 edited";
            }
        }
    }
}