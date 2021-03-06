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
    ///This is a test class for DashboardTest and is intended
    ///to contain all DashboardTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Dashboard Repository Tests")]
    [Category("Dashboard Repository Tests")]
    internal class DashboardTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Dashboard`")]
        [Order(0)]
        public void Dashboard_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _dashboard_supplierstatistics_dashboard = new DemonstratorApp.BO.SupplierStatistic
            {
                TotalCommercialAgreements = 4229,
                DataQuality = 222222.22M,
                DataAvailability = 7391,
                OnTimeDeliveries = 566,
                AsOrderedDeliveries = 392,
                InFullDeliveries = 2558,
                TotalImpeachments = 6437,
                CurrentTurnover = 222222.22M,
                NextTurnover = 222222.22M,
                PreviousTurnover = 222222.22M,
                TotalTransactions = 4498,
            };
            var _dashboard_supplierstatistics_dashboard2 = new DemonstratorApp.BO.SupplierStatistic
            {
                TotalCommercialAgreements = 300,
                DataQuality = 222222.22M,
                DataAvailability = 8121,
                OnTimeDeliveries = 1908,
                AsOrderedDeliveries = 6743,
                InFullDeliveries = 6607,
                TotalImpeachments = 3059,
                CurrentTurnover = 222222.22M,
                NextTurnover = 222222.22M,
                PreviousTurnover = 222222.22M,
                TotalTransactions = 4619,
            };
            var _dashboard_buyerstatistics_dashboard = new DemonstratorApp.BO.BuyerStatistic
            {
            };
            var _dashboard_buyerstatistics_dashboard2 = new DemonstratorApp.BO.BuyerStatistic
            {
            };
            new PersistenceSpecification<DemonstratorApp.BO.Dashboard>(Session)
            .CheckBag(p => p.SupplierStatistics, (new List<DemonstratorApp.BO.SupplierStatistic>
            {
                _dashboard_supplierstatistics_dashboard,
                _dashboard_supplierstatistics_dashboard2
            }))
            .CheckBag(p => p.BuyerStatistics, (new List<DemonstratorApp.BO.BuyerStatistic>
            {
                _dashboard_buyerstatistics_dashboard,
                _dashboard_buyerstatistics_dashboard2
            }))
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Dashboard`")]
        [Order(1)]
        public void Dashboard_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DemonstratorApp.BO.Dashboard> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DemonstratorApp.BO.Dashboard>(
                              a => true
                              && a.SupplierStatistics.Any()
                              && a.BuyerStatistics.Any()
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