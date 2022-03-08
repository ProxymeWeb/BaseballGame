
namespace BaseBall
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labscore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.balle = new System.Windows.Forms.PictureBox();
            this.main = new System.Windows.Forms.PictureBox();
            this.decompte = new System.Windows.Forms.Label();
            this.EZbtn = new System.Windows.Forms.RadioButton();
            this.MDbtn = new System.Windows.Forms.RadioButton();
            this.HDbtn = new System.Windows.Forms.RadioButton();
            this.groupBoxDiff = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nbballe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main)).BeginInit();
            this.groupBoxDiff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // labscore
            // 
            this.labscore.AutoSize = true;
            this.labscore.Font = new System.Drawing.Font("Stencil", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labscore.Location = new System.Drawing.Point(259, 5);
            this.labscore.Name = "labscore";
            this.labscore.Size = new System.Drawing.Size(44, 47);
            this.labscore.TabIndex = 1;
            this.labscore.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "SCORE :";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(408, 545);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(248, 49);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnStart_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.balle);
            this.panel1.Controls.Add(this.main);
            this.panel1.Controls.Add(this.decompte);
            this.panel1.Location = new System.Drawing.Point(23, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 570);
            this.panel1.TabIndex = 5;
            // 
            // balle
            // 
            this.balle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("balle.BackgroundImage")));
            this.balle.Location = new System.Drawing.Point(175, 73);
            this.balle.Name = "balle";
            this.balle.Size = new System.Drawing.Size(10, 10);
            this.balle.TabIndex = 6;
            this.balle.TabStop = false;
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.main.Location = new System.Drawing.Point(146, 555);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(63, 202);
            this.main.TabIndex = 3;
            this.main.TabStop = false;
            // 
            // decompte
            // 
            this.decompte.AutoSize = true;
            this.decompte.BackColor = System.Drawing.Color.Transparent;
            this.decompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decompte.Location = new System.Drawing.Point(128, 178);
            this.decompte.Name = "decompte";
            this.decompte.Size = new System.Drawing.Size(3, 2);
            this.decompte.TabIndex = 5;
            this.decompte.Text = "3";
            // 
            // EZbtn
            // 
            this.EZbtn.AutoSize = true;
            this.EZbtn.Location = new System.Drawing.Point(13, 33);
            this.EZbtn.Name = "EZbtn";
            this.EZbtn.Size = new System.Drawing.Size(60, 17);
            this.EZbtn.TabIndex = 6;
            this.EZbtn.TabStop = true;
            this.EZbtn.Text = "Facile";
            this.EZbtn.UseVisualStyleBackColor = true;
            // 
            // MDbtn
            // 
            this.MDbtn.AutoSize = true;
            this.MDbtn.Checked = true;
            this.MDbtn.Location = new System.Drawing.Point(84, 34);
            this.MDbtn.Name = "MDbtn";
            this.MDbtn.Size = new System.Drawing.Size(61, 17);
            this.MDbtn.TabIndex = 7;
            this.MDbtn.TabStop = true;
            this.MDbtn.Text = "Moyen";
            this.MDbtn.UseVisualStyleBackColor = true;
            // 
            // HDbtn
            // 
            this.HDbtn.AutoSize = true;
            this.HDbtn.Location = new System.Drawing.Point(159, 35);
            this.HDbtn.Name = "HDbtn";
            this.HDbtn.Size = new System.Drawing.Size(74, 17);
            this.HDbtn.TabIndex = 8;
            this.HDbtn.TabStop = true;
            this.HDbtn.Text = "Difficile";
            this.HDbtn.UseVisualStyleBackColor = true;
            // 
            // groupBoxDiff
            // 
            this.groupBoxDiff.BackColor = System.Drawing.Color.Beige;
            this.groupBoxDiff.Controls.Add(this.EZbtn);
            this.groupBoxDiff.Controls.Add(this.HDbtn);
            this.groupBoxDiff.Controls.Add(this.MDbtn);
            this.groupBoxDiff.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDiff.Location = new System.Drawing.Point(408, 464);
            this.groupBoxDiff.Name = "groupBoxDiff";
            this.groupBoxDiff.Size = new System.Drawing.Size(248, 75);
            this.groupBoxDiff.TabIndex = 9;
            this.groupBoxDiff.TabStop = false;
            this.groupBoxDiff.Text = "Difficulté";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(409, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 290);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(408, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 155);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // nbballe
            // 
            this.nbballe.AutoSize = true;
            this.nbballe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nbballe.Font = new System.Drawing.Font("Stencil", 18.25F);
            this.nbballe.ForeColor = System.Drawing.Color.Black;
            this.nbballe.Location = new System.Drawing.Point(602, 133);
            this.nbballe.Margin = new System.Windows.Forms.Padding(0);
            this.nbballe.Name = "nbballe";
            this.nbballe.Padding = new System.Windows.Forms.Padding(0, 3, 0, 5);
            this.nbballe.Size = new System.Drawing.Size(41, 38);
            this.nbballe.TabIndex = 12;
            this.nbballe.Text = "10";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Beige;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Location = new System.Drawing.Point(408, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 573);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(102, 183);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 47);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(49, 236);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 47);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(154, 236);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 47);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gauche";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Droite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Renvoyer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 75);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bienvenue dans BaseBall le jeu ! \r\nPour marquer des points vous devez \r\nréception" +
    "ner la balle lancé par le batteur\r\net la renvoyer (avec Z) au lanceur.\r\n  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(674, 619);
            this.Controls.Add(this.labscore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbballe);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBoxDiff);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "BaseBall";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main)).EndInit();
            this.groupBoxDiff.ResumeLayout(false);
            this.groupBoxDiff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labscore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox main;
        private System.Windows.Forms.Label decompte;
        private System.Windows.Forms.PictureBox balle;
        private System.Windows.Forms.RadioButton EZbtn;
        private System.Windows.Forms.RadioButton MDbtn;
        private System.Windows.Forms.RadioButton HDbtn;
        private System.Windows.Forms.GroupBox groupBoxDiff;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nbballe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

