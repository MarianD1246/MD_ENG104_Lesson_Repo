
namespace CK1;

public class CodeK3
{
    public static string Likes(string[] name)
    {
        return name.Length == 1? $"{name[0]} likes this" : name.Length == 2 ? $"{name[0]} and {name[1]} like this" :
            name.Length == 3? $"{name[0]}, {name[1]} and {name[2]} like this" :
            name.Length >= 4 ? $"{name[0]}, {name[1]} and {name.Length - 2} others like this" : "no one likes this";
    }
}

