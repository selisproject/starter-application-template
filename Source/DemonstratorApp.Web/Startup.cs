// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using Autofac;
using Autofac.Extras.CommonServiceLocator;
using Autofac.Integration.WebApi;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Optimization;
using WebApi.OutputCache.V2;
using AppCode;
using Identity = zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Identity.Model;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Auditing;
using zAppDev.DotNet.Framework.Tools.PerformanceMeasurements;
using zAppDev.DotNet.Framework.Tools.PerformanceMeasurements.Configuration;
using ClaimTypes = zAppDev.DotNet.Framework.Identity.Model.ClaimTypes;
using DemonstratorApp.DAL;
using DemonstratorApp.Security.Owin;
using DemonstratorApp.Web.Code;
using zAppDev.DotNet.Framework.Services;
using IdentityServer3.AccessTokenValidation;
using Microsoft.Owin.Security.Google;
using CacheManager.Core;

using zAppDev.DotNet.Framework.Logging;
using CacheManager.Core;
using CommonServiceLocator;

namespace DemonstratorApp.Web
{
    public class Startup
    {
        public void ConfigureServices(IAppBuilder app, System.Web.Http.HttpConfiguration config)
        {
            var cacheConfig = CacheManager.Core.ConfigurationBuilder.LoadConfiguration("ServicesCache");
            var builder = new ContainerBuilder();
            builder
            .RegisterInstance(RabbitMQMessagingLogger.FromConfiguration())
            .SingleInstance();
            builder
            .RegisterInstance(CacheFactory.FromConfiguration<object>(cacheConfig))
            .SingleInstance();
            builder
            .RegisterInstance(CacheFactory.FromConfiguration<object>(CacheManager.Core.ConfigurationBuilder.LoadConfiguration("AppCache")))
            .Named<ICacheManager<object>>("AppCache")
            .SingleInstance();
            builder
            .RegisterInstance(CacheFactory.FromConfiguration<object>(CacheManager.Core.ConfigurationBuilder.LoadConfiguration("SessionStateStorage")))
            .Named<ICacheManager<object>>("SessionStateStorage")
            .SingleInstance();
            builder
            .Register(c => new DemonstratorApp.Hubs.EventsHub())
            .As<zAppDev.DotNet.Framework.Hubs.IApplicationHub>().SingleInstance();
            var repoBuilder = new RepositoryBuilder();
            builder
            .Register(c => repoBuilder)
            .As<zAppDev.DotNet.Framework.Data.DAL.IRepositoryBuilder>().SingleInstance();
            builder
            .Register(c => new zAppDev.DotNet.Framework.Workflow.WorkflowManager(repoBuilder))
            .As<zAppDev.DotNet.Framework.Workflow.WorkflowManager>().SingleInstance();
            builder
            .Register(c =>
            {
                var scheduleManager = new zAppDev.DotNet.Framework.Workflow.ScheduleManager(repoBuilder);
                return scheduleManager;
            })
            .As<zAppDev.DotNet.Framework.Workflow.ScheduleManager>().SingleInstance();
            builder
            .Register(c => new NHAuditTrailManager())
            .As<INHAuditTrailManager>().SingleInstance();
            builder
            .Register(c =>
            {
                return new Security.Encryption.EncryptionManager();
            })
            .As<zAppDev.DotNet.Framework.Data.Encryption.Manager.EncryptionManagerBase>()
            .SingleInstance();
            builder
            .Register(c =>
            {
                PerformanceMonitorConfiguration monitorConfiguration = null;
                return monitorConfiguration;
            })
            .SingleInstance();
            var container = builder.Build();
            var csl = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => csl);
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        public void Configuration(IAppBuilder app)
        {
            var config = System.Web.Http.GlobalConfiguration.Configuration;
            config.Formatters.JsonFormatter.SerializerSettings.NullValueHandling =
                Newtonsoft.Json.NullValueHandling.Ignore;
            config.CacheOutputConfiguration().RegisterCacheOutputProvider(() => new CustomCacheProvider());
            config.CacheOutputConfiguration().RegisterDefaultCacheKeyGeneratorProvider(() => new CustomCacheKeyGenerator());
            ConfigureServices(app, config);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            System.Web.Http.GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.NullValueHandling =
                Newtonsoft.Json.NullValueHandling.Ignore;
            app.CreatePerOwinContext(MiniSessionManager.Create);
            app.CreatePerOwinContext<UserManager>(UserManager.Create);
            app.CreatePerOwinContext(() =>
            {
                var signInManager = new SignInManager<IdentityUser, string>(
                    HttpContext.Current.GetOwinContext().GetUserManager<UserManager>(),
                    HttpContext.Current.GetOwinContext().Authentication
                );
                return signInManager;
            });
            System.Web.Http.GlobalConfiguration.Configure(ThrottleConfig.Register);
            System.Web.Http.GlobalConfiguration.Configure(APIRegistryConfig.Register);
            int cookieValidationIntervalInSeconds = 1;
            try
            {
                cookieValidationIntervalInSeconds = int.Parse(ConfigurationManager.AppSettings["AuthenticationCookieValidationIntervalInSeconds"]);
            }
            catch (Exception e)
            {
                log4net.LogManager.GetLogger("CookieValidationInterval").Error("Could not parse Cookie Validation Interval Setting! Using default...", e);
            }
            // Retrieve Session Storage cache settings, to sync with authentication cookie
            var authenticationCookineExpirationTimeout = TimeSpan.FromMinutes(20);
            //var authenticationCookineSlidingExpiration = true;
            try
            {
                var cacheConfig = CacheFactory.FromConfiguration<object>(CacheManager.Core.ConfigurationBuilder.LoadConfiguration("SessionStateStorage"));
                var sessionCacheHandle = cacheConfig.CacheHandles.FirstOrDefault();
                authenticationCookineExpirationTimeout = sessionCacheHandle.Configuration.ExpirationTimeout;
                //authenticationCookineSlidingExpiration = sessionCacheHandle.Configuration.ExpirationMode == ExpirationMode.Sliding;
            }
            catch (Exception e)
            {
                log4net.LogManager.GetLogger("SessionStateStorage").Error("Could not retrieve cache configuration for Session Storage!", e);
            }
            log4net.LogManager.GetLogger("AuthenticationCookie").Info($"Authentication Cookie Timeout: {authenticationCookineExpirationTimeout.Minutes} minute(s)");
            //log4net.LogManager.GetLogger("AuthenticationCookie").Info($"Authentication Cookie Sliding Expiration Enabled: {authenticationCookineSlidingExpiration}");
            app.UseCookieAuthentication(
                new CookieAuthenticationOptions
            {
                CookieName = ConfigurationManager.AppSettings["AuthenticationCookieName"],
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                ExpireTimeSpan = authenticationCookineExpirationTimeout,
                //SlidingExpiration = authenticationCookineSlidingExpiration,  // Sliding expiration is always what happens despite this setting

                LoginPath = new PathString("/SignInPage/Load"),

                ReturnUrlParameter = "returnUrl",

                Provider = new CookieAuthenticationProvider
                {
                    OnApplyRedirect = context =>
                    {
                        log4net.LogManager.GetLogger("CookieAuthenticationProvider").Error("REDIRECTING!!!");
                    },
                    OnValidateIdentity = ApplicationCookieIdentityValidator.OnValidateIdentity(validateInterval: TimeSpan.FromSeconds(cookieValidationIntervalInSeconds)),
                    OnException = context => log4net.LogManager.GetLogger("IdentityLogger").DebugFormat("CookieAuthenticationProvider Error for req: {0}", context.Request.Path)
                },
            });
            app.UseBasicAuthentication(new BasicAuthenticationOptions("", (id, secret) =>
            {
                try
                {
                    if (!IdentityHelper.ValidateUser(id, secret)) return Task.FromResult<IEnumerable<Claim>>(null);
                    var user = IdentityHelper.GetUserManager().FindByName(id);
                    if (user == null) return Task.FromResult<IEnumerable<Claim>>(new List<Claim>());
                    var claims = user.User.Permissions.Select(p => new Claim(ClaimTypes.Permission, p.Name)).ToList();
                    claims.Add(new Claim(System.Security.Claims.ClaimTypes.Name, user.UserName));
                    if (!string.IsNullOrWhiteSpace(user.User.Email))
                    {
                        claims.Add(new Claim(System.Security.Claims.ClaimTypes.Email, user.User.Email));
                    }
                    var userRoles = user.User.Roles.Select(r => new Claim(System.Security.Claims.ClaimTypes.Role, r.Name));
                    claims.AddRange(userRoles);
                    return Task.FromResult<IEnumerable<Claim>>(claims);
                }
                catch (Exception e)
                {
                    log4net.LogManager.GetLogger("BasicAuthentication.CredentialValidationFunction").Error("Error validating identity!", e);
                    return Task.FromResult<IEnumerable<Claim>>(null);
                }
            }));
            if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["idsrv:authority"]))
            {
                var options = new IdentityServerBearerTokenAuthenticationOptions
                {
                    Authority = ConfigurationManager.AppSettings["idsrv:authority"]
                };
                if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["idsrv:scopes"]))
                {
                    options.RequiredScopes = ConfigurationManager.AppSettings["idsrv:scopes"].Split(' ');
                }
                if (!string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["idsrv:clientid"]) &&
                        !string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["idsrv:clientsecret"]))
                {
                    options.ClientId = ConfigurationManager.AppSettings["idsrv:clientid"];
                    options.ClientSecret = ConfigurationManager.AppSettings["idsrv:clientsecret"];
                }
                app.UseIdentityServerBearerTokenAuthentication(options);
            }
            else
            {
                // Configure the application for OAuth based flow
                var PublicClientId = "self";
                var OAuthOptions = new OAuthAuthorizationServerOptions
                {
                    TokenEndpointPath = new PathString("/OAuth/Token"),
                    Provider = new zAppDev.DotNet.Framework.Identity.AppOAuthProvider(PublicClientId),
                    AuthorizeEndpointPath = new PathString("/OAuth/Account/ExternalLogin"),
                    AccessTokenExpireTimeSpan = TimeSpan.FromHours(4),
                    AllowInsecureHttp = true // Don't do this in production ONLY FOR DEVELOPING: ALLOW INSECURE HTTP!
                };
                // Enable the application to use bearer tokens to authenticate users
                app.UseOAuthBearerTokens(OAuthOptions);
            }
            Microsoft.AspNet.SignalR.GlobalHost.DependencyResolver.Register(typeof(Newtonsoft.Json.JsonSerializer), () =>
            {
                return Newtonsoft.Json.JsonSerializer.Create(new Newtonsoft.Json.JsonSerializerSettings
                {
                    NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore,
                    ContractResolver = new zAppDev.DotNet.Framework.Utilities.NHibernateContractResolver()
                });
            });
            app.MapSignalR();
            zAppDev.DotNet.Framework.Identity.IdentityHelper.AllowMultipleSessionsPerUser = true;
            zAppDev.DotNet.Framework.Identity.IdentityHelper.AdminCanResetPassword = false;
            DemonstratorApp.DatabaseSeeder databaseSeeder = new DemonstratorApp.DatabaseSeeder();
            databaseSeeder.UpdateAuthorizationTables();
            ConfigeAuditTrailManager();
            ServiceLocator.Current.GetInstance<zAppDev.DotNet.Framework.Workflow.ScheduleManager>();
            ServiceLocator.Current.GetInstance<zAppDev.DotNet.Framework.Workflow.WorkflowManager>()
            .Init(typeof(DemonstratorApp.DAL.Repository).Assembly);
            DemonstratorApp.Hubs.EventsHub.RaiseApplicationStart();
            zAppDev.DotNet.Framework.Mvc.FileHelper.ClearTempData();
        }

        private void ConfigeAuditTrailManager()
        {
            bool.TryParse(ConfigurationManager.AppSettings["audittrail:enabled"], out var enabled);
            if (!enabled)
            {
                log4net.LogManager
                .GetLogger(typeof(Startup))
                .Info("Audit Trail is not enabled. Skipping initialization. If you with to enable it, please add 'audittrail:enabled' in the application settings of web.config.");
                return;
            }
            var manager = ServiceLocator.Current.GetInstance<INHAuditTrailManager>();
            var type = typeof(Repository);
            var auditableTypes = type.Assembly
                                 .GetTypes()
                                 .Where(t => t.GetInterfaces().Contains(typeof(zAppDev.DotNet.Framework.Data.Domain.IDomainModelClass)))
                                 .ToList();
            auditableTypes.AddRange(zAppDev.DotNet.Framework.Utilities.TypeRegistryHelper.GetAuditableSystemDomainModelTypes());
            manager.Enable(auditableTypes, () => new AuditContext
            {
                Username = HttpContext.Current?.User?.Identity?.Name
            });
        }
    }
}