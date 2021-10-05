using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSQLGen.Tools
{
    public class TypeMap
    {
        public Dictionary<Type, DbType> TypeMapDictionary { get; set; }

        public TypeMap()
        {
            this.TypeMapDictionary = new Dictionary<Type, DbType>();
            this.TypeMapDictionary[typeof(byte)] = DbType.Byte;
            this.TypeMapDictionary[typeof(sbyte)] = DbType.SByte;
            this.TypeMapDictionary[typeof(short)] = DbType.Int16;
            this.TypeMapDictionary[typeof(ushort)] = DbType.UInt16;
            this.TypeMapDictionary[typeof(int)] = DbType.Int32;
            this.TypeMapDictionary[typeof(uint)] = DbType.UInt32;
            this.TypeMapDictionary[typeof(long)] = DbType.Int64;
            this.TypeMapDictionary[typeof(ulong)] = DbType.UInt64;
            this.TypeMapDictionary[typeof(float)] = DbType.Single;
            this.TypeMapDictionary[typeof(double)] = DbType.Double;
            this.TypeMapDictionary[typeof(decimal)] = DbType.Decimal;
            this.TypeMapDictionary[typeof(bool)] = DbType.Boolean;
            this.TypeMapDictionary[typeof(string)] = DbType.String;
            this.TypeMapDictionary[typeof(char)] = DbType.StringFixedLength;
            this.TypeMapDictionary[typeof(Guid)] = DbType.Guid;
            this.TypeMapDictionary[typeof(DateTime)] = DbType.DateTime;
            this.TypeMapDictionary[typeof(DateTimeOffset)] = DbType.DateTimeOffset;
            this.TypeMapDictionary[typeof(byte[])] = DbType.Binary;
            this.TypeMapDictionary[typeof(byte?)] = DbType.Byte;
            this.TypeMapDictionary[typeof(sbyte?)] = DbType.SByte;
            this.TypeMapDictionary[typeof(short?)] = DbType.Int16;
            this.TypeMapDictionary[typeof(ushort?)] = DbType.UInt16;
            this.TypeMapDictionary[typeof(int?)] = DbType.Int32;
            this.TypeMapDictionary[typeof(uint?)] = DbType.UInt32;
            this.TypeMapDictionary[typeof(long?)] = DbType.Int64;
            this.TypeMapDictionary[typeof(ulong?)] = DbType.UInt64;
            this.TypeMapDictionary[typeof(float?)] = DbType.Single;
            this.TypeMapDictionary[typeof(double?)] = DbType.Double;
            this.TypeMapDictionary[typeof(decimal?)] = DbType.Decimal;
            this.TypeMapDictionary[typeof(bool?)] = DbType.Boolean;
            this.TypeMapDictionary[typeof(char?)] = DbType.StringFixedLength;
            this.TypeMapDictionary[typeof(Guid?)] = DbType.Guid;
            this.TypeMapDictionary[typeof(DateTime?)] = DbType.DateTime;
            this.TypeMapDictionary[typeof(DateTimeOffset?)] = DbType.DateTimeOffset;
        }
    }
}
