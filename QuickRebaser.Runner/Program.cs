using System;
using System.IO;
using System.Linq;

namespace QuickRebaser.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var commitLineBuilderFactory = new CommitLineBuilderFactory(
                new CommentLineBuilder(),
                new NoOpLineBuilder(),
                new FixupLineBuilder(),
                new PickLineBuilder(),
                new RewordLineBuilder(),
                new SquashLineBuilder(),
                new EditLineBuilder()
                );
            var lines = File.ReadAllLines(args[0]);
            var file = new CommitFile(lines, commitLineBuilderFactory);

            var commits = file.GetCommits();

            commits.Select(x => x.Line).ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
