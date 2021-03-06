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
	/// <summary>תוכן כללי</summary>
	[PublishedModel("globalSettings")]
	public partial class GlobalSettings : PublishedContentModel, ISocialIcons
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const string ModelTypeAlias = "globalSettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<GlobalSettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public GlobalSettings(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// שעות פתיחה: שעות פתיחה
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("openingHour")]
		public string OpeningHour => this.Value<string>("openingHour");

		///<summary>
		/// shortAboutDescription: אודות מקוצר
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("shortAboutDescription")]
		public string ShortAboutDescription => this.Value<string>("shortAboutDescription");

		///<summary>
		/// כתובת העסק: כתובת העסק
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("siteAddress")]
		public string SiteAddress => this.Value<string>("siteAddress");

		///<summary>
		/// נייד: נייד
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("siteCellPhone")]
		public string SiteCellPhone => this.Value<string>("siteCellPhone");

		///<summary>
		/// כתובת דואר אלקטרוני: כתובת דואר אלקטרוני
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("siteEmail")]
		public string SiteEmail => this.Value<string>("siteEmail");

		///<summary>
		/// לוגו אתר: לוגו אתר
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("siteLogo")]
		public IPublishedContent SiteLogo => this.Value<IPublishedContent>("siteLogo");

		///<summary>
		/// טלפון: טלפון
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("sitePhone")]
		public string SitePhone => this.Value<string>("sitePhone");

		///<summary>
		/// כותרת אתר: כותרת אתר
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("siteTitle")]
		public string SiteTitle => this.Value<string>("siteTitle");

		///<summary>
		/// קישור: קישור
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("iconUrl")]
		public Umbraco.Web.Models.Link IconUrl => SocialIcons.GetIconUrl(this);

		///<summary>
		/// סמל חברתי: סמל חברתי
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("socialIcon")]
		public object SocialIcon => SocialIcons.GetSocialIcon(this);
	}
}
