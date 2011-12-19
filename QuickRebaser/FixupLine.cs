namespace QuickRebaser
{
    public class FixupLine : CommitLine
    {
        public FixupLine(string line) : base(line, LineType.Fixup)
        {
        }

        public override bool IsActionable()
        {
            return true;
        }
    }
}