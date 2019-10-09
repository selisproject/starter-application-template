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
    ///This is a test class for SupplierTest and is intended
    ///to contain all SupplierTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Supplier Repository Tests")]
    [Category("Supplier Repository Tests")]
    internal class SupplierTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Supplier`")]
        [Order(0)]
        public void Supplier_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _agreement_commercialagreements_supplier = new DemonstratorApp.BO.CommercialAgreement
            {
                ProductCategory = "CommercialAgreement_ProductCategory",
                PaymentTerms = "CommercialAgreement_PaymentTerms",
            };
            var _agreement_commercialagreements_supplier2 = new DemonstratorApp.BO.CommercialAgreement
            {
                ProductCategory = "CommercialAgreement_ProductCategory",
                PaymentTerms = "CommercialAgreement_PaymentTerms",
            };
            var _agreement_agreements_supplier = new DemonstratorApp.BO.Agreement
            {
                StartDate = now,
                EndDate = now,
                FundedRate = 222222.22M,
                FundedAmount = 222222.22M,
                CurrentAgreementStatus = "Agreement_CurrentAgreementStatus",
                InterestRate = 222222.22M,
            };
            var _agreement_agreements_supplier2 = new DemonstratorApp.BO.Agreement
            {
                StartDate = now,
                EndDate = now,
                FundedRate = 222222.22M,
                FundedAmount = 222222.22M,
                CurrentAgreementStatus = "Agreement_CurrentAgreementStatus",
                InterestRate = 222222.22M,
            };
            var _supplier_supplierbusinessstructuredata_supplier = new DemonstratorApp.BO.SupplierBusinessStructureData
            {
                NumOfCustomersD = 4914,
                NumOfCustomersAbroad = 5582,
                NumOfCustomersEU = 2745,
                NumOfCustomers = 2147,
                ThereofActiveD = 5375,
                ThereofActiveAbroad = 7951,
                ThereofActiveEU = 9551,
                ThereofActive = 7318,
                NumOfOccasionalCustD = 3581,
                NumOfOccasionalCustAbroad = 5004,
                NumOfOccasionalCustEU = 9852,
                NumOfOccasionalCust = 7663,
                NumOpenBalanceD = 4549,
                NumOpenBalanceAboad = 6358,
                NumOpenBalanceEU = 9417,
                NumOpenBalance = 6794,
                NumOfInvoicesD = 7046,
                NumOfInvoicesAbroad = 7875,
                NumOfInvoicesEU = 3299,
                NumOfInvoices = 1556,
                NumOfEmployeesD = 869,
                NumOfEmployeesAbroad = 5974,
                NumTransCustD = 9967,
                NumTransCustAbroad = 4349,
                NumTransCustEU = 276,
                NumTransCust = 139,
                ApplicableCommercialLaw = "SupplierBusinessStructureData_ApplicableCommercialLaw",
                Jurisdiction = "SupplierBusinessStructureData_Jurisdiction",
            };
            var _supplier_supplierreceivables_supplier = new DemonstratorApp.BO.SupplierReceivables
            {
                DomesticCustomersPresent = 2222222222.22222M,
                DomesticCustomersPrior = 2222222222.22222M,
                EUCustomersPresent = 2222222222.22222M,
                EUCustomersPrior = 2222222222.22222M,
                ThirdCountryCustomersPresent = 2222222222.22222M,
                ThirdCountryCustomersPrior = 2222222222.22222M,
                WillUploadFiles = true,
                TotalPrior = 2222222222.22222M,
                TotalPresent = 2222222222.22222M,
            };
            var _supplier_suppliercontactinformation_supplier = new DemonstratorApp.BO.SupplierContactInformation
            {
                ContactPerson = "SupplierContactInformation_ContactPerson",
                AddressOne = "SupplierContactInformation_AddressOne",
                AddressTwo = "SupplierContactInformation_AddressTwo",
                Telephone = "SupplierContactInformation_Telephone",
                Email = "SupplierContactInformation_Email",
                ManagingDirector = "SupplierContactInformation_ManagingDirector",
                EstablishedIn = "SupplierContactInformation_EstablishedIn",
            };
            var _supplier_supplierturnover_supplier = new DemonstratorApp.BO.SupplierTurnover
            {
                PlannedCurrentYear = 2222222222.22222M,
                PlannedCurrentYearD = 2222222222.22222M,
                PlannedCurrentYearEU = 2222222222.22222M,
                PlannedCurrentYearAbroad = 2222222222.22222M,
                PlannedNextYear = 2222222222.22222M,
                PlannedNextYearD = 2222222222.22222M,
                PlannedNextYearEU = 2222222222.22222M,
                PlannedNextYearAbroad = 2222222222.22222M,
                ActualPreviousYear = 2222222222.22222M,
                ActualPreviousYearAbroad = 2222222222.22222M,
                ActualPreviousYearD = 2222222222.22222M,
                ActualPreviousYearEU = 2222222222.22222M,
                PercentageD = 2222222222.22222M,
                PercentageEU = 2222222222.22222M,
                PercentageAbroad = 2222222222.22222M,
                PercentageCND = 2222222222.22222M,
                PercentageCNEU = 2222222222.22222M,
                PercentageCNAbroad = 2222222222.22222M,
                PercentageSales = 2222222222.22222M,
                PercentageCN = 2222222222.22222M,
            };
            var _supplier_supplierextrainformation_supplier = new DemonstratorApp.BO.SupplierExtraInformation
            {
                OccurenceBadDebts = "SupplierExtraInformation_OccurenceBadDebts",
                ExistenceCounterClaims = "SupplierExtraInformation_ExistenceCounterClaims",
                HasCompanyAssigned = "SupplierExtraInformation_HasCompanyAssigned",
                AreCompanyReceivables = "SupplierExtraInformation_AreCompanyReceivables",
            };
            var _supplier_financialstatements_supplier = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_financialstatements_supplier2 = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_economicevaluations_supplier2 = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_economicevaluations_supplier22 = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_businessplans_supplier = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_businessplans_supplier2 = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_prioroutstandingbalances_supplier = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_prioroutstandingbalances_supplier2 = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_outstandingbalances_supplier = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_outstandingbalances_supplier2 = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_currentsituations_supplier = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_currentsituations_supplier2 = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_currentstatements_supplier = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_currentstatements_supplier2 = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_currentcredits_supplier = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_currentcredits_supplier2 = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_factoringagreements_supplier = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_factoringagreements_supplier2 = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_customeragreements_supplier = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_customeragreements_supplier2 = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_generalconstractuals_supplier = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_generalconstractuals_supplier2 = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_organizationalcharts_supplier = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_organizationalcharts_supplier2 = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_invoicesforms_supplier = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_invoicesforms_supplier2 = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_declarations_supplier = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_declarations_supplier2 = new DemonstratorApp.BO.SupplierUploads
            {
                Path = "SupplierUploads_Path",
            };
            var _supplier_supplierevaluation_supplier = new DemonstratorApp.BO.SupplierEvaluation
            {
                Environment = "SupplierEvaluation_Environment",
                ContractualPaymentTerms = 2222222222.22222M,
                Average = 2222222222.22222M,
                AverageInvoiceValue = 2222222222.22222M,
                EquityRatio = 2222222222.22222M,
            };
            var _supplier_dataquality_supplier = new DemonstratorApp.BO.DataQuality
            {
                Orders = true,
                DeliveryNotes = true,
                CustomsDocuments = true,
                IntermediaryLogistics = true,
                Invoices = true,
                PoDs = true,
                PaymentData = true,
            };
            var _supplier_dataavailability_supplier = new DemonstratorApp.BO.DataAvailability
            {
                Orders = true,
                DeliveryNotes = true,
                CustomsDocuments = true,
                IntermediaryLogistics = true,
                Invoices = true,
                PoDs = true,
                PaymentData = true,
            };
            var _supplierproduct_supplierproducts_supplier = new DemonstratorApp.BO.SupplierProduct
            {
                Code = "SupplierProduct_Code",
                Description = "SupplierProduct_Description",
                UnitValue = "SupplierProduct_UnitValue",
                MeasurementUnit = "SupplierProduct_MeasurementUnit",
                Price = 222222.22M,
            };
            var _supplierproduct_supplierproducts_supplier2 = new DemonstratorApp.BO.SupplierProduct
            {
                Code = "SupplierProduct_Code",
                Description = "SupplierProduct_Description",
                UnitValue = "SupplierProduct_UnitValue",
                MeasurementUnit = "SupplierProduct_MeasurementUnit",
                Price = 222222.22M,
            };
            var _transaction_transactions_supplier = new DemonstratorApp.BO.Transaction
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
            var _transaction_transactions_supplier2 = new DemonstratorApp.BO.Transaction
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
            new PersistenceSpecification<DemonstratorApp.BO.Supplier>(Session)
            .CheckProperty(p => p.SupplierId, 1197)
            .CheckProperty(p => p.Company, "Supplier_Company")
            .CheckProperty(p => p.CompanyLogo, "Supplier_CompanyLogo")
            .CheckProperty(p => p.Business, "Supplier_Business")
            .CheckProperty(p => p.CurrentAmount, "Supplier_CurrentAmount")
            .CheckProperty(p => p.AverageAmount, "Supplier_AverageAmount")
            .CheckProperty(p => p.PercentageOfCreditNotes, "Supplier_PercentageOfCreditNotes")
            .CheckProperty(p => p.PrimaryPhone, "Supplier_PrimaryPhone")
            .CheckProperty(p => p.SecondaryPhone, "Supplier_SecondaryPhone")
            .CheckProperty(p => p.Fax, "Supplier_Fax")
            .CheckProperty(p => p.WebSite, "Supplier_WebSite")
            .CheckProperty(p => p.AcceptedPolicyTerms, true)
            .CheckProperty(p => p.SupplierStatus, "Supplier_SupplierStatus")
            .CheckProperty(p => p.DomainFocus, "Supplier_DomainFocus")
            .CheckProperty(p => p.EvaluationResult, "Supplier_EvaluationResult")
            .CheckProperty(p => p.EvaluationCountResult, 116)
            .CheckProperty(p => p.AnnualTurnover, true)
            .CheckProperty(p => p.BEnvironment, true)
            .CheckProperty(p => p.PTerms, true)
            .CheckProperty(p => p.Average, true)
            .CheckProperty(p => p.InvoiceValue, true)
            .CheckProperty(p => p.EqRatio, true)
            .CheckProperty(p => p.Prefix, "Supplier_Prefix")
            .CheckProperty(p => p.VATNumber, "Supplier_VATNumber")
            .CheckProperty(p => p.MarketSegment, "Supplier_MarketSegment")
            .CheckProperty(p => p.AdditionalComments, "Supplier_AdditionalComments")
            .CheckProperty(p => p.AdditionalCommentsStep2, "Supplier_AdditionalCommentsStep2")
            .CheckProperty(p => p.AdditionalCommentsStep3, "Supplier_AdditionalCommentsStep3")
            .CheckProperty(p => p.UserName, "8f7dfdb1-6492-427f-b3fe-cab5ae451e4bSupplier_UserName")
            .CheckProperty(p => p.PasswordHash, "Supplier_PasswordHash")
            .CheckProperty(p => p.SecurityStamp, "Supplier_SecurityStamp")
            .CheckProperty(p => p.EmailConfirmed, true)
            .CheckProperty(p => p.LockoutEnabled, true)
            .CheckProperty(p => p.PhoneNumberConfirmed, true)
            .CheckProperty(p => p.TwoFactorEnabled, true)
            .CheckProperty(p => p.AccessFailedCount, 2338)
            .CheckProperty(p => p.Name, "Supplier_Name")
            .CheckProperty(p => p.Email, "Supplier_Email")
            .CheckProperty(p => p.PhoneNumber, "Supplier_PhoneNumber")
            .CheckProperty(p => p.LockoutEndDate, now)
            .CheckBag(p => p.CommercialAgreements, (new List<DemonstratorApp.BO.CommercialAgreement>
            {
                _agreement_commercialagreements_supplier,
                _agreement_commercialagreements_supplier2
            }))
            .CheckBag(p => p.Agreements, (new List<DemonstratorApp.BO.Agreement>
            {
                _agreement_agreements_supplier,
                _agreement_agreements_supplier2
            }))
            .CheckReference(p => p.SupplierBusinessStructureData, _supplier_supplierbusinessstructuredata_supplier)
            .CheckReference(p => p.SupplierReceivables, _supplier_supplierreceivables_supplier)
            .CheckReference(p => p.SupplierContactInformation, _supplier_suppliercontactinformation_supplier)
            .CheckReference(p => p.SupplierTurnover, _supplier_supplierturnover_supplier)
            .CheckReference(p => p.SupplierExtraInformation, _supplier_supplierextrainformation_supplier)
            .CheckBag(p => p.FinancialStatements, (new List<DemonstratorApp.BO.SupplierUploads>
            {
                _supplier_financialstatements_supplier,
                _supplier_financialstatements_supplier2
            }))
            .CheckBag(p => p.EconomicEvaluations, (new List<DemonstratorApp.BO.SupplierUploads>
            {
                _supplier_economicevaluations_supplier2,
                _supplier_economicevaluations_supplier22
            }))
            .CheckBag(p => p.BusinessPlans, (new List<DemonstratorApp.BO.SupplierUploads>
            {
                _supplier_businessplans_supplier,
                _supplier_businessplans_supplier2
            }))
            .CheckBag(p => p.PriorOutstandingBalances, (new List<DemonstratorApp.BO.SupplierUploads>
            {
                _supplier_prioroutstandingbalances_supplier,
                _supplier_prioroutstandingbalances_supplier2
            }))
            .CheckBag(p => p.OutstandingBalances, (new List<DemonstratorApp.BO.SupplierUploads>
            {
                _supplier_outstandingbalances_supplier,
                _supplier_outstandingbalances_supplier2
            }))
            .CheckBag(p => p.CurrentSituations, (new List<DemonstratorApp.BO.SupplierUploads>
            {
                _supplier_currentsituations_supplier,
                _supplier_currentsituations_supplier2
            }))
            .CheckBag(p => p.CurrentStatements, (new List<DemonstratorApp.BO.SupplierUploads>
            {
                _supplier_currentstatements_supplier,
                _supplier_currentstatements_supplier2
            }))
            .CheckBag(p => p.CurrentCredits, (new List<DemonstratorApp.BO.SupplierUploads>
            {
                _supplier_currentcredits_supplier,
                _supplier_currentcredits_supplier2
            }))
            .CheckBag(p => p.FactoringAgreements, (new List<DemonstratorApp.BO.SupplierUploads>
            {
                _supplier_factoringagreements_supplier,
                _supplier_factoringagreements_supplier2
            }))
            .CheckBag(p => p.CustomerAgreements, (new List<DemonstratorApp.BO.SupplierUploads>
            {
                _supplier_customeragreements_supplier,
                _supplier_customeragreements_supplier2
            }))
            .CheckBag(p => p.GeneralConstractuals, (new List<DemonstratorApp.BO.SupplierUploads>
            {
                _supplier_generalconstractuals_supplier,
                _supplier_generalconstractuals_supplier2
            }))
            .CheckBag(p => p.OrganizationalCharts, (new List<DemonstratorApp.BO.SupplierUploads>
            {
                _supplier_organizationalcharts_supplier,
                _supplier_organizationalcharts_supplier2
            }))
            .CheckBag(p => p.InvoicesForms, (new List<DemonstratorApp.BO.SupplierUploads>
            {
                _supplier_invoicesforms_supplier,
                _supplier_invoicesforms_supplier2
            }))
            .CheckBag(p => p.Declarations, (new List<DemonstratorApp.BO.SupplierUploads>
            {
                _supplier_declarations_supplier,
                _supplier_declarations_supplier2
            }))
            .CheckReference(p => p.SupplierEvaluation, _supplier_supplierevaluation_supplier)
            .CheckReference(p => p.DataQuality, _supplier_dataquality_supplier)
            .CheckReference(p => p.DataAvailability, _supplier_dataavailability_supplier)
            .CheckBag(p => p.SupplierProducts, (new List<DemonstratorApp.BO.SupplierProduct>
            {
                _supplierproduct_supplierproducts_supplier,
                _supplierproduct_supplierproducts_supplier2
            }))
            .CheckBag(p => p.Transactions, (new List<DemonstratorApp.BO.Transaction>
            {
                _transaction_transactions_supplier,
                _transaction_transactions_supplier2
            }))
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Supplier`")]
        [Order(1)]
        public void Supplier_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DemonstratorApp.BO.Supplier> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DemonstratorApp.BO.Supplier>(
                              a => true
                              && (a.SupplierId + 123 > 0)
                              && (a.Company != string.Empty && a.Company != null)
                              && (a.CompanyLogo != string.Empty && a.CompanyLogo != null)
                              && (a.Business != string.Empty && a.Business != null)
                              && (a.CurrentAmount != string.Empty && a.CurrentAmount != null)
                              && (a.AverageAmount != string.Empty && a.AverageAmount != null)
                              && (a.PercentageOfCreditNotes != string.Empty && a.PercentageOfCreditNotes != null)
                              && (a.PrimaryPhone != string.Empty && a.PrimaryPhone != null)
                              && (a.SecondaryPhone != string.Empty && a.SecondaryPhone != null)
                              && (a.Fax != string.Empty && a.Fax != null)
                              && (a.WebSite != string.Empty && a.WebSite != null)
                              && !a.AcceptedPolicyTerms
                              && (a.SupplierStatus != string.Empty && a.SupplierStatus != null)
                              && (a.DomainFocus != string.Empty && a.DomainFocus != null)
                              && (a.EvaluationResult != string.Empty && a.EvaluationResult != null)
                              && (a.EvaluationCountResult + 123 > 0)
                              && !a.AnnualTurnover
                              && !a.BEnvironment
                              && !a.PTerms
                              && !a.Average
                              && !a.InvoiceValue
                              && !a.EqRatio
                              && (a.Prefix != string.Empty && a.Prefix != null)
                              && (a.VATNumber != string.Empty && a.VATNumber != null)
                              && (a.MarketSegment != string.Empty && a.MarketSegment != null)
                              && (a.AdditionalComments != string.Empty && a.AdditionalComments != null)
                              && (a.AdditionalCommentsStep2 != string.Empty && a.AdditionalCommentsStep2 != null)
                              && (a.AdditionalCommentsStep3 != string.Empty && a.AdditionalCommentsStep3 != null)
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
                              && a.Agreements.Any()
                              && a.SupplierBusinessStructureData != null
                              && a.SupplierReceivables != null
                              && a.SupplierContactInformation != null
                              && a.SupplierTurnover != null
                              && a.SupplierExtraInformation != null
                              && a.FinancialStatements.Any()
                              && a.EconomicEvaluations.Any()
                              && a.BusinessPlans.Any()
                              && a.PriorOutstandingBalances.Any()
                              && a.OutstandingBalances.Any()
                              && a.CurrentSituations.Any()
                              && a.CurrentStatements.Any()
                              && a.CurrentCredits.Any()
                              && a.FactoringAgreements.Any()
                              && a.CustomerAgreements.Any()
                              && a.GeneralConstractuals.Any()
                              && a.OrganizationalCharts.Any()
                              && a.InvoicesForms.Any()
                              && a.Declarations.Any()
                              && a.SupplierEvaluation != null
                              && a.DataQuality != null
                              && a.DataAvailability != null
                              && a.SupplierProducts.Any()
                              && a.Transactions.Any()
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