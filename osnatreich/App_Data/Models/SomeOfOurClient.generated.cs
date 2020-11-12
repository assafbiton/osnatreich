//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.6
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "someOfOurClient"
	/// <summary>SomeOfOurClients</summary>
	public partial interface ISomeOfOurClient : IPublishedContent
	{
		/// <summary>לקוח</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IEnumerable<SomeOfOurClients> CustomerItem { get; }

		/// <summary>customersTitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		string CustomersTitle { get; }

		/// <summary>האם רכיב פעיל</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		bool IsCustomerActive { get; }
	}

	/// <summary>SomeOfOurClients</summary>
	[PublishedModel("someOfOurClient")]
	public partial class SomeOfOurClient : PublishedContentModel, ISomeOfOurClient
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const string ModelTypeAlias = "someOfOurClient";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SomeOfOurClient, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public SomeOfOurClient(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// לקוח: לקוח
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("customerItem")]
		public IEnumerable<SomeOfOurClients> CustomerItem => GetCustomerItem(this);

		/// <summary>Static getter for לקוח</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IEnumerable<SomeOfOurClients> GetCustomerItem(ISomeOfOurClient that) => that.Value<IEnumerable<SomeOfOurClients>>("customerItem");

		///<summary>
		/// customersTitle: כותרת הרכיב
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("customersTitle")]
		public string CustomersTitle => GetCustomersTitle(this);

		/// <summary>Static getter for customersTitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static string GetCustomersTitle(ISomeOfOurClient that) => that.Value<string>("customersTitle");

		///<summary>
		/// האם רכיב פעיל: האם רכיב פעיל
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("isCustomerActive")]
		public bool IsCustomerActive => GetIsCustomerActive(this);

		/// <summary>Static getter for האם רכיב פעיל</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static bool GetIsCustomerActive(ISomeOfOurClient that) => that.Value<bool>("isCustomerActive");
	}
}