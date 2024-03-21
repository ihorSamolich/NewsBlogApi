﻿using HackerNewsApi.Interfaces.Services;
using HackerNewsApi.Models.QueryParams;
using Microsoft.AspNetCore.Mvc;

namespace HackerNewsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly IPostService _postService;

        public BlogController(IPostService postService)
        {
            _postService = postService;
        }


        [HttpGet("posts")]
        public IActionResult GetAllPosts([FromQuery] QueryParams queryParams)
        {
            var posts = _postService.GetAllPosts(queryParams);
            return Ok(posts);
        }


        [HttpGet("posts-count")]
        public IActionResult GetPostsCount()
        {
            var count = _postService.GetPostsCount();

            return Ok(count);
        }
    }
}
