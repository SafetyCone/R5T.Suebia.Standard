using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Alamania.Standard;
using R5T.Dacia;
using R5T.Lombardy.Standard;

using R5T.Suebia.Alamania;


namespace R5T.Suebia.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ISecretsDirectoryPathProvider"/> service.
        /// </summary>
        public static IServiceCollection AddSecretsDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddAlamaniaSecretsDirectoryPathProvider(
                services.AddRivetOrganizationDirectoryPathProviderAction(),
                services.AddStringlyTypedPathOperatorAction());

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ISecretsDirectoryPathProvider"/> service.
        /// </summary>
        public static ServiceAction<ISecretsDirectoryPathProvider> AddSecretsDirectoryPathProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ISecretsDirectoryPathProvider>(() => services.AddSecretsDirectoryPathProvider());
            return serviceAction;
        }
    }
}
