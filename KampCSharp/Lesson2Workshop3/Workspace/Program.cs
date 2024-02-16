using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;



IInstructorServise ınstructorServise = new InstructorManager(new InstructorDal());
Instructor ınstructor = new Instructor()
{
    Id = 1,
    Email = "engin@gmail.com",
    FirstName = "Engin",
    LastName = "Demiroğ",
    Password = "123456"
};
ınstructorServise.Add(ınstructor);


IStudentService studentService = new StudentManager(new StudentDal());
Student student = new Student()
{
    Id = 2,
    Email = "emirhan@gmail.com",
    FirstName = "Emirhan",
    LastName = "Doğan",
    Password = "123456"
}; 
studentService.Add(student);

ICourseService courseService = new CourseManager(new CourseDal());
Course course1 = new Course()
{
    Id = 1,
    CategoryId = 1,
    Name = "C# Programlama",
    Description = "5 hafta sürcek",
    InstructorId = 1,
    Price = 0
};
Course course2 = new Course()
{
    Id = 2,
    CategoryId = 2,
    Name = "Angular",
    Description = "8 hafta sürcek",
    InstructorId = 1,
    Price = 0
};
courseService.Add(course1);
courseService.Add(course2);

foreach(var course in courseService.GetAll())
{
    Console.WriteLine(course.Name);
}