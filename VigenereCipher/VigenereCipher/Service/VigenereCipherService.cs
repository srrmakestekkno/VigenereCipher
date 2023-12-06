using VigenereCipher.Interfaces;

namespace VigenereCipher.Service
{
    public class VigenereCipherService : IVigenereCipher
    {

        public string GenerateCryptoKey(uint length)
        {
            throw new NotImplementedException();
        }

        public List<string> GenerateCryptoKeys(uint numberOfKeys)
        {
            throw new NotImplementedException();
        }

        private static char[,] GenerateVigenereMatrix()
        {
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            
            int length = alphabet.Length;
            var matrix = new char[length, length];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++) 
                {
                    int newIndex = (i + j) % length;
                    matrix[i, j] = alphabet[newIndex];
                }
            }

            return matrix;
        }
    }
}
