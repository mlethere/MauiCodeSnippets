using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCodeSnippets.Models
{
    public class BirthdayModel
    {
        public string Name { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public Guid Id { get; set; }
    }

    public class BirthdayModelRepository
    {
        private IList<BirthdayModel> _birthdays = [];

        public BirthdayModelRepository()
        {
            _birthdays.Add(new BirthdayModel { Name = "Mark", BirthDate = new DateTime(1967, 9, 7), Id = Guid.NewGuid() });
            _birthdays.Add(new BirthdayModel { Name = "Jacob", BirthDate = new DateTime(1999, 3, 22), Id = Guid.NewGuid() });
            _birthdays.Add(new BirthdayModel { Name = "Lilly", BirthDate = new DateTime(2001, 6, 25), Id = Guid.NewGuid() });
            _birthdays.Add(new BirthdayModel { Name = "Penny", BirthDate = new DateTime(1972, 7, 17), Id = Guid.NewGuid() });
        }


        public IList<BirthdayModel> Get()
        {
            return _birthdays;
        }
    }
}
