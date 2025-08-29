using System.Text.Json.Serialization;

namespace LunchTimeMCP;

[JsonSerializable(typeof(List<Restaurant>))]
[JsonSerializable(typeof(Restaurant))]
[JsonSerializable(typeof(RestaurantVisitInfo))]
[JsonSerializable(typeof(Dictionary<string, RestaurantVisitInfo>))]
[JsonSerializable(typeof(RestaurantData))]
[JsonSerializable(typeof(FormattedRestaurantStat))]
[JsonSerializable(typeof(FormattedRestaurantStats))]
internal sealed partial class RestaurantContext : JsonSerializerContext
{
}
