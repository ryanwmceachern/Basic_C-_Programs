using System.Data.Entity;
using System.Reflection.Metadata;

public class student
{
    public int Id { get; set; }
    public string StudentName { get; set; }
    
    public virtual List<student> students { get; set; }


}
public class StudentContext : DbContext
{
    public DbSet<student> students { get; set; }
    
}
class Program
{
    static void Main(string[] args)
    {
        using (var db = new StudentContext())
        {
            // Create and save a new Blog
            Console.Write("Enter a name for a new Student: ");
            var name = Console.ReadLine();

            var Student = new student { StudentName = name };
            db.students.Add(Student);
            db.SaveChanges();

            // Display all Blogs from the database
            var query = from b in db.students
                        orderby b.StudentName
                        select b;

            Console.WriteLine("All students in the database:");
            foreach (var item in query)
            {
                Console.WriteLine(item.StudentName);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

