





#pragma warning disable 1591
#pragma warning disable 0108
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Team Development for Sitecore.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;   
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Fields;
using Sitecore.Globalization;
using Sitecore.Data;



namespace SitecoreCookbook.Models
{

	public partial interface IGlassBase{
		
		[SitecoreId]
		Guid Id{ get; }

		[SitecoreInfo(SitecoreInfoType.Language)]
        Language Language{ get; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; }

	}

	public abstract partial class GlassBase : IGlassBase{
		
		[SitecoreId]
		public virtual Guid Id{ get; private set;}

		[SitecoreInfo(SitecoreInfoType.Language)]
        public virtual Language Language{ get; private set; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual int Version { get; private set; }

		[SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; private set; }
	}
}
namespace SitecoreCookbook.Models.sitecore.templates.Coobook
{


 	/// <summary>
	/// IProduct Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/Coobook/Product</para>	
	/// <para>ID: 37fd9fe2-0d7e-4c1e-a95e-00e826e9c33c</para>	
	/// </summary>
	[SitecoreType(TemplateId=IProductConstants.TemplateIdString )] //, Cachable = true
	public partial interface IProduct : IGlassBase , global::SitecoreCookbook.Models.sitecore.templates.Coobook.ICommon_Fields
	{
				}


	public static partial class IProductConstants{

			public const string TemplateIdString = "37fd9fe2-0d7e-4c1e-a95e-00e826e9c33c";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Product";

					
			public static readonly ID BodyFieldId = new ID("7d46c7ed-592f-4662-be46-8f5ca6a44169");
			public const string BodyFieldName = "Body";
			
					
			public static readonly ID IconFieldId = new ID("71b1622e-df88-4729-9fa6-15de6b86f188");
			public const string IconFieldName = "Icon";
			
					
			public static readonly ID ImageFieldId = new ID("3df9f188-0867-4532-88a1-91d20a730dc2");
			public const string ImageFieldName = "Image";
			
					
			public static readonly ID Show_In_MenuFieldId = new ID("e1d13655-25dd-41fe-8862-5e0a658df842");
			public const string Show_In_MenuFieldName = "Show in Menu";
			
					
			public static readonly ID TitleFieldId = new ID("e01393fd-a257-4c2c-af19-6276046136ce");
			public const string TitleFieldName = "Title";
			
			

	}

	
	/// <summary>
	/// Product
	/// <para></para>
	/// <para>Path: /sitecore/templates/Coobook/Product</para>	
	/// <para>ID: 37fd9fe2-0d7e-4c1e-a95e-00e826e9c33c</para>	
	/// </summary>
	[SitecoreType(TemplateId=IProductConstants.TemplateIdString)] //, Cachable = true
	public partial class Product  : GlassBase, IProduct 
	{
	   
						/// <summary>
				/// The Body field.
				/// <para></para>
				/// <para>Field Type: Rich Text</para>		
				/// <para>Field ID: 7d46c7ed-592f-4662-be46-8f5ca6a44169</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IProductConstants.BodyFieldName)]
				public virtual string Body  {get; set;}
					
						/// <summary>
				/// The Icon field.
				/// <para></para>
				/// <para>Field Type: Icon</para>		
				/// <para>Field ID: 71b1622e-df88-4729-9fa6-15de6b86f188</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IProductConstants.IconFieldName)]
				public virtual string Icon  {get; set;}
					
						/// <summary>
				/// The Image field.
				/// <para></para>
				/// <para>Field Type: Image</para>		
				/// <para>Field ID: 3df9f188-0867-4532-88a1-91d20a730dc2</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IProductConstants.ImageFieldName)]
				public virtual Image Image  {get; set;}
					
						/// <summary>
				/// The Show in Menu field.
				/// <para></para>
				/// <para>Field Type: Checkbox</para>		
				/// <para>Field ID: e1d13655-25dd-41fe-8862-5e0a658df842</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IProductConstants.Show_In_MenuFieldName)]
				public virtual bool Show_In_Menu  {get; set;}
					
						/// <summary>
				/// The Title field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: e01393fd-a257-4c2c-af19-6276046136ce</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IProductConstants.TitleFieldName)]
				public virtual string Title  {get; set;}
					
			
	}
}
namespace SitecoreCookbook.Models.sitecore.templates.Coobook
{


 	/// <summary>
	/// IProduct_Section Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/Coobook/Product Section</para>	
	/// <para>ID: 6f6d5e5f-430d-4d03-b2a9-10d091435a1d</para>	
	/// </summary>
	[SitecoreType(TemplateId=IProduct_SectionConstants.TemplateIdString )] //, Cachable = true
	public partial interface IProduct_Section : IGlassBase , global::SitecoreCookbook.Models.sitecore.templates.Coobook.ICommon_Fields
	{
				}


	public static partial class IProduct_SectionConstants{

			public const string TemplateIdString = "6f6d5e5f-430d-4d03-b2a9-10d091435a1d";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Product Section";

					
			public static readonly ID BodyFieldId = new ID("7d46c7ed-592f-4662-be46-8f5ca6a44169");
			public const string BodyFieldName = "Body";
			
					
			public static readonly ID IconFieldId = new ID("71b1622e-df88-4729-9fa6-15de6b86f188");
			public const string IconFieldName = "Icon";
			
					
			public static readonly ID ImageFieldId = new ID("3df9f188-0867-4532-88a1-91d20a730dc2");
			public const string ImageFieldName = "Image";
			
					
			public static readonly ID Show_In_MenuFieldId = new ID("e1d13655-25dd-41fe-8862-5e0a658df842");
			public const string Show_In_MenuFieldName = "Show in Menu";
			
					
			public static readonly ID TitleFieldId = new ID("e01393fd-a257-4c2c-af19-6276046136ce");
			public const string TitleFieldName = "Title";
			
			

	}

	
	/// <summary>
	/// Product_Section
	/// <para></para>
	/// <para>Path: /sitecore/templates/Coobook/Product Section</para>	
	/// <para>ID: 6f6d5e5f-430d-4d03-b2a9-10d091435a1d</para>	
	/// </summary>
	[SitecoreType(TemplateId=IProduct_SectionConstants.TemplateIdString)] //, Cachable = true
	public partial class Product_Section  : GlassBase, IProduct_Section 
	{
	   
						/// <summary>
				/// The Body field.
				/// <para></para>
				/// <para>Field Type: Rich Text</para>		
				/// <para>Field ID: 7d46c7ed-592f-4662-be46-8f5ca6a44169</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IProduct_SectionConstants.BodyFieldName)]
				public virtual string Body  {get; set;}
					
						/// <summary>
				/// The Icon field.
				/// <para></para>
				/// <para>Field Type: Icon</para>		
				/// <para>Field ID: 71b1622e-df88-4729-9fa6-15de6b86f188</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IProduct_SectionConstants.IconFieldName)]
				public virtual string Icon  {get; set;}
					
						/// <summary>
				/// The Image field.
				/// <para></para>
				/// <para>Field Type: Image</para>		
				/// <para>Field ID: 3df9f188-0867-4532-88a1-91d20a730dc2</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IProduct_SectionConstants.ImageFieldName)]
				public virtual Image Image  {get; set;}
					
						/// <summary>
				/// The Show in Menu field.
				/// <para></para>
				/// <para>Field Type: Checkbox</para>		
				/// <para>Field ID: e1d13655-25dd-41fe-8862-5e0a658df842</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IProduct_SectionConstants.Show_In_MenuFieldName)]
				public virtual bool Show_In_Menu  {get; set;}
					
						/// <summary>
				/// The Title field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: e01393fd-a257-4c2c-af19-6276046136ce</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IProduct_SectionConstants.TitleFieldName)]
				public virtual string Title  {get; set;}
					
			
	}
}
namespace SitecoreCookbook.Models.sitecore.templates.Coobook
{


 	/// <summary>
	/// ISite_Root Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/Coobook/Site Root</para>	
	/// <para>ID: 8d924e2b-41fc-4dfd-9e06-0bc48e373d91</para>	
	/// </summary>
	[SitecoreType(TemplateId=ISite_RootConstants.TemplateIdString )] //, Cachable = true
	public partial interface ISite_Root : IGlassBase 
	{
								/// <summary>
					/// The Body field.
					/// <para></para>
					/// <para>Field Type: Rich Text</para>		
					/// <para>Field ID: 9015ec3d-c52a-4de4-ae15-a37ba71f4445</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ISite_RootConstants.BodyFieldName)]
					string Body  {get; set;}
			
								/// <summary>
					/// The Carousel Slides field.
					/// <para></para>
					/// <para>Field Type: Treelist</para>		
					/// <para>Field ID: ec43a434-e288-4263-aaba-01bb42095659</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ISite_RootConstants.Carousel_SlidesFieldName)]
					IEnumerable<Guid> Carousel_Slides  {get; set;}
			
								/// <summary>
					/// The Title field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: 9e8ea374-7cc4-48fb-8f65-56cdbe9ee648</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ISite_RootConstants.TitleFieldName)]
					string Title  {get; set;}
			
				}


	public static partial class ISite_RootConstants{

			public const string TemplateIdString = "8d924e2b-41fc-4dfd-9e06-0bc48e373d91";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Site Root";

					
			public static readonly ID BodyFieldId = new ID("9015ec3d-c52a-4de4-ae15-a37ba71f4445");
			public const string BodyFieldName = "Body";
			
					
			public static readonly ID Carousel_SlidesFieldId = new ID("ec43a434-e288-4263-aaba-01bb42095659");
			public const string Carousel_SlidesFieldName = "Carousel Slides";
			
					
			public static readonly ID TitleFieldId = new ID("9e8ea374-7cc4-48fb-8f65-56cdbe9ee648");
			public const string TitleFieldName = "Title";
			
			

	}

	
	/// <summary>
	/// Site_Root
	/// <para></para>
	/// <para>Path: /sitecore/templates/Coobook/Site Root</para>	
	/// <para>ID: 8d924e2b-41fc-4dfd-9e06-0bc48e373d91</para>	
	/// </summary>
	[SitecoreType(TemplateId=ISite_RootConstants.TemplateIdString)] //, Cachable = true
	public partial class Site_Root  : GlassBase, ISite_Root 
	{
	   
						/// <summary>
				/// The Body field.
				/// <para></para>
				/// <para>Field Type: Rich Text</para>		
				/// <para>Field ID: 9015ec3d-c52a-4de4-ae15-a37ba71f4445</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ISite_RootConstants.BodyFieldName)]
				public virtual string Body  {get; set;}
					
						/// <summary>
				/// The Carousel Slides field.
				/// <para></para>
				/// <para>Field Type: Treelist</para>		
				/// <para>Field ID: ec43a434-e288-4263-aaba-01bb42095659</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ISite_RootConstants.Carousel_SlidesFieldName)]
				public virtual IEnumerable<Guid> Carousel_Slides  {get; set;}
					
						/// <summary>
				/// The Title field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 9e8ea374-7cc4-48fb-8f65-56cdbe9ee648</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ISite_RootConstants.TitleFieldName)]
				public virtual string Title  {get; set;}
					
			
	}
}
namespace SitecoreCookbook.Models.sitecore.templates.Common
{


 	/// <summary>
	/// IFolder Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/Common/Folder</para>	
	/// <para>ID: a87a00b1-e6db-45ab-8b54-636fec3b5523</para>	
	/// </summary>
	[SitecoreType(TemplateId=IFolderConstants.TemplateIdString )] //, Cachable = true
	public partial interface IFolder : IGlassBase 
	{
				}


	public static partial class IFolderConstants{

			public const string TemplateIdString = "a87a00b1-e6db-45ab-8b54-636fec3b5523";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Folder";

			

	}

	
	/// <summary>
	/// Folder
	/// <para></para>
	/// <para>Path: /sitecore/templates/Common/Folder</para>	
	/// <para>ID: a87a00b1-e6db-45ab-8b54-636fec3b5523</para>	
	/// </summary>
	[SitecoreType(TemplateId=IFolderConstants.TemplateIdString)] //, Cachable = true
	public partial class Folder  : GlassBase, IFolder 
	{
	   
			
	}
}
namespace SitecoreCookbook.Models.sitecore.templates.Coobook
{


 	/// <summary>
	/// IProduct_Category Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/Coobook/Product Category</para>	
	/// <para>ID: aba20e59-966b-4833-9427-b7e22bc4f6a5</para>	
	/// </summary>
	[SitecoreType(TemplateId=IProduct_CategoryConstants.TemplateIdString )] //, Cachable = true
	public partial interface IProduct_Category : IGlassBase , global::SitecoreCookbook.Models.sitecore.templates.Coobook.ICommon_Fields
	{
				}


	public static partial class IProduct_CategoryConstants{

			public const string TemplateIdString = "aba20e59-966b-4833-9427-b7e22bc4f6a5";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Product Category";

					
			public static readonly ID BodyFieldId = new ID("7d46c7ed-592f-4662-be46-8f5ca6a44169");
			public const string BodyFieldName = "Body";
			
					
			public static readonly ID IconFieldId = new ID("71b1622e-df88-4729-9fa6-15de6b86f188");
			public const string IconFieldName = "Icon";
			
					
			public static readonly ID ImageFieldId = new ID("3df9f188-0867-4532-88a1-91d20a730dc2");
			public const string ImageFieldName = "Image";
			
					
			public static readonly ID Show_In_MenuFieldId = new ID("e1d13655-25dd-41fe-8862-5e0a658df842");
			public const string Show_In_MenuFieldName = "Show in Menu";
			
					
			public static readonly ID TitleFieldId = new ID("e01393fd-a257-4c2c-af19-6276046136ce");
			public const string TitleFieldName = "Title";
			
			

	}

	
	/// <summary>
	/// Product_Category
	/// <para></para>
	/// <para>Path: /sitecore/templates/Coobook/Product Category</para>	
	/// <para>ID: aba20e59-966b-4833-9427-b7e22bc4f6a5</para>	
	/// </summary>
	[SitecoreType(TemplateId=IProduct_CategoryConstants.TemplateIdString)] //, Cachable = true
	public partial class Product_Category  : GlassBase, IProduct_Category 
	{
	   
						/// <summary>
				/// The Body field.
				/// <para></para>
				/// <para>Field Type: Rich Text</para>		
				/// <para>Field ID: 7d46c7ed-592f-4662-be46-8f5ca6a44169</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IProduct_CategoryConstants.BodyFieldName)]
				public virtual string Body  {get; set;}
					
						/// <summary>
				/// The Icon field.
				/// <para></para>
				/// <para>Field Type: Icon</para>		
				/// <para>Field ID: 71b1622e-df88-4729-9fa6-15de6b86f188</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IProduct_CategoryConstants.IconFieldName)]
				public virtual string Icon  {get; set;}
					
						/// <summary>
				/// The Image field.
				/// <para></para>
				/// <para>Field Type: Image</para>		
				/// <para>Field ID: 3df9f188-0867-4532-88a1-91d20a730dc2</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IProduct_CategoryConstants.ImageFieldName)]
				public virtual Image Image  {get; set;}
					
						/// <summary>
				/// The Show in Menu field.
				/// <para></para>
				/// <para>Field Type: Checkbox</para>		
				/// <para>Field ID: e1d13655-25dd-41fe-8862-5e0a658df842</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IProduct_CategoryConstants.Show_In_MenuFieldName)]
				public virtual bool Show_In_Menu  {get; set;}
					
						/// <summary>
				/// The Title field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: e01393fd-a257-4c2c-af19-6276046136ce</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IProduct_CategoryConstants.TitleFieldName)]
				public virtual string Title  {get; set;}
					
			
	}
}
namespace SitecoreCookbook.Models.sitecore.templates.Coobook
{


 	/// <summary>
	/// ICommon_Fields Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/Coobook/Common Fields</para>	
	/// <para>ID: ba3e9a0e-632c-4e5f-b3e6-73b4078d0957</para>	
	/// </summary>
	[SitecoreType(TemplateId=ICommon_FieldsConstants.TemplateIdString )] //, Cachable = true
	public partial interface ICommon_Fields : IGlassBase 
	{
								/// <summary>
					/// The Body field.
					/// <para></para>
					/// <para>Field Type: Rich Text</para>		
					/// <para>Field ID: 7d46c7ed-592f-4662-be46-8f5ca6a44169</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ICommon_FieldsConstants.BodyFieldName)]
					string Body  {get; set;}
			
								/// <summary>
					/// The Icon field.
					/// <para></para>
					/// <para>Field Type: Icon</para>		
					/// <para>Field ID: 71b1622e-df88-4729-9fa6-15de6b86f188</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ICommon_FieldsConstants.IconFieldName)]
					string Icon  {get; set;}
			
								/// <summary>
					/// The Image field.
					/// <para></para>
					/// <para>Field Type: Image</para>		
					/// <para>Field ID: 3df9f188-0867-4532-88a1-91d20a730dc2</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ICommon_FieldsConstants.ImageFieldName)]
					Image Image  {get; set;}
			
								/// <summary>
					/// The Show in Menu field.
					/// <para></para>
					/// <para>Field Type: Checkbox</para>		
					/// <para>Field ID: e1d13655-25dd-41fe-8862-5e0a658df842</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ICommon_FieldsConstants.Show_In_MenuFieldName)]
					bool Show_In_Menu  {get; set;}
			
								/// <summary>
					/// The Title field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: e01393fd-a257-4c2c-af19-6276046136ce</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ICommon_FieldsConstants.TitleFieldName)]
					string Title  {get; set;}
			
				}


	public static partial class ICommon_FieldsConstants{

			public const string TemplateIdString = "ba3e9a0e-632c-4e5f-b3e6-73b4078d0957";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Common Fields";

					
			public static readonly ID BodyFieldId = new ID("7d46c7ed-592f-4662-be46-8f5ca6a44169");
			public const string BodyFieldName = "Body";
			
					
			public static readonly ID IconFieldId = new ID("71b1622e-df88-4729-9fa6-15de6b86f188");
			public const string IconFieldName = "Icon";
			
					
			public static readonly ID ImageFieldId = new ID("3df9f188-0867-4532-88a1-91d20a730dc2");
			public const string ImageFieldName = "Image";
			
					
			public static readonly ID Show_In_MenuFieldId = new ID("e1d13655-25dd-41fe-8862-5e0a658df842");
			public const string Show_In_MenuFieldName = "Show in Menu";
			
					
			public static readonly ID TitleFieldId = new ID("e01393fd-a257-4c2c-af19-6276046136ce");
			public const string TitleFieldName = "Title";
			
			

	}

	
	/// <summary>
	/// Common_Fields
	/// <para></para>
	/// <para>Path: /sitecore/templates/Coobook/Common Fields</para>	
	/// <para>ID: ba3e9a0e-632c-4e5f-b3e6-73b4078d0957</para>	
	/// </summary>
	[SitecoreType(TemplateId=ICommon_FieldsConstants.TemplateIdString)] //, Cachable = true
	public partial class Common_Fields  : GlassBase, ICommon_Fields 
	{
	   
						/// <summary>
				/// The Body field.
				/// <para></para>
				/// <para>Field Type: Rich Text</para>		
				/// <para>Field ID: 7d46c7ed-592f-4662-be46-8f5ca6a44169</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ICommon_FieldsConstants.BodyFieldName)]
				public virtual string Body  {get; set;}
					
						/// <summary>
				/// The Icon field.
				/// <para></para>
				/// <para>Field Type: Icon</para>		
				/// <para>Field ID: 71b1622e-df88-4729-9fa6-15de6b86f188</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ICommon_FieldsConstants.IconFieldName)]
				public virtual string Icon  {get; set;}
					
						/// <summary>
				/// The Image field.
				/// <para></para>
				/// <para>Field Type: Image</para>		
				/// <para>Field ID: 3df9f188-0867-4532-88a1-91d20a730dc2</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ICommon_FieldsConstants.ImageFieldName)]
				public virtual Image Image  {get; set;}
					
						/// <summary>
				/// The Show in Menu field.
				/// <para></para>
				/// <para>Field Type: Checkbox</para>		
				/// <para>Field ID: e1d13655-25dd-41fe-8862-5e0a658df842</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ICommon_FieldsConstants.Show_In_MenuFieldName)]
				public virtual bool Show_In_Menu  {get; set;}
					
						/// <summary>
				/// The Title field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: e01393fd-a257-4c2c-af19-6276046136ce</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ICommon_FieldsConstants.TitleFieldName)]
				public virtual string Title  {get; set;}
					
			
	}
}
namespace SitecoreCookbook.Models.sitecore.templates.Coobook
{


 	/// <summary>
	/// ISite_Configuration Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/Coobook/Site Configuration</para>	
	/// <para>ID: d70f5c0f-287a-4f35-bd42-f5155642749e</para>	
	/// </summary>
	[SitecoreType(TemplateId=ISite_ConfigurationConstants.TemplateIdString )] //, Cachable = true
	public partial interface ISite_Configuration : IGlassBase 
	{
								/// <summary>
					/// The Company Name field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: 4a39810a-da40-4e2f-87f9-186cf8a735bb</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ISite_ConfigurationConstants.Company_NameFieldName)]
					string Company_Name  {get; set;}
			
								/// <summary>
					/// The Copyright Text field.
					/// <para></para>
					/// <para>Field Type: Rich Text</para>		
					/// <para>Field ID: 0ac1d0c0-6037-4975-85f2-92fb9dbbad00</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ISite_ConfigurationConstants.Copyright_TextFieldName)]
					string Copyright_Text  {get; set;}
			
								/// <summary>
					/// The Logo field.
					/// <para></para>
					/// <para>Field Type: Image</para>		
					/// <para>Field ID: 7908b136-8c4e-4c3b-8119-7b016d0be749</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ISite_ConfigurationConstants.LogoFieldName)]
					Image Logo  {get; set;}
			
				}


	public static partial class ISite_ConfigurationConstants{

			public const string TemplateIdString = "d70f5c0f-287a-4f35-bd42-f5155642749e";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Site Configuration";

					
			public static readonly ID Company_NameFieldId = new ID("4a39810a-da40-4e2f-87f9-186cf8a735bb");
			public const string Company_NameFieldName = "Company Name";
			
					
			public static readonly ID Copyright_TextFieldId = new ID("0ac1d0c0-6037-4975-85f2-92fb9dbbad00");
			public const string Copyright_TextFieldName = "Copyright Text";
			
					
			public static readonly ID LogoFieldId = new ID("7908b136-8c4e-4c3b-8119-7b016d0be749");
			public const string LogoFieldName = "Logo";
			
			

	}

	
	/// <summary>
	/// Site_Configuration
	/// <para></para>
	/// <para>Path: /sitecore/templates/Coobook/Site Configuration</para>	
	/// <para>ID: d70f5c0f-287a-4f35-bd42-f5155642749e</para>	
	/// </summary>
	[SitecoreType(TemplateId=ISite_ConfigurationConstants.TemplateIdString)] //, Cachable = true
	public partial class Site_Configuration  : GlassBase, ISite_Configuration 
	{
	   
						/// <summary>
				/// The Company Name field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 4a39810a-da40-4e2f-87f9-186cf8a735bb</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ISite_ConfigurationConstants.Company_NameFieldName)]
				public virtual string Company_Name  {get; set;}
					
						/// <summary>
				/// The Copyright Text field.
				/// <para></para>
				/// <para>Field Type: Rich Text</para>		
				/// <para>Field ID: 0ac1d0c0-6037-4975-85f2-92fb9dbbad00</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ISite_ConfigurationConstants.Copyright_TextFieldName)]
				public virtual string Copyright_Text  {get; set;}
					
						/// <summary>
				/// The Logo field.
				/// <para></para>
				/// <para>Field Type: Image</para>		
				/// <para>Field ID: 7908b136-8c4e-4c3b-8119-7b016d0be749</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ISite_ConfigurationConstants.LogoFieldName)]
				public virtual Image Logo  {get; set;}
					
			
	}
}
namespace SitecoreCookbook.Models.sitecore.templates.Coobook
{


 	/// <summary>
	/// ICarousel_Slide Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/Coobook/Carousel Slide</para>	
	/// <para>ID: f2711ebf-ce70-4b02-916f-614f43c58d64</para>	
	/// </summary>
	[SitecoreType(TemplateId=ICarousel_SlideConstants.TemplateIdString )] //, Cachable = true
	public partial interface ICarousel_Slide : IGlassBase 
	{
								/// <summary>
					/// The Image field.
					/// <para></para>
					/// <para>Field Type: Image</para>		
					/// <para>Field ID: d1e61c07-3e99-46e5-a5ae-a674fefa8c08</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ICarousel_SlideConstants.ImageFieldName)]
					Image Image  {get; set;}
			
								/// <summary>
					/// The Link Item field.
					/// <para></para>
					/// <para>Field Type: Droptree</para>		
					/// <para>Field ID: aca6b6fa-4c9e-4bb1-9322-05903965edc7</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ICarousel_SlideConstants.Link_ItemFieldName)]
					Guid Link_Item  {get; set;}
			
								/// <summary>
					/// The Title field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: 23341a11-17ed-47b1-9599-6db5c1ffaf97</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ICarousel_SlideConstants.TitleFieldName)]
					string Title  {get; set;}
			
				}


	public static partial class ICarousel_SlideConstants{

			public const string TemplateIdString = "f2711ebf-ce70-4b02-916f-614f43c58d64";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Carousel Slide";

					
			public static readonly ID ImageFieldId = new ID("d1e61c07-3e99-46e5-a5ae-a674fefa8c08");
			public const string ImageFieldName = "Image";
			
					
			public static readonly ID Link_ItemFieldId = new ID("aca6b6fa-4c9e-4bb1-9322-05903965edc7");
			public const string Link_ItemFieldName = "Link Item";
			
					
			public static readonly ID TitleFieldId = new ID("23341a11-17ed-47b1-9599-6db5c1ffaf97");
			public const string TitleFieldName = "Title";
			
			

	}

	
	/// <summary>
	/// Carousel_Slide
	/// <para></para>
	/// <para>Path: /sitecore/templates/Coobook/Carousel Slide</para>	
	/// <para>ID: f2711ebf-ce70-4b02-916f-614f43c58d64</para>	
	/// </summary>
	[SitecoreType(TemplateId=ICarousel_SlideConstants.TemplateIdString)] //, Cachable = true
	public partial class Carousel_Slide  : GlassBase, ICarousel_Slide 
	{
	   
						/// <summary>
				/// The Image field.
				/// <para></para>
				/// <para>Field Type: Image</para>		
				/// <para>Field ID: d1e61c07-3e99-46e5-a5ae-a674fefa8c08</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ICarousel_SlideConstants.ImageFieldName)]
				public virtual Image Image  {get; set;}
					
						/// <summary>
				/// The Link Item field.
				/// <para></para>
				/// <para>Field Type: Droptree</para>		
				/// <para>Field ID: aca6b6fa-4c9e-4bb1-9322-05903965edc7</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ICarousel_SlideConstants.Link_ItemFieldName)]
				public virtual Guid Link_Item  {get; set;}
					
						/// <summary>
				/// The Title field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 23341a11-17ed-47b1-9599-6db5c1ffaf97</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ICarousel_SlideConstants.TitleFieldName)]
				public virtual string Title  {get; set;}
					
			
	}
}