﻿using System;
using Android.Runtime;

namespace Lifecycle
{
	public partial class Event
	{
		[Annotation("android.arch.lifecycle.OnLifecycleEvent(android.arch.lifecycle.Event.ON_CREATE)")]
		public class OnCreateAttribute : Attribute
		{ }

		[Annotation("android.arch.lifecycle.OnLifecycleEvent(android.arch.lifecycle.Event.ON_START)")]
		public class OnStartAttribute : Attribute
		{ }

		[Annotation("android.arch.lifecycle.OnLifecycleEvent(android.arch.lifecycle.Event.ON_RESUME)")]
		public class OnResumeAttribute : Attribute
		{ }

		[Annotation("android.arch.lifecycle.OnLifecycleEvent(android.arch.lifecycle.Event.ON_PAUSE)")]
		public class OnPauseAttribute : Attribute
		{ }

		[Annotation("android.arch.lifecycle.OnLifecycleEvent(android.arch.lifecycle.Event.ON_STOP)")]
		public class OnStopAttribute : Attribute
		{ }

		[Annotation("android.arch.lifecycle.OnLifecycleEvent(android.arch.lifecycle.Event.ON_DESTROY)")]
		public class OnDestroyAttribute : Attribute
		{ }

		[Annotation("android.arch.lifecycle.OnLifecycleEvent(android.arch.lifecycle.Event.ON_ANY)")]
		public class OnAnyAttribute : Attribute
		{ }
	}
}