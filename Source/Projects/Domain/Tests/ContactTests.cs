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
    ///This is a test class for ContactTest and is intended
    ///to contain all ContactTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Contact Repository Tests")]
    [Category("Contact Repository Tests")]
    internal class ContactTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Contact`")]
        [Order(0)]
        public void Contact_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DemonstratorApp.BO.Contact>(Session)
            .CheckProperty(p => p.FirstName, "Contact_FirstName")
            .CheckProperty(p => p.LastName, "Contact_LastName")
            .CheckProperty(p => p.Represents, "Contact_Represents")
            .CheckProperty(p => p.Company, "Contact_Company")
            .CheckProperty(p => p.Email, "Contact_Email")
            .CheckProperty(p => p.Phone, "Contact_Phone")
            .CheckProperty(p => p.Message, "Contact_Message")
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Contact`")]
        [Order(1)]
        public void Contact_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DemonstratorApp.BO.Contact> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DemonstratorApp.BO.Contact>(
                              a => true
                              && (a.FirstName != string.Empty && a.FirstName != null)
                              && (a.LastName != string.Empty && a.LastName != null)
                              && (a.Represents != string.Empty && a.Represents != null)
                              && (a.Company != string.Empty && a.Company != null)
                              && (a.Email != string.Empty && a.Email != null)
                              && (a.Phone != string.Empty && a.Phone != null)
                              && (a.Message != string.Empty && a.Message != null)
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