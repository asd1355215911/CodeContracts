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

// File System.Exception.cs
// Automatically generated contract file.
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics.Contracts;
using System;

// Disable the "this variable is not used" warning as every field would imply it.
#pragma warning disable 0414
// Disable the "this variable is never assigned to".
#pragma warning disable 0067
// Disable the "this event is never assigned to".
#pragma warning disable 0649
// Disable the "this variable is never used".
#pragma warning disable 0169
// Disable the "new keyword not required" warning.
#pragma warning disable 0109
// Disable the "extern without DllImport" warning.
#pragma warning disable 0626
// Disable the "could hide other member" warning, can happen on certain properties.
#pragma warning disable 0108


namespace System
{
  public partial class Exception : System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
  {
    #region Methods and constructors
    protected Exception(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
    {
    }

    public Exception()
    {
    }

    public Exception(string message)
    {
    }

    public Exception(string message, System.Exception innerException)
    {
    }

    public virtual new System.Exception GetBaseException()
    {
      return default(System.Exception);
    }

    public virtual new void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
    {
    }

    public Type GetType()
    {
      return default(Type);
    }

    public override string ToString()
    {
      return default(string);
    }
    #endregion

    #region Properties and indexers
    public virtual new System.Collections.IDictionary Data
    {
      get
      {
        return default(System.Collections.IDictionary);
      }
    }

    public virtual new string HelpLink
    {
      get
      {
        return default(string);
      }
      set
      {
      }
    }

    protected int HResult
    {
      get
      {
        return default(int);
      }
      set
      {
      }
    }

    public System.Exception InnerException
    {
      get
      {
        return default(System.Exception);
      }
    }

    public virtual new string Message
    {
      get
      {
        return default(string);
      }
    }

    public virtual new string Source
    {
      get
      {
        return default(string);
      }
      set
      {
      }
    }

    public virtual new string StackTrace
    {
      get
      {
        return default(string);
      }
    }

    public System.Reflection.MethodBase TargetSite
    {
      get
      {
        return default(System.Reflection.MethodBase);
      }
    }
    #endregion

    #region Events
    protected event EventHandler<System.Runtime.Serialization.SafeSerializationEventArgs> SerializeObjectState
    {
      add
      {
      }
      remove
      {
      }
    }
    #endregion
  }
}
