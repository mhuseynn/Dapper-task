namespace LessonDapper.Entities;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Id_Author { get; set; }
    public int YearPress { get; set; }

    public int Pages { get; set; }
 
}
