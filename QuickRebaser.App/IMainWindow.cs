namespace QuickRebaser.App
{
    public interface IMainWindow
    {
        void Refresh();

        ILinesContainer LinesContainer { get; }
    }
}