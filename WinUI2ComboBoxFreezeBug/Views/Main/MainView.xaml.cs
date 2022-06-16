using System;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.WindowManagement;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Hosting;

namespace WinUI2ComboBoxFreezeBug.Views.Main
{
	public sealed partial class MainView : UserControl
	{
		public MainView()
		{
			this.InitializeComponent();
		}



		//// Event Handlers


		async void btnSpawnWindow_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
		{
			var newView = new MainView();
			await TryShowChildWindow(newView);
		}



		//// Helpers


		public async Task<bool> TryShowChildWindow(UserControl view)
		{
			// Get the child window instance
			var childWindowInstance = await CreateChildWindow();
			if (childWindowInstance == null)
				return false;

			// Show the child window
			var isShown = await childWindowInstance.TryShowAsync();
			return isShown;


			//// Local Functions


			async Task<AppWindow> CreateChildWindow(int width = 500, int height = 400)
			{
				//Create the child window
				var newWindow = await AppWindow.TryCreateAsync();
				if (newWindow == null)
					return null;

				// Create content
				var content = view;

				// Set window size
				var size = new Size(width, height);
				newWindow.RequestSize(size);

				// Set window content
				ElementCompositionPreview.SetAppWindowContent(newWindow, content);

				return newWindow;
			}
		}
	}
}
