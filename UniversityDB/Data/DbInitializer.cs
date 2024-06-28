using UniversityDB.Models;
using System;
using System.Linq;

namespace UniversityDB.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            //sprawdz czy istnieja jacykolwiek studenci
            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student{FirstName="Bartosz", LastName= "Lasecki", DateOfBirth= DateTime.Parse("23.05.1990"), Email = "blasecki@test.com", EnrollmentDate = DateTime.Parse("23.12.2021")},
                new Student{FirstName="Adam", LastName= "Wodzionka", DateOfBirth= DateTime.Parse("13.02.2001"), Email = "awodzionka@test.com", EnrollmentDate = DateTime.Parse("12.12.2022")},
                new Student{FirstName="Katarzyna", LastName= "Krawiec", DateOfBirth= DateTime.Parse("21.04.2003"), Email = "kkrawiec@test.com", EnrollmentDate = DateTime.Parse("20.06.2024")},
                new Student{FirstName="Aleksandra", LastName= "Kolec", DateOfBirth= DateTime.Parse("23.07.1999"), Email = "akolec@test.com", EnrollmentDate = DateTime.Parse("21.02.2019")},
                new Student{FirstName="Wiktoria", LastName= "Muszyna", DateOfBirth= DateTime.Parse("12.05.2004"), Email = "wmuszyna@test.com", EnrollmentDate = DateTime.Parse("23.12.2022")},
                new Student{FirstName="Robert", LastName= "Hetman", DateOfBirth= DateTime.Parse("07.10.2004"), Email = "rhetman@test.com", EnrollmentDate = DateTime.Parse("09.09.2020")},
                new Student{FirstName="Krystian", LastName= "Oponka", DateOfBirth= DateTime.Parse("09.11.2001"), Email = "koponka@test.com", EnrollmentDate = DateTime.Parse("14.02.2021")},
                new Student{FirstName="Mariusz", LastName= "Kabel", DateOfBirth= DateTime.Parse("02.04.2005"), Email = "mkabel@test.com", EnrollmentDate = DateTime.Parse("01.01.2019")},
                new Student{FirstName="Katarzyna", LastName= "Nowak", DateOfBirth= DateTime.Parse("14.06.1992"), Email = "knowak@test.com", EnrollmentDate = DateTime.Parse("15.01.2021")},
                new Student{FirstName="Michał", LastName= "Kowalski", DateOfBirth= DateTime.Parse("27.09.1994"), Email = "mkowalski@test.com", EnrollmentDate = DateTime.Parse("08.03.2022")},
                new Student{FirstName="Anna", LastName= "Wiśniewska", DateOfBirth= DateTime.Parse("05.03.1993"), Email = "awisniewska@test.com", EnrollmentDate = DateTime.Parse("20.06.2021")},
                new Student{FirstName="Paweł", LastName= "Wójcik", DateOfBirth= DateTime.Parse("22.11.1988"), Email = "pwojcik@test.com", EnrollmentDate = DateTime.Parse("15.08.2020")},
                new Student{FirstName="Ewa", LastName= "Kamińska", DateOfBirth= DateTime.Parse("30.07.1995"), Email = "ekaminska@test.com", EnrollmentDate = DateTime.Parse("04.05.2021")},
                new Student{FirstName="Jan", LastName= "Lewandowski", DateOfBirth= DateTime.Parse("12.01.1991"), Email = "jlewandowski@test.com", EnrollmentDate = DateTime.Parse("11.11.2022")},
                new Student{FirstName="Agnieszka", LastName= "Zielińska", DateOfBirth= DateTime.Parse("08.05.1990"), Email = "azielinska@test.com", EnrollmentDate = DateTime.Parse("23.03.2021")},
                new Student{FirstName="Marcin", LastName= "Szymański", DateOfBirth= DateTime.Parse("17.04.1997"), Email = "mszymanski@test.com", EnrollmentDate = DateTime.Parse("01.09.2021")},
                new Student{FirstName="Joanna", LastName= "Włodarczyk", DateOfBirth= DateTime.Parse("19.12.1996"), Email = "jwlodarczyk@test.com", EnrollmentDate = DateTime.Parse("10.10.2022")},
                new Student{FirstName="Tomasz", LastName= "Kaczmarek", DateOfBirth= DateTime.Parse("25.08.1992"), Email = "tkaczmarek@test.com", EnrollmentDate = DateTime.Parse("05.06.2022")}

            };
            foreach (Student student in students)
            {
                context.Students.Add(student);
            }    
            context.SaveChanges();

            var instructors = new Instructor[]
            {
                new Instructor { FirstName = "Kim",     LastName = "Abercrombie",
                    HireDate = DateTime.Parse("11-03-1995") },
                new Instructor { FirstName = "Fadi",    LastName = "Fakhouri",
                    HireDate = DateTime.Parse("06-07-2002") },
                new Instructor { FirstName = "Roger",   LastName = "Harui",
                    HireDate = DateTime.Parse("01-07-1998") },
                new Instructor { FirstName = "Candace", LastName = "Kapoor",
                    HireDate = DateTime.Parse("02-01-2001") },
                new Instructor { FirstName = "Roger",   LastName = "Zheng",
                    HireDate = DateTime.Parse("12-02-2004") },
                new Instructor { FirstName = "Alice",   LastName = "Smith",
                    HireDate = DateTime.Parse("15-05-1997") },
                new Instructor { FirstName = "John",    LastName = "Doe",
                    HireDate = DateTime.Parse("22-08-1996") },
                new Instructor { FirstName = "Emily",   LastName = "Johnson",
                    HireDate = DateTime.Parse("19-11-2000") },
                new Instructor { FirstName = "Michael", LastName = "Brown",
                    HireDate = DateTime.Parse("03-04-2003") },
                new Instructor { FirstName = "Sarah",   LastName = "Davis",
                    HireDate = DateTime.Parse("10-09-1999") },
                new Instructor { FirstName = "David",   LastName = "Wilson",
                    HireDate = DateTime.Parse("05-06-2005") },
                new Instructor { FirstName = "Laura",   LastName = "Moore",
                    HireDate = DateTime.Parse("28-10-1994") },
                new Instructor { FirstName = "James",   LastName = "Taylor",
                    HireDate = DateTime.Parse("14-12-2002") },
                new Instructor { FirstName = "Jessica", LastName = "Anderson",
                    HireDate = DateTime.Parse("17-07-1998") },
                new Instructor { FirstName = "Robert",  LastName = "Thomas",
                    HireDate = DateTime.Parse("23-03-2001") }

            };

            foreach (Instructor i in instructors)
            {
                context.Instructors.Add(i);
            }
            context.SaveChanges();

            var departments = new Department[]
            {
                new Department { Name = "English",     Budget = 350000,
                    StartDate = DateTime.Parse("01-09-2007"),
                    InstructorID  = instructors.Single( i => i.LastName == "Abercrombie").ID },
                new Department { Name = "Mathematics", Budget = 100000,
                    StartDate = DateTime.Parse("01-09-2007"),
                    InstructorID  = instructors.Single( i => i.LastName == "Fakhouri").ID },
                new Department { Name = "Engineering", Budget = 350000,
                    StartDate = DateTime.Parse("01-09-2007"),
                    InstructorID  = instructors.Single( i => i.LastName == "Harui").ID },
                new Department { Name = "Economics",   Budget = 100000,
                    StartDate = DateTime.Parse("01-09-2007"),
                    InstructorID  = instructors.Single( i => i.LastName == "Kapoor").ID },
                new Department { Name = "Computer Science", Budget = 200000,
                    StartDate = DateTime.Parse("01-09-2007"),
                    InstructorID  = instructors.Single( i => i.LastName == "Zheng").ID },
                new Department { Name = "History", Budget = 150000,
                    StartDate = DateTime.Parse("01-09-2007"),
                    InstructorID  = instructors.Single( i => i.LastName == "Smith").ID },
                new Department { Name = "Physics", Budget = 250000,
                    StartDate = DateTime.Parse("01-09-2007"),
                    InstructorID  = instructors.Single( i => i.LastName == "Johnson").ID },
                new Department { Name = "Biology", Budget = 300000,
                    StartDate = DateTime.Parse("01-09-2007"),
                    InstructorID  = instructors.Single( i => i.LastName == "Brown").ID },
                new Department { Name = "Chemistry", Budget = 275000,
                    StartDate = DateTime.Parse("01-09-2007"),
                    InstructorID  = instructors.Single( i => i.LastName == "Davis").ID }

            };

            foreach (Department d in departments)
            {
                context.Departments.Add(d);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Chemistry", Description = "Chemistry 101",Credits=3, DepartmentID = departments.Single( s => s.Name == "Engineering").DepartmentID},
                new Course{CourseID=4022,Title="Microeconomics", Description = "Economy for small businesses",Credits=3, DepartmentID = departments.Single( s => s.Name == "Economics").DepartmentID},
                new Course{CourseID=4041,Title="Macroeconomics", Description = "How the Wall Street works",Credits=3, DepartmentID = departments.Single( s => s.Name == "Economics").DepartmentID},
                new Course{CourseID=1045,Title="Calculus", Description = "Learn to count",Credits=4, DepartmentID = departments.Single( s => s.Name == "Mathematics").DepartmentID},
                new Course{CourseID=3141,Title="Trigonometry", Description = "How do triangles work",Credits=4, DepartmentID = departments.Single( s => s.Name == "Mathematics").DepartmentID},
                new Course{CourseID=2021,Title="Composition", Description = "Compose with us",Credits=3, DepartmentID = departments.Single( s => s.Name == "English").DepartmentID},
                new Course{CourseID=2042,Title="Literature", Description = "Read books professionally",Credits=4, DepartmentID = departments.Single( s => s.Name == "English").DepartmentID},
                new Course{CourseID=3067, Title="Algorithms", Description="Learn efficient problem-solving techniques", Credits=3, DepartmentID = departments.Single( s => s.Name == "Computer Science").DepartmentID},
                new Course{CourseID=1098, Title="Data Structures", Description="Organize data for efficient access and modification", Credits=4, DepartmentID = departments.Single( s => s.Name == "Computer Science").DepartmentID},
                new Course{CourseID=5074, Title="World History", Description="Explore global historical events", Credits=3, DepartmentID = departments.Single( s => s.Name == "History").DepartmentID},
                new Course{CourseID=1235, Title="Ancient Civilizations", Description="Study the ancient cultures and societies", Credits=3, DepartmentID = departments.Single( s => s.Name == "History").DepartmentID},
                new Course{CourseID=4280, Title="Classical Mechanics", Description="Understand the laws of motion and forces", Credits=4, DepartmentID = departments.Single( s => s.Name == "Physics").DepartmentID},
                new Course{CourseID=3347, Title="Quantum Physics", Description="Dive into the world of subatomic particles", Credits=5, DepartmentID = departments.Single( s => s.Name == "Physics").DepartmentID},
                new Course{CourseID=6285, Title="Cell Biology", Description="Study the structure and function of cells", Credits=3, DepartmentID = departments.Single( s => s.Name == "Biology").DepartmentID},
                new Course{CourseID=7432, Title="Genetics", Description="Explore the science of genes and heredity", Credits=4, DepartmentID = departments.Single( s => s.Name == "Biology").DepartmentID},
                new Course{CourseID=8321, Title="Organic Chemistry", Description="Learn about the structure and reactions of organic compounds", Credits=4, DepartmentID = departments.Single( s => s.Name == "Chemistry").DepartmentID},
                new Course{CourseID=9587, Title="Inorganic Chemistry", Description="Study the properties and behaviors of inorganic substances", Credits=4, DepartmentID = departments.Single( s => s.Name == "Chemistry").DepartmentID},
                new Course{CourseID=1073, Title="Creative Writing", Description="Develop your writing skills and creativity", Credits=3, DepartmentID = departments.Single( s => s.Name == "English").DepartmentID},
                new Course{CourseID=3541, Title="Poetry", Description="Analyze and write poetry", Credits=3, DepartmentID = departments.Single( s => s.Name == "English").DepartmentID},
                new Course{CourseID=6789, Title="Abstract Algebra", Description="Understand algebraic structures", Credits=5, DepartmentID = departments.Single( s => s.Name == "Mathematics").DepartmentID},
                new Course{CourseID=9876, Title="Differential Equations", Description="Solve equations involving derivatives", Credits=4, DepartmentID = departments.Single( s => s.Name == "Mathematics").DepartmentID},
                new Course{CourseID=2468, Title="Linear Algebra", Description="Study vector spaces and linear mappings", Credits=4, DepartmentID = departments.Single( s => s.Name == "Mathematics").DepartmentID},
                new Course{CourseID=1357, Title="Introduction to Engineering", Description="Basics of engineering principles", Credits=3, DepartmentID = departments.Single( s => s.Name == "Engineering").DepartmentID},
                new Course{CourseID=9753, Title="Thermodynamics", Description="Study heat and energy transfer", Credits=4, DepartmentID = departments.Single( s => s.Name == "Engineering").DepartmentID},
                new Course{CourseID=8642, Title="Fluid Mechanics", Description="Understand the behavior of fluids", Credits=4, DepartmentID = departments.Single( s => s.Name == "Engineering").DepartmentID},
                new Course{CourseID=7584, Title="Business Management", Description="Learn the fundamentals of managing a business", Credits=3, DepartmentID = departments.Single( s => s.Name == "Economics").DepartmentID},
                new Course{CourseID=6423, Title="Marketing Principles", Description="Study the basics of marketing strategies", Credits=3, DepartmentID = departments.Single( s => s.Name == "Economics").DepartmentID},
                new Course{CourseID=5319, Title="Finance", Description="Understand financial management and investment", Credits=4, DepartmentID = departments.Single( s => s.Name == "Economics").DepartmentID},
                new Course{CourseID=9870, Title="Software Development", Description="Learn to develop software applications", Credits=4, DepartmentID = departments.Single( s => s.Name == "Computer Science").DepartmentID},
                new Course{CourseID=4563, Title="Operating Systems", Description="Study the design and implementation of OS", Credits=4, DepartmentID = departments.Single( s => s.Name == "Computer Science").DepartmentID},
                new Course{CourseID=2378, Title="Database Systems", Description="Manage and design database systems", Credits=4, DepartmentID = departments.Single( s => s.Name == "Computer Science").DepartmentID},
                new Course{CourseID=4837, Title="Modern History", Description="Study historical events of the modern era", Credits=3, DepartmentID = departments.Single( s => s.Name == "History").DepartmentID},
                new Course{CourseID=9274, Title="Medieval History", Description="Explore the medieval period", Credits=3, DepartmentID = departments.Single( s => s.Name == "History").DepartmentID},
                new Course{CourseID=5610, Title="Astrophysics", Description="Study the physics of the universe", Credits=4, DepartmentID = departments.Single( s => s.Name == "Physics").DepartmentID},
                new Course{CourseID=6745, Title="Biochemistry", Description="Learn the chemical processes in living organisms", Credits=5, DepartmentID = departments.Single( s => s.Name == "Biology").DepartmentID},
                new Course{CourseID=8971, Title="Environmental Science", Description="Study the environment and solutions to environmental issues", Credits=4, DepartmentID = departments.Single( s => s.Name == "Biology").DepartmentID},
                new Course{CourseID=3124, Title="Physical Chemistry", Description="Understand the physical basis of chemical systems", Credits=4, DepartmentID = departments.Single( s => s.Name == "Chemistry").DepartmentID}

            };
            foreach(Course course in courses)
            {
                context.Courses.Add(course);
            }
            context.SaveChanges();

            var officeAssignments = new OfficeAssignment[]
           {
                new OfficeAssignment {
                    InstructorID = instructors.Single( i => i.LastName == "Fakhouri").ID,
                    Location = "Smith 17" },
                new OfficeAssignment {
                    InstructorID = instructors.Single( i => i.LastName == "Harui").ID,
                    Location = "Gowan 27" },
                new OfficeAssignment {
                    InstructorID = instructors.Single( i => i.LastName == "Kapoor").ID,
                    Location = "Thompson 304" },
                new OfficeAssignment {
                    InstructorID = instructors.Single( i => i.LastName == "Abercrombie").ID,
                    Location = "Smith 101" },
                new OfficeAssignment {
                    InstructorID = instructors.Single( i => i.LastName == "Zheng").ID,
                    Location = "Gowan 15" },
                new OfficeAssignment {
                    InstructorID = instructors.Single( i => i.LastName == "Smith").ID,
                    Location = "Thompson 208" },
                new OfficeAssignment {
                    InstructorID = instructors.Single( i => i.LastName == "Johnson").ID,
                    Location = "Wells 310" },
                new OfficeAssignment {
                    InstructorID = instructors.Single( i => i.LastName == "Brown").ID,
                    Location = "Johnson 22" },
                new OfficeAssignment {
                    InstructorID = instructors.Single( i => i.LastName == "Davis").ID,
                    Location = "Clark 110" },
                new OfficeAssignment {
                    InstructorID = instructors.Single( i => i.LastName == "Wilson").ID,
                    Location = "Wells 105" },
                new OfficeAssignment {
                    InstructorID = instructors.Single( i => i.LastName == "Moore").ID,
                    Location = "Thompson 420" },
                new OfficeAssignment {
                    InstructorID = instructors.Single( i => i.LastName == "Taylor").ID,
                    Location = "Smith 303" },
                new OfficeAssignment {
                    InstructorID = instructors.Single( i => i.LastName == "Anderson").ID,
                    Location = "Gowan 112" }
           };

            foreach (OfficeAssignment o in officeAssignments)
            {
                context.OfficeAssignments.Add(o);
            }
            context.SaveChanges();

            var courseInstructors = new CourseAssignment[]
            {
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Kapoor").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Harui").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Microeconomics" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Zheng").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Macroeconomics" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Zheng").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Calculus" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Fakhouri").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Trigonometry" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Harui").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Composition" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Abercrombie").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Literature" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Abercrombie").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Algorithms" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Zheng").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Data Structures" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Smith").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "World History" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Johnson").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Ancient Civilizations" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Brown").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Classical Mechanics" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Davis").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Quantum Physics" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Wilson").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Cell Biology" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Moore").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Genetics" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Taylor").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Organic Chemistry" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Anderson").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Inorganic Chemistry" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Thomas").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Creative Writing" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Smith").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Poetry" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Johnson").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Abstract Algebra" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Brown").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Differential Equations" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Davis").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Linear Algebra" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Wilson").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Introduction to Engineering" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Moore").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Thermodynamics" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Taylor").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Fluid Mechanics" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Anderson").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Business Management" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Thomas").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Marketing Principles" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Abercrombie").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Finance" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Fakhouri").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Software Development" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Harui").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Operating Systems" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Kapoor").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Database Systems" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Zheng").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Modern History" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Smith").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Medieval History" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Johnson").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Astrophysics" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Brown").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Biochemistry" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Davis").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Environmental Science" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Wilson").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Physical Chemistry" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Moore").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Smith").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Microeconomics" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Brown").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Macroeconomics" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Johnson").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Calculus" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Davis").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Trigonometry" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Wilson").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Composition" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Moore").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Literature" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Taylor").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Algorithms" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Anderson").ID
                    },
                new CourseAssignment {
                    CourseID = courses.Single(c => c.Title == "Data Structures" ).CourseID,
                    InstructorID = instructors.Single(i => i.LastName == "Thomas").ID
                    }

            };

            foreach (CourseAssignment ci in courseInstructors)
            {
                context.CourseAssignments.Add(ci);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
           {
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Lasecki").ID,
                    CourseID = courses.Single(c => c.Title == "Calculus").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Lasecki").ID,
                    CourseID = courses.Single(c => c.Title == "Algorithms").CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Wodzionka").ID,
                    CourseID = courses.Single(c => c.Title == "Microeconomics").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Wodzionka").ID,
                    CourseID = courses.Single(c => c.Title == "Macroeconomics").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Krawiec").ID,
                    CourseID = courses.Single(c => c.Title == "Composition").CourseID,
                    Grade = Grade.C
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Krawiec").ID,
                    CourseID = courses.Single(c => c.Title == "Literature").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Kolec").ID,
                    CourseID = courses.Single(c => c.Title == "Abstract Algebra").CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Kolec").ID,
                    CourseID = courses.Single(c => c.Title == "Differential Equations").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Muszyna").ID,
                    CourseID = courses.Single(c => c.Title == "Poetry").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Muszyna").ID,
                    CourseID = courses.Single(c => c.Title == "Creative Writing").CourseID,
                    Grade = Grade.C
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Hetman").ID,
                    CourseID = courses.Single(c => c.Title == "Microeconomics").CourseID,
                    Grade = Grade.C
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Hetman").ID,
                    CourseID = courses.Single(c => c.Title == "Macroeconomics").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Oponka").ID,
                    CourseID = courses.Single(c => c.Title == "World History").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Oponka").ID,
                    CourseID = courses.Single(c => c.Title == "Ancient Civilizations").CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Kabel").ID,
                    CourseID = courses.Single(c => c.Title == "Physical Chemistry").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Kabel").ID,
                    CourseID = courses.Single(c => c.Title == "Organic Chemistry").CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Nowak").ID,
                    CourseID = courses.Single(c => c.Title == "Database Systems").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Nowak").ID,
                    CourseID = courses.Single(c => c.Title == "Operating Systems").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Kowalski").ID,
                    CourseID = courses.Single(c => c.Title == "Software Development").CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Kowalski").ID,
                    CourseID = courses.Single(c => c.Title == "Data Structures").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Wiśniewska").ID,
                    CourseID = courses.Single(c => c.Title == "Chemistry").CourseID,
                    Grade = Grade.C
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Wiśniewska").ID,
                    CourseID = courses.Single(c => c.Title == "Biochemistry").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Wójcik").ID,
                    CourseID = courses.Single(c => c.Title == "Thermodynamics").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Wójcik").ID,
                    CourseID = courses.Single(c => c.Title == "Fluid Mechanics").CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Kamińska").ID,
                    CourseID = courses.Single(c => c.Title == "Cell Biology").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Kamińska").ID,
                    CourseID = courses.Single(c => c.Title == "Genetics").CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Lewandowski").ID,
                    CourseID = courses.Single(c => c.Title == "Introduction to Engineering").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Lewandowski").ID,
                    CourseID = courses.Single(c => c.Title == "Linear Algebra").CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Zielińska").ID,
                    CourseID = courses.Single(c => c.Title == "Modern History").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Zielińska").ID,
                    CourseID = courses.Single(c => c.Title == "Medieval History").CourseID,
                    Grade = Grade.C
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Szymański").ID,
                    CourseID = courses.Single(c => c.Title == "Astrophysics").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Szymański").ID,
                    CourseID = courses.Single(c => c.Title == "Quantum Physics").CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Włodarczyk").ID,
                    CourseID = courses.Single(c => c.Title == "Biochemistry").CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Włodarczyk").ID,
                    CourseID = courses.Single(c => c.Title == "Environmental Science").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Kaczmarek").ID,
                    CourseID = courses.Single(c => c.Title == "Classical Mechanics").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Kaczmarek").ID,
                    CourseID = courses.Single(c => c.Title == "Astrophysics").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Lasecki").ID,
                    CourseID = courses.Single(c => c.Title == "Trigonometry").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Krawiec").ID,
                    CourseID = courses.Single(c => c.Title == "Inorganic Chemistry").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Kolec").ID,
                    CourseID = courses.Single(c => c.Title == "Business Management").CourseID,
                    Grade = Grade.C
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Muszyna").ID,
                    CourseID = courses.Single(c => c.Title == "Marketing Principles").CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Hetman").ID,
                    CourseID = courses.Single(c => c.Title == "Finance").CourseID,
                    Grade = Grade.A
                }

           };

            foreach (Enrollment e in enrollments)
            {
                var enrollmentInDataBase = context.Enrollments.Where(
                    s =>
                            s.Student.ID == e.StudentID &&
                            s.Course.CourseID == e.CourseID).SingleOrDefault();
                if (enrollmentInDataBase == null)
                {
                    context.Enrollments.Add(e);
                }
            }
            context.SaveChanges();
        }
    }
}