namespace Adc.CustomSchema.Data
{
    public class CustomerListData
    {

        public CustomerListData()
        {
        }
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Created { get; set; }

        public string Country { get; set; }

        public string City { get; set; }
    }
}