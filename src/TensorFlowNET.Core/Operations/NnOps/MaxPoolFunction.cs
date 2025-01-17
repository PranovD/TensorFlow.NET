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
using static Tensorflow.Python;

namespace Tensorflow.Operations
{
    /// <summary>
    /// Performs the max pooling on the input.
    /// </summary>
    public class MaxPoolFunction : IPoolFunction
    {
        public Tensor Apply(Tensor value,
            int[] ksize,
            int[] strides,
            string padding,
            string data_format = "NHWC",
            string name = null)
        {
            return with(ops.name_scope(name, "MaxPool", value), scope => 
            {
                name = scope;
                value = ops.convert_to_tensor(value, name: "input");
                return gen_nn_ops.max_pool(
                    value,
                    ksize: ksize,
                    strides: strides,
                    padding: padding,
                    data_format: data_format,
                    name: name);
            });
        }
    }
}
