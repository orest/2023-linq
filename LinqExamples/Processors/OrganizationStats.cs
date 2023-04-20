using LinqExamples.Data;
using LinqExamples.Models;

namespace LinqExamples.Processors
{
    public class OrganizationStats
    {
        private List<Employee> Employees { get; set; }

        public OrganizationStats()
        {
            var context = new DataContext();
            Employees = context.Employees;
        }

        public void Process()
        {

            //Filtering();
            //Sorting();
            //Sets();
            //Quantifiers();
            //Projection();
            //Joins();
            //Grouping();
            //Aggregation();


        }


        public int GetTotalEmployeeCount()
        {
            return Employees.Count;

        }
    }
}
