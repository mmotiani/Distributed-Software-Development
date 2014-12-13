using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.IO;
using System.Configuration;
using System.Security.Cryptography;


namespace EncDec
{
    public class Class1
    {
        public static string Encryption(string plain_text)
        {
            string encrypt_key = "ABHWIK268HHJK78GB3"; //Encryption key
            byte[] plaintextInBytes = Encoding.Unicode.GetBytes(plain_text);

            Aes Obj = Aes.Create(); // creation of encryption protocol object
            Rfc2898DeriveBytes Obj1 = new Rfc2898DeriveBytes(encrypt_key, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 }); //conversion of keys from byte to hexadecimal

            Obj.Key = Obj1.GetBytes(32); //creation of 32 byte key from the object
            Obj.IV = Obj1.GetBytes(16);
            
            MemoryStream memory_stream = new MemoryStream(); //creation of memory stream object
            CryptoStream crypto_stream = new CryptoStream(memory_stream, Obj.CreateEncryptor(), CryptoStreamMode.Write); //creation of cryptostream object
            
            crypto_stream.Write(plaintextInBytes, 0, plaintextInBytes.Length); //writing plain text to cryptosteam object
            crypto_stream.Close();
            plain_text = Convert.ToBase64String(memory_stream.ToArray()); //conversion of plain text to cipher text
            return plain_text; //return encrypted text
         }

        public static string Decryption(string encypted_text)
        {
            string decrypt_key = "ABHWIK268HHJK78GB3"; //Decryption key
            byte[] cipher_text = Convert.FromBase64String(encypted_text);

            Aes Obj = Aes.Create(); // creation of encryption protocol object
            Rfc2898DeriveBytes Obj1 = new Rfc2898DeriveBytes(decrypt_key, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });  //conversion of keys from byte to hexadecimal

            Obj.Key = Obj1.GetBytes(32);  //creation of 32 byte key from the object
            Obj.IV = Obj1.GetBytes(16);

            MemoryStream memory_stream = new MemoryStream(); //creation of memory stream object
            CryptoStream cryptostream = new CryptoStream(memory_stream, Obj.CreateDecryptor(), CryptoStreamMode.Write);//creation of crypto stream object
            cryptostream.Write(cipher_text, 0, cipher_text.Length); //writing cipher text to cryptosteam object
            cryptostream.Close();

            encypted_text = Encoding.Unicode.GetString(memory_stream.ToArray()); //conversion of cipher text to plain text
            return encypted_text;  //return plain text
        }
        

    }
}
