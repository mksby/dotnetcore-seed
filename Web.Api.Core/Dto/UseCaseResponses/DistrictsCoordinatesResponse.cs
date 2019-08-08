using System.Collections.Generic;
using Web.Api.Core.Interfaces;

namespace Web.Api.Core.Dto.UseCaseResponses
{
    public class DistrictsCoordinatesResponse : UseCaseResponseMessage
    {
        public object Content { get; }
        public IEnumerable<string> Errors { get; }

        public DistrictsCoordinatesResponse(IEnumerable<string> errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }

        public DistrictsCoordinatesResponse(object content, bool success = false, string message = null) : base(success, message)
        {
            Content = content;
        }
    }
}
