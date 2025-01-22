using Empresa.Churras.Domain.Model.ValueObjects;

namespace Empresa.Churras.Tests;

[TestClass]
public class PeriodoTest
{
    [TestMethod]
    public void QuantoDuraEmHoras()
    {
        var periodo = new Periodo 
        { 
            Inicio = new DateTime(2024, 08, 21, 12, 0, 0),
            Fim = new DateTime(2024, 08, 21, 20, 0, 0)
        };

        int horas = periodo.QuantoDuraEmHoras();

        Assert.AreEqual(8, horas);
    }

    [TestMethod]
    public void QuantoTempoFaltaParaComecar_1()
    {
        var dtInicio = DateTime.Now.AddDays(3).AddHours(5);
        var dtFim = dtInicio.AddHours(6);

        var periodo = new Periodo { Inicio = dtInicio, Fim = dtFim };

        string quantoFalta = periodo.QuantoFaltaParaComecar();

        Assert.AreEqual("Começa em 3 dias e 4 horas.", quantoFalta);
    }

    [TestMethod]
    public void QuantoTempoFaltaParaComecar_2()
    {
        var dtInicio = DateTime.Now.AddHours(5);
        var dtFim = dtInicio.AddHours(6);

        var periodo = new Periodo { Inicio = dtInicio, Fim = dtFim };

        string quantoFalta = periodo.QuantoFaltaParaComecar();

        Assert.AreEqual("Começa em 4 horas.", quantoFalta);

    }

    [TestMethod]
    public void QuantoTempoFaltaParaComecar_3()
    {
        var dtInicio = DateTime.Now.AddDays(-3);
        var dtFim = dtInicio.AddHours(6);

        var periodo = new Periodo { Inicio = dtInicio, Fim = dtFim };

        string quantoFalta = periodo.QuantoFaltaParaComecar();

        Assert.AreEqual("Esse evento ja começou.", quantoFalta);

    }
}
