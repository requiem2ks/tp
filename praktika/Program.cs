using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data;
using System.Data.SqlClient;

namespace praktika1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
          /*    var Employee = db.Employees.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Employee a in Employee)
                {
                    Console.WriteLine(a.EmployeeId + " " + a.FIOEmployee + " " + a.JobTitle);
                }
          */
          
                var Order = db.Orders.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Order a in Order)
                {
                    Console.WriteLine(a.OrderId + " " + a.OrderDate + " " +
                    a.ExecutionDate + " " + a.ClientID + " " + a.EmployeeID + " " + a.OfflinePurchase + " " + a.DeliveryID);
                }
          
            }
             
   /*         using (ApplicationContext db = new ApplicationContext())
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
   */
     
            using (ApplicationContext db = new ApplicationContext())
            {
                var orders = db.Orders.ToArray();
                var employee = db.Employees.Where(a => a.EmployeeId == 15).FirstOrDefault();
                Order order = new Order { OrderId = 15, Status = "not deserved yet", OrderDate = new DateTime(2022-12-14) };
                
              /* Employee employee = new Employee
                {
                    EmployeeId = 999,
                    //OrderId = 99,
                    //Status = "Товар в пути",

                };
              */

                db.Orders.Add(order);

                db.SaveChanges();
            }
     
            using (ApplicationContext db = new ApplicationContext())
            {
                var Order = db.Orders.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Order a in Order)
                {
                    Console.WriteLine(a.OrderId + " " + a.OrderDate + " " +
                    a.ExecutionDate + " " + a.ClientID + " " + a.EmployeeID + " " + a.OfflinePurchase + " " + a.DeliveryID);
                }

            }
        }
        
        
    }
}
