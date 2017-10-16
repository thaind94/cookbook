using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreCookbook.Models
{
    [SitecoreType]
    public class GlassItem : GlassBase
    {

    }
}
namespace SitecoreCookbook.Models.sitecore.templates.Coobook
{
    public partial class Site_Root
    {
        [SitecoreField(ISite_RootConstants.Carousel_SlidesFieldName)]
        public virtual IEnumerable<Carousel_Slide> Mapped_Carousel_Slides { get; set; }
    }
    public partial class Carousel_Slide
    {
        [SitecoreField(ICarousel_SlideConstants.Link_ItemFieldName)]
        public virtual GlassItem Mapped_Link_Item { get; set; }
    }
}