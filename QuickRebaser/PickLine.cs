namespace QuickRebaser
{
    public class PickLine : CommitLine
    {
        public PickLine(string line) : base(line, LineType.Pick)
        {
        }

        public override bool IsActionable()
        {
            return true;
        }
    }
}