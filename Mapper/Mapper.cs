
namespace Mapper.Mapper
{
  public class MapHelper : IMapHelper
    {
        public IMapHelper<TDestination> For<TDestination>(TDestination src)
        {
            return new MapHelper<TDestination>(src);
        }
    }

    public class MapHelper<TDestination> : IMapHelper<TDestination>
    {
        private TDestination _destination;

        public MapHelper(TDestination destination)
        {
            _destination = destination;
        }

        public IMapHelper<TDestination> MapUsing<TSource>(TSource src, IMapHelperMap<TSource, TDestination> mapper)
        {
            _destination = mapper.Map(src, _destination);

            return this;
        }

        public TDestination Result()
        {
            return _destination;
        }
    }
}
