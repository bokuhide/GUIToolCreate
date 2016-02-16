using System.Collections.Generic;

namespace 構成マップ見た目
{
    partial class EditorForm
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
            this.imageComboBox = new System.Windows.Forms.ComboBox();
            this.networkComboBox = new System.Windows.Forms.ComboBox();
            this.flavorComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // imageComboBox
            // 
            this.imageComboBox.FormattingEnabled = true;
            this.imageComboBox.Items.AddRange(new object[] {
            "centos-test",
            "cirros-0.3.3-i386",
            "cirros-0.3.3-x86_64"});
            this.imageComboBox.Location = new System.Drawing.Point(173, 164);
            this.imageComboBox.Name = "comboBox2";
            this.imageComboBox.Size = new System.Drawing.Size(121, 20);
            this.imageComboBox.TabIndex = 8;
            // 
            // networkComboBox
            // 
            this.networkComboBox.FormattingEnabled = true;
            if (MapForm.count == 0) {
                this.networkComboBox.Items.AddRange(new object[] {
                "demo-net1"});
            }
            else if (MapForm.count == 1)
            {
                this.networkComboBox.Items.AddRange(new object[] {
                "demo-net1",
                "demo-net2"});
            }
            else if (MapForm.count == 2)
            {
                this.networkComboBox.Items.AddRange(new object[] {
                "demo-net1",
                "demo-net2",
                "demo-net3"});
            }
            this.networkComboBox.Location = new System.Drawing.Point(173, 214);
            this.networkComboBox.Name = "comboBox3";
            this.networkComboBox.Size = new System.Drawing.Size(121, 20);
            this.networkComboBox.TabIndex = 9;
            // 
            // flavorComboBox
            // 
            this.flavorComboBox.FormattingEnabled = true;
            this.flavorComboBox.Items.AddRange(new object[] {
            "m1.small",
            "m1.medium",
            "m1.large"});
            this.flavorComboBox.Location = new System.Drawing.Point(173, 189);
            this.flavorComboBox.Name = "comboBox4";
            this.flavorComboBox.Size = new System.Drawing.Size(121, 20);
            this.flavorComboBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "決定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "リソース";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(64, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "インスタンス設定";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "インスタンス名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "ディスクイメージ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "フレーバー";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "接続先";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 19);
            this.textBox1.TabIndex = 11;
            // 
            // EditorForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(636, 440);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flavorComboBox);
            this.Controls.Add(this.networkComboBox);
            this.Controls.Add(this.imageComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "EditorForm";
            this.Text = "詳細設定画面";
            this.Load += new System.EventHandler(this.EditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox imageComboBox;
        private System.Windows.Forms.ComboBox networkComboBox;
        private System.Windows.Forms.ComboBox flavorComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private MapForm mapForm;
        private List<string> edit_data;

        public EditorForm(MapForm mapForm)
        {
            this.mapForm = mapForm;
        }

        public EditorForm(MapForm mapForm, List<string> edit_data) : this(mapForm)
        {
            this.edit_data = edit_data;
        }
    }
}