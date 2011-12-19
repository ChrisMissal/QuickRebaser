namespace QuickRebaser
{
    public class CommentLine : CommitLine
    {
        public CommentLine(string line) : base(line, LineType.Unknown)
        {
        }

        public override string Line
        {
            get
            {
                return (line.Trim() == "#") ? "#" : "# " + line;
            }
        }

        public override bool IsActionable()
        {
            return false;
        }
    }
}
