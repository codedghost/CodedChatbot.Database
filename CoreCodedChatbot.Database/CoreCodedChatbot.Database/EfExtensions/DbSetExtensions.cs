using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Microsoft.EntityFrameworkCore
{
    public static class DbSetExtensions
    {
        public static string GetKeyField(Type type)
        {
            var allProperties = type.GetProperties();

            var keyProperty = allProperties.SingleOrDefault(p => p.IsDefined(typeof(KeyAttribute), true));

            return keyProperty != null ? keyProperty.Name : null;
        }

        public static IQueryable<T> OrderBy<T>(this IQueryable<T> source, string orderBy)
        {
            return source.GetOrderByQuery(orderBy, "OrderBy");
        }

        public static IQueryable<T> OrderByDescending<T>(this IQueryable<T> source, string orderBy)
        {
            return source.GetOrderByQuery(orderBy, "OrderByDescending");
        }

        public static IQueryable<T> FilterBy<T>(this IQueryable<T> source, string filterBy, object value)
        {
            return source.GetFilterByQuery(filterBy, value);
        }

        private static IQueryable<T> GetOrderByQuery<T>(this IQueryable<T> source, string orderBy, string methodName)
        {
            var sourceType = typeof(T);
            var property = sourceType.GetProperty(orderBy);
            var parameterExpression = Expression.Parameter(sourceType, "x");
            var getPropertyExpression = Expression.MakeMemberAccess(parameterExpression, property);
            var orderByExpression = Expression.Lambda(getPropertyExpression, parameterExpression);
            var resultExpression = Expression.Call(typeof(Queryable), methodName,
                new[] {sourceType, property.PropertyType}, source.Expression,
                orderByExpression);

            return source.Provider.CreateQuery<T>(resultExpression);
        }

        private static IQueryable<T> GetFilterByQuery<T>(this IQueryable<T> source, string filterBy, object value)
        {
            var sourceType = typeof(T);
            var property = sourceType.GetProperty(filterBy);

            var castValue = Convert.ChangeType(value, property.PropertyType);

            var parameterExpression = Expression.Parameter(sourceType, "x");
            var valueExpression = Expression.Constant(castValue, castValue.GetType());
            var getPropertyExpression = Expression.MakeMemberAccess(parameterExpression, property);

            var expression = Expression.Equal(getPropertyExpression, valueExpression);

            var filterByExpression = Expression.Lambda<Func<T, bool>>(expression, parameterExpression);

            return source.Where(filterByExpression);
        }
    }
}