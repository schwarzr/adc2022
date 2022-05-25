using System;

namespace Adc.CustomSchema.Database.Extendable
{
    public interface IAdditionalDataEntityMapping
    {
        Type Target { get; }

        Type Entity { get; }
    }
}
