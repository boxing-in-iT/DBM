using System;
namespace DBM.DAL.Entities
{
	public class Photo
	{
		public int id { get; set; }
		public string imgUrl { get; set; }

		public Movie Movie { get; set; }
	}
}

