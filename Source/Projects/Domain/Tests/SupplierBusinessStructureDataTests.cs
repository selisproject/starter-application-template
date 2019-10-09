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
    ///This is a test class for SupplierBusinessStructureDataTest and is intended
    ///to contain all SupplierBusinessStructureDataTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("SupplierBusinessStructureData Repository Tests")]
    [Category("SupplierBusinessStructureData Repository Tests")]
    internal class SupplierBusinessStructureDataTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `SupplierBusinessStructureData`")]
        [Order(0)]
        public void SupplierBusinessStructureData_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DemonstratorApp.BO.SupplierBusinessStructureData>(Session)
            .CheckProperty(p => p.NumOfCustomersD, 8913)
            .CheckProperty(p => p.NumOfCustomersAbroad, 5024)
            .CheckProperty(p => p.NumOfCustomersEU, 3117)
            .CheckProperty(p => p.NumOfCustomers, 5620)
            .CheckProperty(p => p.ThereofActiveD, 3234)
            .CheckProperty(p => p.ThereofActiveAbroad, 1836)
            .CheckProperty(p => p.ThereofActiveEU, 8407)
            .CheckProperty(p => p.ThereofActive, 4047)
            .CheckProperty(p => p.NumOfOccasionalCustD, 9417)
            .CheckProperty(p => p.NumOfOccasionalCustAbroad, 3395)
            .CheckProperty(p => p.NumOfOccasionalCustEU, 2615)
            .CheckProperty(p => p.NumOfOccasionalCust, 7291)
            .CheckProperty(p => p.NumOpenBalanceD, 6042)
            .CheckProperty(p => p.NumOpenBalanceAboad, 7836)
            .CheckProperty(p => p.NumOpenBalanceEU, 5594)
            .CheckProperty(p => p.NumOpenBalance, 6191)
            .CheckProperty(p => p.NumOfInvoicesD, 4619)
            .CheckProperty(p => p.NumOfInvoicesAbroad, 1750)
            .CheckProperty(p => p.NumOfInvoicesEU, 6943)
            .CheckProperty(p => p.NumOfInvoices, 767)
            .CheckProperty(p => p.NumOfEmployeesD, 8989)
            .CheckProperty(p => p.NumOfEmployeesAbroad, 5949)
            .CheckProperty(p => p.NumTransCustD, 3844)
            .CheckProperty(p => p.NumTransCustAbroad, 193)
            .CheckProperty(p => p.NumTransCustEU, 5883)
            .CheckProperty(p => p.NumTransCust, 516)
            .CheckProperty(p => p.ApplicableCommercialLaw, "SupplierBusinessStructureData_ApplicableCommercialLaw")
            .CheckProperty(p => p.Jurisdiction, "SupplierBusinessStructureData_Jurisdiction")
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `SupplierBusinessStructureData`")]
        [Order(1)]
        public void SupplierBusinessStructureData_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DemonstratorApp.BO.SupplierBusinessStructureData> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DemonstratorApp.BO.SupplierBusinessStructureData>(
                              a => true
                              && (a.NumOfCustomersD + 123 > 0)
                              && (a.NumOfCustomersAbroad + 123 > 0)
                              && (a.NumOfCustomersEU + 123 > 0)
                              && (a.NumOfCustomers + 123 > 0)
                              && (a.ThereofActiveD + 123 > 0)
                              && (a.ThereofActiveAbroad + 123 > 0)
                              && (a.ThereofActiveEU + 123 > 0)
                              && (a.ThereofActive + 123 > 0)
                              && (a.NumOfOccasionalCustD + 123 > 0)
                              && (a.NumOfOccasionalCustAbroad + 123 > 0)
                              && (a.NumOfOccasionalCustEU + 123 > 0)
                              && (a.NumOfOccasionalCust + 123 > 0)
                              && (a.NumOpenBalanceD + 123 > 0)
                              && (a.NumOpenBalanceAboad + 123 > 0)
                              && (a.NumOpenBalanceEU + 123 > 0)
                              && (a.NumOpenBalance + 123 > 0)
                              && (a.NumOfInvoicesD + 123 > 0)
                              && (a.NumOfInvoicesAbroad + 123 > 0)
                              && (a.NumOfInvoicesEU + 123 > 0)
                              && (a.NumOfInvoices + 123 > 0)
                              && (a.NumOfEmployeesD + 123 > 0)
                              && (a.NumOfEmployeesAbroad + 123 > 0)
                              && (a.NumTransCustD + 123 > 0)
                              && (a.NumTransCustAbroad + 123 > 0)
                              && (a.NumTransCustEU + 123 > 0)
                              && (a.NumTransCust + 123 > 0)
                              && (a.ApplicableCommercialLaw != string.Empty && a.ApplicableCommercialLaw != null)
                              && (a.Jurisdiction != string.Empty && a.Jurisdiction != null)
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