using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adc.CustomSchema.Data.Metadata
{
    public class DefaultMetadataRepository : IMetadataRepository, IMetadataRepositorySetter
    {
        private MetadataModel _model;

        public DefaultMetadataRepository()
        {
            _model = new MetadataModel(0, new EntityMetadata[] { });
        }

        public MetadataModel GetModel()
        {
            return _model;
        }


        public void SetModel(MetadataModel model)
        {
            _model = model;
        }
    }
}
