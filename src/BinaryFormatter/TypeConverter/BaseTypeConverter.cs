﻿using System;
using BinaryFormatter.Types;

namespace BinaryFormatter.TypeConverter
{
    internal abstract class BaseTypeConverter<T> : BaseTypeConverter
    {
        public byte[] Serialize(T obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));

            var objectBytes = ProcessSerialize(obj);
            var objectType = BitConverter.GetBytes((ushort) Type);

            var final = new byte[objectType.Length + objectBytes.Length];

            var offset = 0;
            Array.Copy(objectType, 0, final, offset, objectType.Length);
            offset += objectType.Length;
            Array.Copy(objectBytes, 0, final, offset, objectBytes.Length);

            return final;
        }

        public override byte[] Serialize(object obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));

            return Serialize((T) obj);
        }

        public T Deserialize(byte[] stream)
        {
            var offset = sizeof(short);
            return ProcessDeserialize(stream, ref offset);
        }

        public T Deserialize(byte[] stream, ref int offset)
        {
            var obj = ProcessDeserialize(stream, ref offset);
            offset += GetTypeSize();
            return obj;
        }

        public override object DeserializeToObject(byte[] stream)
        {
            return Deserialize(stream);
        }

        public override object DeserializeToObject(byte[] stream, ref int offset)
        {
            return Deserialize(stream, ref offset);
        }

        protected abstract int GetTypeSize();
        protected abstract byte[] ProcessSerialize(T obj);
        protected abstract T ProcessDeserialize(byte[] stream, ref int offset);

        protected virtual SerializedType GetPackageType(byte[] stream, ref int offset)
        {
            var type = BitConverter.ToInt16(stream, offset);
            offset += sizeof(short);
            return (SerializedType) type;
        }
    }

    internal abstract class BaseTypeConverter
    {
        public abstract SerializedType Type { get; }
        public abstract byte[] Serialize(object obj);
        public abstract object DeserializeToObject(byte[] stream);
        public abstract object DeserializeToObject(byte[] stream, ref int offset);
    }
}