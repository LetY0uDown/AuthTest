namespace JWTAuthTest;

// имитация БД
// :D
public class DbContext
{
    public List<User> Users { get; } = new();
}

public record User(string Username, string Pass);