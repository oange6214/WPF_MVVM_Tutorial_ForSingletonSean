using System.Collections.Generic;

namespace WPF_MVVM_Reserve.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;

        public string Name { get; }

        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }

        /// <summary>
        /// Get the reservations for a users.
        /// </summary>
        /// <param name="usernme">The username of user.</param>
        /// <returns>The reservations for the user.</returns>
         public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservationBook.GetAllReservations();
        }

        /// <summary>
        /// Make a reservation.
        /// </summary>
        /// <param name="reservation">The incoming reservation.</param>
        /// <exception cref="ReservationConflicts"></exception>
        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
