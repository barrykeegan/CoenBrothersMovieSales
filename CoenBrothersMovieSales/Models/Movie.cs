using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace CoenBrothersMovieSales.Models
{
    public class Movie
    {
        
        public int MovieID { get; set; }
        public int DirectorID { get; set; }  
        XmlDocument MovieData { get; set; }
        /*MovieTitle
        MovieRunningTime
        MovieGenre
        MovieDirector
        MovieActors
        MovieClassification
        MovieReleaseDate
        MovieShortDescription
        MovieLongDescription
        MoviePoster
        MovieDVDCover
        MovieTrailerLink
        IMDBTitleID
        IMDBRating
        TomatoTitleID
        TomatoRating*/
    }
}