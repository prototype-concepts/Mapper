
namespace Mapper.Mapper
{
    public interface IMapHelper
    {
        IMapHelper<TDestination> For<TDestination>(TDestination src);
    }

    public interface IMapHelperMap<TSource, TDestination>
    {
        TDestination Map(TSource src, TDestination dest);
    }

    public interface IMapHelper<TDestination>
    {
        IMapHelper<TDestination> MapUsing<TSource>(TSource model, IMapHelperMap<TSource, TDestination> mapper);
        TDestination Result();
    }
}
