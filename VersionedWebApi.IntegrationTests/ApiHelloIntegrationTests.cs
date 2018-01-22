using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace VersionedWebApi.UnitTests
{
	[TestClass]
	public class ApiHelloIntegrationTests
	{
		private TestServer _server;
		private IWebHostBuilder _builder;
		private HttpClient _client;

		[TestInitialize]
		public void TestInitialize()
		{
			_builder = new WebHostBuilder()
				.UseStartup<Startup>()
				.UseEnvironment("Testing");
			_server = new TestServer(_builder);
			_client = _server.CreateClient();
		}

		[TestMethod]
		public async Task Api_Hello_Should_Return_v1_ContentAsync()
		{
			var result = await _client.GetAsync("/api/v1/hello");

			Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);

			var expected = "Hello World!";
			var actual = await result.Content.ReadAsStringAsync();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public async Task Api_Hello_Should_Return_v2_ContentAsync()
		{
			var result = await _client.GetAsync("/api/v2/hello");

			Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);

			var expected = "{\"message\":\"Hello 2017!\"}";
			var actual = await result.Content.ReadAsStringAsync();

			Assert.AreEqual(expected, actual);
		}
	}
}
