using SartainStudios.Cryptography;

var valueToHash = "Hello, World!";

IHash hash = new Hash();

Console.WriteLine("Hashed Value: \n" + hash.GenerateHash(valueToHash));