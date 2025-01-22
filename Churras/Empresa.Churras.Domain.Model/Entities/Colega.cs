using Kernel.Domain.Model.Entities;
using Kernel.Domain.Model.ValueObjects;

namespace Empresa.Churras.Domain.Model.Entities
{
    public class Colega : EntityKeySeq
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
    }
}
