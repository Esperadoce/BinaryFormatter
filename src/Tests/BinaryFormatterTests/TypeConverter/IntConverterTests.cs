using BinaryFormatter.TypeConverter;
using Xunit;

namespace BinaryFormatterTests.TypeConverter
{
    public class IntConverterTests
    {
        [Fact]
        public void CanSerializeAndDeserialize()
        {
            var value = int.MaxValue;
            var converter = new IntConverter();
            var bytes = converter.Serialize(value);

            var valueFromBytes = converter.Deserialize(bytes);

            Assert.Equal(valueFromBytes, value);
        }
    }
}