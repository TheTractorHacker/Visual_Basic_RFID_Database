Imports System.Security.Cryptography
Imports System.Text

Public Class EncryptionHelper
    Private Shared ReadOnly key As Byte() = Convert.FromBase64String("bFXDJ9s6Qpq02lR3kcHTTpW7eytr2IkB6/bF1aqMlFo=")

    Public Shared Function Encrypt(text As String) As String
        Dim textBytes As Byte() = Encoding.UTF8.GetBytes(text)
        Dim iv As Byte() = GenerateRandomIV()

        Using aes As Aes = Aes.Create()
            aes.Key = key
            aes.IV = iv

            Using encryptor As ICryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV)
                Using ms As New IO.MemoryStream()
                    Using cs As New CryptoStream(ms, encryptor, CryptoStreamMode.Write)
                        cs.Write(textBytes, 0, textBytes.Length)
                        cs.FlushFinalBlock()
                        ' Prepend IV to the encrypted data and convert to Base64 string
                        Dim encryptedBytes As Byte() = ms.ToArray()
                        Dim result As Byte() = New Byte(iv.Length + encryptedBytes.Length - 1) {}
                        Array.Copy(iv, 0, result, 0, iv.Length)
                        Array.Copy(encryptedBytes, 0, result, iv.Length, encryptedBytes.Length)
                        Return Convert.ToBase64String(result)
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Shared Function Decrypt(encryptedText As String) As String
        Dim encryptedBytesWithIV As Byte() = Convert.FromBase64String(encryptedText)
        Dim iv As Byte() = New Byte(15) {}
        Dim encryptedBytes As Byte() = New Byte(encryptedBytesWithIV.Length - 17) {}

        Array.Copy(encryptedBytesWithIV, 0, iv, 0, iv.Length)
        Array.Copy(encryptedBytesWithIV, iv.Length, encryptedBytes, 0, encryptedBytes.Length)

        Using aes As Aes = Aes.Create()
            aes.Key = key
            aes.IV = iv

            Using decryptor As ICryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV)
                Using ms As New IO.MemoryStream(encryptedBytes)
                    Using cs As New CryptoStream(ms, decryptor, CryptoStreamMode.Read)
                        Dim decryptedBytes(encryptedBytes.Length - 1) As Byte
                        Dim byteCount = cs.Read(decryptedBytes, 0, decryptedBytes.Length)
                        Return Encoding.UTF8.GetString(decryptedBytes, 0, byteCount)
                    End Using
                End Using
            End Using
        End Using
    End Function

    Private Shared Function GenerateRandomIV() As Byte()
        Using rng As New RNGCryptoServiceProvider()
            Dim iv(15) As Byte
            rng.GetBytes(iv)
            Return iv
        End Using
    End Function
End Class
