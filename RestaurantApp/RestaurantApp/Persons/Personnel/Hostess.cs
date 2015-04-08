namespace RestaurantApp.Persons.Personnel
{
    using System;
    using RestaurantApp.Engine;
    using RestaurantApp.Interfaces;
    
    public class Hostess : AuthorizedEmployee, IReserve, ICancelReservation
    {
        public Hostess(string name, string employeeId, string password)
            : base(name, employeeId, password)
        {
        }

        public void ReserveTable(Table table, ClientType type)
        {
            if (table.TableStatus != TableStatus.Free)
            {
                Console.WriteLine("Table is not free.");
            }
            else
            {
                table.TableStatus = TableStatus.Reserved;
                table.Client.ClientType = type;
            }
        }

        public void CancelReservation(Table table)
        {
            if (table.TableStatus != TableStatus.Reserved)
            {
                Console.WriteLine("Table is not reserved.");
            }
            else
            {
                table.TableStatus = TableStatus.Free;
                table.Client.ClientType = ClientType.Regular;
            }
        }
    }
}