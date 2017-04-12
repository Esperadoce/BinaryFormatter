using System;
using BinaryFormatter.Types;

namespace BinaryFormatter.TypeConverter
{
    internal class ShortConverter : BaseTypeConverter<short>
    {
        public override SerializedType Type => SerializedType.Short;

        protected override byte[] ProcessSerialize(short obj)
        {
            return BitConverter.GetBytes(obj);
        }

        protected override short ProcessDeserialize(byte[] stream, ref int offset)
        {
            return BitConverter.ToInt16(stream, offset);
        }

        protected override int GetTypeSize()
        {
            return sizeof(short);
        }
    }
}