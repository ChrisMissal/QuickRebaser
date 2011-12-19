using System;
using System.Collections;
using NUnit.Framework;

namespace QuickRebaser.Tests
{
    [TestFixture]
    public class PickLineBuilderTests : CommitLineBuilderTests<PickLineBuilder, PickLine>
    {
        public override IEnumerable GetTestLines
        {
            get
            {
                yield return "pick c7ba561 added entry to .gitignore for *ReSharper*";
                yield return "p 0044323 wrote some sweet code'ums!";
            }
        }
    }
}