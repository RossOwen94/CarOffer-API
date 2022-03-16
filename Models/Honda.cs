namespace CarOffer_API.Models
{
    public class Honda
    {
        public string Country { get; set; }
        public string CreatedOn { get; set; }
        public string DateAvailableToPublic { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public string UpdatedOn { get; set; }
        public string VehicleType { get; set; }
        public string WMI { get; set; }

        public Honda(string name,string country,string createdOn,string dateAvailable, int id,string updatedOn, string vehicleType, string wmi)
        {
            Name = name;
            Country = country;
            CreatedOn = createdOn;
            DateAvailableToPublic = dateAvailable;
            Id = id;
            UpdatedOn = updatedOn;
            VehicleType = vehicleType;
            WMI = wmi;

        }




    }
}
