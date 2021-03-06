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
    ///This is a test class for ApplicationUserLoginTest and is intended
    ///to contain all ApplicationUserLoginTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("ApplicationUserLogin Repository Tests")]
    [Category("ApplicationUserLogin Repository Tests")]
    internal class ApplicationUserLoginTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `ApplicationUserLogin`")]
        [Order(0)]
        public void ApplicationUserLogin_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _applicationsystembo_user_logins = new zAppDev.DotNet.Framework.Identity.Model.ApplicationUser
            {
                UserName = "6e4fc3c3-ae33-4eab-9de1-fda7c411a6ceApplicationUser_UserName",
                PasswordHash = "ApplicationUser_PasswordHash",
                SecurityStamp = "ApplicationUser_SecurityStamp",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = true,
                AccessFailedCount = 2421,
                Name = "ApplicationUser_Name",
                Email = "ApplicationUser_Email",
                PhoneNumber = "ApplicationUser_PhoneNumber",
                LockoutEndDate = now,
            };
            new PersistenceSpecification<zAppDev.DotNet.Framework.Identity.Model.ApplicationUserLogin>(Session)
            .CheckProperty(p => p.LoginProvider, "ApplicationUserLogin_LoginProvider")
            .CheckProperty(p => p.ProviderKey, "ApplicationUserLogin_ProviderKey")
            .CheckReference(p => p.User, _applicationsystembo_user_logins)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `ApplicationUserLogin`")]
        [Order(1)]
        public void ApplicationUserLogin_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<zAppDev.DotNet.Framework.Identity.Model.ApplicationUserLogin> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationUserLogin>(
                              a => true
                              && (a.LoginProvider != string.Empty && a.LoginProvider != null)
                              && (a.ProviderKey != string.Empty && a.ProviderKey != null)
                              && a.User != null
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