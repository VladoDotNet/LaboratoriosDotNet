namespace Core.Interfaces.FactoryMethod
{
    public interface IRevistasAcedemicas
    {
        Task <string> GetNombreRevista();
        Task <string> TipoPublicacion();
    }
}
