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

    //������Ԃ̃{�^���L��/�����̊m�F�p(null�G���[�΍�̂��߂ɏ����l��false�ɐݒ�)
    bool button3_start, button4_start, button5_start, button6_start = false;

    private void ReShow_Clicked(object sender, EventArgs e)
    {
        //re���N���b�N�����Ƃ��̏���
        button1.IsVisible = true;
        button2.IsVisible = true;
        textbox.IsVisible = true;
        textbox_out.IsVisible = true;
        re.IsEnabled = false;
        //image.Aspect = "AspectFill";
        //�����l�ɐݒ�(�����ŕ\������Ă�����\���A�����łȂ��������\��)
        button3.IsVisible = button3_start;
        button4.IsVisible = button4_start;
        button5.IsVisible = button5_start;
        button6.IsVisible = button6_start;
    }

    private void Button1_Clicked(object sender, EventArgs e)
    {
        //button1���N���b�N�����Ƃ��̏���
    }

    private void Button2_Clicked(object sender, EventArgs e)
    {
        //button2���N���b�N�����Ƃ��̏���

        //�����̃{�^���L��/������Ԃ��m�F
        button3_start = button3.IsVisible;
        button4_start = button4.IsVisible;
        button5_start = button5.IsVisible;
        button6_start = button6.IsVisible;

        button1.IsVisible = false;
        button2.IsVisible = false;
        button3.IsVisible = false;
        button4.IsVisible = false;
        button5.IsVisible = false;
        button6.IsVisible = false;
        textbox.IsVisible = false;
        textbox_out.IsVisible = false;
        re.IsEnabled = true;
        //image.Aspect = "AspectFit";
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
        //�t�@�C���ǂݍ��ݏ���
        button5.Text = "button5";
        textbox.Text = "Hello!";
        button6.IsVisible = true;
        game_ui.Title = "Game Title";
    }

    private void Button6_Clicked(object sender, EventArgs e)
    {
        //button6���N���b�N�����Ƃ��̏���
    }
}
