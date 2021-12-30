using Autofac;
using Competency.Infrastructure.Data;
using Competency.SharedKernel.Interfaces;
using Module = Autofac.Module;

namespace Competency.Infrastructure;

public class DefaultInfrastructureModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterGeneric(typeof(EfRepository<>))
      .As(typeof(IRepository<>))
      .As(typeof(IReadRepository<>))
      .InstancePerLifetimeScope();
  }
}
