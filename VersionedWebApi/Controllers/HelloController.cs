using Microsoft.AspNetCore.Mvc;

namespace VersionedWebApi.Controllers
{
	/// <summary>
	/// HelloController, just saying Hello World!
	/// </summary>
	[ApiVersion("1.0", Deprecated = true), Route("api/v{version:apiVersion}/[controller]")]
    public class HelloController : Controller
	{
		/// <summary>
		/// Default Get call returning Hello World!
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		public string Get()
		{
			return "Hello World!";
		}
	}
}
