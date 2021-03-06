﻿///////////////////////////////////////////////////////////////////////////////
//
// (C) 2018 ICE TEA GROUP LLC - ALL RIGHTS RESERVED
//
// 
//
// ALL INFORMATION CONTAINED HEREIN IS, AND REMAINS
// THE PROPERTY OF ICE TEA GROUP LLC AND ITS SUPPLIERS, IF ANY.
// THE INTELLECTUAL PROPERTY AND TECHNICAL CONCEPTS CONTAINED
// HEREIN ARE PROPRIETARY TO ICE TEA GROUP LLC AND ITS SUPPLIERS
// AND MAY BE COVERED BY U.S. AND FOREIGN PATENTS, PATENT IN PROCESS, AND
// ARE PROTECTED BY TRADE SECRET OR COPYRIGHT LAW.
//
// DISSEMINATION OF THIS INFORMATION OR REPRODUCTION OF THIS MATERIAL
// IS STRICTLY FORBIDDEN UNLESS PRIOR WRITTEN PERMISSION IS OBTAINED
// FROM ICE TEA GROUP LLC.
//
///////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisej.Web.Ext.Navigator
{
	/// <summary>
	/// Determines how the <see cref="Navigator"/> manages the views
	/// when loading (navigating to) and unloading (navigating away).
	/// </summary>
	public enum NavigatorViewMode
	{
		/// <summary>
		/// The view is disposed when unloaded.
		/// </summary>
		Dispose,

		/// <summary>
		/// The view is not disposed when unloaded, but it will
		/// be disposed by the GC unless it's reused before the GC kicks in.
		/// </summary>
		Collect,

		/// <summary>
		/// The view is not disposed when unloaded, it is hidden
		/// and then shown again when reused.
		/// </summary>
		Persist,
	}
}
