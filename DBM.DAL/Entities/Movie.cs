using System;
namespace DBM.DAL.Entities
{
	public class Movie
	{

		public int id { get; set; }
		public string title { get; set; }
		public string description { get; set; }
		public DateTime Date { get; set; }
		public string mainPhoto { get; set; }
		public string trailerUrl { get; set; }

		public List<Photo> photos { get; set; }
	}
}

