using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using SitecoreCookbook.Models;
using SitecoreCookbook.Models.sitecore.templates.Coobook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreCookbook.Controllers
{
    public class NavigationController : GlassController
    {
        // GET: Navigation
        public ActionResult Carousel()
        {
            //List<CarouselSlide> slides = new List<CarouselSlide>();
            var home = this.GetContextItem<Site_Root>();            
            //if (home.Carousel_Slides.Count() != 0)
            //{
            //    foreach(Guid id in home.Carousel_Slides)
            //    {
            //        slides.Add(new CarouselSlide(Sitecore.Context.Database.GetItem(id.ToString())));
            //    }
            //}
            return PartialView(home.Mapped_Carousel_Slides);
        }
    }
}