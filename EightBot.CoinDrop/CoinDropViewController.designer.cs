// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace EightBot.CoinDrop
{
	[Register ("CoinDropViewController")]
	partial class CoinDropViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnDropCoin { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView ivCoinCatcher { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView ivGoldCoin { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView ivGreenGem { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView ivRedGem { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView ivYellowGem { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnDropCoin != null) {
				btnDropCoin.Dispose ();
				btnDropCoin = null;
			}

			if (ivGoldCoin != null) {
				ivGoldCoin.Dispose ();
				ivGoldCoin = null;
			}

			if (ivCoinCatcher != null) {
				ivCoinCatcher.Dispose ();
				ivCoinCatcher = null;
			}

			if (ivGreenGem != null) {
				ivGreenGem.Dispose ();
				ivGreenGem = null;
			}

			if (ivRedGem != null) {
				ivRedGem.Dispose ();
				ivRedGem = null;
			}

			if (ivYellowGem != null) {
				ivYellowGem.Dispose ();
				ivYellowGem = null;
			}
		}
	}
}
