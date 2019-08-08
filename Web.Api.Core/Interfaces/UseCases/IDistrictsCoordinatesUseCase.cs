using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Dto.UseCaseRequests;
using Web.Api.Core.Dto.UseCaseResponses;

namespace Web.Api.Core.Interfaces.UseCases
{
    public interface IDistrictsCoordinatesUseCase : IUseCaseRequestHandler<DistrictsCoordinatesRequest, DistrictsCoordinatesResponse>
    {
        
    }
}

