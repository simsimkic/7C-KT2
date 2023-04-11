﻿using InitialProject.Domain.Models;
using InitialProject.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialProject.Controller
{
    public class AccommodationReservationController
    {
        private readonly AccommodationReservationService _accommodationReservationService;

        public AccommodationReservationController()
        {
            _accommodationReservationService = new AccommodationReservationService();
        }

        public List<AccommodationReservation> GetAll()
        {
            return _accommodationReservationService.GetAll();
        }


        public AccommodationReservation Get(int id)
        {
            return _accommodationReservationService.Get(id);
        }

        public AccommodationReservation Save(AccommodationReservation accommodationReservation)
        {

            return _accommodationReservationService.Save(accommodationReservation);
        }

        public void Delete(AccommodationReservation accommodationReservation)
        {

            _accommodationReservationService.Delete(accommodationReservation);

        }

        public AccommodationReservation Update(AccommodationReservation accommodationReservation)
        {
            return _accommodationReservationService.Update(accommodationReservation);
        }

        public int NextId()
        {

            return _accommodationReservationService.NextId();

        }

        public List<AccommodationReservation> GetAllReservationsWithoutReview()
        {
            return _accommodationReservationService.GetAllReservationsWithoutReview();
        }

        public int FindNumberOfGuestsWithoutReview()
        {
            return _accommodationReservationService.FindNumberOfGuestsWithoutReview();
        }
        public List<AccommodationReservation> GetByUserId(int guest)
        {
            return _accommodationReservationService.GetByUserId(guest);
        }

        public List<AccommodationReservation> GetAllReservationsWithoutAccommodationOwnerReview(int guest)
        {
            return _accommodationReservationService.GetAllReservationsWithoutAccommodationOwnerReview(guest);
        }
    }
}
