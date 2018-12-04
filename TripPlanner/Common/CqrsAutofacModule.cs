using Autofac;
using Cqrs.Service;
using Cqrs.Service.CommandContracts;
using Cqrs.Service.CommandHandlers;
using Cqrs.Service.QueryContracts;
using Cqrs.Service.QueryHandlers;
using Persistency.Implementations;
using Repositories.Implementations;
using static System.Reflection.IntrospectionExtensions;

namespace Common
{
    /// <summary>
    /// AutofacModule for CqrsStructure project.
    /// </summary>
    /// <seealso cref="Autofac.Module" />
    public class CqrsAutofacModule : Module
    {
        /// <summary>
        /// Override to add registrations to the container.
        /// </summary>
        /// <param name="builder">The builder through which components can be
        /// registered.</param>
        /// <remarks>
        /// Note that the ContainerBuilder parameter is unique to this module.
        /// </remarks>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<PersistencyImplementationsAutofacModule>();
            builder.RegisterModule<RepositoryImplementationsAutofacModule>();

            builder.RegisterType<CommandDispatcher>()
                .As<ICommandDispatcher>();

            builder.RegisterType<QueryDispatcher>()
                .As<IQueryDispatcher>();

            builder.RegisterAssemblyTypes(typeof(BusinessLayer).GetTypeInfo().Assembly)
                .Where(t => t.Name.EndsWith("QueryResult")).AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(typeof(BusinessLayer).GetTypeInfo().Assembly)
                .Where(t => t.Name.EndsWith("Command")).AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(typeof(BusinessLayer).GetTypeInfo().Assembly)
                .Where(t => t.Name.EndsWith("Query")).AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(typeof(BusinessLayer).GetTypeInfo().Assembly)
                .AsClosedTypesOf(typeof(ICommandHandler<>)).AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(typeof(BusinessLayer).GetTypeInfo().Assembly)
                .AsClosedTypesOf(typeof(IQueryHandler<,>)).AsImplementedInterfaces();

            //builder.RegisterType<UserService>()
            //    .As<IUserService>();

        }
    }
}
