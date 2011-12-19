namespace QuickRebaser
{
    public interface ICommitLineBuilderFactory
    {
        ICommitLineBuilder GetBuilder(string line);
    }
}