using NUnit.Framework;
using SartainStudios.Cryptography;

namespace Test;

public class Tests
{
    private IHash _hash;

    [SetUp]
    public void Setup() => _hash = new Hash();

    [Test]
    public void GenerateHash_CreatesStringOf128Characters() => Assert.AreEqual(128, _hash.GenerateHash("fdsaf").Length);
}