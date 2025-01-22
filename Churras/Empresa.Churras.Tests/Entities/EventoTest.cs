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
        Nome = "Tião"
        };

        var evento = new Evento 
        { 
        Nome = "Churras na casa do Ary",
        };

        evento.ColegasConfirmados = null;

        evento.ConfirmarPresenca(colega);

        var confirmacao = evento.ColegasConfirmados.FirstOrDefault(x => x.ColegaNome == "Tião");
        
        Assert.IsNotNull(confirmacao, "Não encontrou o Tião na lista de Confirmação.");
        Assert.AreEqual(colega.Key, confirmacao.ColegaKey, $"Comfirmação não é do colega com o ID {colega.Key}");
    }

    [TestMethod]
    public void CancelarPresencaTest()
    {
        var colega = new Colega
        {
            Key = 1,
            Nome = "Tião"
        };

        var evento = new Evento
        {
            Nome = "Churras na casa do Ary",
        };

        evento.ColegasConfirmados = null;

        evento.ConfirmarPresenca(colega);

        evento.CancelarPresenca(colega);

        var confirmacao = evento.ColegasConfirmados.FirstOrDefault(x => x.ColegaNome == "Tião");

        Assert.IsNull(confirmacao, "O Tião continua na lista de presença.");
    }
}
