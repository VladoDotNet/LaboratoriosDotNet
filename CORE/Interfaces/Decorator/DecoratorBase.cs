namespace CORE.Interfaces.Decorator
{
    public abstract class DecoratorBase : ComponenteBase
    {
        protected ComponenteBase _aComponente;

        public DecoratorBase(ComponenteBase aComponente)
        {
            _aComponente = aComponente;
        }

        public void SetComponente(ComponenteBase aComponente)
        {
            _aComponente = aComponente;
        }

        // El DECORADOR DELEGA todo el trabajo al componente wrapped (envoltorio)...
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
