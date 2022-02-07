﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderCloud.Catalyst
{
	/// <summary>
	/// An interface to define tax categorization for products. Meant to be used as part of product create and edit.
	/// </summary>
	public interface ITaxCodesProvider
	{
		/// <summary>
		/// List the various tax categories a product could fall under
		/// </summary>
		Task<TaxCategorizationResponse> ListTaxCodesAsync(string filterTerm);
	}

	public class TaxCategorizationResponse
	{
		public List<TaxCategorization> Categories { get; set; }
	}

	/// <summary>
	/// A Tax categorization for a product 
	/// </summary>
	public class TaxCategorization
	{
		/// <summary>
		/// A code that represents this categorization
		/// </summary>
		public string Code { get; set; }
		/// <summary>
		/// A reasonable short name for this categorization
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// A full description for this categorization
		/// </summary>
		public string LongDescription { get; set; }
	}
}
