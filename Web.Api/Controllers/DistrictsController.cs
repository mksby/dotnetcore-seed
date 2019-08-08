using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Dto.UseCaseRequests;
using Web.Api.Core.Interfaces.UseCases;
using Web.Api.Infrastructure.Data;
using Web.Api.Presenters;

namespace Web.Api.Controllers
{
    [Authorize(Policy = "ApiUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        private readonly IDistrictsCoordinatesUseCase _districtsCoordinatesUseCase;
        private readonly DistrictsCoordinatesPresenter _districtsCoordinatesPresenter;

        public DistrictsController(
            IDistrictsCoordinatesUseCase districtsCoordinatesUseCase,
            DistrictsCoordinatesPresenter districtsCoordinatesPresenter
        )
        {
            _districtsCoordinatesUseCase = districtsCoordinatesUseCase;
            _districtsCoordinatesPresenter = districtsCoordinatesPresenter;
        }

        // POST api/districts/coordinates
        [HttpPost("coordinates")]
        public async Task<ActionResult> Coordinates()
        {
            await _districtsCoordinatesUseCase.Handle(new DistrictsCoordinatesRequest(), _districtsCoordinatesPresenter);
            return _districtsCoordinatesPresenter.ContentResult;
        }
    }
}