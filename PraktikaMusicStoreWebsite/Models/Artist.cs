using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace PraktikaMusicStoreWebsite.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        public string Name { get; set; }

        //public List<Album> Albums { get; set; }
    }
}
