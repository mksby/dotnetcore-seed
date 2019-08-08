using Web.Api.Core.Shared;

namespace Web.Api.Core.Domain.Entities
{
    public class DistrictsCoordinates : BaseEntity
    {
        public string Type { get; private set; }

        public string Features { get; set; }

        internal DistrictsCoordinates() { }

        internal DistrictsCoordinates(string type, string features)
        {
            Type = type;
            Features = features;
        }
    }

    public class DistrictsCoordinatesDTO
    {
        public string Type { get; set; }
        public object[] Features { get; set; }

        public DistrictsCoordinatesDTO(string type, object[] features)
        {
            Type = type;
            Features = features;
        }
    }
}
