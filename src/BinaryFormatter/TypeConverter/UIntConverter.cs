using System;
using BinaryFormatter.Types;

namespace BinaryFormatter.TypeConverter
{
    internal class UIntConverter : BaseTypeConverter<uint>
    {
        public override SerializedType Type => SerializedType.Uint;

        protected override byte[] ProcessSerialize(uint obj)
        {
            return BitConverter.GetBytes(obj);
        }

        protected override uint ProcessDeserialize(byte[] stream, ref int offset)
        {
            return BitConverter.ToUInt32(stream, offset);
        }

        protected override int GetTypeSize()
        {
            return sizeof(uint);
        }
    }
}