namespace Alice_Novel;

public partial class GamePage : ContentPage
{
	public GamePage()
	{
		InitializeComponent();
	}

    //��ʂ̔䗦�ɂ���ĉ摜�̒��S�ʒu�ύX
    private void Game_ui_SizeChanged(object sender, EventArgs e)
    {
        /*
        double height = main_ui.Height;
        double width = main_ui.Width;

        if (height > width)
        {
            //�cUI
            image.VerticalOptions = LayoutOptions.Start;
        }
        else
        {
            //��UI
            image.VerticalOptions = LayoutOptions.Center;
        }
        */
    }

    private void Button1_Clicked(object sender, EventArgs e)
    {
        //button1���N���b�N�����Ƃ��̏���
    }

    private async void Button2_Clicked(object sender, EventArgs e)
    {
        //button2���N���b�N�����Ƃ��̏���
        await Shell.Current.GoToAsync("//MainPage");
    }

    private void Button3_Clicked(object sender, EventArgs e)
    {
        //button3���N���b�N�����Ƃ��̏���
    }

    private void Button4_Clicked(object sender, EventArgs e)
    {
        //button4���N���b�N�����Ƃ��̏���
    }

    private void Button5_Clicked(object sender, EventArgs e)
    {
        //button5���N���b�N�����Ƃ��̏���
    }

    private void Button6_Clicked(object sender, EventArgs e)
    {
        //button6���N���b�N�����Ƃ��̏���
    }
}