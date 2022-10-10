namespace RestApiTest.Model;

using System.Text;

public class Task
{
    private const string DateFormat = "dd-MM-yyyy";
    public string Id { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public List<Operation> Operations { get; set; }

    public Task(string name, DateTime startDate)
    {
        Name = name;
        StartDate = startDate;
        Id = Ulid.NewUlid().ToString();
        Operations = new List<Operation>();
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.Append("Task [").Append(Id).Append("]:\n\tName: ").Append(Name).Append("\n\tStart date: ");
        result.Append(StartDate.ToString(DateFormat)).Append("\n\tOperations:");

        if (Operations.Count != 0)
        {
            result.Append("\n");
            
            foreach (var operation in Operations)
            {
                result.Append("\t\t").Append(operation).Append("\n");
            }
        }
        else
        {
            result.Append(" none\n");
        }

        return result.ToString();
    }
}