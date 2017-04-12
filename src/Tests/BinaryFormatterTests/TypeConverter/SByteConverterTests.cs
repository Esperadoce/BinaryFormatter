using BinaryFormatter.TypeConverter;
using Xunit;

namespace BinaryFormatterTests.TypeConverter
{
    public class SByteConverterTests
    {
        [Fact]
        public void CanSerializeAndDeserialize()
        {
            var value = sbyte.MaxValue;
            var converter = new SByteConverter();
            var bytes = converter.Serialize(value);

            var valueFromBytes = converter.Deserialize(bytes);

            Assert.Equal(valueFromBytes, value);
        }
    }
}