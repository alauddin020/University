using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FInal.Gateway;
using FInal.Models;

namespace FInal.BIL
{
    public class DepartmentManage
    {
        DepartmentSave aSave = new DepartmentSave();
        public bool IsExistDepartmentCode(string departmentCode)
        {
            return aSave.IsExistDepartmentCode(departmentCode);
        }

        public bool IsExistDepartmentName(string departmentName)
        {
            return aSave.IsExistDepartmentName(departmentName);
        }
        public string SaveDepartment(Department data)
        {
            if (IsExistDepartmentName(data.DepartmentName))
            {
                return "Department Name Already Exists";
            }
            if (IsExistDepartmentCode(data.DepartmentCode))
            {
                return "Category Code Already Exists";
            }
            int rowAffected = aSave.departmentAdd(data);
            if (rowAffected > 0)
            {
                return "Department Added Successfully";
            }
            return "Fail to Save Information!";
        }

        public List<Department> ViewAllDepartment()
        {
            return aSave.ViewDepartment();
        }
    }
}