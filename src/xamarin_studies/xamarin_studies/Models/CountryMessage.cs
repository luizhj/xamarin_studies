using System.Collections.Generic;

namespace xamarin_studies.Models
{
    public class CountryMessage
    {
        public string Message { get; set; }
        public IList<Country> Data { get; set; }
        public string Status { get; set; }
    }
}
