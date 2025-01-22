using Empresa.Churras.Domain.Model.Entities;

namespace Empresa.Churras.Tests.Entities;

[TestClass]
public class EventoTest
{
    [TestMethod]
    public void ConfirmarPresencaTest()
    {
        var colega = new Colega 
        { 
        Key = 1,
        Nome = "Ti�o"
        };

        var evento = new Evento 
        { 
        Nome = "Churras na casa do Ary",
        };

        evento.ColegasConfirmados = null;

        evento.ConfirmarPresenca(colega);

        var confirmacao = evento.ColegasConfirmados.FirstOrDefault(x => x.ColegaNome == "Ti�o");
        
        Assert.IsNotNull(confirmacao, "N�o encontrou o Ti�o na lista de Confirma��o.");
        Assert.AreEqual(colega.Key, confirmacao.ColegaKey, $"Comfirma��o n�o � do colega com o ID {colega.Key}");
    }

    [TestMethod]
    public void CancelarPresencaTest()
    {
        var colega = new Colega
        {
            Key = 1,
            Nome = "Ti�o"
        };

        var evento = new Evento
        {
            Nome = "Churras na casa do Ary",
        };

        evento.ColegasConfirmados = null;

        evento.ConfirmarPresenca(colega);

        evento.CancelarPresenca(colega);

        var confirmacao = evento.ColegasConfirmados.FirstOrDefault(x => x.ColegaNome == "Ti�o");

        Assert.IsNull(confirmacao, "O Ti�o continua na lista de presen�a.");
    }
}
