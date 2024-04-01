namespace MB.Domain.Entities
{
    public class PlayerCharacter
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Level { get; set; } = 0;
        public int Experience { get; set; } = 0;
        public int Health { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public bool IsActive { get; set; } = false;

        public void Restore()
        {
            Health += 20;
        }
    }
}
