// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using FluentNHibernate.Testing;
using DemonstratorApp.BO;
using DemonstratorApp.BoTesting.Tests.Common;
using DemonstratorApp.DAL;

namespace DemonstratorApp.BoTesting.Tests
{
    /// <summary>
    ///This is a test class for ApplicationUserTest and is intended
    ///to contain all ApplicationUserTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("ApplicationUser Repository Tests")]
    [Category("ApplicationUser Repository Tests")]
    internal class ApplicationUserTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `ApplicationUser`")]
        [Order(0)]
        public void ApplicationUser_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _applicationsystembo_permissions_users = new zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission
            {
                Name = "ApplicationPermission_Name",
                Description = "ApplicationPermission_Description",
                IsCustom = true,
            };
            var _applicationsystembo_permissions_users2 = new zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission
            {
                Name = "ApplicationPermission_Name",
                Description = "ApplicationPermission_Description",
                IsCustom = true,
            };
            var _applicationsystembo_roles_users = new zAppDev.DotNet.Framework.Identity.Model.ApplicationRole
            {
                Name = "ApplicationRole_Name",
                Description = "ApplicationRole_Description",
                IsCustom = true,
            };
            var _applicationsystembo_roles_users2 = new zAppDev.DotNet.Framework.Identity.Model.ApplicationRole
            {
                Name = "ApplicationRole_Name",
                Description = "ApplicationRole_Description",
                IsCustom = true,
            };
            var _applicationsystembo_clients_user = new zAppDev.DotNet.Framework.Identity.Model.ApplicationClient
            {
                ClientKey = "ApplicationClient_ClientKey",
                IPAddress = "ApplicationClient_IPAddress",
                SessionId = "ApplicationClient_SessionId",
                ConnectedOn = now,
            };
            var _applicationsystembo_clients_user2 = new zAppDev.DotNet.Framework.Identity.Model.ApplicationClient
            {
                ClientKey = "ApplicationClient_ClientKey",
                IPAddress = "ApplicationClient_IPAddress",
                SessionId = "ApplicationClient_SessionId",
                ConnectedOn = now,
            };
            var _applicationsystembo_logins_user = new zAppDev.DotNet.Framework.Identity.Model.ApplicationUserLogin
            {
                LoginProvider = "ApplicationUserLogin_LoginProvider",
                ProviderKey = "ApplicationUserLogin_ProviderKey",
            };
            var _applicationsystembo_logins_user2 = new zAppDev.DotNet.Framework.Identity.Model.ApplicationUserLogin
            {
                LoginProvider = "ApplicationUserLogin_LoginProvider",
                ProviderKey = "ApplicationUserLogin_ProviderKey",
            };
            var _applicationsystembo_claims_user = new zAppDev.DotNet.Framework.Identity.Model.ApplicationUserClaim
            {
                ClaimType = "ApplicationUserClaim_ClaimType",
                ClaimValue = "ApplicationUserClaim_ClaimValue",
                ClaimValueType = "ApplicationUserClaim_ClaimValueType",
                Issuer = "ApplicationUserClaim_Issuer",
                OriginalIssuer = "ApplicationUserClaim_OriginalIssuer",
            };
            var _applicationsystembo_claims_user2 = new zAppDev.DotNet.Framework.Identity.Model.ApplicationUserClaim
            {
                ClaimType = "ApplicationUserClaim_ClaimType",
                ClaimValue = "ApplicationUserClaim_ClaimValue",
                ClaimValueType = "ApplicationUserClaim_ClaimValueType",
                Issuer = "ApplicationUserClaim_Issuer",
                OriginalIssuer = "ApplicationUserClaim_OriginalIssuer",
            };
            var _applicationsystembo_profile_applicationuser = new zAppDev.DotNet.Framework.Identity.Model.Profile
            {
                LanguageLCID = 5860,
                LocaleLCID = 7855,
                Theme = "Profile_Theme",
            };
            new PersistenceSpecification<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(Session)
            .CheckProperty(p => p.UserName, "e758b6a6-a4aa-4b90-8bde-fdd4866ae676ApplicationUser_UserName")
            .CheckProperty(p => p.PasswordHash, "ApplicationUser_PasswordHash")
            .CheckProperty(p => p.SecurityStamp, "ApplicationUser_SecurityStamp")
            .CheckProperty(p => p.EmailConfirmed, true)
            .CheckProperty(p => p.LockoutEnabled, true)
            .CheckProperty(p => p.PhoneNumberConfirmed, true)
            .CheckProperty(p => p.TwoFactorEnabled, true)
            .CheckProperty(p => p.AccessFailedCount, 1062)
            .CheckProperty(p => p.Name, "ApplicationUser_Name")
            .CheckProperty(p => p.Email, "ApplicationUser_Email")
            .CheckProperty(p => p.PhoneNumber, "ApplicationUser_PhoneNumber")
            .CheckProperty(p => p.LockoutEndDate, now)
            .CheckBag(p => p.Permissions, (new List<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>
            {
                _applicationsystembo_permissions_users,
                _applicationsystembo_permissions_users2
            }))
            .CheckBag(p => p.Roles, (new List<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>
            {
                _applicationsystembo_roles_users,
                _applicationsystembo_roles_users2
            }))
            .CheckBag(p => p.Clients, (new List<zAppDev.DotNet.Framework.Identity.Model.ApplicationClient>
            {
                _applicationsystembo_clients_user,
                _applicationsystembo_clients_user2
            }))
            .CheckBag(p => p.Logins, (new List<zAppDev.DotNet.Framework.Identity.Model.ApplicationUserLogin>
            {
                _applicationsystembo_logins_user,
                _applicationsystembo_logins_user2
            }))
            .CheckBag(p => p.Claims, (new List<zAppDev.DotNet.Framework.Identity.Model.ApplicationUserClaim>
            {
                _applicationsystembo_claims_user,
                _applicationsystembo_claims_user2
            }))
            .CheckReference(p => p.Profile, _applicationsystembo_profile_applicationuser)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `ApplicationUser`")]
        [Order(1)]
        public void ApplicationUser_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(
                              a => true
                              && (a.UserName != string.Empty && a.UserName != null)
                              && (a.PasswordHash != string.Empty && a.PasswordHash != null)
                              && (a.SecurityStamp != string.Empty && a.SecurityStamp != null)
                              && !a.EmailConfirmed
                              && !a.LockoutEnabled
                              && !a.PhoneNumberConfirmed
                              && !a.TwoFactorEnabled
                              && (a.AccessFailedCount + 123 > 0)
                              && (a.Name != string.Empty && a.Name != null)
                              && (a.Email != string.Empty && a.Email != null)
                              && (a.PhoneNumber != string.Empty && a.PhoneNumber != null)
                              && a.LockoutEndDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && a.Permissions.Any()
                              && a.Roles.Any()
                              && a.Clients.Any()
                              && a.Logins.Any()
                              && a.Claims.Any()
                              && a.Profile != null
                              ,
                              cacheQuery: true)
                          .OrderBy(a => a)
                          .Skip(0)
                          .Take(3)
                          .ToList();
            });
            Assert.AreNotEqual(null, results);
        }
    }
}