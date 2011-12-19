namespace QuickRebaser
{
    public class EditLine : CommitLine
    {
        public EditLine(string line) : base(line, LineType.Edit)
        {
        }

        public override bool IsActionable()
        {
            return true;
        }
    }
}