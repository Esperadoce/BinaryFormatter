using BinaryFormatter.TypeConverter;
using Xunit;

namespace BinaryFormatterTests.TypeConverter
{
    public class DecimalConverterTests
    {
        [Fact]
        public void CanSerializeAndDeserialize()
        {
            var value = decimal.MaxValue;
            var converter = new DecimalConverter();
            var bytes = converter.Serialize(value);

            var valueFromBytes = converter.Deserialize(bytes);

            Assert.Equal(valueFromBytes, value);
        }
    }
}