using System.Text;
using BinaryFormatter.TypeConverter;
using Xunit;

namespace BinaryFormatterTests.TypeConverter
{
    public class ByteArrayConverterTests
    {
        [Fact]
        public void CanSerializeAndDeserialize()
        {
            var value = Encoding.UTF8.GetBytes("lorem ipsum");
            var converter = new ByteArrayConverter();
            var bytes = converter.Serialize(value);

            var valueFromBytes = converter.Deserialize(bytes);

            Assert.Equal(valueFromBytes, value);
        }
    }
}