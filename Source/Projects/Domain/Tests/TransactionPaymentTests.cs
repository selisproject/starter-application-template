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
    ///This is a test class for TransactionPaymentTest and is intended
    ///to contain all TransactionPaymentTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("TransactionPayment Repository Tests")]
    [Category("TransactionPayment Repository Tests")]
    internal class TransactionPaymentTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `TransactionPayment`")]
        [Order(0)]
        public void TransactionPayment_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _transactionpayment_transactions_transactionpayment = new DemonstratorApp.BO.Transaction
            {
                TransactionDateOccured = now,
                TransactionValue = 2222222222.22222M,
                FundedAmount = 2222222222.22222M,
                ToBePaidAmount = 2222222222.22222M,
                InvoicedDate = now,
                PaymentStatus = "Transaction_PaymentStatus",
                PaymentDate = now,
                RestPaymentAmount = 2222222222.22222M,
                PaidByBuyer = true,
            };
            var _transactionpayment_transactions_transactionpayment2 = new DemonstratorApp.BO.Transaction
            {
                TransactionDateOccured = now,
                TransactionValue = 2222222222.22222M,
                FundedAmount = 2222222222.22222M,
                ToBePaidAmount = 2222222222.22222M,
                InvoicedDate = now,
                PaymentStatus = "Transaction_PaymentStatus",
                PaymentDate = now,
                RestPaymentAmount = 2222222222.22222M,
                PaidByBuyer = true,
            };
            var _transactionpayment_agreement_transactionpayment = new DemonstratorApp.BO.Agreement
            {
                StartDate = now,
                EndDate = now,
                FundedRate = 222222.22M,
                FundedAmount = 222222.22M,
                CurrentAgreementStatus = "Agreement_CurrentAgreementStatus",
                InterestRate = 222222.22M,
            };
            new PersistenceSpecification<DemonstratorApp.BO.TransactionPayment>(Session)
            .CheckProperty(p => p.PaymentAmount, 222222.22M)
            .CheckProperty(p => p.Receipt, "TransactionPayment_Receipt")
            .CheckProperty(p => p.PaymentDate, now)
            .CheckBag(p => p.Transactions, (new List<DemonstratorApp.BO.Transaction>
            {
                _transactionpayment_transactions_transactionpayment,
                _transactionpayment_transactions_transactionpayment2
            }))
            .CheckReference(p => p.Agreement, _transactionpayment_agreement_transactionpayment)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `TransactionPayment`")]
        [Order(1)]
        public void TransactionPayment_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DemonstratorApp.BO.TransactionPayment> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DemonstratorApp.BO.TransactionPayment>(
                              a => true
                              && (a.PaymentAmount + 123 > 0)
                              && (a.Receipt != string.Empty && a.Receipt != null)
                              && a.PaymentDate.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && a.Transactions.Any()
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