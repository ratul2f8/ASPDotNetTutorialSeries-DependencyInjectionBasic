using dependency_injection_tutorial.Services;

using Microsoft.AspNetCore.Mvc;

namespace dependency_injection_tutorial.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestingController : ControllerBase
	{

		private readonly DependencyService1 _dependencyService1;
		private readonly DependencyService2 _dependencyService2;

		public TestingController(DependencyService1 dependencyService1,
			DependencyService2 dependencyService2)
		{
			_dependencyService1 = dependencyService1;
			_dependencyService2 = dependencyService2;
		}

		[HttpGet("/1")]
		public async Task PrintConsoleValues1()
		{

			_dependencyService1.Write();
			_dependencyService2.Write();
			return;
		}
		[HttpGet("/2")]
		public async Task PrintConsoleValues2()
		{

			_dependencyService1.Write();
			_dependencyService2.Write();
			return;
		}
	}
}
