using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace core2api.Controllers
{
	[Produces("application/json")]
	[Route("v1/Date")]
	[ApiController]
	public class DateController : ControllerBase
	{
		// GET: api/Date
		//[HttpGet]
		//public IEnumerable<string> Get()
		//{
		//	return new string[] { "value1", "value2" };
		//}

		// GET: api/Date/5
		//[HttpGet("{id}", Name = "Get")]
		[HttpGet]
		public string Get()
		{
			return DateTime.Now.ToShortDateString();
		}

		//v1/date/year/123?auth=555
		[HttpGet("year/{id?}")]
		public string Get(int id, string authid)
		{
			if( id != 0)
			{
				return $"{id}, authid={authid}";
			}
			return DateTime.Now.Year.ToString();
		}

		//[HttpGet("{id}")]
		//public Payload Get(int id)
		//{
		//	return new Payload() { Status = Response.StatusCode.ToString(), Content = "testing content" };
		//}

		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			return Ok( new Payload() { Content = "testing content" } );
		}

		// POST: api/Date
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT: api/Date/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

	}

	public class Payload
	{
		public string Status { get; set; }
		public string Content { get; set; }
	}
}
