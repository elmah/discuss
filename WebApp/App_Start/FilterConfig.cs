using System.Web;
using System.Web.Mvc;
using Elmah;

namespace WebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new ErrorLogger());
            filters.Add(new HandleErrorAttribute());
        }

        sealed class ErrorLogger : IExceptionFilter
        {
            public void OnException(ExceptionContext context)
            {
                if (!context.ExceptionHandled)
                    return;
                var httpContext = context.HttpContext.ApplicationInstance.Context;
                ErrorSignal.FromContext(httpContext)
                    .Raise(context.Exception, httpContext);
            }
        }
    }
}
