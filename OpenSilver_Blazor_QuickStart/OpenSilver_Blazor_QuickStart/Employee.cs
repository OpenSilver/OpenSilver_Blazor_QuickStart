using System;

namespace OpenSilver_Blazor_QuickStart
{
    /// <summary>
    /// Sample employee data model for demonstrating Radzen DataGrid.
    /// </summary>
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public string Notes { get; set; }

        /// <summary>
        /// Sample employee data for the DataGrid demonstration.
        /// </summary>
        public static Employee[] SampleData = new Employee[]
        {
            new Employee
            {
                FirstName = "Nancy",
                LastName = "Davolio",
                BirthDate = DateTime.Parse("1968-12-08"),
                Country = "USA",
                Notes = "Education includes a BA in psychology from Colorado State University."
            },
            new Employee
            {
                FirstName = "Andrew",
                LastName = "Fuller",
                BirthDate = DateTime.Parse("1972-02-19"),
                Country = "USA",
                Notes = "Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing."
            },
            new Employee
            {
                FirstName = "Janet",
                LastName = "Leverling",
                BirthDate = DateTime.Parse("1983-08-30"),
                Country = "USA",
                Notes = "Janet has a BS degree in chemistry from Boston College."
            },
            new Employee
            {
                FirstName = "Margaret",
                LastName = "Peacock",
                BirthDate = DateTime.Parse("1957-09-19"),
                Country = "USA",
                Notes = "Margaret holds a BA in English literature from Concordia College."
            },
            new Employee
            {
                FirstName = "Steven",
                LastName = "Buchanan",
                BirthDate = DateTime.Parse("1975-03-04"),
                Country = "UK",
                Notes = "Steven graduated from St. Andrews University, Scotland, with a BSC degree."
            },
            new Employee
            {
                FirstName = "Michael",
                LastName = "Suyama",
                BirthDate = DateTime.Parse("1983-07-02"),
                Country = "UK",
                Notes = "Michael is a graduate of Sussex University (MA, economics)."
            },
            new Employee
            {
                FirstName = "Robert",
                LastName = "King",
                BirthDate = DateTime.Parse("1983-07-02"),
                Country = "UK",
                Notes = "Robert served in the Peace Corps and traveled extensively."
            },
            new Employee
            {
                FirstName = "Laura",
                LastName = "Callahan",
                BirthDate = DateTime.Parse("1978-01-09"),
                Country = "USA",
                Notes = "Laura received a BA in psychology from the University of Washington."
            },
            new Employee
            {
                FirstName = "Anne",
                LastName = "Dodsworth",
                BirthDate = DateTime.Parse("1986-01-27"),
                Country = "UK",
                Notes = "Anne has a BA degree in English from St. Lawrence College."
            }
        };
    }
}
