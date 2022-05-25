using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adc.CustomSchema.Data;

namespace Adc.CustomSchema.Data
{
    public class CustomerPayloadItem
    {
        public CustomerPayloadItem()
        {
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Street { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public CountryInfo Country { get; set; }
    }
}