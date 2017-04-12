using BinaryFormatter.TypeConverter;
using Xunit;

namespace BinaryFormatterTests.TypeConverter
{
    public class DoubleConverterTests
    {
        [Fact]
        public void CanSerializeAndDeserialize()
        {
            var value = double.MaxValue;
            var converter = new DoubleConverter();
            var bytes = converter.Serialize(value);

            var valueFromBytes = converter.Deserialize(bytes);

            Assert.Equal(valueFromBytes, value);
        }
    }
}