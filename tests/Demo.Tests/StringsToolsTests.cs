namespace Demo.Tests;

public class StringsToolsTests
{
    [Fact]
    public void StringsTools_Unir_RetornarStringUnida()
    {
        //Arrange
        var strTools = new StringsTools();

        //Act
        var nomeCompleto = strTools.Unir("Alexandre", "Quintela");

        //Assert
        Assert.Equal("Alexandre Quintela", nomeCompleto);
    }

    [Fact]
    public void StringsTools_UnirNomes_DeveIgnorarCase()
    {
        //Arrange
        var strTools = new StringsTools();

        //Act
        var nomeCompleto = strTools.Unir("Alexandre", "Quintela");

        //Assert
        Assert.Equal("ALEXANDRE QUINTELA", nomeCompleto, true);
    }

    [Fact]
    public void StringTools_UnirNomes_DeveConterTrecho()
    {
        //Arrange
        var strTools = new StringsTools();
        //Act
        var nomeCompleto = strTools.Unir("Alexandre", "Quintela");

        //Assert
        Assert.Contains("tela", nomeCompleto);
    }

    [Fact]
    public void StringTools_UnirNomes_DeveComecarCom()
    {
        //Arrange
        var strTools = new StringsTools();

        //Act
        var nomeCompleto = strTools.Unir("Alexandre", "Quintela");

        //Assert
        Assert.StartsWith("Alex", nomeCompleto);
    }

    [Fact]
    public void StringTools_UnirNomes_DeveTerminarCom()
    {
        //Arrange
        var strTools = new StringsTools();

        //Act
        var nomeCompleto = strTools.Unir("Alexandre", "Quintela");

        //Assert
        Assert.EndsWith("tela", nomeCompleto);
    }

    [Fact]
    public void StringTools_UnirNomes_ValidarExpressaoRegular()
    {
        //Arrange
        var strTools = new StringsTools();

        //Act
        var nomeCompleto = strTools.Unir("Alexandre", "Quintela");

        //Assert
        Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", nomeCompleto);
    }
}

