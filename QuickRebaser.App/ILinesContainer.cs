using System.Collections;

namespace QuickRebaser.App
{
    public interface ILinesContainer
    {
        void UpdateItems(IEnumerable content);
        void MoveSelectionUp();
        void MoveSelectionDown();
        void Refresh();
        object SelectedItem { get; }
        void UpdateLayout();
    }
}