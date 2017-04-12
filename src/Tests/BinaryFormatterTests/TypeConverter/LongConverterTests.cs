using BinaryFormatter.TypeConverter;
using Xunit;

namespace BinaryFormatterTests.TypeConverter
{
    public class LongConverterTests
    {
        [Fact]
        public void CanSerializeAndDeserialize()
        {
            var value = long.MaxValue;
            var converter = new LongConverter();
            var bytes = converter.Serialize(value);

            var valueFromBytes = converter.Deserialize(bytes);

            Assert.Equal(valueFromBytes, value);
        }
    }
}