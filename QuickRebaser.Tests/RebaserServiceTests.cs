using System.Collections.Generic;
using Moq;
using NUnit.Framework;

namespace QuickRebaser.Tests
{
    [TestFixture]
    public class RebaserServiceTests
    {
        private Mock<CommitLine> commitLine;
        private Mock<ICommitLineBuilderFactory> commitLineBuilderFactory;

        [SetUp]
        public void SetUp()
        {
            commitLine = new Mock<CommitLine>("", LineType.Unknown);
            commitLineBuilderFactory = new Mock<ICommitLineBuilderFactory>();
        }

        [TestCase("f")]
        [TestCase("F")]
        [TestCase("e")]
        [TestCase("E")]
        [TestCase("r")]
        [TestCase("R")]
        [TestCase("s")]
        [TestCase("S")]
        [TestCase("p")]
        [TestCase("P")]
        public void GetCommand_should_return_expected_Command_if_key_is_valid(string key)
        {
            var service = GetRebaserService();
            var result = service.GetCommand(key, commitLine.Object);
            Assert.That(result, Is.TypeOf<ToggleCommand>());
        }

        private RebaserService GetRebaserService()
        {
            return new RebaserService(new List<string>(), commitLineBuilderFactory.Object);
        }
    }
}