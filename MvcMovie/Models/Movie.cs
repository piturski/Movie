using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        //public TypeOfQuality QualityType { get; set; }
        public enum TypeOfQuality
        {
            [Display(Name = "NONE_INFO")]
            NONE_INFO = 0,
            [Display(Name = "SD_576i")]
            SD_576i = 1,
            [Display(Name = "HDREADY_720p")]
            HDREADY_720p = 2,
            [Display(Name = "FULLHD_1080p")]
            FULLHD_1080p = 3,
            [Display(Name = "ULTRAHD_2160p")]
            ULTRAHD_2160p = 4,
        }

        public TypeOfQuality TypeOfQualitySetting { get; set; }

        [Display(Name = "Release Date")]
    
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
}