namespace SequenceAlignmentTool
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
            this.startAlgorithm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.match = new System.Windows.Forms.TextBox();
            this.mismatch = new System.Windows.Forms.TextBox();
            this.gapPenalty = new System.Windows.Forms.TextBox();
            this.sequence2 = new System.Windows.Forms.TextBox();
            this.sequence1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SW = new System.Windows.Forms.RadioButton();
            this.NW = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.seq1res = new System.Windows.Forms.TextBox();
            this.seq2res = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startAlgorithm
            // 
            this.startAlgorithm.BackColor = System.Drawing.SystemColors.Control;
            this.startAlgorithm.FlatAppearance.BorderSize = 0;
            this.startAlgorithm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startAlgorithm.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startAlgorithm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.startAlgorithm.Location = new System.Drawing.Point(275, 87);
            this.startAlgorithm.Name = "startAlgorithm";
            this.startAlgorithm.Size = new System.Drawing.Size(228, 90);
            this.startAlgorithm.TabIndex = 0;
            this.startAlgorithm.Text = "Start Algorithm";
            this.startAlgorithm.UseVisualStyleBackColor = false;
            this.startAlgorithm.Click += new System.EventHandler(this.startAlgorithm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Match";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mismatch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gap Penalty";
            // 
            // match
            // 
            this.match.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.match.Location = new System.Drawing.Point(154, 84);
            this.match.Name = "match";
            this.match.Size = new System.Drawing.Size(100, 27);
            this.match.TabIndex = 5;
            // 
            // mismatch
            // 
            this.mismatch.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mismatch.Location = new System.Drawing.Point(154, 117);
            this.mismatch.Name = "mismatch";
            this.mismatch.Size = new System.Drawing.Size(100, 27);
            this.mismatch.TabIndex = 6;
            // 
            // gapPenalty
            // 
            this.gapPenalty.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gapPenalty.Location = new System.Drawing.Point(154, 150);
            this.gapPenalty.Name = "gapPenalty";
            this.gapPenalty.Size = new System.Drawing.Size(100, 27);
            this.gapPenalty.TabIndex = 7;
            // 
            // sequence2
            // 
            this.sequence2.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sequence2.Location = new System.Drawing.Point(154, 51);
            this.sequence2.Name = "sequence2";
            this.sequence2.Size = new System.Drawing.Size(349, 27);
            this.sequence2.TabIndex = 11;
            // 
            // sequence1
            // 
            this.sequence1.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sequence1.Location = new System.Drawing.Point(154, 18);
            this.sequence1.Name = "sequence1";
            this.sequence1.Size = new System.Drawing.Size(349, 27);
            this.sequence1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sequence 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sequence 1";
            // 
            // SW
            // 
            this.SW.AutoSize = true;
            this.SW.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SW.ForeColor = System.Drawing.SystemColors.Control;
            this.SW.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SW.Location = new System.Drawing.Point(12, 198);
            this.SW.Name = "SW";
            this.SW.Size = new System.Drawing.Size(237, 23);
            this.SW.TabIndex = 12;
            this.SW.TabStop = true;
            this.SW.Text = "Smith-Waterman(Local)";
            this.SW.UseVisualStyleBackColor = true;
            // 
            // NW
            // 
            this.NW.AutoSize = true;
            this.NW.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NW.ForeColor = System.Drawing.Color.White;
            this.NW.Location = new System.Drawing.Point(255, 198);
            this.NW.Name = "NW";
            this.NW.Size = new System.Drawing.Size(267, 23);
            this.NW.TabIndex = 13;
            this.NW.TabStop = true;
            this.NW.Text = "Needleman-Wunsch(Global)";
            this.NW.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(12, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Result";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score.ForeColor = System.Drawing.SystemColors.Control;
            this.score.Location = new System.Drawing.Point(149, 378);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(0, 25);
            this.score.TabIndex = 16;
            // 
            // seq1res
            // 
            this.seq1res.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seq1res.Location = new System.Drawing.Point(154, 292);
            this.seq1res.Name = "seq1res";
            this.seq1res.ReadOnly = true;
            this.seq1res.Size = new System.Drawing.Size(349, 27);
            this.seq1res.TabIndex = 17;
            // 
            // seq2res
            // 
            this.seq2res.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seq2res.Location = new System.Drawing.Point(154, 337);
            this.seq2res.Name = "seq2res";
            this.seq2res.ReadOnly = true;
            this.seq2res.Size = new System.Drawing.Size(349, 27);
            this.seq2res.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Seq2: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(12, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Seq1: ";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(522, 241);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.seq2res);
            this.Controls.Add(this.seq1res);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NW);
            this.Controls.Add(this.SW);
            this.Controls.Add(this.sequence2);
            this.Controls.Add(this.sequence1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gapPenalty);
            this.Controls.Add(this.mismatch);
            this.Controls.Add(this.match);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startAlgorithm);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(538, 460);
            this.MinimumSize = new System.Drawing.Size(538, 280);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startAlgorithm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox match;
        private System.Windows.Forms.TextBox mismatch;
        private System.Windows.Forms.TextBox gapPenalty;
        private System.Windows.Forms.TextBox sequence2;
        private System.Windows.Forms.TextBox sequence1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton SW;
        private System.Windows.Forms.RadioButton NW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.TextBox seq1res;
        private System.Windows.Forms.TextBox seq2res;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}

