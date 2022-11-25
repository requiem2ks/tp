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
            /*
            using (ApplicationContext db = new ApplicationContext())
            {
                var orders = db.Orders.ToArray();
                var employee = db.Employees.Where(a => a.EmployeeId == 15).FirstOrDefault();
                Order order = new Order { OrderId = 15, Status = "not deserved yet", OrderDate = new DateTime(2022-12-14) };   
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
            
            using (ApplicationContext db = new ApplicationContext())
            {
                Order? update = (from Order in db.Orders where Order.OrderId == 11 select Order).First();
                if (update != null)
                {
                    update.Status = "Тест";
                    db.SaveChanges();
                }
                var orders = db.Orders.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Order a in orders)
                {
                    Console.WriteLine(a.OrderId + " " + a.OrderDate + " " +
                    a.ExecutionDate + " " + a.ClientID + " " + a.EmployeeID + " " + a.OfflinePurchase + " " + a.DeliveryID);
                }
            }
            using (ApplicationContext db = new ApplicationContext())
            {
                Order? delete = (from Order in db.Orders where Order.OrderId == 11 select Order).First();
                if (delete != null)
                {
                    db.Orders.Remove(delete);
                    db.SaveChanges();
                }
                var users = db.Orders.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Order a in users)
                {
                    Console.WriteLine(a.OrderId + " " + a.OrderDate + " " +
                    a.ExecutionDate + " " + a.ClientID + " " + a.EmployeeID + " " + a.OfflinePurchase + " " + a.DeliveryID);
                }
            }
            */
            //Простая проекция
            using (ApplicationContext db = new ApplicationContext())
            {
                /*  var users = from p in db.Users.ToArray()
                              select p.Fio; */
                var users = db.Orders.ToArray().Select(a => a.OrderId);
                foreach (var a in users)
                {
                    Console.WriteLine(a);
                }
            }
            //Анонимный объект

            using (ApplicationContext db = new ApplicationContext())
            {
                /*var users = from p in db.Users.ToArray()
                            select new
                            {
                                Fio = p.Fio + "(New obj)",
                                Age = p.Age * 2
                            }; */
                var users = db.Orders.ToArray().Select(a => new
                {
                    OrderId = a.OrderId + "(New obj)",
                    Status = a.Status = ("Test123")
                });
                foreach (var a in users)
                {
                    Console.WriteLine(a.OrderId + " " + a.Status);
                }
            }

            //Переменные в операторах Linq
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = from a in db.Orders.ToArray()
                    let Status = a.Status = "Test321"
                    select new
                    {
                       OrderId = a.OrderId + "(New obj)",
                       Status = Status                                 
                    };
                 foreach (var a in users)
                 {
                     Console.WriteLine(a.OrderId + " " + a.Status);
                 }
            }

            //Декартово произведение
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = from u in db.Orders.ToArray()
                from c in db.Employees.ToArray()
                select new
                {
                    OrderId = u.OrderId,
                    EmployeeId = c.EmployeeId
                };
                     // var users = db.Users.ToArray(). (db.Countries.ToArray(), (u, c) => new { Fio = u.Fio, Country = c.Name });
                     foreach (var a in users)
                     {
                         Console.WriteLine(a.OrderId + " " + a.EmployeeId);
                     }

            }

            //Фильтрация коллекции
            using (ApplicationContext db = new ApplicationContext())
            {
                     /* var users = from p in db.Users.ToArray()
                                  where p.Id <= 2
                                  select p.Fio;*/ 
                var users = db.Orders.ToArray().Where(a => a.OrderId <= 12).Select(p => p.Status);
                foreach (var a in users)
                {
                    Console.WriteLine(a);
                }
            }

            //Сортировка коллекции

            using (ApplicationContext db = new ApplicationContext())
            {
                     /*  var users = from u in db.Users.ToArray()
                                    orderby u.Fio
                                    select u;  */
                var users = db.Orders.ToArray().OrderBy(u => u.OrderId);
                foreach (var a in users)
                {
                    Console.WriteLine(a.OrderId);
                }

            }


            //Объединение таблиц
            using (ApplicationContext db = new ApplicationContext())
            {

                     /*    var users = from u in db.Users.ToArray() join
                                      c in db.Companies.ToArray() on u.CompanyID equals c.Id
                                      select new { user = u.Fio, company = c.Name };
                     */

                var users = db.Orders.ToArray().Join(db.Employees.ToArray(), u => u.OrderId, c => c.EmployeeId, (u, c) => new { order = u.Status, employee = c.FIOEmployee });
                foreach (var p in users)
                {
                    Console.WriteLine(p.order + " " + p.employee);
                }

            }

            //Загрузка связанных данных
            using (ApplicationContext db = new ApplicationContext())
            {
                     var users = db.Orders.Include(u => u.Employee).ToArray();
                     foreach (var p in users)
                     {
                         Console.WriteLine(p.OrderId + " " + p.Employee?.EmployeeId);
                     }

            }
        }       
    }
}
