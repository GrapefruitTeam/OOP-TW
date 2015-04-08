namespace RestaurantApp.Interfaces
{
    using RestaurantApp.Persons.Personnel;

    public interface IReport
    {
        void CreateReport(string startDate, string endDate);

        void CreateEmployeeReport(AuthorizedEmployee employee, string startDate, string endDate);
    }
}
