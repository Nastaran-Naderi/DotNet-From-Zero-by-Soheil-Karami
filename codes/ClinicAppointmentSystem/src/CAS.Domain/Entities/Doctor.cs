
namespace CAS.Domain;

public class Doctor(string name, string lastname, string expertise, List<int> workingDays, string codeMeli)
{
    public string Name { get; } = name;
    public string Lastname { get; } = lastname;
    public string Expertise { get; } = expertise;
    public List<int> WorkingDays { get; } = workingDays;
    public Guid Id { get; set; }
    public string CodeMeli { get; set; }
}

