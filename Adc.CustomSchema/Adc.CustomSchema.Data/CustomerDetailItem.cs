using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adc.CustomSchema.Data;

namespace Adc.CustomSchema.Data
{
    public class CustomerDetailItem : CustomerPayloadItem
    {
        public CustomerDetailItem()
        {
        }

        public Guid Id { get; set; }

        public DateTime Created { get; set; }
    }
}