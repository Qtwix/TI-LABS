using System.Collections;

namespace TI2
{
    public class LFSRCipher
    {
        public BitArray BitRegister { get; private set; }
        public BitArray BitKey { get; private set; }
        public BitArray PlainText { get; set; }
        public BitArray CipherBit { get; private set; }

        public void ProduceBitRegister(string parsingString)
        {
            BitRegister = new BitArray(parsingString.Length);
            for (int i = 0; i < parsingString.Length; i++)
                BitRegister[i] = parsingString[parsingString.Length - 1 - i] == '1';
        }
        
        public void ProduceBitKey(int length)
        {
            BitKey = new BitArray(length);
            BitArray tempRegister = new BitArray(BitRegister);
            for (int i = 0; i < length; i++)
            {
                BitKey[i] = tempRegister[33];
                bool feedback = tempRegister[33] ^ tempRegister[14] ^ tempRegister[13] ^ tempRegister[0];
                for (int j = 33; j > 0; j--)
                    tempRegister[j] = tempRegister[j - 1];
                tempRegister[0] = feedback;
            }
        }
        public void Cipher()
        {
            CipherBit = new BitArray(PlainText.Length);
            for (int i = 0; i < PlainText.Length; i++)
                CipherBit[i] = PlainText[i] ^ BitKey[i];
        }
    }
}