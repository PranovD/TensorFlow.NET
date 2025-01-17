﻿/*****************************************************************************
   Copyright 2018 The TensorFlow.NET Authors. All Rights Reserved.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
******************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace Tensorflow
{
    public static class dtypes
    {
        public static TF_DataType int8 = TF_DataType.TF_INT8;
        public static TF_DataType int32 = TF_DataType.TF_INT32;
        public static TF_DataType int64 = TF_DataType.TF_INT64;
        public static TF_DataType float32 = TF_DataType.TF_FLOAT; // is that float32?
        public static TF_DataType float16 = TF_DataType.TF_HALF;
        public static TF_DataType float64 = TF_DataType.TF_DOUBLE;

        public static Type as_numpy_datatype(this TF_DataType type)
        {
            switch (type)
            {
                case TF_DataType.TF_BOOL:
                    return typeof(bool);
                case TF_DataType.TF_INT64:
                    return typeof(long);
                case TF_DataType.TF_INT32:
                    return typeof(int);
                case TF_DataType.TF_INT16:
                    return typeof(short);
                case TF_DataType.TF_FLOAT:
                    return typeof(float);
                case TF_DataType.TF_DOUBLE:
                    return typeof(double);
                case TF_DataType.TF_STRING:
                    return typeof(string);
                default:
                    return null;
            }
        }

        // "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "Complex"
        public static TF_DataType as_dtype(Type type)
        {
            TF_DataType dtype = TF_DataType.DtInvalid;
            
            switch (type.Name)
            {
                case "SByte":
                    dtype = TF_DataType.TF_INT8;
                    break;
                case "Byte":
                    dtype = TF_DataType.TF_UINT8;
                    break;
                case "Int16":
                    dtype = TF_DataType.TF_INT16;
                    break;
                case "UInt16":
                    dtype = TF_DataType.TF_UINT16;
                    break;
                case "Int32":
                    dtype = TF_DataType.TF_INT32;
                    break;
                case "UInt32":
                    dtype = TF_DataType.TF_UINT32;
                    break;
                case "Int64":
                    dtype = TF_DataType.TF_INT64;
                    break;
                case "UInt64":
                    dtype = TF_DataType.TF_UINT64;
                    break;
                case "Single":
                    dtype = TF_DataType.TF_FLOAT;
                    break;
                case "Double":
                    dtype = TF_DataType.TF_DOUBLE;
                    break;
                case "Complex":
                    dtype = TF_DataType.TF_COMPLEX128;
                    break;
                case "String":
                    dtype = TF_DataType.TF_STRING;
                    break;
                case "Boolean":
                    dtype = TF_DataType.TF_BOOL;
                    break;
                default:
                    throw new Exception("as_dtype Not Implemented");
            }

            return dtype;
        }

        public static DataType as_datatype_enum(this TF_DataType type)
        {
            DataType dtype = DataType.DtInvalid;

            switch (type)
            {
                default:
                    Enum.TryParse(((int)type).ToString(), out dtype);
                    break;
            }

            return dtype;
        }

        public static TF_DataType as_base_dtype(this TF_DataType type)
        {
            return (int)type > 100 ?
                (TF_DataType)Enum.Parse(typeof(TF_DataType), ((int)type - 100).ToString()) :
                type;
        }

        public static int name(this TF_DataType type)
        {
            return (int)type;
        }

        public static Type as_numpy_dtype(this DataType type)
        {
            return type.as_tf_dtype().as_numpy_datatype();
        }

        public static DataType as_base_dtype(this DataType type)
        {
            return (int)type > 100 ?
                (DataType)Enum.Parse(typeof(DataType), ((int)type - 100).ToString()) :
                type;
        }

        public static TF_DataType as_tf_dtype(this DataType type)
        {
            TF_DataType dtype = TF_DataType.DtInvalid;

            switch (type)
            {
                default:
                    Enum.TryParse(((int)type).ToString(), out dtype);
                    break;
            }

            return dtype;
        }

        public static TF_DataType as_ref(this TF_DataType type)
        {
            return (int)type < 100 ?
                (TF_DataType)Enum.Parse(typeof(TF_DataType), ((int)type + 100).ToString()) :
                type;
        }

        public static long max(this TF_DataType type)
        {
            switch (type)
            {
                case TF_DataType.TF_INT8:
                    return sbyte.MaxValue;
                case TF_DataType.TF_INT16:
                    return short.MaxValue;
                case TF_DataType.TF_INT32:
                    return int.MaxValue;
                case TF_DataType.TF_INT64:
                    return long.MaxValue;
                case TF_DataType.TF_UINT8:
                    return byte.MaxValue;
                case TF_DataType.TF_UINT16:
                    return ushort.MaxValue;
                case TF_DataType.TF_UINT32:
                    return uint.MaxValue;
                default:
                    throw new NotImplementedException($"max {type.name()}");
            }
        }

        public static bool is_complex(this TF_DataType type)
        {
            return type == TF_DataType.TF_COMPLEX || type == TF_DataType.TF_COMPLEX64 || type == TF_DataType.TF_COMPLEX128;
        }

        public static bool is_integer(this TF_DataType type)
        {
            return type == TF_DataType.TF_INT8 || type == TF_DataType.TF_INT16 || type == TF_DataType.TF_INT32 || type == TF_DataType.TF_INT64 ||
                type == TF_DataType.TF_UINT8 || type == TF_DataType.TF_UINT16 || type == TF_DataType.TF_UINT32 || type == TF_DataType.TF_UINT64;
        }

        public static bool is_floating(this TF_DataType type)
        {
            return type == TF_DataType.TF_HALF || type == TF_DataType.TF_FLOAT || type == TF_DataType.TF_DOUBLE;
        }

        public static bool is_ref_dtype(this TF_DataType type)
        {
            return (int)type > 100;
        }
    }
}
