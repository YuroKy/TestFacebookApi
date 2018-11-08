using System.Collections.Generic;
using System.Threading.Tasks;
using Facebook;
using FacebookApi.Abstractions;
using FacebookApi.Models;
using Newtonsoft.Json;

namespace FacebookApi.Implementations
{
	public class UserServices : IUserServices
	{
		public async Task<ShortUserModel> GetMeAsync(string accessToken)
		{
			var fb = new FacebookClient { AccessToken = accessToken };
			var parameters = new Dictionary<string, object>
			{
				["fields"] = "id,name,first_name,last_name,age_range"
			};

			dynamic content = await fb.GetTaskAsync("me", parameters);
			var model = (UserModel)JsonConvert.DeserializeObject<UserModel>(content.ToString());

			return new ShortUserModel
			{
				FirstName = model.FirstName,
				LastName = model.LastName,
				Age = model.UserAgeRange.Min
			};
		}
	}
}
