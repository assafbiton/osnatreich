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
	/// <summary>contactUs</summary>
	[PublishedModel("contactUs")]
	public partial class ContactUs : PublishedContentModel, ISeoConfig
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const string ModelTypeAlias = "contactUs";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactUs, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ContactUs(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// תוכן הדף: תוכן הדף
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("pageContent")]
		public IHtmlString PageContent => this.Value<IHtmlString>("pageContent");

		///<summary>
		/// תיאור קצר: תיאור קצר
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("pageShortDescription")]
		public string PageShortDescription => this.Value<string>("pageShortDescription");

		///<summary>
		/// כותרת הדף: כותרת הדף
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => this.Value<string>("pageTitle");

		///<summary>
		/// IndexNoFollow: IndexNoFollow
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("indexNoFollow")]
		public bool IndexNoFollow => SeoConfig.GetIndexNoFollow(this);

		///<summary>
		/// מילות מפתח: מילות מפתח
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("seoKeyWords")]
		public IEnumerable<string> SeoKeyWords => SeoConfig.GetSeoKeyWords(this);

		///<summary>
		/// תיאור דף עבור מנועי החיפוש: תיאור דף עבור מנועי החיפוש
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("seoPageDescription")]
		public string SeoPageDescription => SeoConfig.GetSeoPageDescription(this);

		///<summary>
		/// כותרת קידום: כותרת קידום
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("seoPageTitle")]
		public string SeoPageTitle => SeoConfig.GetSeoPageTitle(this);
	}
}
