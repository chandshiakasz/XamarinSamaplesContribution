using System;
using Xamarin.Forms;

namespace abs
{
	public class samle : ContentPage
	{
		public samle ()
		{
			Title = "Settings page ";

			var redBox = new StackLayout 
			{
				Padding = 10,
				HeightRequest = 500,
				BackgroundColor = Color.Red,
				Children={
					new Label{
						Text="Profile",
						TextColor=Color.White,
					},
					new Label{
						Text="SignOut",
						TextColor=Color.White,
					},
				},
			};
				
//			var blueBox = new BoxView {
//				Color = Color.Blue
//			};
//
//			var yellowBox = new BoxView {
//
//				Color = Color.Yellow
//
//			};
//
//			var purpleBox = new BoxView {
//
//				Color = Color.Purple
//
//			};
//
//			var greenBox = new BoxView {
//
//				Color = Color.Green
//
//			};

			AbsoluteLayout.SetLayoutFlags(redBox, AbsoluteLayoutFlags.All);

			AbsoluteLayout.SetLayoutBounds(redBox, new Rectangle(0.99,0.00,0.25,0.25));
			//developers comments
			//rectangle(it moves left right , ti moves top , bottom,size,size)
//			AbsoluteLayout.SetLayoutFlags(blueBox, AbsoluteLayoutFlags.All);
//
//			AbsoluteLayout.SetLayoutBounds(blueBox, new Rectangle(0.15, 0.15, 0.25, 0.25));

//			AbsoluteLayout.SetLayoutFlags(yellowBox, AbsoluteLayoutFlags.All);
//
//			AbsoluteLayout.SetLayoutBounds(yellowBox, new Rectangle(0.30, 0.30, 0.25,
//
//				0.25));

//			AbsoluteLayout.SetLayoutFlags(purpleBox, AbsoluteLayoutFlags.All);
//
//			AbsoluteLayout.SetLayoutBounds(purpleBox, new Rectangle(0.45, 0.45, 0.25,
//
//				0.25));

//			AbsoluteLayout.SetLayoutFlags(greenBox, AbsoluteLayoutFlags.All);
//
//			AbsoluteLayout.SetLayoutBounds(greenBox, new Rectangle(0.60, 0.60, 0.25,
//
//				0.25));

			var absolute = new AbsoluteLayout 
			{
				IsVisible =false,
				Children = {
					redBox,
					//blueBox, yellowBox, purpleBox, greenBox
				}
			};

			var search = new ToolbarItem { 
				Text = "settings",
				//Icon = "search.png",
				Command = new Command (() => {
					//searchBox.Text = string.Empty;
					absolute.IsVisible = !absolute.IsVisible;
				}),
			};
			ToolbarItems.Add (search);
//
//			var btn = new Button{
//				Text = "settings"
//			};
//
//			btn.Clicked+= (sender, e) => {
//				absolute.IsVisible = !absolute.IsVisible;
//			};
			var stack = new StackLayout {
				BackgroundColor = Color.Aqua,
				Children=
				{
					//btn,
					absolute
				},	
			};

			var tap = new TapGestureRecognizer ();
			tap.Tapped += (sender, e) => {
				absolute.IsVisible=false;
			};
			stack.GestureRecognizers.Add (tap);
			Content = stack;
		}
	}
}


