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
    ///This is a test class for SupplierExtraInformationTest and is intended
    ///to contain all SupplierExtraInformationTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("SupplierExtraInformation Repository Tests")]
    [Category("SupplierExtraInformation Repository Tests")]
    internal class SupplierExtraInformationTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `SupplierExtraInformation`")]
        [Order(0)]
        public void SupplierExtraInformation_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DemonstratorApp.BO.SupplierExtraInformation>(Session)
            .CheckProperty(p => p.OccurenceBadDebts, "SupplierExtraInformation_OccurenceBadDebts")
            .CheckProperty(p => p.ExistenceCounterClaims, "SupplierExtraInformation_ExistenceCounterClaims")
            .CheckProperty(p => p.HasCompanyAssigned, "SupplierExtraInformation_HasCompanyAssigned")
            .CheckProperty(p => p.AreCompanyReceivables, "SupplierExtraInformation_AreCompanyReceivables")
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `SupplierExtraInformation`")]
        [Order(1)]
        public void SupplierExtraInformation_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DemonstratorApp.BO.SupplierExtraInformation> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DemonstratorApp.BO.SupplierExtraInformation>(
                              a => true
                              && (a.OccurenceBadDebts != string.Empty && a.OccurenceBadDebts != null)
                              && (a.ExistenceCounterClaims != string.Empty && a.ExistenceCounterClaims != null)
                              && (a.HasCompanyAssigned != string.Empty && a.HasCompanyAssigned != null)
                              && (a.AreCompanyReceivables != string.Empty && a.AreCompanyReceivables != null)
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