using System;
using System.Collections;
using System.Linq;
using System.Windows.Controls;

namespace QuickRebaser.App
{
    public class LinesContainer : ItemsControl, ILinesContainer
    {
        private int selectedIndex = 0;
        private CommitLineItem item;

        public void UpdateItems(IEnumerable content)
        {
            ItemsSource = content;
            var selectedItem = ItemsSource.Cast<CommitLineItem>().First();
            SetSelectedItem(selectedItem);
        }

        public void MoveSelectionUp()
        {
            selectedIndex = Math.Max(selectedIndex - 1, 0);
            Refresh();
        }

        public void MoveSelectionDown()
        {
            selectedIndex = Math.Min(selectedIndex + 1, Items.Count - 1);
            Refresh();
        }

        public void Refresh()
        {
            if (!HasItems)
                return;

            var selectedItem = ItemsSource.Cast<CommitLineItem>().ElementAt(selectedIndex);
            SetSelectedItem(selectedItem);
        }

        private void SetSelectedItem(CommitLineItem selectedItem)
        {
            item = selectedItem;
            ItemsSource.Cast<CommitLineItem>().ForEach(i => i.IsSelected = (i == selectedItem));
        }

        public object SelectedItem
        {
            get { return item; }
        }
    }
}