namespace RestaurantApp
{
    using System;

    public interface IReport
    {
        void CreateReport(string startDate, string endDate);

        void CreateEmployeeReport(AuthorizedEmployee employee, string startDate, string endDate);
    }
}
