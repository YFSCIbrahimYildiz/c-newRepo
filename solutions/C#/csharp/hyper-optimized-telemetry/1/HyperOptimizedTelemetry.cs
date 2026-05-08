public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] buffer = new byte[9];
        if (4_294_967_296 <= reading && reading <= 9_223_372_036_854_775_807)
        {
            buffer[0] = 248;
            byte[] payloadBytes = BitConverter.GetBytes((long)reading);
            Array.Copy(payloadBytes, 0, buffer, 1, payloadBytes.Length);
        }
        else if (2_147_483_648 <= reading && reading <= 4_294_967_295)
        {
            buffer[0] = 4;
            byte[] payloadBytes = BitConverter.GetBytes((uint)reading);
            Array.Copy(payloadBytes, 0, buffer, 1, payloadBytes.Length);
        }
        else if (65_536 <= reading && reading <= 2_147_483_647)
        {
            buffer[0] = 252;
            byte[] payloadBytes = BitConverter.GetBytes((int)reading);
            Array.Copy(payloadBytes, 0, buffer, 1, payloadBytes.Length);
        }
        else if (0 <= reading && reading <= 65_535)
        {
            buffer[0] = 2;
            byte[] payloadBytes = BitConverter.GetBytes((ushort)reading);
            Array.Copy(payloadBytes, 0, buffer, 1, payloadBytes.Length);
        }
        else if (-32_768 <= reading && reading <= -1)
        {
            buffer[0] = 254;
            byte[] payloadBytes = BitConverter.GetBytes((short)reading);
            Array.Copy(payloadBytes, 0, buffer, 1, payloadBytes.Length);
        }
        else if (-2_147_483_648 <= reading && reading <= -32_769)
        {
            buffer[0] = 252;
            byte[] payloadBytes = BitConverter.GetBytes((int)reading);
            Array.Copy(payloadBytes, 0, buffer, 1, payloadBytes.Length);
        }
        else if (-9_223_372_036_854_775_808 <= reading && reading <= -2_147_483_649)
        {
            buffer[0] = 248;
            byte[] payloadBytes = BitConverter.GetBytes((long)reading);
            Array.Copy(payloadBytes, 0, buffer, 1, payloadBytes.Length);
        }

        return buffer;
    }

    public static long FromBuffer(byte[] buffer)
    {
        switch (buffer[0])
        {
            case 248:
                return BitConverter.ToInt64(buffer, 1);
            case 4:
                return BitConverter.ToUInt32(buffer, 1);
            case 252:
                return BitConverter.ToInt32(buffer, 1);
            case 2:
                return BitConverter.ToUInt16(buffer, 1);
            case 254:
                return BitConverter.ToInt16(buffer, 1);
        }

        return 0;
    }
}