using QuickRebaser.Specifications;

namespace QuickRebaser
{
    public abstract class CommitLineBuilderBase : ICommitLineBuilder
    {
        protected abstract ISpecification<string> Specification { get; }

        //protected CommitLine BuildIgnoringPrefix(string line)
        //{
        //}

        public abstract CommitLine Build(string line);

        public bool IsQualified(string line)
        {
            return Specification.IsSatisfiedBy(line);
        }
    }
}
