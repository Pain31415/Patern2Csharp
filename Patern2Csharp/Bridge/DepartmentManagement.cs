using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern2Csharp.Bridge
{
    public enum DepartmentType
    {
        Sales,
        Development,
        Marketing
    }

    public interface IDepartment
    {
        void PerformTask();
    }

    public class SalesDepartment : IDepartment
    {
        public void PerformTask()
        {
            Console.WriteLine("Sales Department: Handling customer inquiries and sales.");
        }
    }

    public class DevelopmentDepartment : IDepartment
    {
        public void PerformTask()
        {
            Console.WriteLine("Development Department: Developing new products and features.");
        }
    }

    public class MarketingDepartment : IDepartment
    {
        public void PerformTask()
        {
            Console.WriteLine("Marketing Department: Creating marketing strategies and campaigns.");
        }
    }
}
