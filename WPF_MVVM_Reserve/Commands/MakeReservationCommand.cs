using System;
using System.ComponentModel;
using System.Windows;
using WPF_MVVM_Reserve.Exceptions;
using WPF_MVVM_Reserve.Models;
using WPF_MVVM_Reserve.ViewModels;

namespace WPF_MVVM_Reserve.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly Hotel _hotel;
        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;

            _makeReservationViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.Username) &&
                _makeReservationViewModel.FloorNumber > 0 &&
                base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            Reservation reservation = new Reservation(
                new RoomID(_makeReservationViewModel.FloorNumber, _makeReservationViewModel.RoomNumber),
                _makeReservationViewModel.Username,
                _makeReservationViewModel.StartDate,
                _makeReservationViewModel.EndDate
                );

            try
            {
                _hotel.MakeReservation(reservation);

                MessageBox.Show(
                    "Successfully reserved room.",
                    "Success",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            catch (ReservationConflictException)
            {
                MessageBox.Show(
                    "This room is already taken.", 
                    "Error", 
                    MessageBoxButton.OK, 
                    MessageBoxImage.Error);
            }
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName ==  nameof(MakeReservationViewModel.Username))
            {
                OnCanExecutedChanged();
            }
        }
    }
}
