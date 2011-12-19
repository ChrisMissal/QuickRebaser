namespace QuickRebaser.App
{
    public class CommitLineItem
    {
        private readonly CommitLine commitLine;

        public CommitLineItem(CommitLine commitLine)
        {
            this.commitLine = commitLine;
        }

        public string Text
        {
            get { return commitLine.Line; }
        }

        public bool IsSelected { get; set; }
    }
}