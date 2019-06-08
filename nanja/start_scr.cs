using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace nanja
{
    public partial class start_scr : Form
    {
        public start_scr()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        //「追加」ボタンクリック
        private void Add_menber_button_Click(object sender, EventArgs e)
        {
            if (Member_name_text.Text is "")
            {
                MessageBox.Show("名前を入力してください");
            }
            else
            {
                Member_List.Items.Add(Member_name_text.Text, true);
            }
            Member_name_text.Clear();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Start_scr_Load(object sender, EventArgs e)
        {
            
        }

        //スタートボタンクリック
        private void Start_button_Click(object sender, EventArgs e)
        {
            var member = new List<string>();
            //チェックボックスからメンバ取得
            foreach (string person in Member_List.CheckedItems)
            {
                member.Add(person);
            }

            var setting = new GameSetting();

            setting.card_num = int.Parse(card_num_text.Text);   //カード枚数
            setting.m_Player = member;                            //プレイヤー List<string>
            setting.FilePath = Filepath_text.Text;              //ファイルパス

            var game_Scr = new game_scr();

            game_Scr.SetSetting(setting);
            game_Scr.ShowDialog(this);
        }

        public object GetCheckBox ()
        {
           
            return Member_List;
        }

        private void Member_name_text_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)

                Add_menber_button_Click(sender,e);
        }

        private void Member_name_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void Filepath_Button_Click(object sender, EventArgs e)
        {
            FilepathDialog.ShowDialog();
            Filepath_text.Text = FilepathDialog.SelectedPath;
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {


            foreach (string rem in Member_List.Items.Count.ToString())
            {
                int index = int.Parse(rem);
                if (Member_List.GetItemChecked(index))
                {
                    break;
                }
                else
                {
                    Member_List.Items.Remove(rem);
                    Remove_button_Click(sender, e);
                    break;
                }
            }
        }
    }
}
