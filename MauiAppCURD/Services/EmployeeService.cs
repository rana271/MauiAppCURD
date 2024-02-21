using MauiAppCURD.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppCURD.Services
{
   
    public class EmployeeService
    {
        private readonly SQLiteConnection _dbConnection;
        public EmployeeService()
        {

            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Employee.db3");
            _dbConnection = new SQLiteConnection(dbPath);
            _dbConnection.CreateTable<EmployeeModel>();

        }
        public List<EmployeeModel> GetAllEmployees()
        {

            var res = _dbConnection.Table<EmployeeModel>().ToList();
            return res;
        }

        public int InsertEmployee(EmployeeModel obj)
        {
            return _dbConnection.Insert(obj);
        }

        public int UpdateEmployee(EmployeeModel obj)
        {
            return _dbConnection.Update(obj);
        }

        public int DeleteEmployee(EmployeeModel obj)
        {
            return _dbConnection.Delete(obj);
        }

    }
}
