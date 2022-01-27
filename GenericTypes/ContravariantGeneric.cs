
namespace GenericTypes
{
    interface IContravariant<in T> { }

    class ContravariantClass<T> : IContravariant<T> { }

    class Dummy { }
}
