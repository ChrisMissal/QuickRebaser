using System.Collections;
using System.IO;
using System.Linq;

namespace QuickRebaser.App
{
    public class MainWindowPresenter
    {
        private readonly string fileName;
        private readonly IMainWindow mainWindow;
        private readonly IRebaserService rebaserService;

        public MainWindowPresenter(string fileName, IMainWindow mainWindow)
        {
            this.fileName = fileName;
            this.mainWindow = mainWindow;
            var lines = File.ReadAllLines(fileName).ToList();

            var commitLineBuilderFactory = new CommitLineBuilderFactory(
                new CommentLineBuilder(),
                new NoOpLineBuilder(),
                new FixupLineBuilder(),
                new PickLineBuilder(),
                new RewordLineBuilder(),
                new SquashLineBuilder(),
                new EditLineBuilder()
                );
            rebaserService = new RebaserService(lines, commitLineBuilderFactory);

            mainWindow.LinesContainer.Refresh();
        }

        public void IssueKeyCommand(string key, CommitLine line)
        {
            var command = rebaserService.GetCommand(key, line);
            if (command == null)
                return;

            rebaserService.IssueCommand(command);
            mainWindow.Refresh();
        }

        public IEnumerable GetContent()
        {
            return rebaserService.GetActionableFiles().Select(x => new CommitLineItem(x)).ToArray();
        }

        public void Close()
        {
            rebaserService.Save(fileName);
        }
    }
}