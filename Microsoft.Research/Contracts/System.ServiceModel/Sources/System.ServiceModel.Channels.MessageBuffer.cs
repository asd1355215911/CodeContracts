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

// File System.ServiceModel.Channels.MessageBuffer.cs
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


namespace System.ServiceModel.Channels
{
  abstract public partial class MessageBuffer : System.Xml.XPath.IXPathNavigable, IDisposable
  {
    #region Methods and constructors
    public abstract void Close();

    public abstract Message CreateMessage();

    public System.Xml.XPath.XPathNavigator CreateNavigator(System.Xml.XmlSpace space)
    {
      Contract.Ensures(Contract.Result<System.Xml.XPath.XPathNavigator>() != null);

      return default(System.Xml.XPath.XPathNavigator);
    }

    public System.Xml.XPath.XPathNavigator CreateNavigator(int nodeQuota, System.Xml.XmlSpace space)
    {
      Contract.Ensures(Contract.Result<System.Xml.XPath.XPathNavigator>() != null);

      return default(System.Xml.XPath.XPathNavigator);
    }

    public System.Xml.XPath.XPathNavigator CreateNavigator(int nodeQuota)
    {
      Contract.Ensures(Contract.Result<System.Xml.XPath.XPathNavigator>() != null);

      return default(System.Xml.XPath.XPathNavigator);
    }

    public System.Xml.XPath.XPathNavigator CreateNavigator()
    {
      return default(System.Xml.XPath.XPathNavigator);
    }

    protected MessageBuffer()
    {
    }

    void System.IDisposable.Dispose()
    {
    }

    public virtual new void WriteMessage(Stream stream)
    {
    }
    #endregion

    #region Properties and indexers
    public abstract int BufferSize
    {
      get;
    }

    public virtual new string MessageContentType
    {
      get
      {
        return default(string);
      }
    }
    #endregion
  }
}
