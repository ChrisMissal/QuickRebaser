namespace QuickRebaser
{
    public interface ICommand
    {
        void Execute(CommitFile commitFile, CommitLine commitLine);

        CommitLine CommitLine { get; }
    }
}