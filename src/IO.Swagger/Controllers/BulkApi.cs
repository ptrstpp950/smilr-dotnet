using System;
using System.Threading.Tasks;
using IO.Swagger.Attributes;
using IO.Swagger.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using ProblemDetails = IO.Swagger.Models.ProblemDetails;

namespace IO.Swagger.Controllers
{
    /// <inheritdoc />
    public class BulkApi : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        /// <inheritdoc />
        public BulkApi(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Bulk load events and feedback</remarks>
        /// <param name="bulk">Bulk payload</param>
        /// <response code="200">Status message</response>
        /// <response code="500">Unexpected error</response>
        [HttpPost]
        [Route("/api/bulk")]
        [ValidateModelState]
        [SwaggerOperation("BulkLoad")]
        [SwaggerResponse(statusCode: 500, type: typeof(ProblemDetails), description: "Unexpected error")]
        public async Task<IActionResult> BulkLoad([FromBody]Bulk bulk)
        {
            _dbContext.AddRange(bulk.Events);
            foreach (var feedback in bulk.Feedback)
            {
                feedback.Id = string.IsNullOrEmpty(feedback.Id) ? Guid.NewGuid().ToString("D") : feedback.Id;
            }
            _dbContext.AddRange(bulk.Feedback);
            await _dbContext.SaveChangesAsync();
            return StatusCode(200);
        }
    }
}