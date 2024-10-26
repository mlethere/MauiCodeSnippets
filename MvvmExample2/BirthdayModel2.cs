namespace MauiCodeSnippets.MvvmExample2
{
    /// <summary>
    /// Define in a separate class our BirthdayModel
    /// </summary>
    public record BirthdayModel2
    {
        public string Name { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public Guid Id { get; set; }
    }

    
}
