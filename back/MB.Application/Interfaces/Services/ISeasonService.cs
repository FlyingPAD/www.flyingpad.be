namespace MB.Application.Interfaces.Services;

public interface ISeasonService
{
    /// <summary>
    /// Clôture la saison en cours (promotion/démotion des users), 
    /// puis crée la nouvelle saison hebdomadaire.
    /// </summary>
    Task ProcessSeasonsAsync();
}