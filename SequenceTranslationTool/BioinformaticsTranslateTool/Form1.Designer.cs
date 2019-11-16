namespace BioinformaticsTranslateTool
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clear2 = new System.Windows.Forms.PictureBox();
            this.selection2 = new System.Windows.Forms.ComboBox();
            this.selection1 = new System.Windows.Forms.ComboBox();
            this.clear1 = new System.Windows.Forms.PictureBox();
            this.swap = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.translate = new System.Windows.Forms.PictureBox();
            this.sequence2 = new System.Windows.Forms.RichTextBox();
            this.sequence1 = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clear2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clear1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translate)).BeginInit();
            this.SuspendLayout();
            // 
            // clear2
            // 
            this.clear2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear2.Image = ((System.Drawing.Image)(resources.GetObject("clear2.Image")));
            this.clear2.Location = new System.Drawing.Point(728, 22);
            this.clear2.Name = "clear2";
            this.clear2.Size = new System.Drawing.Size(51, 44);
            this.clear2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clear2.TabIndex = 26;
            this.clear2.TabStop = false;
            this.toolTip1.SetToolTip(this.clear2, "Delete Sequence2");
            this.clear2.Click += new System.EventHandler(this.clear2_Click);
            // 
            // selection2
            // 
            this.selection2.BackColor = System.Drawing.Color.LightSlateGray;
            this.selection2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selection2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.selection2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selection2.ForeColor = System.Drawing.Color.White;
            this.selection2.FormattingEnabled = true;
            this.selection2.Items.AddRange(new object[] {
            "Amino Acid",
            "Protein",
            "DNA"});
            this.selection2.Location = new System.Drawing.Point(436, 32);
            this.selection2.Name = "selection2";
            this.selection2.Size = new System.Drawing.Size(212, 26);
            this.selection2.TabIndex = 25;
            // 
            // selection1
            // 
            this.selection1.BackColor = System.Drawing.Color.LightSlateGray;
            this.selection1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selection1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.selection1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selection1.ForeColor = System.Drawing.Color.White;
            this.selection1.FormattingEnabled = true;
            this.selection1.Items.AddRange(new object[] {
            "DNA",
            "Amino Acid"});
            this.selection1.Location = new System.Drawing.Point(14, 32);
            this.selection1.Name = "selection1";
            this.selection1.Size = new System.Drawing.Size(212, 26);
            this.selection1.TabIndex = 24;
            // 
            // clear1
            // 
            this.clear1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear1.Image = ((System.Drawing.Image)(resources.GetObject("clear1.Image")));
            this.clear1.Location = new System.Drawing.Point(289, 21);
            this.clear1.Name = "clear1";
            this.clear1.Size = new System.Drawing.Size(51, 45);
            this.clear1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clear1.TabIndex = 23;
            this.clear1.TabStop = false;
            this.toolTip1.SetToolTip(this.clear1, "Delete Sequence1");
            this.clear1.Click += new System.EventHandler(this.clear1_Click);
            // 
            // swap
            // 
            this.swap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swap.Image = ((System.Drawing.Image)(resources.GetObject("swap.Image")));
            this.swap.Location = new System.Drawing.Point(346, 197);
            this.swap.Name = "swap";
            this.swap.Size = new System.Drawing.Size(84, 74);
            this.swap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.swap.TabIndex = 22;
            this.swap.TabStop = false;
            this.toolTip1.SetToolTip(this.swap, "Swap Sequences");
            this.swap.Click += new System.EventHandler(this.swap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(432, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Please enter a sequence";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Please enter a sequence";
            // 
            // translate
            // 
            this.translate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.translate.Image = ((System.Drawing.Image)(resources.GetObject("translate.Image")));
            this.translate.Location = new System.Drawing.Point(346, 95);
            this.translate.Name = "translate";
            this.translate.Size = new System.Drawing.Size(84, 74);
            this.translate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.translate.TabIndex = 19;
            this.translate.TabStop = false;
            this.toolTip1.SetToolTip(this.translate, "Translate");
            this.translate.Click += new System.EventHandler(this.translate_Click);
            // 
            // sequence2
            // 
            this.sequence2.BackColor = System.Drawing.Color.LightSlateGray;
            this.sequence2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sequence2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sequence2.ForeColor = System.Drawing.Color.White;
            this.sequence2.Location = new System.Drawing.Point(436, 72);
            this.sequence2.Name = "sequence2";
            this.sequence2.ReadOnly = true;
            this.sequence2.Size = new System.Drawing.Size(343, 234);
            this.sequence2.TabIndex = 18;
            this.sequence2.Text = "";
            // 
            // sequence1
            // 
            this.sequence1.BackColor = System.Drawing.Color.LightSlateGray;
            this.sequence1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sequence1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sequence1.ForeColor = System.Drawing.Color.White;
            this.sequence1.Location = new System.Drawing.Point(14, 72);
            this.sequence1.Name = "sequence1";
            this.sequence1.Size = new System.Drawing.Size(326, 234);
            this.sequence1.TabIndex = 17;
            this.sequence1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(790, 325);
            this.Controls.Add(this.clear2);
            this.Controls.Add(this.selection2);
            this.Controls.Add(this.selection1);
            this.Controls.Add(this.clear1);
            this.Controls.Add(this.swap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.translate);
            this.Controls.Add(this.sequence2);
            this.Controls.Add(this.sequence1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translate Tool";
            ((System.ComponentModel.ISupportInitialize)(this.clear2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clear1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox clear2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox selection2;
        private System.Windows.Forms.ComboBox selection1;
        private System.Windows.Forms.PictureBox clear1;
        private System.Windows.Forms.PictureBox swap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox translate;
        private System.Windows.Forms.RichTextBox sequence2;
        private System.Windows.Forms.RichTextBox sequence1;
    }
}

