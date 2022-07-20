using System.Collections.Generic;
using System.Threading.Tasks;
using WPF_MVVM_Reserve.Models;

namespace WPF_MVVM_Reserve.Services.ReservationProviders
{
    public interface IReservationProvider
    {
        Task<IEnumerable<Reservation>> GetAllReservations();
    }
}
