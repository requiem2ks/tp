using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;
using System.Linq;

namespace praktika1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var Employee = db.Employees.Include(a => a.Order).ToList();
                Console.WriteLine("Список объектов");
                foreach (Employee a in Employee)
                {
                    Console.WriteLine(a.EmployeeId + " " + a.FIOEmployee + " " + a.JobTitle + " " + a.Order?.OrderId + " " + a.Order?.OrderDate + " " +
                       a.Order?.ExecutionDate + " " + a.Order?.ClientID + " " + a.Order?.EmployeeID + " " + a.Order?.OfflinePurchase + a.Order?.DeliveryID);
                }
            }
            
        using (ApplicationContext db = new ApplicationContext())
        {
            var Order = db.Orders.Include(TR => TR.Employee).ToList();
            foreach (Order TR in Order)
            {
                Console.WriteLine($"\nЗаказ: {TR.OrderId}");
                foreach (Employee a in TR.Employee)
                {
                    Console.WriteLine(a.EmployeeId + " " + a.FIOEmployee);
                }
            }
        }
     
     /*
            using (ApplicationContext db = new ApplicationContext())
            {
                var employees = db.Employees.ToArray();
                var order = db.Orders.Where(TR => TR.OrderId == 11).FirstOrDefault();
                if (order == null)
                {
                    order = new Order { OrderId = 11, Status = "yep", ClientID = 28, EmployeeID = 222 };
                }
                Employee employee = new Employee
                {
                    EmployeeId = 999,
                    //OrderId = 99,
                    //Status = "Товар в пути",

                };


                db.Employees.Add(employee);

                db.SaveChanges();
            }
     */
            using (ApplicationContext db = new ApplicationContext())
            {
                var Employee = db.Employees.Include(a => a.Order).ToList();
                Console.WriteLine("Список объектов");
                foreach (Employee a in Employee)
                {
                    Console.WriteLine(a.EmployeeId + " " + a.FIOEmployee + " " + a.JobTitle + " " + a.Order?.OrderId + " " + a.Order?.OrderDate + " " +
                    a.Order?.ExecutionDate + " " + a.Order?.ClientID + " " + a.Order?.EmployeeID + " " + a.Order?.OfflinePurchase + a.Order?.DeliveryID);
                }
            }
        
        }
    }
}
