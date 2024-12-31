﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Dto.ReservationDtos
{
    public class ReservationCreateDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? PickUpLocationId { get; set; }
        public int? DropOffLocationId { get; set; }
        public int CarId { get; set; }
        public int Age { get; set; }
        public int DriverLicenseYear { get; set; }
        public string? Description { get; set; }
        public int ReservationStatusId { get; set; }
    }
}
