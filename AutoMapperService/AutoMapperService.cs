using AutoMapper;
using AutoMapperService.Converters;

namespace AutoMapperService
{
    /// <summary>
    /// The mapper service using AutoMapper
    /// </summary>
    public class AutoMapperService : Infrastructure.Mapping.IMapper
    {
        /// <summary>
        /// Maps the specified domain.
        /// </summary>
        /// <typeparam name="TDomain">The type of the domain.</typeparam>
        /// <typeparam name="TItem">The type of the item.</typeparam>
        /// <param name="domain">The domain.</param>
        /// <returns>Returns a mapped entity.</returns>
        public TItem Map<TDomain, TItem>(TDomain domain) where TItem : class
        {
            return Mapper.Map<TDomain, TItem>(domain);
        }

        static AutoMapperService instance;
        // Constructor is 'protected'
        protected AutoMapperService()
        {
            init();
        }
        public static AutoMapperService Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (instance == null)
            {
                instance = new AutoMapperService();
            }
            return instance;
        }
        private void init()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Data.Entities.VAllTables, Generate.ViewModel.Table>().ConvertUsing(new VAllTablesToTableConverter());
                cfg.CreateMap<Data.Entities.VAllTabCols, Generate.ViewModel.Table>().ConvertUsing(new VAllTabColsToTableConverter());
                cfg.CreateMap<Data.Entities.VAllTabCols, Generate.ViewModel.Column>().ConvertUsing(new VAllTabColsToColumnConverter());
            });
        }
    }
}