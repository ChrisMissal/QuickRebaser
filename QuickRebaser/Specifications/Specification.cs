namespace QuickRebaser.Specifications
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T candidate);
        ISpecification<T> And(ISpecification<T> other);
        ISpecification<T> Or(ISpecification<T> other);
        ISpecification<T> Not();
    }

    public abstract class Specification<T> : ISpecification<T>
    {
        public abstract bool IsSatisfiedBy(T candidate);

        public ISpecification<T> And(ISpecification<T> specification)
        {
            return new AndSpecification(this, specification);
        }

        public ISpecification<T> Or(ISpecification<T> specification)
        {
            return new OrSpecification(this, specification);
        }

        public ISpecification<T> Not()
        {
            return new NotSpecification(this);
        }

        internal abstract class CompositeSpecification : Specification<T>
        {
            protected readonly ISpecification<T> Left;
            protected readonly ISpecification<T> Right;

            protected CompositeSpecification(ISpecification<T> left, ISpecification<T> right)
            {
                Left = left;
                Right = right;
            }
        }

        internal class AndSpecification : CompositeSpecification
        {
            internal AndSpecification(ISpecification<T> left, ISpecification<T> right)
                : base(left, right)
            {
            }

            public override bool IsSatisfiedBy(T candidate)
            {
                return Left.IsSatisfiedBy(candidate) && Right.IsSatisfiedBy(candidate);
            }
        }

        internal class OrSpecification : CompositeSpecification
        {
            internal OrSpecification(ISpecification<T> left, ISpecification<T> right)
                : base(left, right)
            {
            }

            public override bool IsSatisfiedBy(T candidate)
            {
                return Left.IsSatisfiedBy(candidate) || Right.IsSatisfiedBy(candidate);
            }
        }

        internal class NotSpecification : Specification<T>
        {
            private readonly Specification<T> specification;

            internal NotSpecification(Specification<T> specification)
            {
                this.specification = specification;
            }

            public override bool IsSatisfiedBy(T candidate)
            {
                return !specification.IsSatisfiedBy(candidate);
            }
        }
    }
}