using System.Threading.Tasks;
using FacebookApi.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FacebookApi.Controllers
{
	[Route("facebook/users/")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private const string MyToken =
			"EAAH2r9S2iY4BAIOeR4DY75GA7frbnSQNIvya3C8e8av4THCSpSZBUtbyXN5jadiSqZBPDQE0EVCLZB4f9eHSl1iie81sy9zEaz88Orwkv8OA9rT4hpCQNlw9I02BeI9oYvvqtH4bu5whWWapwOGqq0QKwlgGlR4KSpzcdQU7aBeKqCIT8AJZCoZBvmjTy1BfKBB4r7ZAjpIgZDZD";

		private readonly IUserServices _userServices;

		public UserController(IUserServices userServices)
		{
			_userServices = userServices;
		}

		[HttpGet]
		[Route("me")]
		public async Task<IActionResult> GetMyInfo()
		{
			return Ok(await _userServices.GetMeAsync(MyToken));
		}
	}
}