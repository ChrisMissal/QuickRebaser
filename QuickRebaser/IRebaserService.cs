using System;
using System.Collections.Generic;

namespace QuickRebaser
{
    public interface IRebaserService
    {
        Func<string, CommitLine> BuildLine();

        IEnumerable<CommitLine> GetActionableFiles();

        void IssueCommand(ICommand command);

        ICommand GetCommand(string key, CommitLine commitLine);

        void Save(string fileName);
    }
}