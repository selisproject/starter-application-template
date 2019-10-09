
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
	/// The Investor extensions
	/// </summary>
	public static class InvestorExtensions
	{
        public static System.Collections.Generic.List<string> GetDomainFocusOptions(DemonstratorApp.BO.Investor inv){using (new zAppDev.DotNet.Framework.Profiling.Profiler("Investor", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetDomainFocusOptions")) {
System.Collections.Generic.List<string> options = new System.Collections.Generic.List<string>();
options.Add("Recurring");
options.Add("Project-based");
options.Add("Other");
if ((((options.Contains((inv?.DomainFocus ?? ""))) == false) && inv?.DomainFocus != null)) {
options.Add((inv?.DomainFocus ?? ""));
}
return options;
}
}


public static bool IsInvestor(this BO.Investor @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("Investor", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "IsInvestor")) {
return (zAppDev.DotNet.Framework.Identity.IdentityHelper.GetCurrentApplicationUser()?.IsInRole("Investor") ?? false);
}
}



        
	}
}
