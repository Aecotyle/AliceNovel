namespace Alice_Novel;

public partial class GamePage : ContentPage
{
	public GamePage()
	{
		InitializeComponent();
	}

    //������Ԃ̃{�^���L��/�����̊m�F�p(null�G���[�΍�̂��߂ɏ����l��false�ɐݒ�)
    bool button1_start, button2_start, button3_start, button4_start, button5_start, button6_start = false;
    //UI�\��/��\��
    bool ui_visible = true;

    private void ReShow_Clicked(object sender, EventArgs e)
    {
        //��ʂ��N���b�N�����Ƃ��̏���
        if (ui_visible == true)
        {
            //�e�L�X�g��i�߂鏈��
            talkname.Text = ".NET";
            if (textbox.Text == "Next...")
                textbox.Text = "Text";
            else
                textbox.Text = "Next...";

        }
        else
        {
            //UI�ĕ\������
            talkname.IsVisible = true;
            textbox.IsVisible = true;
            textbox_out.IsVisible = true;
            //�����l�ɐݒ�(�����ŕ\������Ă�����\���A�����łȂ��������\��)
            button1.IsVisible = button1_start;
            button2.IsVisible = button2_start;
            button3.IsVisible = button3_start;
            button4.IsVisible = button4_start;
            button5.IsVisible = button5_start;
            button6.IsVisible = button6_start;
            ui_visible = true;
        }
    }

    private void Button1_Clicked(object sender, EventArgs e)
    {
        //button1���N���b�N�����Ƃ��̏���
    }

    private void Button2_Clicked(object sender, EventArgs e)
    {
        //button2���N���b�N�����Ƃ��̏���

        //�����̃{�^���L��/������Ԃ��m�F
        button1_start = button1.IsVisible;
        button2_start = button2.IsVisible;
        button3_start = button3.IsVisible;
        button4_start = button4.IsVisible;
        button5_start = button5.IsVisible;
        button6_start = button6.IsVisible;
        //�摜�ȊO���ׂĔ�\��
        button1.IsVisible = false;
        button2.IsVisible = false;
        button3.IsVisible = false;
        button4.IsVisible = false;
        button5.IsVisible = false;
        button6.IsVisible = false;
        talkname.IsVisible = false;
        textbox.IsVisible = false;
        textbox_out.IsVisible = false;
        ui_visible = false;
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
        talkname.Text = ".NET";
        textbox.Text = "�悤����!";
        button5.IsVisible = false;
        //button6.IsVisible = true;
        game_ui.Title = "Game Title";
    }

    private void Button6_Clicked(object sender, EventArgs e)
    {
        //button6���N���b�N�����Ƃ��̏���
    }
}
