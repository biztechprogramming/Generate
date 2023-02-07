using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Generate.ViewModel;
using Data.Entities;

namespace AutoMapperService.Converters
{
    public class VAllTablesToTableConverter : ITypeConverter<VAllTables, Table>
    {
        public Table Convert(VAllTables source, Table destination, ResolutionContext context)
        {
            destination = new Table();

            destination.TableName = source.TableName;

            return destination;
        }
    }
}