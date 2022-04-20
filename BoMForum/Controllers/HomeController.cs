using BoMForum.Models;
using BoMForum.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BoMForum.Controllers
{
    public class HomeController : Controller
    {
        private IForumRepository _repo { get; set; }

        public HomeController(IForumRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            ViewBag.tags = _repo.Tags;

            var posts = _repo.UserPosts;
            return View(posts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult Details(int postid)
        {
            UserPost post = _repo.UserPosts.Single(x => x.UserPostID == postid);
            IQueryable<Comment> comments = _repo.Comments.Where(x => x.UserPostID == postid);
            DetailsPage detailsPage = new DetailsPage(post, comments);
            return View(detailsPage);
        }


        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.tags = _repo.Tags;
            return View(new UserPost());
        }

        [HttpPost]
        public IActionResult Create(UserPost userPost)
        {
            if (ModelState.IsValid)
            {
                _repo.SavePost(userPost);
                return RedirectToAction("Index");
            }
            ViewBag.tags = _repo.Tags;
            return View(userPost);
        }
    }
}
