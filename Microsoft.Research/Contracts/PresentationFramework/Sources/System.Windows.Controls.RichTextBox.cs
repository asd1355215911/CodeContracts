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

// File System.Windows.Controls.RichTextBox.cs
// Automatically generated contract file.
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics.Contracts;
using System;
using System.Windows.Documents;

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


namespace System.Windows.Controls
{
  public partial class RichTextBox : System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Markup.IAddChild
  {
    #region Methods and constructors
    public System.Windows.Documents.TextPointer GetNextSpellingErrorPosition(System.Windows.Documents.TextPointer position, System.Windows.Documents.LogicalDirection direction)
    {
      return default(System.Windows.Documents.TextPointer);
    }

    public System.Windows.Documents.TextPointer GetPositionFromPoint(System.Windows.Point point, bool snapToText)
    {
      return default(System.Windows.Documents.TextPointer);
    }

    public SpellingError GetSpellingError(System.Windows.Documents.TextPointer position)
    {
      Contract.Requires(position != null);

      return default(SpellingError);
    }

    public System.Windows.Documents.TextRange GetSpellingErrorRange(System.Windows.Documents.TextPointer position)
    {
      Contract.Requires(position != null);

      return default(System.Windows.Documents.TextRange);
    }

    protected override System.Windows.Size MeasureOverride(System.Windows.Size constraint)
    {
      return default(System.Windows.Size);
    }

    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
    {
      return default(System.Windows.Automation.Peers.AutomationPeer);
    }

    public RichTextBox(System.Windows.Documents.FlowDocument document)
    {
    }

    public RichTextBox()
    {
    }

    public bool ShouldSerializeDocument()
    {
      return default(bool);
    }

    void System.Windows.Markup.IAddChild.AddChild(Object value)
    {
    }

    void System.Windows.Markup.IAddChild.AddText(string text)
    {
    }
    #endregion

    #region Properties and indexers
    public System.Windows.Documents.TextPointer CaretPosition
    {
      get
      {
        return default(System.Windows.Documents.TextPointer);
      }
      set
      {
      }
    }

    public System.Windows.Documents.FlowDocument Document
    {
      get
      {
        return default(System.Windows.Documents.FlowDocument);
      }
      set
      {
      }
    }

    public bool IsDocumentEnabled
    {
      get
      {
        return default(bool);
      }
      set
      {
      }
    }

    internal protected override System.Collections.IEnumerator LogicalChildren
    {
      get
      {
        return default(System.Collections.IEnumerator);
      }
    }

    public System.Windows.Documents.TextSelection Selection
    {
      get
      {
        Contract.Ensures(Contract.Result<TextSelection>() != null);

        return default(System.Windows.Documents.TextSelection);
      }
    }
    #endregion

    #region Fields
    public readonly static System.Windows.DependencyProperty IsDocumentEnabledProperty;
    #endregion
  }
}
