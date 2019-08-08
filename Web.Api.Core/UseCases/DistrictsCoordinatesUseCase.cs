using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Dto.UseCaseRequests;
using Web.Api.Core.Dto.UseCaseResponses;
using Web.Api.Core.Interfaces;
using Web.Api.Core.Interfaces.Gateways;
using Web.Api.Core.Interfaces.UseCases;
using Web.Api.Core.Mapping;
using Web.Api.Core.Shared;

namespace Web.Api.Core.UseCases
{
    internal class DistrictsCoordinatesUseCase: IDistrictsCoordinatesUseCase
    {
        private readonly DistrictsMapper _districtsMapper;
        private readonly IMemoryDbContext _memoryDbContext;
        public DistrictsCoordinatesUseCase(DistrictsMapper districtsMapper, IMemoryDbContext memoryDbContext)
        {
            _districtsMapper = districtsMapper;
            _memoryDbContext = memoryDbContext;
        }

        public async Task<bool> Handle(DistrictsCoordinatesRequest message, IOutputPort<DistrictsCoordinatesResponse> outputPort)
        {
            DistrictsCoordinatesDTO districtsCoordinatesDTO = _districtsMapper.MapToDistrictsCoordinatesDTO(_memoryDbContext.DistrictsCoordinates.ToList()[0]);
            
            outputPort.Handle(new DistrictsCoordinatesResponse(districtsCoordinatesDTO, true));

            return true;
        }
    }
}
