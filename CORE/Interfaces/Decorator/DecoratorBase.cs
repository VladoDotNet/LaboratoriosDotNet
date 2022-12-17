namespace CORE.Interfaces.Decorator
{
    //La clase Base Decorator tiene un campo para hacer referencia a un objeto ajustado.
    //El tipo de campo debe declararse como la interfaz del componente
    //para que pueda contener tanto componentes concretos como decoradores.
    //El decorador de la base delega todas las operaciones al objeto envuelto (wrapper).
    public abstract class DecoratorBase : ComponenteBase
    {
        protected ComponenteBase _aComponente; // DI , OBJETO WRAPPER
        public DecoratorBase(ComponenteBase aComponente)
        {
            _aComponente = aComponente;
        }
        public void SetComponente(ComponenteBase aComponente)
        {
            _aComponente = aComponente;
        }

        // El DECORADOR DELEGA todo el trabajo al componente wrapped (envuelto)...
        public override string Operacion()
        {
            if(_aComponente != null)
            {
                return _aComponente.Operacion();
            }
            else
            {
                return string.Empty;
            }
        }

    }
}
