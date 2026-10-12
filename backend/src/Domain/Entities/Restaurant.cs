namespace MenuCreator.Domain.Entities;

public class Restaurant
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    
    public string Name { get; private set; }
    
    public string? Description { get; private set; }
    
    public DateTime CreatedAtUtc { get; private set; } = DateTime.UtcNow;

    private Restaurant()
    {
        Name = null!;
    }


    public Restaurant(string name, string? description = null)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Le nom est obligatoire", nameof(name));
        }

        Name = name.Trim();
        Description = description?.Trim();
    }
    
    public void UpdateDetails(string name, string? description)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(
                "Le nom du restaurant est obligatoire.",
                nameof(name));
        }

        Name = name.Trim();
        Description = description?.Trim();
    }
    
    
    
}