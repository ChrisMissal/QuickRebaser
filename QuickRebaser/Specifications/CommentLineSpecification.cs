using System;

namespace QuickRebaser.Specifications
{
    public class FixupLineSpecification : Specification<string>
    {
        public override bool IsSatisfiedBy(string candidate)
        {
            return !candidate.IsNullOrEmpty() && candidate.ToUpper().StartsWith("F");
        }
    }

    public class NoOpLineSpecification : Specification<string>
    {
        public override bool IsSatisfiedBy(string candidate)
        {
            return candidate.IsNullOrEmpty() || candidate.Equals("noop", StringComparison.OrdinalIgnoreCase);
        }
    }

    public class CommentLineSpecification : Specification<string>
    {
        public override bool IsSatisfiedBy(string candidate)
        {
            return !candidate.IsNullOrEmpty() && candidate.StartsWith("#");
        }
    }

    public class RewordLineSpecification : Specification<string>
    {
        public override bool IsSatisfiedBy(string candidate)
        {
            return !candidate.IsNullOrEmpty() && candidate.ToUpper().StartsWith("R");
        }
    }

    public class PickLineSpecification : Specification<string>
    {
        public override bool IsSatisfiedBy(string candidate)
        {
            return !candidate.IsNullOrEmpty() && candidate.ToUpper().StartsWith("P");
        }
    }

    public class EditLineSpecification : Specification<string>
    {
        public override bool IsSatisfiedBy(string candidate)
        {
            return !candidate.IsNullOrEmpty() && candidate.ToUpper().StartsWith("E");
        }
    }

    public class SquashLineSpecification : Specification<string>
    {
        public override bool IsSatisfiedBy(string candidate)
        {
            return !candidate.IsNullOrEmpty() && candidate.ToUpper().StartsWith("S");
        }
    }
}