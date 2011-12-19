using QuickRebaser.Specifications;

namespace QuickRebaser
{
    public class PickLineBuilder : CommitLineBuilderBase
    {
        private readonly ISpecification<string> pickLineSpecification = new PickLineSpecification();

        protected override ISpecification<string> Specification
        {
            get { return pickLineSpecification; }
        }

        public override CommitLine Build(string line)
        {
            return new PickLine(line);
        }
    }
}