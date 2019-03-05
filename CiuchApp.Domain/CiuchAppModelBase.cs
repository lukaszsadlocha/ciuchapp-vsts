using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CiuchApp.Domain
{
    public abstract class CiuchAppBaseModel
    {
        [DisplayName("#")]
        public int Id { get; set; }
        [DisplayName("Obraz")]
        public string ImageName { get; set; }

        public List<KeyValuePair<string, string>> ToKeyValuePairs<T>(bool newItem)
        {
            var list = new List<KeyValuePair<string, string>>();

            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                // Add all DateTime fields, all dropdown values and Id if not new item
                if ((!newItem && property.PropertyType == typeof(Int32) && property.Name == "Id")
                    || (property.PropertyType == typeof(Int32) && property.Name != "Id" && property.Name.EndsWith("Id"))
                    || (property.PropertyType == typeof(Double) && property.Name.Contains("Price"))
                    || (property.PropertyType == typeof(Int32) && property.Name.Contains("Amount")) 
                    || (property.PropertyType == typeof(string) && property.Name == "Name"))
                {
                    list.Add(new KeyValuePair<string, string>(property.Name, property.GetValue(this).ToString()));
                }

                if (property.PropertyType == typeof(string) && property.Name == "ImageName")
                {
                    var imageNameValue = property.GetValue(this);
                    if (imageNameValue != null)
                    {
                        list.Add(new KeyValuePair<string, string>(property.Name, imageNameValue.ToString()));
                    }
                }

                if(property.PropertyType == typeof(DateTime))
                {
                    list.Add(new KeyValuePair<string, string>(property.Name, ((DateTime)property.GetValue(this)).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")));
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