using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generate.ViewModel;
using Infrastructure.Mapping;

namespace GenerateBL
{
    public class OracleSchemaGenerator : SchemaGenerator
    {
        public OracleSchemaGenerator(IMapper mapper):base(mapper)
        {
        }

        public override List<Table> GetTables()
        {
            var ret = new List<Table>();
            // Connect to Oracle database and fetch table information
            // ...
            //var tables = new Data.Entities.VAllTablesDap().All().Where(x=> x.Owner == "BTREE" && x.TableName.StartsWith("BT_")).OrderBy(x => x.TableName);
            var valltables = new Data.Entities.VAllTablesDap().All().Where(x => x.Owner == "BTREE" && x.TableName == "BT_APP_USER").OrderBy(x => x.TableName).ToList();


            foreach (var valltable in valltables)
            {
                var table = _mapper.Map<Data.Entities.VAllTables, Generate.ViewModel.Table>(valltable);

                ret.Add(table);
            }

            return ret;
        }

        public override List<Column> GetColumns(Table table)
        {
            var ret = new List<Column>();

            var tableColumns = new Data.Entities.VAllTabColsDap().GetByTableName(table.TableName);

            foreach (var tableColumn in tableColumns)
            {
                var column = _mapper.Map<Data.Entities.VAllTabCols, Generate.ViewModel.Column>(tableColumn);

                ret.Add(column);
            }

            return ret;
        }
    }
}
