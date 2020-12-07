﻿using System.Threading.Tasks;
using SEP3.Model;

namespace SEP3.Data
{
    public interface ICloudDoctorHospitalService
    {
        public Task AddDoctorHospital(DoctorHospital doctorHospital);
    }
}