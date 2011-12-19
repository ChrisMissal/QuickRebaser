using System;
using System.Collections;
using NUnit.Framework;

namespace QuickRebaser.Tests
{
    [TestFixture]
    public class RewordLineBuilderTests : CommitLineBuilderTests<RewordLineBuilder, RewordLine>
    {
        public override IEnumerable GetTestLines
        {
            get
            {
                yield return "r fce66d line text was entered";
                yield return "reword fce66d more text was entered";
            }
        }
    }
}