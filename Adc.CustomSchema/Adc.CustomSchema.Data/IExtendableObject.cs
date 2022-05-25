using System.Collections.Generic;

namespace Adc.CustomSchema.Data
{
    public interface IExtendableObject
    {
        public Dictionary<string, object> AdditionalProperties { get; set; }
    }
}
