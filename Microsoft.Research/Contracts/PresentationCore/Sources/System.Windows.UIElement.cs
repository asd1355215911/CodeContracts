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

// File System.Windows.UIElement.cs
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


namespace System.Windows
{
  public partial class UIElement : System.Windows.Media.Visual, System.Windows.Media.Animation.IAnimatable, IInputElement
  {
    #region Methods and constructors
    public void AddHandler(RoutedEvent routedEvent, Delegate handler, bool handledEventsToo)
    {
    }

    public void AddHandler(RoutedEvent routedEvent, Delegate handler)
    {
    }

    public void AddToEventRoute(EventRoute route, RoutedEventArgs e)
    {
    }

    public void ApplyAnimationClock(DependencyProperty dp, System.Windows.Media.Animation.AnimationClock clock)
    {
    }

    public void ApplyAnimationClock(DependencyProperty dp, System.Windows.Media.Animation.AnimationClock clock, System.Windows.Media.Animation.HandoffBehavior handoffBehavior)
    {
    }

    public void Arrange(Rect finalRect)
    {
    }

    protected virtual new void ArrangeCore(Rect finalRect)
    {
    }

    public void BeginAnimation(DependencyProperty dp, System.Windows.Media.Animation.AnimationTimeline animation, System.Windows.Media.Animation.HandoffBehavior handoffBehavior)
    {
    }

    public void BeginAnimation(DependencyProperty dp, System.Windows.Media.Animation.AnimationTimeline animation)
    {
    }

    public bool CaptureMouse()
    {
      return default(bool);
    }

    public bool CaptureStylus()
    {
      return default(bool);
    }

    public bool CaptureTouch(System.Windows.Input.TouchDevice touchDevice)
    {
      return default(bool);
    }

    public bool Focus()
    {
      return default(bool);
    }

    public Object GetAnimationBaseValue(DependencyProperty dp)
    {
      return default(Object);
    }

    protected virtual new System.Windows.Media.Geometry GetLayoutClip(Size layoutSlotSize)
    {
      return default(System.Windows.Media.Geometry);
    }

    protected internal virtual new DependencyObject GetUIParentCore()
    {
      return default(DependencyObject);
    }

    protected override System.Windows.Media.GeometryHitTestResult HitTestCore(System.Windows.Media.GeometryHitTestParameters hitTestParameters)
    {
      return default(System.Windows.Media.GeometryHitTestResult);
    }

    protected override System.Windows.Media.HitTestResult HitTestCore(System.Windows.Media.PointHitTestParameters hitTestParameters)
    {
      return default(System.Windows.Media.HitTestResult);
    }

    public IInputElement InputHitTest(Point point)
    {
      return default(IInputElement);
    }

    public void InvalidateArrange()
    {
    }

    public void InvalidateMeasure()
    {
    }

    public void InvalidateVisual()
    {
    }

    public void Measure(Size availableSize)
    {
    }

    protected virtual new Size MeasureCore(Size availableSize)
    {
      return default(Size);
    }

    public virtual new bool MoveFocus(System.Windows.Input.TraversalRequest request)
    {
      return default(bool);
    }

    protected virtual new void OnAccessKey(System.Windows.Input.AccessKeyEventArgs e)
    {
    }

    protected virtual new void OnChildDesiredSizeChanged(System.Windows.UIElement child)
    {
    }

    protected virtual new System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
    {
      return default(System.Windows.Automation.Peers.AutomationPeer);
    }

    protected virtual new void OnDragEnter(DragEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnDragLeave(DragEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnDragOver(DragEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnDrop(DragEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnGiveFeedback(GiveFeedbackEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnGotFocus(RoutedEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnGotKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnGotMouseCapture(System.Windows.Input.MouseEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnGotStylusCapture(System.Windows.Input.StylusEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnGotTouchCapture(System.Windows.Input.TouchEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnIsKeyboardFocusedChanged(DependencyPropertyChangedEventArgs e)
    {
    }

    protected virtual new void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
    {
    }

    protected virtual new void OnIsMouseCapturedChanged(DependencyPropertyChangedEventArgs e)
    {
    }

    protected virtual new void OnIsMouseCaptureWithinChanged(DependencyPropertyChangedEventArgs e)
    {
    }

    protected virtual new void OnIsMouseDirectlyOverChanged(DependencyPropertyChangedEventArgs e)
    {
    }

    protected virtual new void OnIsStylusCapturedChanged(DependencyPropertyChangedEventArgs e)
    {
    }

    protected virtual new void OnIsStylusCaptureWithinChanged(DependencyPropertyChangedEventArgs e)
    {
    }

    protected virtual new void OnIsStylusDirectlyOverChanged(DependencyPropertyChangedEventArgs e)
    {
    }

    protected virtual new void OnKeyDown(System.Windows.Input.KeyEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnKeyUp(System.Windows.Input.KeyEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnLostFocus(RoutedEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnLostKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnLostMouseCapture(System.Windows.Input.MouseEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnLostStylusCapture(System.Windows.Input.StylusEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnLostTouchCapture(System.Windows.Input.TouchEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnManipulationBoundaryFeedback(System.Windows.Input.ManipulationBoundaryFeedbackEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnManipulationCompleted(System.Windows.Input.ManipulationCompletedEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnManipulationDelta(System.Windows.Input.ManipulationDeltaEventArgs e)
    {
      Contract.Requires(e != null);
    }

#if NETFRAMEWORK_4_0
    protected virtual new void OnManipulationInertiaStarting(System.Windows.Input.ManipulationInertiaStartingEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnManipulationStarted(System.Windows.Input.ManipulationStartedEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnManipulationStarting(System.Windows.Input.ManipulationStartingEventArgs e)
    {
      Contract.Requires(e != null);
    }
#endif

    protected virtual new void OnMouseDown(System.Windows.Input.MouseButtonEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnMouseEnter(System.Windows.Input.MouseEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnMouseLeave(System.Windows.Input.MouseEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnMouseLeftButtonDown(System.Windows.Input.MouseButtonEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnMouseLeftButtonUp(System.Windows.Input.MouseButtonEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnMouseMove(System.Windows.Input.MouseEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnMouseRightButtonDown(System.Windows.Input.MouseButtonEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnMouseRightButtonUp(System.Windows.Input.MouseButtonEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnMouseUp(System.Windows.Input.MouseButtonEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnMouseWheel(System.Windows.Input.MouseWheelEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewDragEnter(DragEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewDragLeave(DragEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewDragOver(DragEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewDrop(DragEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewGiveFeedback(GiveFeedbackEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewGotKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewKeyDown(System.Windows.Input.KeyEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewKeyUp(System.Windows.Input.KeyEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewLostKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewMouseDown(System.Windows.Input.MouseButtonEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewMouseLeftButtonDown(System.Windows.Input.MouseButtonEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewMouseLeftButtonUp(System.Windows.Input.MouseButtonEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewMouseMove(System.Windows.Input.MouseEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewMouseRightButtonDown(System.Windows.Input.MouseButtonEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewMouseRightButtonUp(System.Windows.Input.MouseButtonEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewMouseUp(System.Windows.Input.MouseButtonEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewMouseWheel(System.Windows.Input.MouseWheelEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewQueryContinueDrag(QueryContinueDragEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewStylusButtonDown(System.Windows.Input.StylusButtonEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewStylusButtonUp(System.Windows.Input.StylusButtonEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewStylusDown(System.Windows.Input.StylusDownEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewStylusInAirMove(System.Windows.Input.StylusEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewStylusInRange(System.Windows.Input.StylusEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewStylusMove(System.Windows.Input.StylusEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewStylusOutOfRange(System.Windows.Input.StylusEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewStylusSystemGesture(System.Windows.Input.StylusSystemGestureEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewStylusUp(System.Windows.Input.StylusEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewTextInput(System.Windows.Input.TextCompositionEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewTouchDown(System.Windows.Input.TouchEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewTouchMove(System.Windows.Input.TouchEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnPreviewTouchUp(System.Windows.Input.TouchEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnQueryContinueDrag(QueryContinueDragEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnQueryCursor(System.Windows.Input.QueryCursorEventArgs e)
    {
      Contract.Requires(e != null);
    }

    protected virtual new void OnRender(System.Windows.Media.DrawingContext drawingContext)
    {
    }

    protected internal virtual new void OnRenderSizeChanged(SizeChangedInfo info)
    {
    }

    protected virtual new void OnStylusButtonDown(System.Windows.Input.StylusButtonEventArgs e)
    {
    }

    protected virtual new void OnStylusButtonUp(System.Windows.Input.StylusButtonEventArgs e)
    {
    }

    protected virtual new void OnStylusDown(System.Windows.Input.StylusDownEventArgs e)
    {
    }

    protected virtual new void OnStylusEnter(System.Windows.Input.StylusEventArgs e)
    {
    }

    protected virtual new void OnStylusInAirMove(System.Windows.Input.StylusEventArgs e)
    {
    }

    protected virtual new void OnStylusInRange(System.Windows.Input.StylusEventArgs e)
    {
    }

    protected virtual new void OnStylusLeave(System.Windows.Input.StylusEventArgs e)
    {
    }

    protected virtual new void OnStylusMove(System.Windows.Input.StylusEventArgs e)
    {
    }

    protected virtual new void OnStylusOutOfRange(System.Windows.Input.StylusEventArgs e)
    {
    }

    protected virtual new void OnStylusSystemGesture(System.Windows.Input.StylusSystemGestureEventArgs e)
    {
    }

    protected virtual new void OnStylusUp(System.Windows.Input.StylusEventArgs e)
    {
    }

    protected virtual new void OnTextInput(System.Windows.Input.TextCompositionEventArgs e)
    {
    }

    protected virtual new void OnTouchDown(System.Windows.Input.TouchEventArgs e)
    {
    }

    protected virtual new void OnTouchEnter(System.Windows.Input.TouchEventArgs e)
    {
    }

    protected virtual new void OnTouchLeave(System.Windows.Input.TouchEventArgs e)
    {
    }

    protected virtual new void OnTouchMove(System.Windows.Input.TouchEventArgs e)
    {
    }

    protected virtual new void OnTouchUp(System.Windows.Input.TouchEventArgs e)
    {
    }

    protected internal override void OnVisualParentChanged(DependencyObject oldParent)
    {
    }

    public virtual new DependencyObject PredictFocus(System.Windows.Input.FocusNavigationDirection direction)
    {
      return default(DependencyObject);
    }

    public void RaiseEvent(RoutedEventArgs e)
    {
    }

    public void ReleaseAllTouchCaptures()
    {
    }

    public void ReleaseMouseCapture()
    {
    }

    public void ReleaseStylusCapture()
    {
    }

    public bool ReleaseTouchCapture(System.Windows.Input.TouchDevice touchDevice)
    {
      return default(bool);
    }

    public void RemoveHandler(RoutedEvent routedEvent, Delegate handler)
    {
    }

    public bool ShouldSerializeCommandBindings()
    {
      return default(bool);
    }

    public bool ShouldSerializeInputBindings()
    {
      return default(bool);
    }

    public Point TranslatePoint(Point point, System.Windows.UIElement relativeTo)
    {
      return default(Point);
    }

    public UIElement()
    {
    }

    public void UpdateLayout()
    {
    }
    #endregion

    #region Properties and indexers
    public bool AllowDrop
    {
      get
      {
        return default(bool);
      }
      set
      {
      }
    }

    public bool AreAnyTouchesCaptured
    {
      get
      {
        return default(bool);
      }
    }

    public bool AreAnyTouchesCapturedWithin
    {
      get
      {
        return default(bool);
      }
    }

    public bool AreAnyTouchesDirectlyOver
    {
      get
      {
        return default(bool);
      }
    }

    public bool AreAnyTouchesOver
    {
      get
      {
        return default(bool);
      }
    }

    public System.Windows.Media.Effects.BitmapEffect BitmapEffect
    {
      get
      {
        return default(System.Windows.Media.Effects.BitmapEffect);
      }
      set
      {
      }
    }

    public System.Windows.Media.Effects.BitmapEffectInput BitmapEffectInput
    {
      get
      {
        return default(System.Windows.Media.Effects.BitmapEffectInput);
      }
      set
      {
      }
    }

    public System.Windows.Media.CacheMode CacheMode
    {
      get
      {
        return default(System.Windows.Media.CacheMode);
      }
      set
      {
      }
    }

    public System.Windows.Media.Geometry Clip
    {
      get
      {
        return default(System.Windows.Media.Geometry);
      }
      set
      {
      }
    }

    public bool ClipToBounds
    {
      get
      {
        return default(bool);
      }
      set
      {
      }
    }

    public System.Windows.Input.CommandBindingCollection CommandBindings
    {
      get
      {
        return default(System.Windows.Input.CommandBindingCollection);
      }
    }

    public Size DesiredSize
    {
      get
      {
        return default(Size);
      }
    }

    public System.Windows.Media.Effects.Effect Effect
    {
      get
      {
        return default(System.Windows.Media.Effects.Effect);
      }
      set
      {
      }
    }

    public bool Focusable
    {
      get
      {
        return default(bool);
      }
      set
      {
      }
    }

    public bool HasAnimatedProperties
    {
      get
      {
        return default(bool);
      }
    }

    public System.Windows.Input.InputBindingCollection InputBindings
    {
      get
      {
        return default(System.Windows.Input.InputBindingCollection);
      }
    }

    public bool IsArrangeValid
    {
      get
      {
        return default(bool);
      }
    }

    public bool IsEnabled
    {
      get
      {
        return default(bool);
      }
      set
      {
      }
    }

    protected virtual new bool IsEnabledCore
    {
      get
      {
        return default(bool);
      }
    }

    public bool IsFocused
    {
      get
      {
        return default(bool);
      }
    }

    public bool IsHitTestVisible
    {
      get
      {
        return default(bool);
      }
      set
      {
      }
    }

    public bool IsInputMethodEnabled
    {
      get
      {
        return default(bool);
      }
    }

    public bool IsKeyboardFocused
    {
      get
      {
        return default(bool);
      }
    }

    public bool IsKeyboardFocusWithin
    {
      get
      {
        return default(bool);
      }
    }

    public bool IsManipulationEnabled
    {
      get
      {
        return default(bool);
      }
      set
      {
      }
    }

    public bool IsMeasureValid
    {
      get
      {
        return default(bool);
      }
    }

    public bool IsMouseCaptured
    {
      get
      {
        return default(bool);
      }
    }

    public bool IsMouseCaptureWithin
    {
      get
      {
        return default(bool);
      }
    }

    public bool IsMouseDirectlyOver
    {
      get
      {
        return default(bool);
      }
    }

    public bool IsMouseOver
    {
      get
      {
        return default(bool);
      }
    }

    public bool IsStylusCaptured
    {
      get
      {
        return default(bool);
      }
    }

    public bool IsStylusCaptureWithin
    {
      get
      {
        return default(bool);
      }
    }

    public bool IsStylusDirectlyOver
    {
      get
      {
        return default(bool);
      }
    }

    public bool IsStylusOver
    {
      get
      {
        return default(bool);
      }
    }

    public bool IsVisible
    {
      get
      {
        return default(bool);
      }
    }

    public double Opacity
    {
      get
      {
        return default(double);
      }
      set
      {
      }
    }

    public System.Windows.Media.Brush OpacityMask
    {
      get
      {
        return default(System.Windows.Media.Brush);
      }
      set
      {
      }
    }

    public int PersistId
    {
      get
      {
        return default(int);
      }
    }

    public Size RenderSize
    {
      get
      {
        return default(Size);
      }
      set
      {
      }
    }

    public System.Windows.Media.Transform RenderTransform
    {
      get
      {
        return default(System.Windows.Media.Transform);
      }
      set
      {
      }
    }

    public Point RenderTransformOrigin
    {
      get
      {
        return default(Point);
      }
      set
      {
      }
    }

    public bool SnapsToDevicePixels
    {
      get
      {
        return default(bool);
      }
      set
      {
      }
    }

    protected System.Windows.Input.StylusPlugIns.StylusPlugInCollection StylusPlugIns
    {
      get
      {
        return default(System.Windows.Input.StylusPlugIns.StylusPlugInCollection);
      }
    }

    public IEnumerable<System.Windows.Input.TouchDevice> TouchesCaptured
    {
      get
      {
        return default(IEnumerable<System.Windows.Input.TouchDevice>);
      }
    }

    public IEnumerable<System.Windows.Input.TouchDevice> TouchesCapturedWithin
    {
      get
      {
        return default(IEnumerable<System.Windows.Input.TouchDevice>);
      }
    }

    public IEnumerable<System.Windows.Input.TouchDevice> TouchesDirectlyOver
    {
      get
      {
        return default(IEnumerable<System.Windows.Input.TouchDevice>);
      }
    }

    public IEnumerable<System.Windows.Input.TouchDevice> TouchesOver
    {
      get
      {
        return default(IEnumerable<System.Windows.Input.TouchDevice>);
      }
    }

    public string Uid
    {
      get
      {
        return default(string);
      }
      set
      {
      }
    }

    public Visibility Visibility
    {
      get
      {
        return default(Visibility);
      }
      set
      {
      }
    }
    #endregion

    #region Events
    public event DragEventHandler DragEnter
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DragEventHandler DragLeave
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DragEventHandler DragOver
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DragEventHandler Drop
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DependencyPropertyChangedEventHandler FocusableChanged
    {
      add
      {
      }
      remove
      {
      }
    }

    public event GiveFeedbackEventHandler GiveFeedback
    {
      add
      {
      }
      remove
      {
      }
    }

    public event RoutedEventHandler GotFocus
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.KeyboardFocusChangedEventHandler GotKeyboardFocus
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseEventHandler GotMouseCapture
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusEventHandler GotStylusCapture
    {
      add
      {
      }
      remove
      {
      }
    }

    public event EventHandler<System.Windows.Input.TouchEventArgs> GotTouchCapture
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DependencyPropertyChangedEventHandler IsEnabledChanged
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DependencyPropertyChangedEventHandler IsHitTestVisibleChanged
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DependencyPropertyChangedEventHandler IsKeyboardFocusedChanged
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DependencyPropertyChangedEventHandler IsKeyboardFocusWithinChanged
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DependencyPropertyChangedEventHandler IsMouseCapturedChanged
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DependencyPropertyChangedEventHandler IsMouseCaptureWithinChanged
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DependencyPropertyChangedEventHandler IsMouseDirectlyOverChanged
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DependencyPropertyChangedEventHandler IsStylusCapturedChanged
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DependencyPropertyChangedEventHandler IsStylusCaptureWithinChanged
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DependencyPropertyChangedEventHandler IsStylusDirectlyOverChanged
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DependencyPropertyChangedEventHandler IsVisibleChanged
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.KeyEventHandler KeyDown
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.KeyEventHandler KeyUp
    {
      add
      {
      }
      remove
      {
      }
    }

    public event EventHandler LayoutUpdated
    {
      add
      {
      }
      remove
      {
      }
    }

    public event RoutedEventHandler LostFocus
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.KeyboardFocusChangedEventHandler LostKeyboardFocus
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseEventHandler LostMouseCapture
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusEventHandler LostStylusCapture
    {
      add
      {
      }
      remove
      {
      }
    }

    public event EventHandler<System.Windows.Input.TouchEventArgs> LostTouchCapture
    {
      add
      {
      }
      remove
      {
      }
    }

    public event EventHandler<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> ManipulationBoundaryFeedback
    {
      add
      {
      }
      remove
      {
      }
    }

    public event EventHandler<System.Windows.Input.ManipulationCompletedEventArgs> ManipulationCompleted
    {
      add
      {
      }
      remove
      {
      }
    }

    public event EventHandler<System.Windows.Input.ManipulationDeltaEventArgs> ManipulationDelta
    {
      add
      {
      }
      remove
      {
      }
    }

#if NETFRAMEWORK_4_0
    public event EventHandler<System.Windows.Input.ManipulationInertiaStartingEventArgs> ManipulationInertiaStarting
    {
      add
      {
      }
      remove
      {
      }
    }
#endif

    public event EventHandler<System.Windows.Input.ManipulationStartedEventArgs> ManipulationStarted
    {
      add
      {
      }
      remove
      {
      }
    }

#if NETFRAMEWORK_4_0
    public event EventHandler<System.Windows.Input.ManipulationStartingEventArgs> ManipulationStarting
    {
      add
      {
      }
      remove
      {
      }
    }
#endif

    public event System.Windows.Input.MouseButtonEventHandler MouseDown
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseEventHandler MouseEnter
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseEventHandler MouseLeave
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseButtonEventHandler MouseLeftButtonDown
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseButtonEventHandler MouseLeftButtonUp
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseEventHandler MouseMove
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseButtonEventHandler MouseRightButtonDown
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseButtonEventHandler MouseRightButtonUp
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseButtonEventHandler MouseUp
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseWheelEventHandler MouseWheel
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DragEventHandler PreviewDragEnter
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DragEventHandler PreviewDragLeave
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DragEventHandler PreviewDragOver
    {
      add
      {
      }
      remove
      {
      }
    }

    public event DragEventHandler PreviewDrop
    {
      add
      {
      }
      remove
      {
      }
    }

    public event GiveFeedbackEventHandler PreviewGiveFeedback
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.KeyboardFocusChangedEventHandler PreviewGotKeyboardFocus
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.KeyEventHandler PreviewKeyDown
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.KeyEventHandler PreviewKeyUp
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.KeyboardFocusChangedEventHandler PreviewLostKeyboardFocus
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseButtonEventHandler PreviewMouseDown
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseButtonEventHandler PreviewMouseLeftButtonDown
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseButtonEventHandler PreviewMouseLeftButtonUp
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseEventHandler PreviewMouseMove
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseButtonEventHandler PreviewMouseRightButtonDown
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseButtonEventHandler PreviewMouseRightButtonUp
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseButtonEventHandler PreviewMouseUp
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.MouseWheelEventHandler PreviewMouseWheel
    {
      add
      {
      }
      remove
      {
      }
    }

    public event QueryContinueDragEventHandler PreviewQueryContinueDrag
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusButtonEventHandler PreviewStylusButtonDown
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusButtonEventHandler PreviewStylusButtonUp
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusDownEventHandler PreviewStylusDown
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusEventHandler PreviewStylusInAirMove
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusEventHandler PreviewStylusInRange
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusEventHandler PreviewStylusMove
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusEventHandler PreviewStylusOutOfRange
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusSystemGestureEventHandler PreviewStylusSystemGesture
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusEventHandler PreviewStylusUp
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.TextCompositionEventHandler PreviewTextInput
    {
      add
      {
      }
      remove
      {
      }
    }

    public event EventHandler<System.Windows.Input.TouchEventArgs> PreviewTouchDown
    {
      add
      {
      }
      remove
      {
      }
    }

    public event EventHandler<System.Windows.Input.TouchEventArgs> PreviewTouchMove
    {
      add
      {
      }
      remove
      {
      }
    }

    public event EventHandler<System.Windows.Input.TouchEventArgs> PreviewTouchUp
    {
      add
      {
      }
      remove
      {
      }
    }

    public event QueryContinueDragEventHandler QueryContinueDrag
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.QueryCursorEventHandler QueryCursor
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusButtonEventHandler StylusButtonDown
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusButtonEventHandler StylusButtonUp
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusDownEventHandler StylusDown
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusEventHandler StylusEnter
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusEventHandler StylusInAirMove
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusEventHandler StylusInRange
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusEventHandler StylusLeave
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusEventHandler StylusMove
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusEventHandler StylusOutOfRange
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusSystemGestureEventHandler StylusSystemGesture
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.StylusEventHandler StylusUp
    {
      add
      {
      }
      remove
      {
      }
    }

    public event System.Windows.Input.TextCompositionEventHandler TextInput
    {
      add
      {
      }
      remove
      {
      }
    }

    public event EventHandler<System.Windows.Input.TouchEventArgs> TouchDown
    {
      add
      {
      }
      remove
      {
      }
    }

    public event EventHandler<System.Windows.Input.TouchEventArgs> TouchEnter
    {
      add
      {
      }
      remove
      {
      }
    }

    public event EventHandler<System.Windows.Input.TouchEventArgs> TouchLeave
    {
      add
      {
      }
      remove
      {
      }
    }

    public event EventHandler<System.Windows.Input.TouchEventArgs> TouchMove
    {
      add
      {
      }
      remove
      {
      }
    }

    public event EventHandler<System.Windows.Input.TouchEventArgs> TouchUp
    {
      add
      {
      }
      remove
      {
      }
    }
    #endregion

    #region Fields
    public readonly static DependencyProperty AllowDropProperty;
    public readonly static DependencyProperty AreAnyTouchesCapturedProperty;
    public readonly static DependencyProperty AreAnyTouchesCapturedWithinProperty;
    public readonly static DependencyProperty AreAnyTouchesDirectlyOverProperty;
    public readonly static DependencyProperty AreAnyTouchesOverProperty;
    public readonly static DependencyProperty BitmapEffectInputProperty;
    public readonly static DependencyProperty BitmapEffectProperty;
    public readonly static DependencyProperty CacheModeProperty;
    public readonly static DependencyProperty ClipProperty;
    public readonly static DependencyProperty ClipToBoundsProperty;
    public readonly static RoutedEvent DragEnterEvent;
    public readonly static RoutedEvent DragLeaveEvent;
    public readonly static RoutedEvent DragOverEvent;
    public readonly static RoutedEvent DropEvent;
    public readonly static DependencyProperty EffectProperty;
    public readonly static DependencyProperty FocusableProperty;
    public readonly static RoutedEvent GiveFeedbackEvent;
    public readonly static RoutedEvent GotFocusEvent;
    public readonly static RoutedEvent GotKeyboardFocusEvent;
    public readonly static RoutedEvent GotMouseCaptureEvent;
    public readonly static RoutedEvent GotStylusCaptureEvent;
    public readonly static RoutedEvent GotTouchCaptureEvent;
    public readonly static DependencyProperty IsEnabledProperty;
    public readonly static DependencyProperty IsFocusedProperty;
    public readonly static DependencyProperty IsHitTestVisibleProperty;
    public readonly static DependencyProperty IsKeyboardFocusedProperty;
    public readonly static DependencyProperty IsKeyboardFocusWithinProperty;
    public readonly static DependencyProperty IsManipulationEnabledProperty;
    public readonly static DependencyProperty IsMouseCapturedProperty;
    public readonly static DependencyProperty IsMouseCaptureWithinProperty;
    public readonly static DependencyProperty IsMouseDirectlyOverProperty;
    public readonly static DependencyProperty IsMouseOverProperty;
    public readonly static DependencyProperty IsStylusCapturedProperty;
    public readonly static DependencyProperty IsStylusCaptureWithinProperty;
    public readonly static DependencyProperty IsStylusDirectlyOverProperty;
    public readonly static DependencyProperty IsStylusOverProperty;
    public readonly static DependencyProperty IsVisibleProperty;
    public readonly static RoutedEvent KeyDownEvent;
    public readonly static RoutedEvent KeyUpEvent;
    public readonly static RoutedEvent LostFocusEvent;
    public readonly static RoutedEvent LostKeyboardFocusEvent;
    public readonly static RoutedEvent LostMouseCaptureEvent;
    public readonly static RoutedEvent LostStylusCaptureEvent;
    public readonly static RoutedEvent LostTouchCaptureEvent;
    public readonly static RoutedEvent ManipulationBoundaryFeedbackEvent;
    public readonly static RoutedEvent ManipulationCompletedEvent;
    public readonly static RoutedEvent ManipulationDeltaEvent;
    public readonly static RoutedEvent ManipulationInertiaStartingEvent;
    public readonly static RoutedEvent ManipulationStartedEvent;
    public readonly static RoutedEvent ManipulationStartingEvent;
    public readonly static RoutedEvent MouseDownEvent;
    public readonly static RoutedEvent MouseEnterEvent;
    public readonly static RoutedEvent MouseLeaveEvent;
    public readonly static RoutedEvent MouseLeftButtonDownEvent;
    public readonly static RoutedEvent MouseLeftButtonUpEvent;
    public readonly static RoutedEvent MouseMoveEvent;
    public readonly static RoutedEvent MouseRightButtonDownEvent;
    public readonly static RoutedEvent MouseRightButtonUpEvent;
    public readonly static RoutedEvent MouseUpEvent;
    public readonly static RoutedEvent MouseWheelEvent;
    public readonly static DependencyProperty OpacityMaskProperty;
    public readonly static DependencyProperty OpacityProperty;
    public readonly static RoutedEvent PreviewDragEnterEvent;
    public readonly static RoutedEvent PreviewDragLeaveEvent;
    public readonly static RoutedEvent PreviewDragOverEvent;
    public readonly static RoutedEvent PreviewDropEvent;
    public readonly static RoutedEvent PreviewGiveFeedbackEvent;
    public readonly static RoutedEvent PreviewGotKeyboardFocusEvent;
    public readonly static RoutedEvent PreviewKeyDownEvent;
    public readonly static RoutedEvent PreviewKeyUpEvent;
    public readonly static RoutedEvent PreviewLostKeyboardFocusEvent;
    public readonly static RoutedEvent PreviewMouseDownEvent;
    public readonly static RoutedEvent PreviewMouseLeftButtonDownEvent;
    public readonly static RoutedEvent PreviewMouseLeftButtonUpEvent;
    public readonly static RoutedEvent PreviewMouseMoveEvent;
    public readonly static RoutedEvent PreviewMouseRightButtonDownEvent;
    public readonly static RoutedEvent PreviewMouseRightButtonUpEvent;
    public readonly static RoutedEvent PreviewMouseUpEvent;
    public readonly static RoutedEvent PreviewMouseWheelEvent;
    public readonly static RoutedEvent PreviewQueryContinueDragEvent;
    public readonly static RoutedEvent PreviewStylusButtonDownEvent;
    public readonly static RoutedEvent PreviewStylusButtonUpEvent;
    public readonly static RoutedEvent PreviewStylusDownEvent;
    public readonly static RoutedEvent PreviewStylusInAirMoveEvent;
    public readonly static RoutedEvent PreviewStylusInRangeEvent;
    public readonly static RoutedEvent PreviewStylusMoveEvent;
    public readonly static RoutedEvent PreviewStylusOutOfRangeEvent;
    public readonly static RoutedEvent PreviewStylusSystemGestureEvent;
    public readonly static RoutedEvent PreviewStylusUpEvent;
    public readonly static RoutedEvent PreviewTextInputEvent;
    public readonly static RoutedEvent PreviewTouchDownEvent;
    public readonly static RoutedEvent PreviewTouchMoveEvent;
    public readonly static RoutedEvent PreviewTouchUpEvent;
    public readonly static RoutedEvent QueryContinueDragEvent;
    public readonly static RoutedEvent QueryCursorEvent;
    public readonly static DependencyProperty RenderTransformOriginProperty;
    public readonly static DependencyProperty RenderTransformProperty;
    public readonly static DependencyProperty SnapsToDevicePixelsProperty;
    public readonly static RoutedEvent StylusButtonDownEvent;
    public readonly static RoutedEvent StylusButtonUpEvent;
    public readonly static RoutedEvent StylusDownEvent;
    public readonly static RoutedEvent StylusEnterEvent;
    public readonly static RoutedEvent StylusInAirMoveEvent;
    public readonly static RoutedEvent StylusInRangeEvent;
    public readonly static RoutedEvent StylusLeaveEvent;
    public readonly static RoutedEvent StylusMoveEvent;
    public readonly static RoutedEvent StylusOutOfRangeEvent;
    public readonly static RoutedEvent StylusSystemGestureEvent;
    public readonly static RoutedEvent StylusUpEvent;
    public readonly static RoutedEvent TextInputEvent;
    public readonly static RoutedEvent TouchDownEvent;
    public readonly static RoutedEvent TouchEnterEvent;
    public readonly static RoutedEvent TouchLeaveEvent;
    public readonly static RoutedEvent TouchMoveEvent;
    public readonly static RoutedEvent TouchUpEvent;
    public readonly static DependencyProperty UidProperty;
    public readonly static DependencyProperty VisibilityProperty;
    #endregion
  }
}
