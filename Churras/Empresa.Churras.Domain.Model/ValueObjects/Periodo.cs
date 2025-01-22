using Kernel.Domain.Model.ValueObjects;

namespace Empresa.Churras.Domain.Model.ValueObjects
{
    public class Periodo : ValueObject
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }

    }
}
