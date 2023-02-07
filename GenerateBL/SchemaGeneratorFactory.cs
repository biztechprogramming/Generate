using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Mapping;

namespace GenerateBL
{
    public static class SchemaGeneratorFactory
    {
        public static SchemaGenerator GetSchemaGenerator(IMapper mapper)
        {
            return new OracleSchemaGenerator(mapper);
        }
    }
}
