using System;
using System.Collections.Generic;

namespace flick_net_sdk.Models
{
    public class EGSData
    {
        public string VatName { get; set; }
        public string VatNumber { get; set; }
        public List<Device> Devices { get; set; }
    }

    public class Device
    {
        public string DeviceName { get; set; }
        public string City { get; set; }
        public string CitySubdiv { get; set; }
        public string Street { get; set; }
        public string Plot { get; set; }
        public string Building { get; set; }
        public string Postal { get; set; }
        public string BranchName { get; set; }
        public string BranchIndustry { get; set; }
        public string OTP { get; set; }
    }
}
