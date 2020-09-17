﻿using AppKit;

namespace Xamarin.Platform.Handlers
{
	public partial class ButtonHandler : AbstractViewHandler<IButton, NSButton>
	{
		protected override NSButton CreateView() => new NSButton();

		public static void MapText(IViewHandler handler, IButton view) { }
	}
}