using Hangfire.Dashboard;

namespace MB.API.Configuration
{
    public class HangfireAuthorizationFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize(DashboardContext context)
        {
            // Récupérer le contexte HTTP de la requête
            var httpContext = context.GetHttpContext();

            // Vérifier si un token JWT est présent dans l'en-tête Authorization
            var authorizationHeader = httpContext.Request.Headers["Authorization"];
            if (string.IsNullOrEmpty(authorizationHeader) || !authorizationHeader.ToString().StartsWith("Bearer "))
            {
                // Si aucun token n'est présent, refuser l'accès
                return false;
            }

            // Autoriser l'accès si un token est présent
            return true;
        }
    }
}