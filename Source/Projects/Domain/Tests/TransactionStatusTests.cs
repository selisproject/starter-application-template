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
    ///This is a test class for TransactionStatusTest and is intended
    ///to contain all TransactionStatusTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("TransactionStatus Repository Tests")]
    [Category("TransactionStatus Repository Tests")]
    internal class TransactionStatusTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `TransactionStatus`")]
        [Order(0)]
        public void TransactionStatus_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DemonstratorApp.BO.TransactionStatus>(Session)
            .CheckProperty(p => p.TransactionDateOccured, now)
            .CheckProperty(p => p.Status, "TransactionStatus_Status")
            .CheckProperty(p => p.Shipped, true)
            .CheckProperty(p => p.Invoiced, true)
            .CheckProperty(p => p.ShippedDateOccured, now)
            .CheckProperty(p => p.InvoicedDateOccured, now)
            .CheckProperty(p => p.Cancelled, true)
            .CheckProperty(p => p.InTransit, true)
            .CheckProperty(p => p.Picked, true)
            .CheckProperty(p => p.PaymentStatus, true)
            .CheckProperty(p => p.InitialOrderDate, now)
            .CheckProperty(p => p.FinalOrderDate, now)
            .CheckProperty(p => p.Delivered, true)
            .CheckProperty(p => p.Ordered, true)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `TransactionStatus`")]
        [Order(1)]
        public void TransactionStatus_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DemonstratorApp.BO.TransactionStatus> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DemonstratorApp.BO.TransactionStatus>(
                              a => true
                              && a.TransactionDateOccured.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.Status != string.Empty && a.Status != null)
                              && !a.Shipped
                              && !a.Invoiced
                              && a.ShippedDateOccured.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && a.InvoicedDateOccured.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && !a.Cancelled
                              && !a.InTransit
                              && !a.Picked
                              && !a.PaymentStatus
                              && a.InitialOrderDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && a.FinalOrderDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && !a.Delivered
                              && !a.Ordered
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