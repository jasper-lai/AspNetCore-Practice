﻿using Microsoft.AspNetCore.Mvc;

namespace IActionResultSample.Controllers
{
    [Route("NotFound/[action]")]
    [ApiController]
    public class NotFoundController : ControllerBase
    {
        /// <summary>
        /// Return HTTP 404
        /// 回傳 HTTP 404
        /// </summary>
        /// <returns>NotFoundResult</returns>
        public IActionResult Demo1()
        {
            return NotFound();
        }

        /// <summary>
        /// Return HTTP 404 and custom message object.
        /// 回傳 HTTP 404 與自訂訊息物件。
        /// </summary>
        /// <returns>NotFoundObjectResult</returns>
        public IActionResult Demo2()
        {
            var obj = new
            {
                Error = "Not Found."
            };
            return NotFound(obj);
        }
    }
}