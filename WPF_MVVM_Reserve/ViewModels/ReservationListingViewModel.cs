using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WPF_MVVM_Reserve.Commands;
using WPF_MVVM_Reserve.Models;
using WPF_MVVM_Reserve.Services;
using WPF_MVVM_Reserve.Stores;

namespace WPF_MVVM_Reserve.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly Hotel _hotel;
        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public IEnumerable<ReservationViewModel> Reservations => _reservations;

        public ICommand MakeReservationCommand { get; }

        public ReservationListingViewModel(Hotel hotel, NavigationService makeReservationNavigationService)
        {
            _hotel = hotel;

            _reservations = new ObservableCollection<ReservationViewModel>();

            MakeReservationCommand = new NavigateCommand(makeReservationNavigationService);

            UpdateReservations();
        }

        private void UpdateReservations()
        {
            _reservations.Clear();

            foreach(Reservation? reservation in _hotel.GetAllReservations())
            {
                ReservationViewModel reservationViewModel = new ReservationViewModel(reservation);
                _reservations.Add(reservationViewModel);
            }
        }
    }
}