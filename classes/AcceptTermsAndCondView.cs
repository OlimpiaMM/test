using Eliot.App.LibPages.Commons.Controls;
using Eliot.App.LibPages.Commons.Infrastructure;
using Eliot.App.LibPages.Federation.ViewModels;
using Eliot.App.LibPages.Localization;
using Eliot.App.LibPages.ViewModel;
using Xamarin.Forms;

namespace Eliot.App.LibPages.Federation.Views
{
	public class AcceptTermsAndCondView: ViewBase
	{
		public AcceptTermsAndCondView()
		{
			BindingContext = Bootstrapper.InstanceOf<AcceptTermsAndCondViewModel>();

			Title = "ACCEPT TERMS AND CONDITIONS";
			BackgroundImage = "background.png";

			var info = new LabelLibPages
			{
				Text = "Lorem ipsum dolor sit amet",
				VerticalOptions = LayoutOptions.StartAndExpand,
				HorizontalOptions = LayoutOptions.StartAndExpand,
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
				HorizontalTextAlignment = TextAlignment.Start,
			};

			var separator = new BoxView
			{
				HeightRequest = 2,
				BackgroundColor = ChronoColor.White80
			};

			var topGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection
				{
					new RowDefinition { Height = GridLength.Auto },
					//new RowDefinition { Height = GridLength.Auto },
				},

				VerticalOptions = LayoutOptions.EndAndExpand
			};
			topGrid.Children.Add(info, 0, 0);
			//topGrid.Children.Add(separator, 1, 0);

			var centerGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection
				{
					new RowDefinition {Height = GridLength.Auto},
				},
				Padding = new Thickness(16, 32, 16, 0),
				VerticalOptions = LayoutOptions.Start

			};
			var check1 = new Image
			{
				Source = ImageSource.FromFile("checkbox_on.png"),
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Start
			};
			var check2 = new Image
			{
				Source = ImageSource.FromFile("checkbox_on.png"),
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center
			};
			var check1Stack = new StackLayout
			{
				Orientation = StackOrientation.Horizontal,
				VerticalOptions = LayoutOptions.Start,
				Children =
				{
					check1,
					new LabelLibPages { Text = "Lorem ipsum dolor" }
				}
			};
			var check2Stack = new StackLayout
			{
				Orientation = StackOrientation.Horizontal,
				VerticalOptions = LayoutOptions.Start,
				Children =
				{
					check2,
					new LabelLibPages { Text ="Lorem ipsum dolor" }
				}
			};
			var stack = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.StartAndExpand
			};
			stack.Children.Add(check1Stack);
			stack.Children.Add(check2Stack);
			centerGrid.Children.Add(stack, 0, 0);

			var cmdNext = new ButtonLibPages
			{
				Image = "confirm.png",
			};
			cmdNext.SetBinding(Button.CommandProperty, new Binding("NextCommand"));


			var bottomGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection
				{
					new RowDefinition {Height = GridLength.Auto},
				},
				VerticalOptions = LayoutOptions.Center,
				Padding = new Thickness(16, 0, 16, 0),
			};
			bottomGrid.Children.Add(cmdNext, 0, 0);

			var contentGrid = new Grid
			{
				RowDefinitions = new RowDefinitionCollection
				{
					new RowDefinition { Height = GridLength.Star },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition {Height = new GridLength(3, GridUnitType.Star)},
					new RowDefinition { Height = GridLength.Star }
				},
				VerticalOptions = LayoutOptions.FillAndExpand,
			};

			contentGrid.Children.Add(topGrid, 0, 0);
			contentGrid.Children.Add(centerGrid, 0, 2);
			contentGrid.Children.Add(bottomGrid, 0, 3);

			var layoutGeneral = new ScrollView
			{
				Content = contentGrid,
				Padding = new Thickness(16, 16, 16, 16)
			};

			Content = layoutGeneral;
		}
	}
}
