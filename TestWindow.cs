
using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;

namespace SamplesButtonMadness
{
	public partial class TestWindow : AppKit.NSWindow
	{
		#region Constructors

		// Called when created from unmanaged code
		public TestWindow (IntPtr handle) : base(handle)
		{
			Initialize ();
		}

		// Called when created directly from a XIB file
		[Export("initWithCoder:")]
		public TestWindow (NSCoder coder) : base(coder)
		{
			Initialize ();
		}

		// Shared initialization code
		void Initialize ()
		{
		}
		
		#endregion
	}
}

