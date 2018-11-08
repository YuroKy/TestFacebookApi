using System.Threading.Tasks;
using FacebookApi.Models;

namespace FacebookApi.Abstractions
{
	public interface IUserServices
	{
		Task<ShortUserModel> GetMeAsync(string accessToken);
	}
}