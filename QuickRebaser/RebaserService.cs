using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace QuickRebaser
{
    public class RebaserService : IRebaserService
    {
        private readonly CommitFile commitFile;
        private readonly ICommitLineBuilderFactory commitLineBuilderFactory;
        private readonly string[] toggleKeys = new[] {"F", "S", "R", "P", "E"};

        public RebaserService(IList<string> lines, ICommitLineBuilderFactory commitLineBuilderFactory)
        {
            this.commitLineBuilderFactory = commitLineBuilderFactory;

            commitFile = new CommitFile(lines, this.commitLineBuilderFactory);
        }

        public Func<string, CommitLine> BuildLine()
        {
            return line =>
            {
                var builder = commitLineBuilderFactory.GetBuilder(line);
                if (builder == null)
                    return null;

                return builder.Build(line);
            };
        }

        public IEnumerable<CommitLine> GetActionableFiles()
        {
            return commitFile.GetCommits().Where(x => x.IsActionable());
        }

        public void IssueCommand(ICommand command)
        {
            command.Execute(commitFile, command.CommitLine);
        }

        public ICommand GetCommand(string key, CommitLine commitLine)
        {
            if (key == null)
                return null;

            if (toggleKeys.Contains(key.ToUpper()))
            {
                var line = BuildLine()(commitLine.Line);
                return new ToggleCommand(key, line);
            }

            return null;
        }

        public void Save(string fileName)
        {
            var contents = commitFile.GetCommits().Select(x => x.Line);
            File.WriteAllLines(fileName, contents);
        }
    }
}