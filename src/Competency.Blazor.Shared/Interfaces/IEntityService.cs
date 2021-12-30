using Ardalis.Specification;
using Competency.Core.CompetencyAggregate;
using Competency.Core.CompetencyAggregate.Entities;
using Competency.Core.CompetencyAggregate.Specifications;
using Competency.SharedKernel;

namespace Competency.Blazor.Shared.Interfaces;

public interface IEntityService<T> where T : BaseEntity
{
  Task<PagedList<Project>> GetList();
  Task<PagedList<T>> GetList(CompetencyParameters parameters);
  Task<T> Get(int id);
  Task<T> Get(Specification<T> spec);
  Task<T> Add(T entity);
  Task<T> Update(T entity);
  Task DeleteEmployee(int id);
}
