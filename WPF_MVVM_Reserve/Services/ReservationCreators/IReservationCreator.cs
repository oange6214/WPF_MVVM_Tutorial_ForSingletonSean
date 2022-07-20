using System.Threading.Tasks;
using WPF_MVVM_Reserve.Models;

namespace WPF_MVVM_Reserve.Services.ReservationCreators
{
    public interface IReservationCreator
    {
        Task CreateReservation(Reservation reservation);
    }
}
