
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Collections;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Configuration;
using zAppDev.DotNet.Framework.Data.Domain;

using DemonstratorApp.DAL;

namespace DemonstratorApp.BO
{
	/// <summary>
	/// The Invoice extensions
	/// </summary>
	public static class InvoiceExtensions
	{
        public static System.Collections.Generic.List<DemonstratorApp.BO.Invoice> FindAgreement(){using (new zAppDev.DotNet.Framework.Profiling.Profiler("Invoice", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "FindAgreement")) {
string userName = "";
System.Collections.Generic.List<DemonstratorApp.BO.Agreement> agreements = new DemonstratorApp.DAL.Repository().Get<DemonstratorApp.BO.Agreement>((a) => a.Investor.UserName == zAppDev.DotNet.Framework.Identity.IdentityHelper.GetCurrentApplicationUser().UserName);
System.Collections.Generic.List<DemonstratorApp.BO.Invoice> foundInvoices = new System.Collections.Generic.List<DemonstratorApp.BO.Invoice>();
foreach (var agr in agreements ?? Enumerable.Empty<DemonstratorApp.BO.Agreement>()) {
userName = (agr?.Supplier?.UserName ?? "");foreach (var invoice in new DemonstratorApp.DAL.Repository().Get<DemonstratorApp.BO.Invoice>((o) => o.Transaction.Supplier.UserName == userName) ?? Enumerable.Empty<DemonstratorApp.BO.Invoice>()) {
foundInvoices?.Add(invoice);
}
}
return foundInvoices;
}
}



        
	}
}
