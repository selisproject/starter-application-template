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
    ///This is a test class for OrderTest and is intended
    ///to contain all OrderTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Order Repository Tests")]
    [Category("Order Repository Tests")]
    internal class OrderTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Order`")]
        [Order(0)]
        public void Order_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _agreement_commercialagreement_orders = new DemonstratorApp.BO.CommercialAgreement
            {
                ProductCategory = "CommercialAgreement_ProductCategory",
                PaymentTerms = "CommercialAgreement_PaymentTerms",
            };
            var _order_orderproducts_order = new DemonstratorApp.BO.OrderProduct
            {
                Code = "OrderProduct_Code",
                Quantity = 222222.22M,
                Description = "OrderProduct_Description",
                UnitValue = "OrderProduct_UnitValue",
                MeasurementUnit = "OrderProduct_MeasurementUnit",
                Price = 222222.22M,
                LineTotalPrice = 222222.22M,
            };
            var _order_orderproducts_order2 = new DemonstratorApp.BO.OrderProduct
            {
                Code = "OrderProduct_Code",
                Quantity = 222222.22M,
                Description = "OrderProduct_Description",
                UnitValue = "OrderProduct_UnitValue",
                MeasurementUnit = "OrderProduct_MeasurementUnit",
                Price = 222222.22M,
                LineTotalPrice = 222222.22M,
            };
            var _order_proofofdeliveries_orders = new DemonstratorApp.BO.ProofOfDelivery
            {
                PODNumber = "ProofOfDelivery_PODNumber",
                DateIssued = now,
                QualityStatus = "ProofOfDelivery_QualityStatus",
                QuantityStatus = "ProofOfDelivery_QuantityStatus",
                DeliveryStatus = "ProofOfDelivery_DeliveryStatus",
                PODAttachment = "ProofOfDelivery_PODAttachment",
                Comments = "ProofOfDelivery_Comments",
            };
            var _order_proofofdeliveries_orders2 = new DemonstratorApp.BO.ProofOfDelivery
            {
                PODNumber = "ProofOfDelivery_PODNumber",
                DateIssued = now,
                QualityStatus = "ProofOfDelivery_QualityStatus",
                QuantityStatus = "ProofOfDelivery_QuantityStatus",
                DeliveryStatus = "ProofOfDelivery_DeliveryStatus",
                PODAttachment = "ProofOfDelivery_PODAttachment",
                Comments = "ProofOfDelivery_Comments",
            };
            var _order_invoices_orders = new DemonstratorApp.BO.Invoice
            {
                InvoiceNumber = "Invoice_InvoiceNumber",
                Description = "Invoice_Description",
                DateIssued = now,
                Amount = 2222222222222.22M,
                CustomerType = "Invoice_CustomerType",
                CumulativeBalance = 222222.22M,
                TotalPrice = 222222.22M,
                DescriptionTwo = "Invoice_DescriptionTwo",
                Attribute = "Invoice_Attribute",
                InvoiceAttachment = "Invoice_InvoiceAttachment",
            };
            var _order_invoices_orders2 = new DemonstratorApp.BO.Invoice
            {
                InvoiceNumber = "Invoice_InvoiceNumber",
                Description = "Invoice_Description",
                DateIssued = now,
                Amount = 2222222222222.22M,
                CustomerType = "Invoice_CustomerType",
                CumulativeBalance = 222222.22M,
                TotalPrice = 222222.22M,
                DescriptionTwo = "Invoice_DescriptionTwo",
                Attribute = "Invoice_Attribute",
                InvoiceAttachment = "Invoice_InvoiceAttachment",
            };
            var _order_deliverynotes_orders = new DemonstratorApp.BO.DeliveryNote
            {
                DeliveryNoteNumber = "DeliveryNote_DeliveryNoteNumber",
                Description = "DeliveryNote_Description",
                DateIssued = now,
                Amount = 2222222222222.22M,
                TotalPrice = 222222.22M,
                DNoteAttachment = "DeliveryNote_DNoteAttachment",
            };
            var _order_deliverynotes_orders2 = new DemonstratorApp.BO.DeliveryNote
            {
                DeliveryNoteNumber = "DeliveryNote_DeliveryNoteNumber",
                Description = "DeliveryNote_Description",
                DateIssued = now,
                Amount = 2222222222222.22M,
                TotalPrice = 222222.22M,
                DNoteAttachment = "DeliveryNote_DNoteAttachment",
            };
            var _order_orderstatus_order = new DemonstratorApp.BO.OrderStatus
            {
                OrderdDateOccured = now,
                Status = "OrderStatus_Status",
                PaymentStatus = true,
                InitialOrdered = true,
                FinalOrdered = true,
            };
            var _order_finalacceptancecertificate_order = new DemonstratorApp.BO.FinalAcceptanceCertificate
            {
                Certificate = "FinalAcceptanceCertificate_Certificate",
            };
            var _order_creditnotes_orders = new DemonstratorApp.BO.CreditNote
            {
                CreditNoteNumber = "CreditNote_CreditNoteNumber",
                Description = "CreditNote_Description",
                DateIssued = now,
                Amount = 2222222222.22222M,
                TotalPrice = 2222222222.22222M,
                CreditNoteDocument = "CreditNote_CreditNoteDocument",
                CNoteAttachment = "CreditNote_CNoteAttachment",
            };
            var _order_creditnotes_orders2 = new DemonstratorApp.BO.CreditNote
            {
                CreditNoteNumber = "CreditNote_CreditNoteNumber",
                Description = "CreditNote_Description",
                DateIssued = now,
                Amount = 2222222222.22222M,
                TotalPrice = 2222222222.22222M,
                CreditNoteDocument = "CreditNote_CreditNoteDocument",
                CNoteAttachment = "CreditNote_CNoteAttachment",
            };
            var _order_orderpayment_order = new DemonstratorApp.BO.OrderPayment
            {
                PaymentAmount = 2222222222.22222M,
                DateIssued = now,
            };
            var _order_orderpayment_order2 = new DemonstratorApp.BO.OrderPayment
            {
                PaymentAmount = 2222222222.22222M,
                DateIssued = now,
            };
            var _order_letterofcredits_orders = new DemonstratorApp.BO.LetterOfCredit
            {
                ValueOfLoC = 222222.22M,
                IssuingBank = "LetterOfCredit_IssuingBank",
                Detail = "LetterOfCredit_Detail",
                UploadOfScan = "LetterOfCredit_UploadOfScan",
                Calculated = 222222.22M,
                DateOfValidity = now,
                DateOfExpiry = now,
            };
            var _order_letterofcredits_orders2 = new DemonstratorApp.BO.LetterOfCredit
            {
                ValueOfLoC = 222222.22M,
                IssuingBank = "LetterOfCredit_IssuingBank",
                Detail = "LetterOfCredit_Detail",
                UploadOfScan = "LetterOfCredit_UploadOfScan",
                Calculated = 222222.22M,
                DateOfValidity = now,
                DateOfExpiry = now,
            };
            var _order_billoflandings_orders = new DemonstratorApp.BO.BillOfLanding
            {
                LandingPlace = "BillOfLanding_LandingPlace",
                LandingDate = now,
                DeliveryPlace = "BillOfLanding_DeliveryPlace",
                DeliveryDate = now,
                DOCNumber = 1719,
                ReceivingPartyId = 3491,
                IsBuyerReceiving = true,
            };
            var _order_billoflandings_orders2 = new DemonstratorApp.BO.BillOfLanding
            {
                LandingPlace = "BillOfLanding_LandingPlace",
                LandingDate = now,
                DeliveryPlace = "BillOfLanding_DeliveryPlace",
                DeliveryDate = now,
                DOCNumber = 7438,
                ReceivingPartyId = 1385,
                IsBuyerReceiving = true,
            };
            var _order_intermediaries_orders = new DemonstratorApp.BO.Intermediary
            {
                OtherDescription = "Intermediary_OtherDescription",
                Company = "Intermediary_Company",
                EMail = "Intermediary_EMail",
                GUID = "Intermediary_GUID",
            };
            var _order_intermediaries_orders2 = new DemonstratorApp.BO.Intermediary
            {
                OtherDescription = "Intermediary_OtherDescription",
                Company = "Intermediary_Company",
                EMail = "Intermediary_EMail",
                GUID = "Intermediary_GUID",
            };
            var _transaction_transaction_orders = new DemonstratorApp.BO.Transaction
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
            new PersistenceSpecification<DemonstratorApp.BO.Order>(Session)
            .CheckProperty(p => p.OrderNumber, "Order_OrderNumber")
            .CheckProperty(p => p.EstimatedDateOfDelivery, now)
            .CheckProperty(p => p.PaymentTerms, "Order_PaymentTerms")
            .CheckProperty(p => p.IntermediateParty, true)
            .CheckProperty(p => p.IsCancelled, true)
            .CheckProperty(p => p.DateOfOrder, now)
            .CheckProperty(p => p.OrderAmount, 2222222222.22222M)
            .CheckProperty(p => p.TotalPrice, 2222222222.22222M)
            .CheckProperty(p => p.From, "Order_From")
            .CheckProperty(p => p.DeliveryTo, "Order_DeliveryTo")
            .CheckProperty(p => p.OrderAttachment, "Order_OrderAttachment")
            .CheckReference(p => p.CommercialAgreement, _agreement_commercialagreement_orders)
            .CheckBag(p => p.OrderProducts, (new List<DemonstratorApp.BO.OrderProduct>
            {
                _order_orderproducts_order,
                _order_orderproducts_order2
            }))
            .CheckBag(p => p.ProofOfDeliveries, (new List<DemonstratorApp.BO.ProofOfDelivery>
            {
                _order_proofofdeliveries_orders,
                _order_proofofdeliveries_orders2
            }))
            .CheckBag(p => p.Invoices, (new List<DemonstratorApp.BO.Invoice>
            {
                _order_invoices_orders,
                _order_invoices_orders2
            }))
            .CheckBag(p => p.DeliveryNotes, (new List<DemonstratorApp.BO.DeliveryNote>
            {
                _order_deliverynotes_orders,
                _order_deliverynotes_orders2
            }))
            .CheckReference(p => p.OrderStatus, _order_orderstatus_order)
            .CheckReference(p => p.FinalAcceptanceCertificate, _order_finalacceptancecertificate_order)
            .CheckBag(p => p.CreditNotes, (new List<DemonstratorApp.BO.CreditNote>
            {
                _order_creditnotes_orders,
                _order_creditnotes_orders2
            }))
            .CheckBag(p => p.OrderPayment, (new List<DemonstratorApp.BO.OrderPayment>
            {
                _order_orderpayment_order,
                _order_orderpayment_order2
            }))
            .CheckBag(p => p.LetterOfCredits, (new List<DemonstratorApp.BO.LetterOfCredit>
            {
                _order_letterofcredits_orders,
                _order_letterofcredits_orders2
            }))
            .CheckBag(p => p.BillOfLandings, (new List<DemonstratorApp.BO.BillOfLanding>
            {
                _order_billoflandings_orders,
                _order_billoflandings_orders2
            }))
            .CheckBag(p => p.Intermediaries, (new List<DemonstratorApp.BO.Intermediary>
            {
                _order_intermediaries_orders,
                _order_intermediaries_orders2
            }))
            .CheckReference(p => p.Transaction, _transaction_transaction_orders)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Order`")]
        [Order(1)]
        public void Order_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DemonstratorApp.BO.Order> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DemonstratorApp.BO.Order>(
                              a => true
                              && (a.OrderNumber != string.Empty && a.OrderNumber != null)
                              && a.EstimatedDateOfDelivery.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.PaymentTerms != string.Empty && a.PaymentTerms != null)
                              && !a.IntermediateParty
                              && !a.IsCancelled
                              && a.DateOfOrder.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.OrderAmount + 123 > 0)
                              && (a.TotalPrice + 123 > 0)
                              && (a.From != string.Empty && a.From != null)
                              && (a.DeliveryTo != string.Empty && a.DeliveryTo != null)
                              && (a.OrderAttachment != string.Empty && a.OrderAttachment != null)
                              && a.Status == DemonstratorApp.BO.Status.Initial
                              && a.CommercialAgreement != null
                              && a.OrderProducts.Any()
                              && a.ProofOfDeliveries.Any()
                              && a.Invoices.Any()
                              && a.DeliveryNotes.Any()
                              && a.OrderStatus != null
                              && a.FinalAcceptanceCertificate != null
                              && a.CreditNotes.Any()
                              && a.OrderPayment.Any()
                              && a.LetterOfCredits.Any()
                              && a.BillOfLandings.Any()
                              && a.Intermediaries.Any()
                              && a.Transaction != null
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