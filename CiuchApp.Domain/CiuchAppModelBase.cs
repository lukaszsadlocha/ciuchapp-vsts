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
    }
}