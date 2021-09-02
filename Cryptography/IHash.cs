namespace SartainStudios.Cryptography;

/// <summary>
///     Ability to hash string.
/// </summary>
public interface IHash
{
    /// <summary>
    ///     Generates the hash equivalent of passed string.
    /// </summary>
    string GenerateHash(string valueToHash);
}