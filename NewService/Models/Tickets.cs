using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewService.Models
{
    public class Tickets
    {
        public int Id { get; set; }
        public int CinemaRoomId { get; set; }
        public int SeansID { get; set; }
        public int LineId { get; set; }
        public bool Sold { get; set; }
    }
}