
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
	/// The Supplier extensions
	/// </summary>
	public static class SupplierExtensions
	{
        public static bool IsSupplier(this BO.Supplier @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("Supplier", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "IsSupplier")) {
if (((@this?.IsInRole("GuestSupplier") ?? false) || (@this?.IsInRole("PendingRegistered") ?? false) || (@this?.IsInRole("RegisteredSupplier") ?? false) || (@this?.IsInRole("PendingValidated") ?? false) || (@this?.IsInRole("ValidatedSupplier") ?? false) || (@this?.IsInRole("ActiveSupplier") ?? false))) {
return true;
}
return false;
}
}



        
	}
}
