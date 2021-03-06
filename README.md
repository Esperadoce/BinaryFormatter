# BinaryFormatter  [![Build status](https://ci.appveyor.com/api/projects/status/ubkhv5snpqccgyv7?svg=true)](https://ci.appveyor.com/project/Esperadoce/binaryformatter)
### Description
BinaryFormatter is a byte serialized/deserializer for .NET Core, created for Distributed Cache Platform - [Kronos][kronos-url]. After few days of development, [Protobuf-Net][protobuf-net-url] (contract base serializer, fork of Google Protobuf) has announcement  support for .NET Core. 

### Supported types
  - char
  - (s)byte
  - (u)short
  - (u)int
  - (u)long
  - float
  - double
  - bool
  - decimal
  - DateTime
  - byte[]
  - classes and structures

 ### Not supported types
  - Collections

### Version
1.0.0.1

### Installation
```powershell
$ Install-Package BinaryFormatter
```

### Serialization
```cs
BinaryConverter converter = new BinaryConverter();
byte[] byteArray = converter.Serialize(model);
```    

### Deserialization
```cs
BinaryConverter converter = new BinaryConverter();
TzpeViewModel obj = converter.Deserialize<TzpeViewModel>(byteArray);
```    

License
----
MIT

   [kronos-url]: <https://github.com/lukasz-pyrzyk/Kronos>
   [protobuf-net-url]: <https://github.com/mgravell/protobuf-net>
