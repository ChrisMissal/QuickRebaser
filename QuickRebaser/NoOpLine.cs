namespace QuickRebaser
{
    public class NoOpLine : CommitLine
    {
        public NoOpLine(string line) : base(line, LineType.NoOp)
        {
        }

        public override bool IsActionable()
        {
            return false;
        }
    }
}