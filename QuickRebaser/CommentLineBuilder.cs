using QuickRebaser.Specifications;

namespace QuickRebaser
{
    public class CommentLineBuilder : CommitLineBuilderBase
    {
        private readonly ISpecification<string> commentLineSpecification = new CommentLineSpecification();

        protected override ISpecification<string> Specification
        {
            get { return commentLineSpecification; }
        }

        public override CommitLine Build(string line)
        {
            return new CommentLine(line);
        }
    }
}