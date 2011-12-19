namespace QuickRebaser
{
    public abstract class CommitLine
    {
        protected string line;
        protected LineType lineType;

        protected CommitLine(string line, LineType lineType)
        {
            this.lineType = lineType;
            this.line = line.Substring(line.IndexOf(" ") + 1); ;
        }

        protected LineType LineType
        {
            get { return lineType; }
        }

        public virtual string Line
        {
            get
            {
                return IsActionable() ? string.Format("{0} {1}", LineType.ToString().ToLower(), line) : line;
            }
        }

        public override string ToString()
        {
            return Line;
        }

        public abstract bool IsActionable();

        public void SetType(LineType lineType)
        {
            this.lineType = lineType;
        }
    }
}