using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Alias.Models;
using OrchardCore.Apis;
using OrchardCore.ContentManagement;
using OrchardCore.Modules;

namespace OrchardCore.Alias.GraphQL
{
    [RequireFeatures("OrchardCore.Apis.GraphQL")]
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddObjectGraphType<AliasPart, AliasQueryObjectType>();
            services.AddInputObjectGraphType<AliasPart, AliasInputObjectType>();
            services.AddGraphQLFilterType<ContentItem, AliasGraphQLFilter>();
        }
    }
}