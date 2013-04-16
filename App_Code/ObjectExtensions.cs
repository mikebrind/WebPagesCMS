using System.Collections.Generic;
using System.ComponentModel;


public static class ObjectExtensions
{
    /// <summary>
    /// Adds properties to an existing anonymous type
    /// </summary>
    /// <param name="obj">The anonymous type to add the property to</param>
    /// <param name="name">The name of the property to add</param>
    /// <param name="value">The value of the propoerty to add</param>
    /// <returns>The anonymous type as a Dictionary</returns>
    public static IDictionary<string, object> AddProperty(this object obj, string name, object value) {
        var dictionary = obj.ToDictionary();
        dictionary.Add(name, value);
        return dictionary;
    }

    
    private static IDictionary<string, object> ToDictionary(this object obj) {
        IDictionary<string, object> result = new Dictionary<string, object>();
        var properties = TypeDescriptor.GetProperties(obj);
        foreach (PropertyDescriptor property in properties) {
            result.Add(property.Name, property.GetValue(obj));
        }
        return result;
    }
}
