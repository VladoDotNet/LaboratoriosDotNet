namespace Core.Interfaces.AbstractFactory
{
    public abstract class BaseProyectosAFactory
    {
        // Abstract Factory declara un conjunto de métodos que devuelven
        // diferentes productos abstractos.
        // Estos productos corresponden a categorias o familias como categoría superior.
        // Los productos de una familia son  por lo general capaces de colaborar entre ellos.

        //Observe que los obejetos a crear son de TIPOS ESPECÍFICOS (Interfaces)

        public abstract IPrySeminarios CrearProyectoSeminarios(string modalidad);
        public abstract IPryInvestigacion CrearProyectosInvestigacion(string modalidad);
    }
}
