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
    ///This is a test class for ProfileTest and is intended
    ///to contain all ProfileTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Profile Repository Tests")]
    [Category("Profile Repository Tests")]
    internal class ProfileTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Profile`")]
        [Order(0)]
        public void Profile_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _applicationsystembo_settings_parentprofile = new zAppDev.DotNet.Framework.Identity.Model.ProfileSetting
            {
                Key = "ProfileSetting_Key",
                Value = "ProfileSetting_Value",
            };
            var _applicationsystembo_settings_parentprofile2 = new zAppDev.DotNet.Framework.Identity.Model.ProfileSetting
            {
                Key = "ProfileSetting_Key",
                Value = "ProfileSetting_Value",
            };
            new PersistenceSpecification<zAppDev.DotNet.Framework.Identity.Model.Profile>(Session)
            .CheckProperty(p => p.LanguageLCID, 9363)
            .CheckProperty(p => p.LocaleLCID, 9508)
            .CheckProperty(p => p.Theme, "Profile_Theme")
            .CheckBag(p => p.Settings, (new List<zAppDev.DotNet.Framework.Identity.Model.ProfileSetting>
            {
                _applicationsystembo_settings_parentprofile,
                _applicationsystembo_settings_parentprofile2
            }))
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Profile`")]
        [Order(1)]
        public void Profile_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<zAppDev.DotNet.Framework.Identity.Model.Profile> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<zAppDev.DotNet.Framework.Identity.Model.Profile>(
                              a => true
                              && (a.LanguageLCID + 123 > 0)
                              && (a.LocaleLCID + 123 > 0)
                              && (a.Theme != string.Empty && a.Theme != null)
                              && a.Settings.Any()
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