using QuickRebaser.Specifications;

namespace QuickRebaser
{
    public class RewordLineBuilder : CommitLineBuilderBase
    {
        private readonly ISpecification<string> rewordLineSpecification = new RewordLineSpecification();

        protected override ISpecification<string> Specification
        {
            get { return rewordLineSpecification; }
        }

        public override CommitLine Build(string line)
        {
            return new RewordLine(line);
        }
    }
}