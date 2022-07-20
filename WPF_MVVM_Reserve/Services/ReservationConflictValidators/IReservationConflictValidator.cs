using System.Threading.Tasks;
using WPF_MVVM_Reserve.Models;

namespace WPF_MVVM_Reserve.Services.ReservationConflictValidators
{
    public interface IReservationConflictValidator
    {
        Task<Reservation> GetConflictingReservation(Reservation reservation);
    }
}
