// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System.Diagnostics.Contracts;
using System;

namespace System.Resources
{

    public class ResourceWriter
    {

        public void Generate () {

        }
        public void Dispose () {

        }
        public void Close () {

        }
        public void AddResource (string name, Byte[] value) {
            Contract.Requires(name != null);

        }
        public void AddResource (string name, object value) {
            Contract.Requires(name != null);

        }
        public void AddResource (string name, string value) {
            Contract.Requires(name != null);

        }
        public ResourceWriter (System.IO.Stream stream) {
            Contract.Requires(stream != null);

          return default(ResourceWriter);
        }
        public ResourceWriter (string fileName) {
            Contract.Requires(fileName != null);
          return default(ResourceWriter);
        }
    }
}
