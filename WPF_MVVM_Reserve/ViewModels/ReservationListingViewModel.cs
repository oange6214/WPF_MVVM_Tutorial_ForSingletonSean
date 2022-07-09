using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WPF_MVVM_Reserve.Models;

namespace WPF_MVVM_Reserve.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;
        public IEnumerable<ReservationViewModel> Reservations => _reservations;

        public ICommand MakeReservationCommand { get; }
        public ReservationListingViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            _reservations.Add(
                new ReservationViewModel(
                    new Reservation(
                        new RoomID(1, 2),
                        "SingletonSean", 
                        DateTime.Now,
                        DateTime.Now)));
            _reservations.Add(
                new ReservationViewModel(
                    new Reservation(
                        new RoomID(3, 2),
                        "Joe",
                        DateTime.Now,
                        DateTime.Now)));
            _reservations.Add(
                new ReservationViewModel(
                    new Reservation(
                        new RoomID(2, 4),
                        "Mary",
                        DateTime.Now,
                        DateTime.Now)));
        }
    }
}