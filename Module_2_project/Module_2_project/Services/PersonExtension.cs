// <copyright file="MedicineExtension.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace hw8.Classes
{
    using Module_2_project.Models.Classes;

    public static class PersonExtension
    {
        internal static Person[] FindByName(this Person[] pers, string name)
        {
            Person[] sortedArrayOfPeople = new Person[1000];

            for (int i = 0; i < pers.Length; i++)
            {
                if (pers[i] != null)
                {
                    if (pers[i].Name == name)
                    {
                        sortedArrayOfPeople[i] = pers[i];
                    }
                }
            }

            return sortedArrayOfPeople;
        }
    }
}