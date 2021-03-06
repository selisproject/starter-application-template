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
    ///This is a test class for FinalAcceptanceCertificateTest and is intended
    ///to contain all FinalAcceptanceCertificateTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("FinalAcceptanceCertificate Repository Tests")]
    [Category("FinalAcceptanceCertificate Repository Tests")]
    internal class FinalAcceptanceCertificateTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `FinalAcceptanceCertificate`")]
        [Order(0)]
        public void FinalAcceptanceCertificate_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DemonstratorApp.BO.FinalAcceptanceCertificate>(Session)
            .CheckProperty(p => p.Certificate, "FinalAcceptanceCertificate_Certificate")
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `FinalAcceptanceCertificate`")]
        [Order(1)]
        public void FinalAcceptanceCertificate_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DemonstratorApp.BO.FinalAcceptanceCertificate> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DemonstratorApp.BO.FinalAcceptanceCertificate>(
                              a => true
                              && (a.Certificate != string.Empty && a.Certificate != null)
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