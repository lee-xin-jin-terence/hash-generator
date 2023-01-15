
using System.Security.Cryptography;
using System.Text;


namespace HashGeneratorApp.Models
{
    /// <summary>
    /// A Model class that generates a hexadecimal hash output string
    /// 
    /// Author: Terence Lee
    /// 
    /// Example usage:
    ///   
    ///     string hashInput = "12345";
    ///     string hashOutput = HashGenerator.GenerateHash(hashInput, HashAlgorithmType.MD5);
    ///     
    /// </summary>
    public class HashGenerator
    {
        /// <summary>
        /// The type of hash algorithm to be used
        /// </summary>
        public enum HashAlgorithmType
        {
            MD5, SHA1, SHA256, SHA384, SHA512
        }

        /// <summary>
        /// Make the constructor private as there is no use for it
        /// in this class
        /// </summary>
        private HashGenerator()
        { 
        }


        

        /// <summary>
        /// Generates a hash based on the specified input and hash algorithm. Supported
        /// hash algorithms are specified in the HashAlgorithmType enum declared in this
        /// class
        /// </summary>
        /// <param name="hashInput">The string input to be passed to the hash algorithm
        ///             for hashing </param>
        /// <param name="hashAlgorithmType">the type of hash algorithm to be used</param>
        /// <returns></returns>
        public static string GenerateHash(string hashInput, 
                                        HashAlgorithmType hashAlgorithmType)
        {

            StringBuilder stringBuilder = new StringBuilder();
            HashAlgorithm hashAlgorithm = GetHashAlgorithmInstance(hashAlgorithmType);

            byte[] byteArrayHash = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(hashInput));



            foreach (byte b in byteArrayHash)
            {
                stringBuilder.Append(b.ToString("x2"));
            }

            return stringBuilder.ToString();
        }


        /// <summary>
        /// Private helper method that returns a HashAlgorithm instance based on the
        /// hash algorithm type provided
        /// </summary>
        /// <param name="hashAlgorithmType">an enum representing the type of hash algorthm</param>
        /// <returns>a HashAlgorithm instance (from standard .NET library) representing
        ///     the type of hash algorithm needed</returns>
        private static HashAlgorithm GetHashAlgorithmInstance(
                                                        HashAlgorithmType hashAlgorithmType)
        {
            HashAlgorithm hashAlgorithmInstance = null;


            switch (hashAlgorithmType)
            {
                case HashAlgorithmType.MD5:
                    hashAlgorithmInstance = MD5.Create();
                    break;

                case HashAlgorithmType.SHA1:
                    hashAlgorithmInstance = SHA1.Create();
                    break;


                case HashAlgorithmType.SHA256:
                    hashAlgorithmInstance = SHA256.Create();
                    break;


                case HashAlgorithmType.SHA384:
                    hashAlgorithmInstance = SHA384.Create();
                    break;


                case HashAlgorithmType.SHA512:
                    hashAlgorithmInstance = SHA512.Create();
                    break;

            }

            return hashAlgorithmInstance;
        }
    }
}