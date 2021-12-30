using Ardalis.Specification;
using Competency.Core.CompetencyAggregate.Entities;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class CertificateByIdWithEmployees : Specification<Certificate>, ISingleResultSpecification
{
  public CertificateByIdWithEmployees(int id)
  {
    Query
      .Where(r => r.Id == id)
      .Include(r => r.Employees);
  }
}
