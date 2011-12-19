using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;

namespace QuickRebaser.Tests
{
    [TestFixture]
    public class CommitLineBuilderFactoryTests
    {
        private readonly IList<ICommitLineBuilder> builders = new List<ICommitLineBuilder>();

        [Test]
        public void GetBuilder_should_not_return_Builder_that_is_not_Qualified()
        {
            var line = "some line from the file";
            var nonQualifiedBuilder = new Mock<ICommitLineBuilder>();
            nonQualifiedBuilder.Setup(x => x.IsQualified(line)).Returns(false);
            builders.Add(nonQualifiedBuilder.Object);
            var factory = GetCommitLineBuilderFactory();

            var result = factory.GetBuilder(line);

            result.ShouldBeNull();
        }

        [Test]
        public void GetBuilder_should_return_first_Builder_that_IsQualified()
        {
            var line = "some line from the file";
            var nonQualifiedBuilder = new Mock<ICommitLineBuilder>();
            nonQualifiedBuilder.Setup(x => x.IsQualified(line)).Returns(false);
            var qualifiedBuilder = new Mock<ICommitLineBuilder>();
            qualifiedBuilder.Setup(x => x.IsQualified(line)).Returns(true);
            builders.Add(nonQualifiedBuilder.Object);
            builders.Add(qualifiedBuilder.Object);
            var factory = GetCommitLineBuilderFactory();

            var result = factory.GetBuilder(line);

            result.ShouldBe(qualifiedBuilder.Object);
        }

        private CommitLineBuilderFactory GetCommitLineBuilderFactory()
        {
            return new CommitLineBuilderFactory(builders.ToArray());
        }
    }
}