// <copyright file="MedicamentTypeExtension.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hw8.Classes
{
    using Module_2_project.Models.Classes;

    public static class EmployeeTypeExtension
    {
        internal static Employee[] EmployeeSortingByType(this Employee[] staff)
        {
            Employee[] sortedArrayOfPeople;

            Array.Sort(staff, delegate (Employee me1, Employee me2)
            {
                return me1.Type.CompareTo(me2.Type);
            });

            sortedArrayOfPeople = staff;
            return sortedArrayOfPeople;
        }
        internal static int EmployeeCountByJob(this Employee[] meTy, string lookingType)
        {
            int count = 0;
            foreach (Employee meType in meTy)
            {
                if (meType.Type == lookingType)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
