using System.Text.Json;

namespace MauiCodeSnippets.Crud.Models;

/// <summary>
/// CRUD model to manage a family with members
/// </summary>
public class CrudModel
{
    /// <summary>
    /// Hold a static name of the file where we save the data
    /// </summary>
    private readonly string _fileName;

    public CrudModel()
    {
        _fileName = System.IO.Path.Combine(FileSystem.AppDataDirectory, "OneHappyFamily.json");
    }

    /// <summary>
    /// Main property to hole a single family with members
    /// </summary>
    public FamilyModel Family { get; set; } = new FamilyModel();

    /// <summary>
    /// Let's welcome someone into the family
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="dateOfBirth"></param>
    public bool AddFamilyMember(string firstName, DateTime dateOfBirth)
    {
        // I would never validate like this in a real app
        if (string.IsNullOrWhiteSpace(firstName))
            return false;

        if (Family.FamilyMembers.Any(x => x.FirstName == firstName))
            return false;

        if (dateOfBirth <= DateTime.MinValue)
            return false;

        Family.FamilyMembers.Add(new PersonModel
        {
            FirstName = firstName,
            DateOfBirth = dateOfBirth
        });

        SaveToLocalFile();

        return true;
    }

    /// <summary>
    /// Someone changed their name or date of birth
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="newFirstName"></param>
    /// <param name="newDateOfBirth"></param>
    public void EditFamilyMember(string firstName, string newFirstName, DateTime newDateOfBirth)
    {
        var person = Family.FamilyMembers.FirstOrDefault(x => x.FirstName == firstName);
        if (person != null)
        {
            person.FirstName = newFirstName;
            person.DateOfBirth = newDateOfBirth;
        }
    }

    /// <summary>
    /// Return the local file name - of course, this is just for interest
    /// </summary>
    /// <returns></returns>
    public string GetLocalFilename()
    {
        return _fileName;
    }

    /// <summary>
    /// Load from a local file
    /// </summary>
    public void LoadFromLocalFile()
    {
        if (File.Exists(_fileName))
        {
            string json = File.ReadAllText(_fileName);
            Family = JsonSerializer.Deserialize<FamilyModel>(json) ?? new FamilyModel();
        }
    }

    /// <summary>
    /// Oh no, someone left the family
    /// </summary>
    /// <param name="firstName"></param>
    public void RemoveFamilyMember(string firstName)
    {
        Family.FamilyMembers.RemoveAll(x => x.FirstName == firstName);
    }

    /// <summary>
    /// Save to a local file
    /// </summary>
    public void SaveToLocalFile()
    {
        string json = JsonSerializer.Serialize(Family);
        File.WriteAllText(_fileName, json);
    }
}

/// <summary>
/// Main Family Model
/// </summary>
public class FamilyModel
{
    public List<PersonModel> FamilyMembers { get; set; } = [];
    public string FamilyName { get; set; } = string.Empty;
}

/// <summary>
/// Person seems cold, but it's a family member
/// </summary>
public class PersonModel
{
    public DateTime DateOfBirth { get; set; }
    public string FirstName { get; set; } = string.Empty;
}