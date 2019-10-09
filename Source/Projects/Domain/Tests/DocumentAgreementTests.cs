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
    ///This is a test class for DocumentAgreementTest and is intended
    ///to contain all DocumentAgreementTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("DocumentAgreement Repository Tests")]
    [Category("DocumentAgreement Repository Tests")]
    internal class DocumentAgreementTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `DocumentAgreement`")]
        [Order(0)]
        public void DocumentAgreement_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _agreement_agreement_documentagreement = new DemonstratorApp.BO.Agreement
            {
                StartDate = now,
                EndDate = now,
                FundedRate = 222222.22M,
                FundedAmount = 222222.22M,
                CurrentAgreementStatus = "Agreement_CurrentAgreementStatus",
                InterestRate = 222222.22M,
            };
            new PersistenceSpecification<DemonstratorApp.BO.DocumentAgreement>(Session)
            .CheckProperty(p => p.SupplierDocument, "DocumentAgreement_SupplierDocument")
            .CheckProperty(p => p.InvestorDocument, "DocumentAgreement_InvestorDocument")
            .CheckProperty(p => p.AdminDocument, "DocumentAgreement_AdminDocument")
            .CheckReference(p => p.Agreement, _agreement_agreement_documentagreement)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `DocumentAgreement`")]
        [Order(1)]
        public void DocumentAgreement_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DemonstratorApp.BO.DocumentAgreement> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DemonstratorApp.BO.DocumentAgreement>(
                              a => true
                              && (a.SupplierDocument != string.Empty && a.SupplierDocument != null)
                              && (a.InvestorDocument != string.Empty && a.InvestorDocument != null)
                              && (a.AdminDocument != string.Empty && a.AdminDocument != null)
                              && a.Agreement != null
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