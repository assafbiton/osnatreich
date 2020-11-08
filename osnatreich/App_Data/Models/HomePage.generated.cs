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
	/// <summary>דף הבית</summary>
	[PublishedModel("homePage")]
	public partial class HomePage : PublishedContentModel, IHpWellcom, ISeoConfig, ISwiperSlider
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const string ModelTypeAlias = "homePage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HomePage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public HomePage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// swiper-slider: באנר מתחלף
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("swiperSlider")]
		public IEnumerable<SwiperSlider> SwiperSlider => this.Value<IEnumerable<SwiperSlider>>("swiperSlider");

		///<summary>
		/// Welcome Text: Welcome Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("welcomeText")]
		public IHtmlString WelcomeText => HpWellcom.GetWelcomeText(this);

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

		///<summary>
		/// תמונת רקע: תמונת רקע
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("backgroundImage")]
		public IPublishedContent BackgroundImage => SwiperSlider.GetBackgroundImage(this);

		///<summary>
		/// טקסט הבאנר: טקסט הבאנר
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("textDescription")]
		public IHtmlString TextDescription => SwiperSlider.GetTextDescription(this);

		///<summary>
		/// כותרת באנר: כותרת באנר
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("title")]
		public string Title => SwiperSlider.GetTitle(this);
	}
}