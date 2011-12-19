using System.Linq;

namespace QuickRebaser
{
    public class CommitLineBuilderFactory : ICommitLineBuilderFactory
    {
        private readonly ICommitLineBuilder[] builders;

        public CommitLineBuilderFactory(params ICommitLineBuilder[] builders)
        {
            this.builders = builders;
        }

        public ICommitLineBuilder GetBuilder(string line)
        {
            return builders.FirstOrDefault(x => x.IsQualified(line));
        }
    }
}