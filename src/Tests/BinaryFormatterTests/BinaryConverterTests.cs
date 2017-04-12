using System;
using System.Text;
using BinaryFormatter;
using Xunit;

namespace BinaryFormatterTests
{
    public class BinaryConverterTests
    {
        [Fact]
        public void CanSerialize_Bool()
        {
            var value = false;

            var converter = new BinaryConverter();
            var bytes = converter.Serialize(value);
            var deserializedValue = converter.Deserialize<bool>(bytes);

            Assert.Equal(value, deserializedValue);
        }

        [Fact]
        public void CanSerialize_Byte()
        {
            var value = byte.MinValue;

            var converter = new BinaryConverter();
            var bytes = converter.Serialize(value);
            var deserializedValue = converter.Deserialize<byte>(bytes);

            Assert.Equal(value, deserializedValue);
        }

        [Fact]
        public void CanSerialize_ByteArray()
        {
            var value = Encoding.UTF8.GetBytes("lorem ipsum");

            var converter = new BinaryConverter();
            var bytes = converter.Serialize(value);
            var deserializedValue = converter.Deserialize<byte[]>(bytes);

            Assert.Equal(value, deserializedValue);
        }

        [Fact]
        public void CanSerialize_Char()
        {
            var value = char.MinValue;

            var converter = new BinaryConverter();
            var bytes = converter.Serialize(value);
            var deserializedValue = converter.Deserialize<char>(bytes);

            Assert.Equal(value, deserializedValue);
        }

        [Fact]
        public void CanSerialize_Datetime()
        {
            var value = DateTime.MinValue;

            var converter = new BinaryConverter();
            var bytes = converter.Serialize(value);
            var deserializedValue = converter.Deserialize<DateTime>(bytes);

            Assert.Equal(value, deserializedValue);
        }

        [Fact]
        public void CanSerialize_Decimal()
        {
            var value = decimal.MinValue;

            var converter = new BinaryConverter();
            var bytes = converter.Serialize(value);
            var deserializedValue = converter.Deserialize<decimal>(bytes);

            Assert.Equal(value, deserializedValue);
        }

        [Fact]
        public void CanSerialize_Double()
        {
            var value = double.MinValue;

            var converter = new BinaryConverter();
            var bytes = converter.Serialize(value);
            var deserializedValue = converter.Deserialize<double>(bytes);

            Assert.Equal(value, deserializedValue);
        }

        [Fact]
        public void CanSerialize_Float()
        {
            var value = float.MinValue;

            var converter = new BinaryConverter();
            var bytes = converter.Serialize(value);
            var deserializedValue = converter.Deserialize<float>(bytes);

            Assert.Equal(value, deserializedValue);
        }

        [Fact]
        public void CanSerialize_Int()
        {
            var value = int.MinValue;

            var converter = new BinaryConverter();
            var bytes = converter.Serialize(value);
            var deserializedValue = converter.Deserialize<int>(bytes);

            Assert.Equal(value, deserializedValue);
        }

        [Fact]
        public void CanSerialize_Long()
        {
            var value = long.MinValue;

            var converter = new BinaryConverter();
            var bytes = converter.Serialize(value);
            var deserializedValue = converter.Deserialize<long>(bytes);

            Assert.Equal(value, deserializedValue);
        }

        [Fact]
        public void CanSerialize_SByte()
        {
            var value = sbyte.MinValue;

            var converter = new BinaryConverter();
            var bytes = converter.Serialize(value);
            var deserializedValue = converter.Deserialize<sbyte>(bytes);

            Assert.Equal(value, deserializedValue);
        }

        [Fact]
        public void CanSerialize_Short()
        {
            var value = short.MinValue;

            var converter = new BinaryConverter();
            var bytes = converter.Serialize(value);
            var deserializedValue = converter.Deserialize<short>(bytes);

            Assert.Equal(value, deserializedValue);
        }

        [Fact]
        public void CanSerialize_String()
        {
            var value = "lorem ipsum";

            var converter = new BinaryConverter();
            var bytes = converter.Serialize(value);
            var deserializedValue = converter.Deserialize<string>(bytes);

            Assert.Equal(value, deserializedValue);
        }

        [Fact]
        public void CanSerialize_UInt()
        {
            var value = uint.MinValue;

            var converter = new BinaryConverter();
            var bytes = converter.Serialize(value);
            var deserializedValue = converter.Deserialize<uint>(bytes);

            Assert.Equal(value, deserializedValue);
        }

        [Fact]
        public void CanSerialize_Ulong()
        {
            var value = ulong.MinValue;

            var converter = new BinaryConverter();
            var bytes = converter.Serialize(value);
            var deserializedValue = converter.Deserialize<ulong>(bytes);

            Assert.Equal(value, deserializedValue);
        }

        [Fact]
        public void CanSerialize_Ushort()
        {
            var value = ushort.MinValue;

            var converter = new BinaryConverter();
            var bytes = converter.Serialize(value);
            var deserializedValue = converter.Deserialize<ushort>(bytes);

            Assert.Equal(value, deserializedValue);
        }
    }
}