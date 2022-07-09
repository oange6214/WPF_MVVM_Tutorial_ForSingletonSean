﻿using System;

namespace WPF_MVVM_Reserve.Models
{
    public class Reservation
    {
        public RoomID RoomID { get; }
        public string UserName { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public TimeSpan Length => EndTime.Subtract(StartTime);
        public Reservation(RoomID roomID, string userName, DateTime startTime, DateTime endTime)
        {
            RoomID = roomID;
            UserName = userName;
            StartTime = startTime;
            EndTime = endTime;
        }

        /// <summary>
        /// Check if  reservation conflicts.
        /// </summary>
        /// <param name="reservation">The incoming reservation.</param>
        /// <returns>True/false for conflicts.</returns>
        public bool Conflicts(Reservation reservation)
        {
            if (reservation.RoomID != RoomID)
            {
                return false;
            }

            return reservation.StartTime < EndTime && reservation.EndTime > StartTime;
        }
    }
}
