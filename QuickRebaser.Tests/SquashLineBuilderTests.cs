using System;
using System.Collections;
using NUnit.Framework;

namespace QuickRebaser.Tests
{
    [TestFixture]
    public class SquashLineBuilderTests : CommitLineBuilderTests<SquashLineBuilder, SquashLine>
    {
        public override IEnumerable GetTestLines
        {
            get
            {
                yield return "s c7ba561 some commit message";
                yield return "squash c7ba561 here's a message";
            }
        }
    }
}