using System.Reflection;

namespace Lesson6.Services
{
    public static class TypeConvertion
    {
        public static TResult Convert<TResult, T>(T model) where TResult : class, new()
        {
            TResult result = new();
            typeof(T).GetProperties().ToList().ForEach(p =>
            {
                PropertyInfo? property = typeof(TResult).GetProperty(p.Name);
                property?.SetValue(result, p.GetValue(model));
            });

            return result;
        }
    }
}
