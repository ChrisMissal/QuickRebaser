using System;
using System.Collections;
using System.Windows.Input;

namespace QuickRebaser.App
{
    public partial class MainWindow : IMainWindow
    {
        private readonly MainWindowPresenter presenter;
        private const string fileName = "./test-file.txt";

        public MainWindow()
        {
            InitializeComponent();

            presenter = new MainWindowPresenter(fileName, this);
            Refresh();
        }

        /*private void commitLinesListBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            var key = e.Key.ToString();
            var listBox = sender as ListBox;
            var line = listBox.SelectedItem as CommitLine;
            var selectedLine = listBox.SelectedIndex;

            presenter.IssueKeyCommand(key, line);
            listBox.SelectedIndex = selectedLine;
        }*/

        public void Refresh()
        {
            LinesContainer.UpdateItems(presenter.GetContent());
        }

        public ILinesContainer LinesContainer
        {
            get { return linesContainer; }
        }

        public IEnumerable Lines
        {
            get { return presenter.GetContent(); }
        }

        private void QuickRebaser_Closed(object sender, EventArgs e)
        {
            presenter.Close();
        }

        private void QuickRebaser_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Escape:
                    Close();
                    break;
                case Key.Up:
                    LinesContainer.MoveSelectionUp();
                    break;
                case Key.Down:
                    LinesContainer.MoveSelectionDown();
                    break;
                default:
                    return;
            }
        }

        protected bool MoveRequested
        {
            get
            {
                return Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);
            }
        }
    }
}
