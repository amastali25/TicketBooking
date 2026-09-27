using System;
using System.Collections.Generic;
using System.Text;
using TicketBooking.Domain.Enums;

namespace TicketBooking.Domain.Entities
{
    internal class Session
    {   private int Id { get; set; }

        private DateTime StartDateTime { get; set; }

        private DateTime EndDateTime { get; set; }

        private int TotalCapacity { get; set; }

        private int AvailableCapacity { get; set; }

        private decimal Price { get; set; }

        private int SoldCount { get; set; }

        private SessionStatus Status { get; set; }

        public void SetTimeAndDate(DateTime startDateTime, DateTime endDateTime)
        {
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
        }
    }
}

