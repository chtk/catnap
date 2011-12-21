using System;

namespace Catnap.Maps.Impl
{
    public class ListParentIdColumnNameConvention
    {
        private readonly Func<IListPropertyMap, string> convention;

        public ListParentIdColumnNameConvention(Func<IListPropertyMap, string> convention)
        {
            this.convention = convention;
        }

        public string GetColumnName<TEntity, TProperty>(ListPropertyMap<TEntity, TProperty> map) 
            where TEntity : class, new()
            where TProperty : class, new()
        {
            return convention(map);
        }
    }
}