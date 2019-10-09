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
    ///This is a test class for BuyerTest and is intended
    ///to contain all BuyerTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Buyer Repository Tests")]
    [Category("Buyer Repository Tests")]
    internal class BuyerTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Buyer`")]
        [Order(0)]
        public void Buyer_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _agreement_commercialagreements_buyer = new DemonstratorApp.BO.CommercialAgreement
            {
                ProductCategory = "CommercialAgreement_ProductCategory",
                PaymentTerms = "CommercialAgreement_PaymentTerms",
            };
            var _agreement_commercialagreements_buyer2 = new DemonstratorApp.BO.CommercialAgreement
            {
                ProductCategory = "CommercialAgreement_ProductCategory",
                PaymentTerms = "CommercialAgreement_PaymentTerms",
            };
            new PersistenceSpecification<DemonstratorApp.BO.Buyer>(Session)
            .CheckProperty(p => p.BuyerId, 3865)
            .CheckProperty(p => p.PrimaryPhone, "Buyer_PrimaryPhone")
            .CheckProperty(p => p.SecondaryPhone, "Buyer_SecondaryPhone")
            .CheckProperty(p => p.Fax, "Buyer_Fax")
            .CheckProperty(p => p.WebSite, "Buyer_WebSite")
            .CheckProperty(p => p.Company, "Buyer_Company")
            .CheckProperty(p => p.AnnualTurnOver, 2222222222.22222M)
            .CheckProperty(p => p.LegalRepresentative, "Buyer_LegalRepresentative")
            .CheckProperty(p => p.Rating, "Buyer_Rating")
            .CheckProperty(p => p.CreditInsurance, true)
            .CheckProperty(p => p.Logo, "Buyer_Logo")
            .CheckProperty(p => p.AddressOne, "Buyer_AddressOne")
            .CheckProperty(p => p.AddressTwo, "Buyer_AddressTwo")
            .CheckProperty(p => p.VatNumber, "Buyer_VatNumber")
            .CheckProperty(p => p.ContactPerson, "Buyer_ContactPerson")
            .CheckProperty(p => p.Prefix, "Buyer_Prefix")
            .CheckProperty(p => p.Temp, "Buyer_Temp")
            .CheckProperty(p => p.UserName, "d39b3f00-63a0-47e6-b034-4a0315facc13Buyer_UserName")
            .CheckProperty(p => p.PasswordHash, "Buyer_PasswordHash")
            .CheckProperty(p => p.SecurityStamp, "Buyer_SecurityStamp")
            .CheckProperty(p => p.EmailConfirmed, true)
            .CheckProperty(p => p.LockoutEnabled, true)
            .CheckProperty(p => p.PhoneNumberConfirmed, true)
            .CheckProperty(p => p.TwoFactorEnabled, true)
            .CheckProperty(p => p.AccessFailedCount, 8398)
            .CheckProperty(p => p.Name, "Buyer_Name")
            .CheckProperty(p => p.Email, "Buyer_Email")
            .CheckProperty(p => p.PhoneNumber, "Buyer_PhoneNumber")
            .CheckProperty(p => p.LockoutEndDate, now)
            .CheckBag(p => p.CommercialAgreements, (new List<DemonstratorApp.BO.CommercialAgreement>
            {
                _agreement_commercialagreements_buyer,
                _agreement_commercialagreements_buyer2
            }))
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Buyer`")]
        [Order(1)]
        public void Buyer_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DemonstratorApp.BO.Buyer> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DemonstratorApp.BO.Buyer>(
                              a => true
                              && (a.BuyerId + 123 > 0)
                              && (a.PrimaryPhone != string.Empty && a.PrimaryPhone != null)
                              && (a.SecondaryPhone != string.Empty && a.SecondaryPhone != null)
                              && (a.Fax != string.Empty && a.Fax != null)
                              && (a.WebSite != string.Empty && a.WebSite != null)
                              && (a.Company != string.Empty && a.Company != null)
                              && (a.AnnualTurnOver + 123 > 0)
                              && (a.LegalRepresentative != string.Empty && a.LegalRepresentative != null)
                              && (a.Rating != string.Empty && a.Rating != null)
                              && !a.CreditInsurance
                              && (a.Logo != string.Empty && a.Logo != null)
                              && (a.AddressOne != string.Empty && a.AddressOne != null)
                              && (a.AddressTwo != string.Empty && a.AddressTwo != null)
                              && (a.VatNumber != string.Empty && a.VatNumber != null)
                              && (a.ContactPerson != string.Empty && a.ContactPerson != null)
                              && (a.Prefix != string.Empty && a.Prefix != null)
                              && (a.Temp != string.Empty && a.Temp != null)
                              && (a.UserName != string.Empty && a.UserName != null)
                              && (a.PasswordHash != string.Empty && a.PasswordHash != null)
                              && (a.SecurityStamp != string.Empty && a.SecurityStamp != null)
                              && !a.EmailConfirmed
                              && !a.LockoutEnabled
                              && !a.PhoneNumberConfirmed
                              && !a.TwoFactorEnabled
                              && (a.AccessFailedCount + 123 > 0)
                              && (a.Name != string.Empty && a.Name != null)
                              && (a.Email != string.Empty && a.Email != null)
                              && (a.PhoneNumber != string.Empty && a.PhoneNumber != null)
                              && a.LockoutEndDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && a.CommercialAgreements.Any()
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