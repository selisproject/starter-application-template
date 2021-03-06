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
    ///This is a test class for DataQualityTest and is intended
    ///to contain all DataQualityTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("DataQuality Repository Tests")]
    [Category("DataQuality Repository Tests")]
    internal class DataQualityTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `DataQuality`")]
        [Order(0)]
        public void DataQuality_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DemonstratorApp.BO.DataQuality>(Session)
            .CheckProperty(p => p.Orders, true)
            .CheckProperty(p => p.DeliveryNotes, true)
            .CheckProperty(p => p.CustomsDocuments, true)
            .CheckProperty(p => p.IntermediaryLogistics, true)
            .CheckProperty(p => p.Invoices, true)
            .CheckProperty(p => p.PoDs, true)
            .CheckProperty(p => p.PaymentData, true)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `DataQuality`")]
        [Order(1)]
        public void DataQuality_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DemonstratorApp.BO.DataQuality> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DemonstratorApp.BO.DataQuality>(
                              a => true
                              && !a.Orders
                              && !a.DeliveryNotes
                              && !a.CustomsDocuments
                              && !a.IntermediaryLogistics
                              && !a.Invoices
                              && !a.PoDs
                              && !a.PaymentData
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