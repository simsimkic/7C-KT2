﻿using InitialProject.Controller;
using InitialProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InitialProject.WPF.Views.GuideWindows
{
    /// <summary>
    /// Interaction logic for GuestsForTour.xaml
    /// </summary>
    public partial class GuestsForTour : Window
    {
        public TourReservationController _tourReservationController { get; set; }
        public ObservableCollection<User> Guests2 { get; set; }

        public User SelectedGuest { get; set; }
        public TourPoint CurrentTourPoint { get; set; }
        public TourEvent CurrentTourEvent { get; set; }
        public GuestsForTour(TourEvent tourEvent, TourPoint tourPoint)
        {
            InitializeComponent();
            this.DataContext = this;

            CurrentTourEvent = tourEvent;
            CurrentTourPoint = tourPoint;

            _tourReservationController = new TourReservationController();
            Guests2 = new ObservableCollection<User> (_tourReservationController.FindGuestsThatDidntComeYet(tourEvent));

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            TourReservation tourReservation = _tourReservationController.FindTourReservationForUserAndTourEvent(SelectedGuest, CurrentTourEvent);
            tourReservation.TourPointWhenGuestCame = CurrentTourPoint;

            //Obavestenje ob = new Obavestenje(reservation, false);
            //obavestenejController.dodaj(ob);
            

            _tourReservationController.Update(tourReservation);
            Close();
        }
    }
}
