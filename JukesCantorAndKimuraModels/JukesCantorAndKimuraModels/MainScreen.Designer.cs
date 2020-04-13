namespace JukesCantorAndKimuraModels
{
    partial class MainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sequnce1 = new System.Windows.Forms.TextBox();
            this.sequence2 = new System.Windows.Forms.TextBox();
            this.jukescantor = new System.Windows.Forms.CheckBox();
            this.kimura = new System.Windows.Forms.CheckBox();
            this.calculate = new System.Windows.Forms.Button();
            this.res1label = new System.Windows.Forms.Label();
            this.res2label = new System.Windows.Forms.Label();
            this.res1textbox = new System.Windows.Forms.TextBox();
            this.res2textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sequence1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sequence2";
            // 
            // sequnce1
            // 
            this.sequnce1.Location = new System.Drawing.Point(98, 23);
            this.sequnce1.Name = "sequnce1";
            this.sequnce1.Size = new System.Drawing.Size(280, 20);
            this.sequnce1.TabIndex = 2;
            // 
            // sequence2
            // 
            this.sequence2.Location = new System.Drawing.Point(98, 82);
            this.sequence2.Name = "sequence2";
            this.sequence2.Size = new System.Drawing.Size(280, 20);
            this.sequence2.TabIndex = 3;
            // 
            // jukescantor
            // 
            this.jukescantor.AutoSize = true;
            this.jukescantor.Location = new System.Drawing.Point(72, 139);
            this.jukescantor.Name = "jukescantor";
            this.jukescantor.Size = new System.Drawing.Size(88, 17);
            this.jukescantor.TabIndex = 4;
            this.jukescantor.Text = "Jukes-Cantor";
            this.jukescantor.UseVisualStyleBackColor = true;
            // 
            // kimura
            // 
            this.kimura.AutoSize = true;
            this.kimura.Location = new System.Drawing.Point(245, 139);
            this.kimura.Name = "kimura";
            this.kimura.Size = new System.Drawing.Size(58, 17);
            this.kimura.TabIndex = 5;
            this.kimura.Text = "Kimura";
            this.kimura.UseVisualStyleBackColor = true;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(12, 175);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(366, 48);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "Calculate Distance";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // res1label
            // 
            this.res1label.AutoSize = true;
            this.res1label.Location = new System.Drawing.Point(10, 241);
            this.res1label.Name = "res1label";
            this.res1label.Size = new System.Drawing.Size(43, 13);
            this.res1label.TabIndex = 7;
            this.res1label.Text = "Result1";
            this.res1label.Visible = false;
            // 
            // res2label
            // 
            this.res2label.AutoSize = true;
            this.res2label.Location = new System.Drawing.Point(9, 276);
            this.res2label.Name = "res2label";
            this.res2label.Size = new System.Drawing.Size(43, 13);
            this.res2label.TabIndex = 8;
            this.res2label.Text = "Result2";
            this.res2label.Visible = false;
            // 
            // res1textbox
            // 
            this.res1textbox.Location = new System.Drawing.Point(133, 238);
            this.res1textbox.Name = "res1textbox";
            this.res1textbox.ReadOnly = true;
            this.res1textbox.Size = new System.Drawing.Size(246, 20);
            this.res1textbox.TabIndex = 11;
            this.res1textbox.Visible = false;
            // 
            // res2textbox
            // 
            this.res2textbox.Location = new System.Drawing.Point(133, 272);
            this.res2textbox.Name = "res2textbox";
            this.res2textbox.ReadOnly = true;
            this.res2textbox.Size = new System.Drawing.Size(246, 20);
            this.res2textbox.TabIndex = 12;
            this.res2textbox.Visible = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 233);
            this.Controls.Add(this.res2textbox);
            this.Controls.Add(this.res1textbox);
            this.Controls.Add(this.res2label);
            this.Controls.Add(this.res1label);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.kimura);
            this.Controls.Add(this.jukescantor);
            this.Controls.Add(this.sequence2);
            this.Controls.Add(this.sequnce1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(414, 340);
            this.MinimumSize = new System.Drawing.Size(414, 272);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sequnce1;
        private System.Windows.Forms.TextBox sequence2;
        private System.Windows.Forms.CheckBox jukescantor;
        private System.Windows.Forms.CheckBox kimura;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label res1label;
        private System.Windows.Forms.Label res2label;
        private System.Windows.Forms.TextBox res1textbox;
        private System.Windows.Forms.TextBox res2textbox;
    }
}

