using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSpecification.Composit
{
    internal interface ISpecifacation<T>
    {
        bool IsSatisfied(T entity);
    }

    internal abstract class CompositSpecification<T> : ISpecifacation<T>
    {
        public abstract bool IsSatisfied(T entity);
    }
    internal class AndSpecification<T> : CompositSpecification<T>
    {
        private readonly CompositSpecification<T> _right;
        private readonly CompositSpecification<T> _left;

        public AndSpecification(CompositSpecification<T> right, CompositSpecification<T> left)
        {
            _right = right;
            _left = left;
        }
        public override bool IsSatisfied(T entity)
        {
            return _right.IsSatisfied(entity) &&
                _left.IsSatisfied(entity);
        }
    }

    internal class OrSpecification<T> : CompositSpecification<T>
    {
        private readonly CompositSpecification<T> _right;
        private readonly CompositSpecification<T> _left;

        public OrSpecification(CompositSpecification<T> right, CompositSpecification<T> left)
        {
            _right = right;
            _left = left;
        }
        public override bool IsSatisfied(T entity)
        {
            return _right.IsSatisfied(entity) ||
                _left.IsSatisfied(entity);
        }
    }

}
