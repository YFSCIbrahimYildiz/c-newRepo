using System.Numerics;

public static class DiffieHellman
{
    public static BigInteger PrivateKey(BigInteger primeP)
    {
        Random rnd = new Random();
        int sayi = (int)primeP;
        return rnd.Next(0, sayi);
    }

    public static BigInteger PublicKey(BigInteger primeP, BigInteger primeG, BigInteger privateKey)
    {
        var A = BigInteger.ModPow(primeG, privateKey, primeP);
        return A;
    }

    public static BigInteger Secret(BigInteger primeP, BigInteger publicKey, BigInteger privateKey)
    {
        var s = BigInteger.ModPow(publicKey,privateKey, primeP);
        return s; 
    }
}