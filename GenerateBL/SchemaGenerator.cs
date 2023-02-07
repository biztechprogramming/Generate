using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Mapping;
using Generate.ViewModel;

namespace GenerateBL
{
    public abstract class SchemaGenerator
    {
        protected IMapper _mapper;
        public SchemaGenerator(IMapper mapper)
        {
            _mapper = mapper;
        }

        public abstract List<Table> GetTables();
        public abstract List<Column> GetColumns(Table table);
    }
}
