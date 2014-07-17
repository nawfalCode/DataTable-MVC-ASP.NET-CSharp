using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookEample.Controllers
{
    public class AuctionsController : Controller
    {
        //
        // GET: /Auctions/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Auctions/Details/5
        public ActionResult Details()
        {
            var auction = new BookEample.Models.Auction
            {
                Id = 1,
                Title = "Brand new Widget 1.0",
                Description = "This is a brand new version 1.0 Widget!",
                StartPrice = 1.00m,
                CurrentPrice = 1m,
                StartTime = DateTime.Parse(DateTime.Now.ToString()),
                EndTime = DateTime.Parse("6-23-2012 12:34 PM"),
            };
            var auction2 = new BookEample.Models.Auction
            {
                Id = 2,
                Title = "Brand new Widget 2.0",
                Description = "3This is a brand new version 2.0 Widget!",
                StartPrice = 2m,
                CurrentPrice = 2m,
                StartTime = DateTime.Parse(DateTime.Now.ToString()),
                EndTime = DateTime.Parse("6-23-2012 12:34 PM"),
            
            };
            var auction3 = new BookEample.Models.Auction
            {
                Id = 3,
                Title = "Brand new Widget 3.0",
                Description = "3This is a brand new version 3.0 Widget!",
                StartPrice = 3,
                CurrentPrice = 3m,
                StartTime = DateTime.Parse(DateTime.Now.ToString()),
                EndTime = DateTime.Parse("6-23-2012 12:34 PM"),

            };

            var auction4 = new BookEample.Models.Auction
            {
                Id = 4,
                Title = "Brand new Widget 4.0",
                Description = "3This is a brand new version 4.0 Widget!",
                StartPrice = 4m,
                CurrentPrice = 4m,
                StartTime = DateTime.Parse(DateTime.Now.ToString()),
                EndTime = DateTime.Parse("6-23-2012 12:34 PM"),

            };

            var auction5 = new BookEample.Models.Auction
            {
                Id = 5,
                Title = "Brand new Widget 5.0",
                Description = "3This is a brand new version 5.0 Widget!",
                StartPrice = 5m,
                CurrentPrice = 5m,
                StartTime = DateTime.Parse(DateTime.Now.ToString()),
                EndTime = DateTime.Parse("6-23-2012 12:34 PM"),

            };



            var Auctions =new BookEample.Models.Auctions();
            Auctions.AllAuctions=new List<Models.Auction>();
            Auctions.AllAuctions.Add(auction);
            Auctions.AllAuctions.Add(auction2);
            Auctions.AllAuctions.Add(auction3);
            Auctions.AllAuctions.Add(auction4);
            Auctions.AllAuctions.Add(auction5);
            return View(Auctions);
        }

        //
        // GET: /Auctions/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Auctions/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Auctions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Auctions/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Auctions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Auctions/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
