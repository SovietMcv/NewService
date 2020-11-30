using NewService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewService.Controllers
{
    public class TicketsController : ApiController
    {
        public IEnumerable<Tickets> GetTickets()
        {
            using (MainDataBaseEntities db = new MainDataBaseEntities())
            {
                return db.TicketsList.Select(x => new Tickets
                {
                    Id = x.Id,
                    CinemaRoomId = x.CinemaRoomId,
                    LineId = x.LineId,
                    SeansID = x.SeansId,
                    Sold = x.Sold
                }).ToList();
            }
        }
    }
}
