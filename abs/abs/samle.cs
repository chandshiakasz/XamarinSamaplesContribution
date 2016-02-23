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

			var greenBox = new StackLayout 
			{
				Padding = 10,
				HeightRequest = 500,
				//WidthRequest = 1000,
				BackgroundColor = Color.Green,
				Children={
					new Label{
						Text="Low to High",
						TextColor=Color.White,
					},
					new Label{
						Text="High to low",
						TextColor=Color.White,
					},
				},
			};

			AbsoluteLayout.SetLayoutFlags(redBox, AbsoluteLayoutFlags.All);

			AbsoluteLayout.SetLayoutBounds(redBox, new Rectangle(0.99,0.00,0.25,0.25));
			//developers comments
			//rectangle(it moves left right , ti moves top , bottom,width percentage,height percentage)

			AbsoluteLayout.SetLayoutFlags(greenBox, AbsoluteLayoutFlags.All);

			AbsoluteLayout.SetLayoutBounds(greenBox, new Rectangle(0.50,0.50,0.35,0.25));
		
			var absoluteSettings = new AbsoluteLayout 
			{
				IsVisible =false,
				Children = {
					redBox,
				}
			};

			var absoluteActionSettings = new AbsoluteLayout 
			{
				IsVisible =false,
				Children = {
					greenBox,
				}
			};

			var settings = new ToolbarItem { 
				Text = "settings",
				//Icon = "search.png",
				Command = new Command (() => {
					absoluteSettings.IsVisible = !absoluteSettings.IsVisible;
					absoluteActionSettings.IsVisible=false;

				}),
			};
			ToolbarItems.Add (settings);

			var settingsAction = new ToolbarItem { 
				Text = "setAction",
				Command = new Command (() => {
					absoluteActionSettings.IsVisible = !absoluteActionSettings.IsVisible;
					absoluteSettings.IsVisible=false;
				}),
			};
			ToolbarItems.Add (settingsAction);

			var stack = new StackLayout {
				BackgroundColor = Color.Aqua,
				Children=
				{
					absoluteSettings,
					absoluteActionSettings
				},	
			};

			var tap = new TapGestureRecognizer ();
			tap.Tapped += (sender, e) => {
				absoluteSettings.IsVisible=false;
				absoluteActionSettings.IsVisible=false;
			};
			stack.GestureRecognizers.Add (tap);
			Content = stack;
		}
	}
}


