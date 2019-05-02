using System;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using Glass.Mapper.Sc.Web.Mvc;
using Glass.Mapper.Sc.Web.WebForms;
using Microsoft.Extensions.DependencyInjection;
using Sitecore;
using Sitecore.Data;
using Sitecore.DependencyInjection;

namespace SF.Foundation.SXAGlass.Configuration
{

    /// <summary>
    /// This adds Each of the Glass Classes to Sitecore's DI Container.
    /// </summary>
    public class GlassMapperConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ISitecoreService>(sp => new SitecoreService(Context.Database));
            serviceCollection.AddScoped<IMvcContext>(sp => new MvcContext(sp.GetService<ISitecoreService>()));
            serviceCollection.AddScoped<IRequestContext>(sp => new RequestContext(sp.GetService<ISitecoreService>()));
            serviceCollection.AddScoped<IWebFormsContext>(sp => new WebFormsContext(sp.GetService<ISitecoreService>()));
        }
    }
}