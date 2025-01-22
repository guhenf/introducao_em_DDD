using System.ComponentModel;

namespace Empresa.Churras.Domain.Model.Enums
{
    public enum TipoEvento
    {
        [Description("Churrasco")]
        Churras = 1,
        [Description("Rodizio de Pizza")]
        Pizza = 2, 
        Lanche = 3, 
        Outros = 999
    }
}
