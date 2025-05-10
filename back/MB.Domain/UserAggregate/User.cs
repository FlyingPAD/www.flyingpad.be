using MB.Domain.AchievementAggregate;
using MB.Domain.LeagueAggregate;
using MB.Domain.SeasonAggregate;

namespace MB.Domain.UserAggregate;

public class User : AuditableEntity
{
    // Identité et contact
    public string UserName { get; private set; } = string.Empty;
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public bool IsEmailVerified { get; private set; }

    // Authentification
    public byte[]? PasswordHash { get; private set; }
    public byte[]? PasswordSalt { get; private set; }

    // Progression
    public int Experience { get; private set; }
    public int Level { get; private set; } = 1;
    public int SeasonScore { get; private set; } = 0;

    // Rôles et date de naissance
    public int Role { get; private set; } = 1;
    public DateTime Birthdate { get; private set; } = DateTime.MinValue;

    // Associations
    private readonly List<EmailVerificationToken> _emailVerificationTokens = [];
    public IReadOnlyCollection<EmailVerificationToken> EmailVerificationTokens
        => _emailVerificationTokens.AsReadOnly();

    private readonly List<UserAchievement> _achievements = [];
    public IReadOnlyCollection<UserAchievement> Achievements
        => _achievements.AsReadOnly();

    // Saison et ligue
    public int? SeasonId { get; private set; }
    public Season? Season { get; private set; }

    public int? LeagueDefinitionId { get; private set; }
    public LeagueDefinition? LeagueDefinition { get; private set; }

    // Constructeur EF Core
    private User() { }

    // Factory de création initiale
    public static User Register(
        string userName,
        string firstName,
        string lastName,
        string email,
        byte[] passwordHash,
        byte[] passwordSalt,
        DateTime birthdate)
    {
        if (string.IsNullOrWhiteSpace(userName)) throw new ArgumentException("UserName requis", nameof(userName));
        if (string.IsNullOrWhiteSpace(firstName)) throw new ArgumentException("FirstName requis", nameof(firstName));
        if (string.IsNullOrWhiteSpace(lastName)) throw new ArgumentException("LastName requis", nameof(lastName));
        if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Email requis", nameof(email));
        if (passwordHash == null || passwordHash.Length == 0) throw new ArgumentException("Hash requis", nameof(passwordHash));
        if (passwordSalt == null || passwordSalt.Length == 0) throw new ArgumentException("Salt requis", nameof(passwordSalt));

        return new User
        {
            UserName = userName,
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            PasswordHash = passwordHash,
            PasswordSalt = passwordSalt,
            Birthdate = birthdate,
            IsEmailVerified = false,
            Experience = 0,
            Level = 1,
            Role = 1
        };
    }

    // ------------------------
    // Méthodes métier (mutations autorisées)
    // ------------------------

    /// <summary>
    /// Met à jour les informations de profil.
    /// </summary>
    public void UpdateProfile(string userName, string firstName, string lastName, DateTime birthdate)
    {
        if (string.IsNullOrWhiteSpace(userName)) throw new ArgumentException("UserName requis", nameof(userName));
        if (string.IsNullOrWhiteSpace(firstName)) throw new ArgumentException("FirstName requis", nameof(firstName));
        if (string.IsNullOrWhiteSpace(lastName)) throw new ArgumentException("LastName requis", nameof(lastName));

        UserName = userName;
        FirstName = firstName;
        LastName = lastName;
        Birthdate = birthdate;
    }

    /// <summary>
    /// Change le rôle de l'utilisateur.
    /// </summary>
    public void ChangeRole(int newRole)
    {
        if (newRole < 0) throw new ArgumentException("Role invalide", nameof(newRole));
        Role = newRole;
    }

    /// <summary>
    /// Modifie l'adresse email et marque à vérifier.
    /// </summary>
    public void ChangeEmail(string newEmail)
    {
        if (string.IsNullOrWhiteSpace(newEmail)) throw new ArgumentException("Email requis", nameof(newEmail));
        Email = newEmail;
        IsEmailVerified = false;
    }

    /// <summary>
    /// Met à jour le hachage du mot de passe.
    /// </summary>
    public void ChangePassword(byte[] newHash, byte[] newSalt)
    {
        if (newHash == null || newHash.Length == 0) throw new ArgumentException("Hash requis", nameof(newHash));
        if (newSalt == null || newSalt.Length == 0) throw new ArgumentException("Salt requis", nameof(newSalt));

        PasswordHash = newHash;
        PasswordSalt = newSalt;
    }

    /// <summary>
    /// Valide l'email de l'utilisateur.
    /// </summary>
    public void VerifyEmail() => IsEmailVerified = true;

    /// <summary>
    /// Ajoute de l'expérience.
    /// </summary>
    public void GainExperience(int xp)
    {
        if (xp <= 0) return;
        Experience += xp;
    }

    /// <summary>
    /// Met à jour le niveau.
    /// </summary>
    public void UpdateLevel(int newLevel)
    {
        if (newLevel <= 0) return;
        Level = newLevel;
    }

    /// <summary>
    /// Débloque un achievement et donne son XP.
    /// </summary>
    public void UnlockAchievement(AchievementDefinition def)
    {
        ArgumentNullException.ThrowIfNull(def);
        if (_achievements.Any(a => a.AchievementDefinitionId == def.EntityId))
            return;

        var ua = UserAchievement.Unlock(this.EntityId, def);
        _achievements.Add(ua);
        GainExperience(def.XpReward);
    }

    /// <summary>
    /// Participe à une saison.
    /// </summary>
    public void ParticipateInSeason(Season season)
    {
        ArgumentNullException.ThrowIfNull(season);
        SeasonId = season.EntityId;
        Season = season;
    }

    /// <summary>
    /// Met à jour la ligue de l'utilisateur.
    /// </summary>
    public void UpdateLeague(LeagueDefinition league)
    {
        ArgumentNullException.ThrowIfNull(league);
        LeagueDefinitionId = league.EntityId;
        LeagueDefinition = league;
    }

    /// <summary>
    /// Ajoute des points au score de saison (jamais en dessous de zéro).
    /// </summary>
    public void GainSeasonPoints(int points)
    {
        if (points == 0) return;
        SeasonScore = Math.Max(0, SeasonScore + points);
    }

    /// <summary>
    /// Réinitialise le score de saison (appelée après calcul des promotions).
    /// </summary>
    public void ResetSeasonScore()
    {
        SeasonScore = 0;
    }
}