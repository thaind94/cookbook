using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using SitecoreCookbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreCookbook.Controllers
{
    public class NavigationController : Controller
    {
        // GET: Navigation
        public ActionResult Carousel()
        {
            List<CarouselSlide> slides = new List<CarouselSlide>();
            MultilistField multilistField = Sitecore.Context.Item.Fields["Carousel Slides"];
            if (multilistField != null)
            {
                Item[] carouselItem = multilistField.GetItems();
                foreach(Item item in carouselItem)
                {
                    slides.Add(new CarouselSlide(item));
                }
            }
            return PartialView(slides);
        }
    }
}