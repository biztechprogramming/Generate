using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Generate.ViewModel;
using Data.Entities;

namespace AutoMapperService.Converters
{
    public class VAllTabColsToColumnConverter : ITypeConverter<VAllTabCols, Column>
    {
        public Column Convert(VAllTabCols source, Column destination, ResolutionContext context)
        {
            destination = new Column();

            destination.Name = source.ColumnName;
            destination.DataType = Type.GetType(source.DataType);

            return destination;
        }
    }
}