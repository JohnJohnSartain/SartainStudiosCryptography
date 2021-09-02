using System.Security.Cryptography;
using System.Text;

namespace SartainStudios.Cryptography;

/// <summary>
///     Ability to hash string.
/// </summary>
public class Hash : IHash
{
    /// <summary>
    ///     Generates the hash equivalent of passed string.
    /// </summary>
    public string GenerateHash(string valueToHash) => GenerateSha512String(valueToHash);

    private static string GenerateSha512String(string inputString)
    {
        var sha512 = SHA512.Create();
        var bytes = Encoding.UTF8.GetBytes(inputString);
        var hash = sha512.ComputeHash(bytes);

        return GetStringFromHash(hash);
    }

    private static string GetStringFromHash(IEnumerable<byte> hash)
    {
        var result = new StringBuilder();

        foreach (var character in hash)
            result.Append(character.ToString("X2"));

        return result.ToString();
    }
}