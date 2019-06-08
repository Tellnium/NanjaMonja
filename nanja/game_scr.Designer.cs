namespace nanja
{
    partial class game_scr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Game_scorre = new System.Windows.Forms.DataGridView();
            this.player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Game_scorre)).BeginInit();
            this.SuspendLayout();
            // 
            // Game_scorre
            // 
            this.Game_scorre.AllowUserToAddRows = false;
            this.Game_scorre.AllowUserToDeleteRows = false;
            this.Game_scorre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Game_scorre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.player,
            this.Score});
            this.Game_scorre.Location = new System.Drawing.Point(836, 12);
            this.Game_scorre.Name = "Game_scorre";
            this.Game_scorre.ReadOnly = true;
            this.Game_scorre.RowHeadersWidth = 82;
            this.Game_scorre.RowTemplate.Height = 33;
            this.Game_scorre.Size = new System.Drawing.Size(383, 692);
            this.Game_scorre.TabIndex = 0;
            this.Game_scorre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // player
            // 
            this.player.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.player.Frozen = true;
            this.player.HeaderText = "プレイヤー";
            this.player.MinimumWidth = 10;
            this.player.Name = "player";
            this.player.ReadOnly = true;
            this.player.Width = 148;
            // 
            // Score
            // 
            this.Score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Score.Frozen = true;
            this.Score.HeaderText = "枚数";
            this.Score.MinimumWidth = 10;
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 103;
            // 
            // game_scr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 716);
            this.Controls.Add(this.Game_scorre);
            this.Name = "game_scr";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Game_scr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Game_scorre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Game_scorre;
        private System.Windows.Forms.DataGridViewTextBoxColumn player;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}