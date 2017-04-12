using System;
using System.Text;
using BinaryFormatter.TypeConverter;
using BinaryFormatter.Types;
using Xunit;

namespace BinaryFormatterTests.TypeConverter
{
    public class BaseTypeConverterTests
    {
        public const string Message = "Lorem ipsum";

        internal class Fake : BaseTypeConverter<string>
        {
            public override SerializedType Type => SerializedType.String;

            protected override int GetTypeSize()
            {
                return Message.Length;
            }

            protected override byte[] ProcessSerialize(string obj)
            {
                return Encoding.UTF8.GetBytes(obj);
            }

            protected override string ProcessDeserialize(byte[] stream, ref int offset)
            {
                var size = BitConverter.ToInt32(stream, offset);
                offset += sizeof(int);
                return Encoding.UTF8.GetString(stream, offset, size);
            }
        }

        [Fact]
        public void ThrowsWhenObjIsNull()
        {
            var fake = new Fake();

            Assert.ThrowsAny<ArgumentNullException>(() => fake.Serialize(null));
        }

        [Fact]
        public void ThrowsWhenObjIsNullWithCasting()
        {
            var fake = new Fake();

            Assert.ThrowsAny<ArgumentNullException>(() => fake.Serialize((object) null));
        }
    }
}