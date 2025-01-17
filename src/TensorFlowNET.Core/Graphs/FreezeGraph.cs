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
    public class FreezeGraph
    {
        public static void freeze_graph(string input_graph,
                              string input_saver,
                              bool input_binary,
                              string input_checkpoint,
                              string output_node_names,
                              string restore_op_name,
                              string filename_tensor_name,
                              string output_graph,
                              bool clear_devices,
                              string initializer_nodes)
        {

        }
    }
}
