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
    public class random_seed
    {
        private static int DEFAULT_GRAPH_SEED = 87654321;

        public static (int?, int?) get_seed(int? op_seed = null)
        {
            if (op_seed.HasValue)
                return (DEFAULT_GRAPH_SEED, 0);
            else
                return (null, null);
        }
    }
}
