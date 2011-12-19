using QuickRebaser.Specifications;

namespace QuickRebaser
{
    public class SquashLineBuilder : CommitLineBuilderBase
    {
        private readonly ISpecification<string> squashLineSpecification = new SquashLineSpecification();

        protected override ISpecification<string> Specification
        {
            get { return squashLineSpecification; }
        }

        public override CommitLine Build(string line)
        {
            return new SquashLine(line);
        }
    }
}