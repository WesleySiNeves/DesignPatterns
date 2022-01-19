using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VideoGalery.Models;
using VideoGalery.Proxy;
using VideoLibrary;

namespace VideoGalery.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;

        private bool _isHD;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index(int videoId)
        {
            var viewModel = new VideoViewModel
            {
                Videos = _repository.GetAllVideoDetails(),
            };

            //((ProxyRepository)_repository).IsHdRequest = _isHD;
            viewModel.Path = videoId == 0 ? "~/Videos/Escalator - 2304.mp4" : _repository.GetVideoPath(videoId);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(VideoViewModel video, string HD)
        {
            _isHD = string.IsNullOrEmpty(HD) ? false : true;

            return Index(video.SelectedVideoId);

        }


        public IActionResult Privacy()
        {
            return View();
        }
        //[ResponseCache(Duration =0,Location =ResponseCacheLocation.None]
    }
}
