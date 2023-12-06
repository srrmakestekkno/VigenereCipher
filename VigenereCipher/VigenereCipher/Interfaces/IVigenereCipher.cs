namespace VigenereCipher.Interfaces
{
    public interface IVigenereCipher
    {
        string GenerateCryptoKey(uint length);
        List<string> GenerateCryptoKeys(uint numberOfKeys);
        
    }
}
