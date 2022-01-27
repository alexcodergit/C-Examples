
namespace GenericTypes
{
    interface ICovariant<out T> { }

    class CovariantClass<T> : ICovariant<T> { }
}
