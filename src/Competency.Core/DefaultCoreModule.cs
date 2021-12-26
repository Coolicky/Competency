using Autofac;

namespace Competency.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    // builder.RegisterType<T>()
    //     .As<iT>().InstancePerLifetimeScope();
  }
}
