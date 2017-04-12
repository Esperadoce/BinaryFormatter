using System;
using BinaryFormatter.Types;

namespace BinaryFormatter.TypeConverter
{
    internal class CharConverter : BaseTypeConverter<char>
    {
        public override SerializedType Type => SerializedType.Char;

        protected override byte[] ProcessSerialize(char obj)
        {
            return BitConverter.GetBytes(obj);
        }

        protected override char ProcessDeserialize(byte[] stream, ref int offset)
        {
            var result = BitConverter.ToChar(stream, offset);
            return result;
        }

        protected override int GetTypeSize()
        {
            return sizeof(char);
        }
    }
}