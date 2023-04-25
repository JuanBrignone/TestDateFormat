using   NUnit.Framework;
using TestDateFormat;
namespace Library.Tests;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectFormat()
    {
        const string input = "14/05/1899";
        const string expected = "14-05-1899";
        string actual = DateFormatter.ChangeFormat(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void IncorrectFormat()
    {
        const string input = "14/05/1899";
        const string expected = "14-05-1899";
        string actual = DateFormatter.ChangeFormat(input);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Empty()
    {
        const string input = "";
        const string expected = "";
        string actual = DateFormatter.ChangeFormat(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
}