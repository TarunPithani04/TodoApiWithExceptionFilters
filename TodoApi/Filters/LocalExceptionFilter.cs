using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TodoApi.Models;

namespace TodoApi.Filters
{
    public class LocalExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var error = new ErrorDetails()
            {
                StatusCode = 501,
                Message = "Something went wrong! Internal Server Error."
            };
            context.Result = new JsonResult(error);
        }
    }
}
