using System;
using BinaryFormatter.Types;

namespace BinaryFormatter.TypeConverter
{
    internal class ByteArrayConverter : BaseTypeConverter<byte[]>
    {
        private int Size { get; set; }

        public override SerializedType Type => SerializedType.ByteArray;

        protected override byte[] ProcessSerialize(byte[] obj)
        {
            Size = obj.Length;
            var lengthBytes = BitConverter.GetBytes(Size);

            var serializedStringWithSize = new byte[sizeof(int) + Size];
            Array.Copy(lengthBytes, 0, serializedStringWithSize, 0, lengthBytes.Length);
            Array.Copy(obj, 0, serializedStringWithSize, lengthBytes.Length, obj.Length);

            return serializedStringWithSize;
        }

        protected override byte[] ProcessDeserialize(byte[] stream, ref int offset)
        {
            var size = BitConverter.ToInt32(stream, offset);
            offset += sizeof(int);

            var deserialized = new byte[size];
            Array.Copy(stream, offset, deserialized, 0, size);
            return deserialized;
        }

        protected override int GetTypeSize()
        {
            return Size;
        }
    }
}