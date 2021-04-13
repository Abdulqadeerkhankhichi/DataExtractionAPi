using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileUploadApi.Models
{
    public class FinalFileData
    {
        public string Authentication { get; set; }
        public  List<PatientData> PatientData { get; set; }
    }
}