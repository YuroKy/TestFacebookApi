using Newtonsoft.Json;

namespace FacebookApi.Models
{

	public class ShortUserModel
	{
		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("age")]
		public int Age { get; set; }
	}

	public class UserModel : ShortUserModel
	{
		[JsonProperty("age_range")]
		public UserAgeRangeModel UserAgeRange { get; set; }
	}

	public class UserAgeRangeModel
	{
		[JsonProperty("min")]
		public int Min { get; set; }
	}
}
