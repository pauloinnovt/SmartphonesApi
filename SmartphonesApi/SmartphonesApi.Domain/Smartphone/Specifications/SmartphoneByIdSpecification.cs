using Innovt.Domain.Core.Specification;
using System.Linq.Expressions;

namespace SmartphonesApi.Domain.Smartphone.Specifications
{
    public class SmartphoneByIdSpecification(Guid id) : Specification<Smartphone>
    {
        public Guid Id { get; set; } = id;

        public override Expression<Func<Smartphone, bool>> SatisfiedBy()
        {
            return s => s.Id == Id;
        }
    }
}
