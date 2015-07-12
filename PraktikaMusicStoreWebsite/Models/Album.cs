using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace PraktikaMusicStoreWebsite.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Price { get; set; }
    }
}
