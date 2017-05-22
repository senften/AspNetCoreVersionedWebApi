# Versioning Models

This was an experiment in how to change and version models when versioning an API via .net core asp versioning (&swagger).

It turns out, after studying patterns for versioning APIs, my thought of using namespaces to version models was not all that clever and pretty much how the API implementations are handled.

Take a look at `VersionedWebApi/Controllers/GoodByeController.cs` and `VersionedWebApi/Models/GoodByeWorldModel.cs` Then peak at `VersionedWebApi/Models/GoodByeWorldModel_V2.cs`. From my perspective, there's a style question but using namespaces to version the models is a viable and simple approach.

From a swagger client generation perspective, codegen does the "right" thing. It generates client side models based on the API version number. Any model not readily used by a version is filtered out and not generated. This is true for embedded classes as well as appear in v3 of the GoodByeWorldModel.

## Strangeness

The documentation for using MapToApiVersion, as shown below, shows the addition of `[ApiVersion("3.0)]` attribute on the class as well, but when I include that attribute the swagger ui for the api doesn't generate properly. I do not know if this is a change in 1.1.1. or not.

```
namespace VersionedWebApi.Controllers
{
	/// <summary>
	/// GoodByeController, just saying Goodbye!
	/// </summary>
	[ApiVersion("1.0", Deprecated = true)]
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

```