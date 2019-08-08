using Newtonsoft.Json;
using Web.Api.Core.Domain.Entities;

namespace Web.Api.Infrastructure.Data.Mapping
{
    class DistrictsMapper
    {
        public DistrictsCoordinatesDTO MapToDistrictsCoordinatesDTO(DistrictsCoordinates districtsCoordinatesData)
        {
            object[] json = JsonConvert.DeserializeObject<object[]>(districtsCoordinatesData.Features);

            return new DistrictsCoordinatesDTO(districtsCoordinatesData.Type, json);
        }
    }
}
