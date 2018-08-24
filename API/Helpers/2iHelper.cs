using API.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Helpers
{
    public static class _2iHelper
    {
        public static string GetTableName<T>() where T: class
        {
            var attrs = typeof(T).GetCustomAttributes(true);
            foreach (Attribute attr in attrs)
            {
                var o = attr as InfTable;

                if (o != null)
                    return o.Name;
            }
            return string.Empty; 
        }
    }
}
