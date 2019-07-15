using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab20_website.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab20_website.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {

            var blogList = new List<Blog>
            {
                new Blog
                {
                    Date = DateTime.Now,
                    Title = "Today's Entry 1",
                    Entry = "today was awesome"
                },

                new Blog
                {
                    Date = DateTime.Now.AddDays(-1),
                    Title = "Yesterday's Entry",
                    Entry = "Zombies reversus ab inferno, nam malum cerebro. De carne animata corpora quaeritis. Summus sit​​, morbo vel maleficia? De Apocalypsi undead dictum mauris. Hi mortuis soulless creaturas, imo monstra adventus vultus comedat cerebella viventium. Qui offenderit rapto, terribilem incessu. The voodoo sacerdos suscitat mortuos comedere carnem. Search for solum oculi eorum defunctis cerebro. Nescio an Undead zombies. Sicut malus movie horror."
                },

                new Blog
                {
                    Date = DateTime.Now.AddDays(-7),
                    Title = "Last Week's Entry",
                    Entry = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet. Duis sagittis ipsum. Praesent mauris. Fusce nec tellus sed augue semper porta. Mauris massa. Vestibulum lacinia arcu eget nulla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Curabitur sodales ligula in libero."
                }
            };

            return View(blogList);
        }
    }
}