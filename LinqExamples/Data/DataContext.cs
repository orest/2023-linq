using LinqExamples.Models;

namespace LinqExamples.Data {
    public class DataContext {
        public List<Department> Departments {
            get {
                return new List<Department> {
                   new Department { DepartmentId=1,  DepartmentName="Sales" },
                    new Department { DepartmentId=2,  DepartmentName="Application Development" },
                    new Department { DepartmentId=3,  DepartmentName="Mobile Development" },
                    new Department { DepartmentId=4,  DepartmentName="IT Security" },
                    new Department { DepartmentId=5,  DepartmentName="Networking" },
                    new Department { DepartmentId=6,  DepartmentName="Human resources" },
                    new Department { DepartmentId=7,  DepartmentName="Database" },
                };
            }
        }

        public List<Employee> Employees {
            get {
                return new List<Employee> {
     new Employee(){FirstName = "Jennie", LastName = "Nichols",Gender = "F",DateOfBirth = DateTime.Today.AddYears(-25), DepartmentId = 1, HireDate = new DateTime(2022,2,3),Id = 1},
     new Employee(){FirstName = "Carley", LastName = "West",Gender = "F",DateOfBirth = DateTime.Today.AddYears(-34), DepartmentId = 1, HireDate = new DateTime(2022,4,3),Id = 2},
     new Employee(){FirstName = "Derek", LastName = "Cole",Gender = "M",DateOfBirth = DateTime.Today.AddYears(-21), DepartmentId = 7, HireDate = new DateTime(2016,1,3),Id = 3},
     new Employee(){FirstName = "Lilia", LastName = "Frazier",Gender = "F",DateOfBirth = DateTime.Today.AddYears(-45), DepartmentId = 2, HireDate = new DateTime(1998,5,12),Id = 4},
     new Employee(){FirstName = "Amanda", LastName = "Riggs",Gender = "F",DateOfBirth = DateTime.Today.AddYears(-56), DepartmentId = 2, HireDate = new DateTime(2000,5,12),Id = 5},
     new Employee(){FirstName = "Christopher", LastName = "Franklin",Gender = "M",DateOfBirth = DateTime.Today.AddYears(-21), DepartmentId = 7, HireDate = new DateTime(2000,1,3),Id = 6},
     new Employee(){FirstName = "Erik", LastName = "Barry",Gender = "M",DateOfBirth = DateTime.Today.AddYears(-21), DepartmentId = 7, HireDate = new DateTime(2000,1,3),Id = 7},
     new Employee(){FirstName = "Jonathan", LastName = "Perry",Gender = "M",DateOfBirth = DateTime.Today.AddYears(-21), DepartmentId = 7, HireDate = new DateTime(2000,1,3),Id = 8},
     new Employee(){FirstName = "Michael", LastName = "Willis",Gender = "M",DateOfBirth = DateTime.Today.AddYears(-60), DepartmentId = 2, HireDate = new DateTime(2000,1,3),Id = 9},
     new Employee(){FirstName = "Andrew", LastName = "Melton",Gender = "M",DateOfBirth = DateTime.Today.AddYears(-22), DepartmentId = 3, HireDate = new DateTime(2022,9,3),Id = 10},
     new Employee(){FirstName = "Jason", LastName = "Harper",Gender = "M",DateOfBirth = DateTime.Today.AddYears(-34), DepartmentId = 4, HireDate = new DateTime(2015,1,3),Id = 11},
     new Employee(){FirstName = "Kevin", LastName = "Clarke",Gender = "M",DateOfBirth = DateTime.Today.AddYears(-45), DepartmentId = 5, HireDate = new DateTime(2019,10,3),Id = 12},
     new Employee(){FirstName = "Nathan", LastName = "Gilbert",Gender = "M",DateOfBirth = DateTime.Today.AddYears(-30), DepartmentId = 5, HireDate = new DateTime(2021,1,3),Id = 13},
     new Employee(){FirstName = "Matthew", LastName = "Taylor",Gender = "M",DateOfBirth = DateTime.Today.AddYears(-54), DepartmentId = 6, HireDate = new DateTime(2019,5,3),Id = 14},
     new Employee(){FirstName = "Thomas", LastName = "Peterso",Gender = "M",DateOfBirth = DateTime.Today.AddYears(-65), DepartmentId = 7, HireDate = new DateTime(2018,1,3),Id = 15},
     new Employee(){FirstName = "Leslie", LastName = "Jones",Gender = "F",DateOfBirth = DateTime.Today.AddYears(-64), DepartmentId = 4, HireDate = new DateTime(1998,11,3),Id = 16},
     new Employee(){FirstName = "Kimberly", LastName = "Kennedy",Gender = "F",DateOfBirth = DateTime.Today.AddYears(-55), DepartmentId = 7, HireDate = new DateTime(2000,1,3),Id = 17},
                };
            }
        }

    }
}