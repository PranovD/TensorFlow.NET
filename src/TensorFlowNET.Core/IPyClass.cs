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
    public interface IPyClass
    {
        /// <summary>
        /// Called when the instance is created.
        /// </summary>
        /// <param name="args"></param>
        void __init__(IPyClass self, dynamic args);

        void __enter__(IPyClass self);

        void __exit__(IPyClass self);

        void __del__(IPyClass self);
    }
}
