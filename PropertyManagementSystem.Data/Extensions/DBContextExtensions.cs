using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection;

namespace PropertyManagementSystem.Data.Extensions
{
    public static class DBContextExtensions
    {
        public static List<PropertyInfo> GetDbSetProperties(this DbContext context)
        {
            var dbSetProperties = new List<PropertyInfo>();
            var properties = context.GetType().GetProperties();

            foreach (var property in properties)
            {
                var setType = property.PropertyType;

                var isDbSet = setType.IsGenericType && (typeof (DbSet<>).IsAssignableFrom(setType.GetGenericTypeDefinition()));

                if (isDbSet)
                {
                    dbSetProperties.Add(property);
                }
            }

            return dbSetProperties;

        }
    }
}
