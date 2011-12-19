using QuickRebaser.Specifications;

namespace QuickRebaser
{
    public class NoOpLineBuilder : CommitLineBuilderBase
    {
        private readonly ISpecification<string> noOpLineSpecification = new NoOpLineSpecification();

        protected override ISpecification<string> Specification { get { return noOpLineSpecification; } }

        public override CommitLine Build(string line)
        {
            return new NoOpLine(line);
        }
    }
}