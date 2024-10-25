namespace MauiCodeSnippets.MvvmExample
{
    /// <summary>
    /// Define in a separate class our BirthdayModel
    /// </summary>
    public record BirthdayModel
    {
        public string Name { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public Guid Id { get; set; }
    }

    
}
