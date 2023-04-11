﻿using InitialProject.Domain.Models;
using InitialProject.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialProject.Controller
{
    public class ReservationRescheduleRequestController
    {
        private readonly ReservationRescheduleRequestService _reservationRescheduleRequestService;

        public ReservationRescheduleRequestController()
        {
            _reservationRescheduleRequestService = new ReservationRescheduleRequestService();
        }

        public List<ReservationRescheduleRequest> GetAll()
        {
            return _reservationRescheduleRequestService.GetAll();
        }


        public ReservationRescheduleRequest Get(int id)
        {
            return _reservationRescheduleRequestService.Get(id);
        }

        public ReservationRescheduleRequest Save(ReservationRescheduleRequest reservationRescheduleRequest)
        {

            return _reservationRescheduleRequestService.Save(reservationRescheduleRequest);
        }

        public void Delete(ReservationRescheduleRequest reservationRescheduleRequest)
        {
            _reservationRescheduleRequestService.Delete(reservationRescheduleRequest);
        }

        public ReservationRescheduleRequest Update(ReservationRescheduleRequest reservationRescheduleRequest)
        {
            return _reservationRescheduleRequestService.Update(reservationRescheduleRequest);
        }

        public int NextId()
        {
            return _reservationRescheduleRequestService.NextId();
        }

        public List<ReservationRescheduleRequest> GetStandBy()
        {
            return _reservationRescheduleRequestService.GetStandBy();
        }

        public List<ReservationRescheduleRequest> GetApproved()
        {
            return _reservationRescheduleRequestService.GetApproved();
        }

        public List<ReservationRescheduleRequest> GetDeclined()
        {
            return _reservationRescheduleRequestService.GetDeclined();
        }
    }
}
