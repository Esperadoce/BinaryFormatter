﻿using System;
using System.Text;
using BinaryFormatter.Types;

namespace BinaryFormatter.TypeConverter
{
    internal class StringConverter : BaseTypeConverter<string>
    {
        private int Size { get; set; }

        public override SerializedType Type => SerializedType.String;

        protected override byte[] ProcessSerialize(string obj)
        {
            Size = obj.Length;
            var sizeBytes = BitConverter.GetBytes(obj.Length);
            var objBytes = Encoding.UTF8.GetBytes(obj);

            var serializedStringWithSize = new byte[sizeof(int) + obj.Length];

            Array.ConstrainedCopy(sizeBytes, 0, serializedStringWithSize, 0, sizeBytes.Length);
            Array.ConstrainedCopy(objBytes, 0, serializedStringWithSize, sizeBytes.Length, objBytes.Length);

            return serializedStringWithSize;
        }

        protected override string ProcessDeserialize(byte[] stream, ref int offset)
        {
            Size = BitConverter.ToInt32(stream, offset);
            offset += sizeof(int);

            return Encoding.UTF8.GetString(stream, offset, Size);
        }

        protected override int GetTypeSize()
        {
            return Size;
        }
    }
}