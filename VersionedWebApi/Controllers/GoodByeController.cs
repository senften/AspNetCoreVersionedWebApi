using Microsoft.AspNetCore.Mvc;
using VersionedWebApi.Model;

namespace VersionedWebApi.Controllers
{
	/// <summary>
	/// GoodByeController, just saying Goodbye!
	/// </summary>
	[ApiVersion("1.0", Deprecated = true)]
	[ApiVersion("3.0")]
    [Route("api/v{api-version:apiVersion}/[controller]")]
    public class GoodByeController : Controller
	{
		/// <summary>
		/// Default Get call returning Goodbye world!
		/// </summary>
		/// <returns></returns>
		[HttpGet]
        [ProducesResponseType(typeof(GoodByeWorldModel), 200)]
        [ProducesResponseType(typeof(void), 404)]
		public GoodByeWorldModel Get()
		{
			return new GoodByeWorldModel();
		}

		/// <summary>
		/// Default Get call returning Goodbye world!
		/// </summary>
		/// <returns></returns>
		[HttpGet, MapToApiVersion("3.0")]
        [ProducesResponseType(typeof(VersionedWebApi.Model.v3.GoodByeWorldModel), 200)]
        [ProducesResponseType(typeof(void), 404)]
		public VersionedWebApi.Model.v3.GoodByeWorldModel GetV3()
		{
			return new VersionedWebApi.Model.v3.GoodByeWorldModel();
		}
	}
}
