using System;
using System.Collections.Generic;
using System.Text;

namespace xamarin_studies.Models
{
    public class CountryMessage
    {
        public string Message { get; set; }
        public IList<Country> Data { get; set; }
        public string Status { get; set; }
    }
}
