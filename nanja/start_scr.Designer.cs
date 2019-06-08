namespace nanja
{
    partial class start_scr
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button Start_button;
            this.Member_List = new System.Windows.Forms.CheckedListBox();
            this.Add_menber_button = new System.Windows.Forms.Button();
            this.Member_name_text = new System.Windows.Forms.TextBox();
            this.Remove_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FilepathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Filepath_text = new System.Windows.Forms.TextBox();
            this.Filepath_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.card_num_text = new System.Windows.Forms.TextBox();
            Start_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start_button
            // 
            Start_button.Location = new System.Drawing.Point(512, 464);
            Start_button.Margin = new System.Windows.Forms.Padding(2);
            Start_button.Name = "Start_button";
            Start_button.Size = new System.Drawing.Size(179, 51);
            Start_button.TabIndex = 2;
            Start_button.Text = "Start";
            Start_button.UseVisualStyleBackColor = true;
            Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Member_List
            // 
            this.Member_List.FormattingEnabled = true;
            this.Member_List.Location = new System.Drawing.Point(512, 42);
            this.Member_List.Margin = new System.Windows.Forms.Padding(2);
            this.Member_List.Name = "Member_List";
            this.Member_List.Size = new System.Drawing.Size(192, 334);
            this.Member_List.TabIndex = 0;
            // 
            // Add_menber_button
            // 
            this.Add_menber_button.Location = new System.Drawing.Point(390, 57);
            this.Add_menber_button.Margin = new System.Windows.Forms.Padding(2);
            this.Add_menber_button.Name = "Add_menber_button";
            this.Add_menber_button.Size = new System.Drawing.Size(75, 30);
            this.Add_menber_button.TabIndex = 1;
            this.Add_menber_button.Text = "追加";
            this.Add_menber_button.UseVisualStyleBackColor = true;
            this.Add_menber_button.Click += new System.EventHandler(this.Add_menber_button_Click);
            // 
            // Member_name_text
            // 
            this.Member_name_text.Location = new System.Drawing.Point(89, 58);
            this.Member_name_text.Margin = new System.Windows.Forms.Padding(2);
            this.Member_name_text.Name = "Member_name_text";
            this.Member_name_text.Size = new System.Drawing.Size(281, 25);
            this.Member_name_text.TabIndex = 3;
            this.Member_name_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Member_name_text_KeyPress);
            this.Member_name_text.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Member_name_text_PreviewKeyDown);
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(517, 394);
            this.Remove_button.Margin = new System.Windows.Forms.Padding(2);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(187, 30);
            this.Remove_button.TabIndex = 4;
            this.Remove_button.Text = "消去";
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "名前";
            // 
            // Filepath_text
            // 
            this.Filepath_text.Location = new System.Drawing.Point(89, 160);
            this.Filepath_text.Name = "Filepath_text";
            this.Filepath_text.Size = new System.Drawing.Size(281, 25);
            this.Filepath_text.TabIndex = 7;
            // 
            // Filepath_Button
            // 
            this.Filepath_Button.Location = new System.Drawing.Point(390, 157);
            this.Filepath_Button.Name = "Filepath_Button";
            this.Filepath_Button.Size = new System.Drawing.Size(75, 30);
            this.Filepath_Button.TabIndex = 8;
            this.Filepath_Button.Text = "参照";
            this.Filepath_Button.UseVisualStyleBackColor = true;
            this.Filepath_Button.Click += new System.EventHandler(this.Filepath_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "ファイル";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "同じカードの枚数";
            // 
            // card_num_text
            // 
            this.card_num_text.Location = new System.Drawing.Point(212, 287);
            this.card_num_text.Name = "card_num_text";
            this.card_num_text.Size = new System.Drawing.Size(158, 25);
            this.card_num_text.TabIndex = 11;
            this.card_num_text.Text = "8";
            this.card_num_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // start_scr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 534);
            this.Controls.Add(this.card_num_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Filepath_Button);
            this.Controls.Add(this.Filepath_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.Member_name_text);
            this.Controls.Add(Start_button);
            this.Controls.Add(this.Add_menber_button);
            this.Controls.Add(this.Member_List);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "start_scr";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Start_scr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add_menber_button;
        private System.Windows.Forms.TextBox Member_name_text;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox Member_List;
        private System.Windows.Forms.FolderBrowserDialog FilepathDialog;
        private System.Windows.Forms.TextBox Filepath_text;
        private System.Windows.Forms.Button Filepath_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox card_num_text;
    }
}

