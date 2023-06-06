using System;
using Microsoft.AspNetCore.Mvc;

namespace CQRSWithCleanArchitecture.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    [ApiController]
    [Route("[controller]")]
    public class PostControllers : Controller
    {
        public PostControllers()
        {
        }

    }
}

