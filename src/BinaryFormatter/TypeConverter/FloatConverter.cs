using System;
using BinaryFormatter.Types;

namespace BinaryFormatter.TypeConverter
{
    internal class FloatConverter : BaseTypeConverter<float>
    {
        public override SerializedType Type => SerializedType.Float;

        protected override byte[] ProcessSerialize(float obj)
        {
            return BitConverter.GetBytes(obj);
        }

        protected override float ProcessDeserialize(byte[] stream, ref int offset)
        {
            return BitConverter.ToSingle(stream, offset);
        }

        protected override int GetTypeSize()
        {
            return sizeof(float);
        }
    }
}