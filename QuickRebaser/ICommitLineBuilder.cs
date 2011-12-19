namespace QuickRebaser
{
    public interface ICommitLineBuilder
    {
        CommitLine Build(string line);
        bool IsQualified(string line);
    }
}
