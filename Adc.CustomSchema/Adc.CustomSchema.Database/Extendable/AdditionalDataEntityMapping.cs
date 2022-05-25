using System;
using Adc.CustomSchema.Data;

namespace Adc.CustomSchema.Database.Extendable
{
    public class AdditionalDataEntityMapping<TTarget, TEntity> : IAdditionalDataEntityMapping
        where TTarget : IExtendableObject
    {
        public AdditionalDataEntityMapping()
        {
            Target = typeof(TTarget);
            Entity = typeof(TEntity);
        }

        public Type Target { get; }

        public Type Entity { get; }
    }
}
