using System;
using UnityEngine;

namespace UnityAtoms
{
    internal static class TypeExtensions
    {
        public static bool IsUnitySerializable(this Type type)
        {
            return type.IsSerializable || type.IsSubclassOf(typeof(UnityEngine.Object));
        }

        public static bool IsKeyword(this Type type)
        {
            if (type == typeof(IntPtr))
            {
                return true;
            }
            else if (type == typeof(UIntPtr))
            {
                return true;
            }

            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Boolean:
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.Char:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                case TypeCode.Int32:
                case TypeCode.UInt32:
                case TypeCode.Int64:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.UInt16:
                case TypeCode.String:
                    return true;
                default:
                    return false;
            }
        }

        public static string CSharpName(this Type type)
        {
            if(type == typeof(IntPtr))
            {
                return "nint";
            }
            else if(type == typeof(UIntPtr))
            {
                return "nuint";
            }

            switch(Type.GetTypeCode(type))
            {
                case TypeCode.Boolean:
                    return "bool";
                case TypeCode.Byte:
                    return "byte";
                case TypeCode.SByte:
                    return "sbyte";
                case TypeCode.Char:
                    return "char";
                case TypeCode.Decimal:
                    return "decimal";
                case TypeCode.Double:
                    return "double";
                case TypeCode.Single:
                    return "float";
                case TypeCode.Int32:
                    return "int";
                case TypeCode.UInt32:
                    return "uint";
                case TypeCode.Int64:
                    return "long";
                case TypeCode.UInt64:
                    return "ulong";
                case TypeCode.Int16:
                    return "short";
                case TypeCode.UInt16:
                    return "ushort";
                case TypeCode.String:
                    return "string";
                default:
                    return type.Name;
            }
        }

        public static bool IsNumeric(this Type type)
        {
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsVector(this Type type)
        {
            return type == typeof(Vector2)
                || type == typeof(Vector2Int)
                || type == typeof(Vector3)
                || type == typeof(Vector3Int)
                || type == typeof(Vector4);
        }
    }
}
