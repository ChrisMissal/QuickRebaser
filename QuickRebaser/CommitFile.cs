using System;
using System.Collections.Generic;

namespace QuickRebaser
{
    public class CommitFile
    {
        private readonly ICommitLineBuilderFactory commitLineBuilderFactory;
        private readonly IList<string> lines;

        public CommitFile(IList<string> lines, ICommitLineBuilderFactory commitLineBuilderFactory)
        {
            this.lines = lines;
            this.commitLineBuilderFactory = commitLineBuilderFactory;
        }

        public IEnumerable<CommitLine> GetCommits()
        {
            foreach (var line in lines)
            {
                var builder = commitLineBuilderFactory.GetBuilder(line);
                if (builder == null)
                    throw new InvalidOperationException("Unable to build up a CommitLine for [{0}]".FormatWith(line));

                yield return builder.Build(line);
            }
        }

        public void Replace(CommitLine old, CommitLine @new)
        {
            var index = lines.IndexOf(old.Line);
            lines.RemoveAt(index);
            lines.Insert(index, @new.Line);
        }
    }
}
