namespace SCManagement.Models
{
    public class ClubTranslations : ITranslation
    {
        public int Id { get; set; }

        public int ClubId { get; set; }

        public Club? Club { get; set; }

        public string? Language { get; set; }

        public string? Value { get; set; }
        
        public string? Atribute { get; set; }
    }
}
