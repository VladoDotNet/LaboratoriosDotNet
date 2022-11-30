using CORE.Interfaces.Composite;

namespace PATRONESAPP.ClientComposite
{
    // El código del cliente funciona con todos los componentes
    // a través de la interface base
   
    public class Client
    {
        public void ClientRequest(AComponent leaf)
        {
            Console.WriteLine($"RESULTADO : {leaf.Operaciones()}");
        }

        public void ClienteRequestComp(AComponent aComponent1,
            AComponent aComponent2)
        {
            if (aComponent1.IsComposite())
            {
                aComponent1.Agregar(aComponent2);
            }

            Console.WriteLine($"RESULTADO : {aComponent1.Operaciones()}");
        }
    }
}
