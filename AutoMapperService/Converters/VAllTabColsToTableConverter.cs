using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Generate.ViewModel;
using Data.Entities;

namespace AutoMapperService.Converters
{
    public class VAllTabColsToTableConverter : ITypeConverter<VAllTabCols, Table>
    {
        public Table Convert(VAllTabCols source, Table destination, ResolutionContext context)
        {
            destination = new Table();

            destination.TableName = source.TableName;

            var column = new Column
            {
                Name = source.ColumnName,
                DataType = Type.GetType(source.DataType)
                //,
                //IsPrimaryKey = vAllTabCols.p == "Y",
                //IsForeignKey = vAllTabCols.IsForeignKey == "Y",
                //IsNullable = vAllTabCols.IsNullable == "Y",
            };

            destination.Columns.Add(column);

            return destination;
        }
    }
}