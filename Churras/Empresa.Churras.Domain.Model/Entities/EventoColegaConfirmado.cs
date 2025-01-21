using Kernel.Domain.Model.Entities;

namespace Empresa.Churras.Domain.Model.Entities
{
    public class EventoColegaConfirmado
    {
        public long ColegaKey { get; set; }
        public long ColegaNome { get; set; }
        public long OqueVaiLevar { get; set; }

    }
}
