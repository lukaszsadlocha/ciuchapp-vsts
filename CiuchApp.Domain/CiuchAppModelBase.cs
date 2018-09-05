using System;
using System.Collections.Generic;

namespace CiuchApp.Domain
{
    public abstract class CiuchAppModelBase
    {
        public List<KeyValuePair<string, string>> ToKeyValuePairs<T>()
        {
            var list = new List<KeyValuePair<string, string>>();

            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                if ((property.PropertyType == typeof(Int32) && property.Name != "Id" && property.Name.EndsWith("Id")) || property.PropertyType == typeof(DateTime))
                {
                    list.Add(new KeyValuePair<string, string>(property.Name, property.GetValue(this).ToString()));
                }
            }

            return list;
        }

        public bool IsValid<T>(bool newItem)
        {
            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                if(property.PropertyType == typeof(DateTime))
                {
                    //All Date Times need to be filled
                    if (property.GetValue(this) == null || (DateTime)property.GetValue(this) == default(DateTime))
                    {
                        return false;
                    }
                }
                
                if ((property.PropertyType == typeof(Int32) && property.Name != "Id" && property.Name.EndsWith("Id")))
                {
                    //All Dropdowns need to be filled
                    if((int)property.GetValue(this) < 1)
                    {
                        return false;
                    }
                }

                if(!newItem && property.PropertyType == typeof(Int32) && property.Name == "Id")
                {
                    //If item updated then Id cannot be less then 1
                    if ((int)property.GetValue(this) < 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}