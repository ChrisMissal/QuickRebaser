using QuickRebaser.Specifications;

namespace QuickRebaser
{
    public class FixupLineBuilder : CommitLineBuilderBase
    {
        private readonly ISpecification<string> fixupLineSpecification = new FixupLineSpecification();

        protected override ISpecification<string> Specification
        {
            get { return fixupLineSpecification; }
        }

        public override CommitLine Build(string line)
        {
            return new FixupLine(line);
        }
    }
}