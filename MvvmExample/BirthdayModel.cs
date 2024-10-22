namespace MauiCodeSnippets.MvvmExample
{

    /// <summary>
    /// Static class. No data changes
    /// </summary>
    //public static class BirthdayModelRepository
    //{
    //    /// <summary>
    //    /// Create a static list of Birthdays
    //    /// </summary>
    //    /// <returns></returns>
    //    public static IEnumerable<BirthdayModel> Get()
    //    {
    //        IList<BirthdayModel> _birthdays = [];
    //        _birthdays.Add(new BirthdayModel { Name = "Mark", BirthDate = new DateTime(1967, 9, 7), Id = Guid.NewGuid() });
    //        _birthdays.Add(new BirthdayModel { Name = "Jacob", BirthDate = new DateTime(1999, 3, 22), Id = Guid.NewGuid() });
    //        _birthdays.Add(new BirthdayModel { Name = "Lilly", BirthDate = new DateTime(2001, 6, 25), Id = Guid.NewGuid() });
    //        _birthdays.Add(new BirthdayModel { Name = "Penny", BirthDate = new DateTime(1972, 7, 17), Id = Guid.NewGuid() });
    //        return _birthdays.AsEnumerable();
    //    }
    //}

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
