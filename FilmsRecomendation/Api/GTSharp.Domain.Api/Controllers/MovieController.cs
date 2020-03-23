using System;
using System.Collections.Generic;
using System.Linq;
using GTSharp.Domain.Commands.Input;
using GTSharp.Domain.Entities;
using GTSharp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GTSharp.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/movies")]
    public class MovieController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<Movie> GetAll([FromServices]IMovieRepository repository)
        {
            return repository.GetAll();
        }
    }
}