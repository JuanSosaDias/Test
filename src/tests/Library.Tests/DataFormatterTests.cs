namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FechaCorrecta()
    {
        string date ="10/10/1997";
        string expected = "1997-10-10";

        string actual = DateFormatter.ChangeFormat(date);
        
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void FechaIncorrecta()
    {
        string date ="10/10/199";
        string expected = "";

        string actual = DateFormatter.ChangeFormat(date);

        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test]
    public void FechaEnBlanco()
    {
        string date ="";
        string expected ="";

        string actual = DateFormatter.ChangeFormat(date);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
//Una fecha en formato correcto
//Una fecha que no tenga el formato correcto
//Una fecha en blanco