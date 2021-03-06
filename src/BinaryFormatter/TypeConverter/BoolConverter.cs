﻿using System;
using BinaryFormatter.Types;

namespace BinaryFormatter.TypeConverter
{
    internal class BoolConverter : BaseTypeConverter<bool>
    {
        public override SerializedType Type => SerializedType.Bool;

        protected override byte[] ProcessSerialize(bool obj)
        {
            return BitConverter.GetBytes(obj);
        }

        protected override bool ProcessDeserialize(byte[] stream, ref int offset)
        {
            var result = BitConverter.ToBoolean(stream, offset);
            return result;
        }

        protected override int GetTypeSize()
        {
            return sizeof(bool);
        }
    }
}