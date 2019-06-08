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
    public partial class game_scr : Form
    {
         GameSetting m_setting { get; set; }

        public game_scr()
        {
            InitializeComponent();

        }

        public void SetSetting(object set)

        {
            m_setting = set as GameSetting;
        }
        
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Game_scr_Load(object sender, EventArgs e)
        {
                                    
            Game_scorre.Rows.Add();
        }
    }
}
