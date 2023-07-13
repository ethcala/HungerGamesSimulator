using System.Security.Cryptography.X509Certificates;

namespace HungerGamesSimulator.Models
{
	class Game
	{
		public int LimitDistricts { get; set; }
		public int MembersPerDistrict { get; set; }
		public List<District> Districts { get; set; }
	}
}