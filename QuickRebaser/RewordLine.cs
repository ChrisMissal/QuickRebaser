namespace QuickRebaser
{
    public class RewordLine : CommitLine
    {
        public RewordLine(string line) : base(line, LineType.Reword)
        {
        }

        public override bool IsActionable()
        {
            return true;
        }
    }
}