namespace QuickRebaser
{
    public class SquashLine : CommitLine
    {
        public SquashLine(string line) : base(line, LineType.Squash)
        {
        }

        public override bool IsActionable()
        {
            return true;
        }
    }
}