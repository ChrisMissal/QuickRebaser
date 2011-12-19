using System.Linq;

namespace QuickRebaser
{
    public class ToggleCommand : ICommand
    {
        private readonly string key;
        private readonly CommitLine newCommitLine;

        public ToggleCommand(string key, CommitLine newCommitLine)
        {
            this.key = key;
            this.newCommitLine = newCommitLine;
        }

        public void Execute(CommitFile commitFile, CommitLine commitLine)
        {
            var newLine = commitFile.GetCommits()
                .FirstOrDefault(x => x.Line == commitLine.Line);
            newLine.SetType(key.ToLineType());
            commitFile.Replace(commitLine, newLine);
        }

        public CommitLine CommitLine
        {
            get { return newCommitLine; }
        }
    }
}