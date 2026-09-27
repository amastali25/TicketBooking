using System;
using System.Collections.Generic;
using System.Text;

namespace TicketBooking.Domain.Entities
{
    internal class Event
    { public string Name { get; set; }

            private decimal PricePerUnit { get; set; }

            private string Description { get; set; }
        }
    }

