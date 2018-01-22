using Microsoft.AspNetCore.Mvc;
using System;

namespace VersionedWebApi.Controllers.v2
{
	/// <summary>
	/// The modern HelloController, all up to date responses
	/// </summary>
	[ApiVersion("2.0"), Route("api/v{api-version:apiVersion}/[controller]")]
	public class HelloController : Controller
	{
		/// <summary>
		/// Default Get call returning Hello current-year!
		/// </summary>
		/// <response code="200">Success</response>
		/// <response code="404">Not found</response>
		/// <response code="0">unexpected error</response>
		/// <returns></returns>
		[HttpGet]
		[ProducesResponseType(typeof(HelloWorldModel), 200)]
		[ProducesResponseType(typeof(void), 404)]
		public HelloWorldModel Get()
		{
			return new HelloWorldModel
			{
				Message = $"Hello {DateTime.Now.Year}!"
			};
		}
	}

	/// <summary>
	/// HelloWorldModel class for HelloController
	/// </summary>
	public class HelloWorldModel
	{
		/// <summary>
		/// Message string
		/// </summary>
		public string Message { get; set; }
	}
}
