using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using FInal.Models;

namespace FInal.Gateway
{
    public class DepartmentSave:ConnectionGateway
    {
        public bool IsExistDepartmentCode(string departmentCode)
        {
            Connection.Open();
            Query = "SELECT * FROM department_tbl WHERE depCode=@departmentCode";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("departmentCode", departmentCode);
            Reader = Command.ExecuteReader();
            bool hasRow = Reader.HasRows;
            Reader.Close();
            Connection.Close();
            return hasRow;

        }
        public bool IsExistDepartmentName(string departmentName)
        {
            Connection.Open();
            Query = "SELECT * FROM department_tbl WHERE depName=@departmentName";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("departmentName", departmentName);
            Reader = Command.ExecuteReader();
            bool hasRow = Reader.HasRows;
            Reader.Close();
            Connection.Close();
            return hasRow;
        }

        public int departmentAdd(Department data)
        {
            Connection.Open();
            Query = "INSERT INTO department_tbl(depCode,depName)VALUES(@departmentCode,@departmentName)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("departmentCode", data.DepartmentCode);
            Command.Parameters.AddWithValue("departmentName", data.DepartmentName);
            int rowCount = Command.ExecuteNonQuery();
            Connection.Close();
            return rowCount;
        }

        public List<Department> ViewDepartment()
        {
            Connection.Open();
            Query = "SELECT * FROM department_tbl";
            Command = new SqlCommand(Query, Connection);
            Reader = Command.ExecuteReader();
            List<Department> aDepartments = new List<Department>();
            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Department data = new Department();
                    data.DepartmentCode = Reader["depCode"].ToString();
                    data.DepartmentName = Reader["depName"].ToString();
                    aDepartments.Add(data);
                }
            }
            Reader.Close();
            Connection.Close();
            return aDepartments;
        }
    }
}