using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Storage;

namespace Alice_Novel;

public partial class DevPage : ContentPage
{
	public DevPage()
	{
		InitializeComponent();
	}

    private async void File_Clicked(object sender, EventArgs e)
    {
        await PickFolder(CancellationToken.None);

        static async Task PickFolder(CancellationToken cancellationToken)
        {
            var result = await FolderPicker.Default.PickAsync(cancellationToken);
            if (result.IsSuccessful)
            {
                //await Toast.Make($"�t�H���_�[���m�F���܂����B����:{result.Folder.Name}, �ꏊ:{result.Folder.Path}", ToastDuration.Long).Show(cancellationToken);
                string location = result.Folder.Path;
            }
            /*
            else
            {
                await Toast.Make($"�\�����ʃG���[���������܂����B�G���[���e: {result.Exception.Message}").Show(cancellationToken);
            }
            */
        }
    }
}