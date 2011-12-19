using System.Collections;
using NUnit.Framework;

namespace QuickRebaser.Tests
{
    [TestFixture]
    public class FixupLineBuilderTests : CommitLineBuilderTests<FixupLineBuilder, FixupLine>
    {
        public override IEnumerable GetTestLines
        {
            get
            {
                yield return @"f e14506e to fix up";
                yield return @"fixup c7ba561 fixup previous";
            }
        }
    }
}