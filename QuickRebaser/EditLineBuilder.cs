using QuickRebaser.Specifications;

namespace QuickRebaser
{
    public class EditLineBuilder : CommitLineBuilderBase
    {
        private readonly ISpecification<string> editLineSpecification = new EditLineSpecification();

        protected override ISpecification<string> Specification
        {
            get { return editLineSpecification; }
        }

        public override CommitLine Build(string line)
        {
            return new EditLine(line);
        }
    }
}