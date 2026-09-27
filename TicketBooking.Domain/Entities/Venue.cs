using System;
using System.Collections.Generic;
using System.Text;

namespace TicketBooking.Domain.Entities
{  internal class Venue
        {
            private int Id { get; set; }

            private string Name { get; set; }

            private string Address { get; set; }

            private int Capacity { get; set; }

            private DateTime StartTime { get; set; }

            private DateTime EndTime { get; set; }

            private string Description { get; set; }

            private readonly List<Session> _sessions = new();

            public void SetCapacity(int capacity)
            {
                if (capacity <= 0)
                    throw new ArgumentException("Capacity must be greater than zero.");

                Capacity = capacity;
            }

            public void AddSession(Session session)
            {
                ArgumentNullException.ThrowIfNull(session);

                _sessions.Add(session);
            }

            public void RemoveSession(Session session)
            {
                ArgumentNullException.ThrowIfNull(session);

                _sessions.Remove(session);
            }
        }
    }

