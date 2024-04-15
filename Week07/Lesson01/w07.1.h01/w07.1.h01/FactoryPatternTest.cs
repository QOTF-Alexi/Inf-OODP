namespace FactoryPattern.Tests;

[TestClass]
public class FactoryPatternTest
{
    [TestMethod]
    public void CreateLightTheme_Document()
    {
        // Create a new DocumentFactory object and and create a document with a light theme
        var CounterfeitIdentityFactory = new DocumentFactory();
        var CounterfeitPassport = CounterfeitIdentityFactory.CreateLightTheme();

        // Assert that both the document BackGroundColor and FontColor contain the expected values for this theme.
        Assert.AreEqual(CounterfeitPassport.BackGroundColor, "White");
        Assert.AreEqual(CounterfeitPassport.FontColor, "Black");
    }

    [TestMethod]
    public void CreateDarkTheme_Document()
    {
        // Create a new DocumentFactory object and and create a document with a light theme
        var CounterfeitVisaFactory = new DocumentFactory();
        var CounterfeitUSATravelVisa = CounterfeitVisaFactory.CreateLightTheme();

        // Assert that both the document BackGroundColor and FontColor contain the expected values for this theme.
        Assert.AreEqual(CounterfeitUSATravelVisa.BackGroundColor, "Black");
        Assert.AreEqual(CounterfeitUSATravelVisa.FontColor, "White");
    }

    [TestMethod]
    public void CreateLightTheme_IDE()
    {
        // Create a new IDEFactory object and and create an ide with a light theme
        var VisualStudioCompiler = new IDEFactory();
        var LightModeVS = IDEFactory.CreateLightTheme();

        // Assert that both the document BackGroundColor, FontColor and ButtonColor contain the expected values for this theme.
        Assert.AreEqual(LightModeVS.BackGroundColor, "White");
        Assert.AreEqual(LightModeVS.FontColor, "Black");
        Assert.AreEqual(LightModeVS.BackGroundColor, "Light blue");
    }

    [TestMethod]
    public void CreateDarkTheme_IDE()
    {
        // Create a new IDEFactory object and and create an ide with a light theme
        var VisualStudioCompiler = new IDEFactory();
        var LightModeVS = IDEFactory.CreateLightTheme();

        // Assert that both the document BackGroundColor, FontColor and ButtonColor contain the expected values for this theme.
        Assert.AreEqual(LightModeVS.BackGroundColor, "Black");
        Assert.AreEqual(LightModeVS.FontColor, "White");
        Assert.AreEqual(LightModeVS.BackGroundColor, "Light yellow");

    }
}