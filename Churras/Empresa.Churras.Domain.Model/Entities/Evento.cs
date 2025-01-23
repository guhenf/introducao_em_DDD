using Empresa.Churras.Domain.Model.Enums;
using Empresa.Churras.Domain.Model.ValueObjects;
using Kernel.Domain.Model.Entities;

namespace Empresa.Churras.Domain.Model.Entities
{
    public class Evento : EntityKeySeq, IAggregateRoot
    {
        public string Nome { get; set; }
        public long DonoDaCasaKey { get; set; }
        public Colega DonoDaCasa { get; set; }
        public TipoEvento Tipo { get; set; }
        public DateTime Dia { get; set; }
        public Periodo Periodo { get; set; }
        public IList<EventoColegaConfirmado> ColegasConfirmados { get; set; }

        public Evento()
        {
            ColegasConfirmados = new List<EventoColegaConfirmado>();
        }
        public void ConfirmarPresenca(Colega colega)
        {
            if(ColegasConfirmados == null)
                ColegasConfirmados = new List<EventoColegaConfirmado>();

            ColegasConfirmados.Add(new EventoColegaConfirmado 
            { 
            ColegaNome = colega.Nome,
            ColegaKey = colega.Key
            });
        }

        public void CancelarPresenca(Colega colega)
        {
            if (ColegasConfirmados == null) return;

            var confirmarcao = ColegasConfirmados.FirstOrDefault(x => x.ColegaKey == colega.Key);

            if(confirmarcao != null)
            {
                ColegasConfirmados.Remove(confirmarcao);
            }
        }
    }
}
