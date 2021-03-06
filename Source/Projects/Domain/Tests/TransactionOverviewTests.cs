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
    ///This is a test class for TransactionOverviewTest and is intended
    ///to contain all TransactionOverviewTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("TransactionOverview Repository Tests")]
    [Category("TransactionOverview Repository Tests")]
    internal class TransactionOverviewTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `TransactionOverview`")]
        [Order(0)]
        public void TransactionOverview_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DemonstratorApp.BO.TransactionOverview>(Session)
            .CheckProperty(p => p.DeliveryDate, now)
            .CheckProperty(p => p.OrderQuantity, 2222222222.22222M)
            .CheckProperty(p => p.OrderDate, now)
            .CheckProperty(p => p.InvoiceId, 8137)
            .CheckProperty(p => p.InvoiceDate, now)
            .CheckProperty(p => p.FundedRate, 2222222222.22222M)
            .CheckProperty(p => p.InterestRate, 2222222222.22222M)
            .CheckProperty(p => p.TotalValue, 2222222222.22222M)
            .CheckProperty(p => p.FundingValue, 2222222222.22222M)
            .CheckProperty(p => p.PaymentId, 4373)
            .CheckProperty(p => p.PayementDate, now)
            .CheckProperty(p => p.CreditNoteNumber, "TransactionOverview_CreditNoteNumber")
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `TransactionOverview`")]
        [Order(1)]
        public void TransactionOverview_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DemonstratorApp.BO.TransactionOverview> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DemonstratorApp.BO.TransactionOverview>(
                              a => true
                              && a.DeliveryDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.OrderQuantity + 123 > 0)
                              && a.OrderDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.InvoiceId + 123 > 0)
                              && a.InvoiceDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.FundedRate + 123 > 0)
                              && (a.InterestRate + 123 > 0)
                              && (a.TotalValue + 123 > 0)
                              && (a.FundingValue + 123 > 0)
                              && (a.PaymentId + 123 > 0)
                              && a.PayementDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.CreditNoteNumber != string.Empty && a.CreditNoteNumber != null)
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