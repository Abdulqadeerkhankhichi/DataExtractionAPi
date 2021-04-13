using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileUploadApi.Models
{
    public class PatientData
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }      
        public string Facility { get; set; }
        public string Address { get; set; }
        public string DOB { get; set; }
        public string PateintDr { get; set; }
        public string MedicareNumber { get; set; }
        public string PhoneNumber { get; set; }
        

    }
}