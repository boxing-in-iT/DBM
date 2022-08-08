using System;
namespace DBM.BLL.DTO.Requests
{
	public class MovieRequest
	{
       
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime Date { get; set; }
        public string mainPhoto { get; set; }
        public string trailerUrl { get; set; }
    }
}

