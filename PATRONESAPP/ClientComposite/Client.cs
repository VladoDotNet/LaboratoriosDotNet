using CORE.Interfaces.Composite;

namespace PATRONESAPP.ClientComposite
{
    // The client code works with all of the components via the base
    // interface.
    public class Client
    {
        public void ClientRequest(AComponent leaf)
        {
            Console.WriteLine($"RESULTADO : {leaf.Operaciones()}");
        }

        // The client code works with all of the components via the base
        // interface.
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
