using CompositeSpecification.Composit;

namespace CompositeSpecification.Leafs
{
    internal class EvenNumbers : CompositSpecification<long>
    {
        public CompositSpecification<long> And(CompositSpecification<long> left) =>
            new AndSpecification<long>(this, left);

        

        public override bool IsSatisfied(long entity)
        {
            return entity % 2 == 0;
        }

    }

    internal class ZeroNumber : CompositSpecification<long>
    {
        public override bool IsSatisfied(long entity)
        {
            return entity == 0;
        }
    }

    internal class PositiveNumber : CompositSpecification<long>
    {
        public override bool IsSatisfied(long entity)
        {
            return entity > 0;
        }
    }
}
