using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrantAccessCore.ManifestModels.v1alpha;
using GrantAccessCore.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GrantAccessCore.Controllers.v1alpha
{
    [Route("api/v1alpha/[controller]")]
    public class ProjectController : Controller
    {
        DBContextPg _context;

        public ProjectController(DBContextPg context)
        {
            _context = context;
        }

        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Projects.ToList());
        }


        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]ProjectManifest value)
        {
            Project pr = value.Definition;

            bool isUpdated = _context.Projects.Where(p => p.ProjectId == pr.ProjectId).Count() > 0;

            if(isUpdated)
            {
                _context.Update(pr);

                _context.SaveChanges();
                return Ok();
            }
            else
            {
                Project created = _context.Add(pr).Entity;
                _context.SaveChanges();
                return Created(created.ProjectId, created);
            }

        }


    }
}

