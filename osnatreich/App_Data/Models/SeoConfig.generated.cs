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
	// Mixin Content Type with alias "seoConfig"
	/// <summary>קידום הדף במנועי החיפוש</summary>
	public partial interface ISeoConfig : IPublishedContent
	{
		/// <summary>IndexNoFollow</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		bool IndexNoFollow { get; }

		/// <summary>מילות מפתח</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IEnumerable<string> SeoKeyWords { get; }

		/// <summary>תיאור דף עבור מנועי החיפוש</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		string SeoPageDescription { get; }

		/// <summary>כותרת קידום</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		string SeoPageTitle { get; }
	}

	/// <summary>קידום הדף במנועי החיפוש</summary>
	[PublishedModel("seoConfig")]
	public partial class SeoConfig : PublishedContentModel, ISeoConfig
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const string ModelTypeAlias = "seoConfig";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SeoConfig, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public SeoConfig(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// IndexNoFollow: IndexNoFollow
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("indexNoFollow")]
		public bool IndexNoFollow => GetIndexNoFollow(this);

		/// <summary>Static getter for IndexNoFollow</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static bool GetIndexNoFollow(ISeoConfig that) => that.Value<bool>("indexNoFollow");

		///<summary>
		/// מילות מפתח: מילות מפתח
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("seoKeyWords")]
		public IEnumerable<string> SeoKeyWords => GetSeoKeyWords(this);

		/// <summary>Static getter for מילות מפתח</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IEnumerable<string> GetSeoKeyWords(ISeoConfig that) => that.Value<IEnumerable<string>>("seoKeyWords");

		///<summary>
		/// תיאור דף עבור מנועי החיפוש: תיאור דף עבור מנועי החיפוש
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("seoPageDescription")]
		public string SeoPageDescription => GetSeoPageDescription(this);

		/// <summary>Static getter for תיאור דף עבור מנועי החיפוש</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static string GetSeoPageDescription(ISeoConfig that) => that.Value<string>("seoPageDescription");

		///<summary>
		/// כותרת קידום: כותרת קידום
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("seoPageTitle")]
		public string SeoPageTitle => GetSeoPageTitle(this);

		/// <summary>Static getter for כותרת קידום</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static string GetSeoPageTitle(ISeoConfig that) => that.Value<string>("seoPageTitle");
	}
}