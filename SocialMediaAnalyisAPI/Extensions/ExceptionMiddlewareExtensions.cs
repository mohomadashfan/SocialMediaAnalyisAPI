using Microsoft.AspNetCore.Diagnostics;
using SocialMediaAnalyis.Entities.ErrorModel;
using SocialMediaAnalyis.Entities.Exceptions;
using SocialMediaAnalyis.Repository.Contracts;
using System.Net;

namespace SocialMediaAnalyis.API.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this WebApplication app, ILoggerManager logger)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        context.Response.StatusCode = contextFeature.Error switch
                        {
                            NotFoundException => StatusCodes.Status404NotFound,
                            BadRequestException => StatusCodes.Status400BadRequest,

                        };

                        logger.LogError($"Something went wrong: {contextFeature.Error}");

                        await context.Response.WriteAsync(new ErrorDetails()
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = contextFeature.Error.Message,
                            InnerException = contextFeature.Error.InnerException != null ? contextFeature.Error.InnerException.Message : ""
                        }.ToString());
                    }
                });
            });
        }
    }
}
