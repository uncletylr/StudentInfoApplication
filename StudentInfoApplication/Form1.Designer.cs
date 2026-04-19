using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace StudentInfoApplication
{
    partial class FrmInfoStudent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfoStudent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.EXIT_BTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDTXT = new System.Windows.Forms.TextBox();
            this.FIRSTNAMETXT = new System.Windows.Forms.TextBox();
            this.LASTNAMETXT = new System.Windows.Forms.TextBox();
            this.SUBMIT_BTN = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.CLEAR_BTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.EXIT_BTN);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 485);
            this.panel1.TabIndex = 0;
            // 
            // EXIT_BTN
            // 
            this.EXIT_BTN.Font = new System.Drawing.Font("Georgia", 12F);
            this.EXIT_BTN.ForeColor = System.Drawing.Color.Black;
            this.EXIT_BTN.Location = new System.Drawing.Point(39, 445);
            this.EXIT_BTN.Name = "EXIT_BTN";
            this.EXIT_BTN.Size = new System.Drawing.Size(97, 30);
            this.EXIT_BTN.TabIndex = 14;
            this.EXIT_BTN.Text = "EXIT";
            this.EXIT_BTN.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(39, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 92);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(187)))));
            this.label1.Location = new System.Drawing.Point(194, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "STUDENT ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(187)))));
            this.label2.Location = new System.Drawing.Point(402, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "FIRST NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(187)))));
            this.label3.Location = new System.Drawing.Point(610, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "LAST NAME";
            // 
            // IDTXT
            // 
            this.IDTXT.Location = new System.Drawing.Point(194, 52);
            this.IDTXT.Name = "IDTXT";
            this.IDTXT.Size = new System.Drawing.Size(161, 20);
            this.IDTXT.TabIndex = 4;
            // 
            // FIRSTNAMETXT
            // 
            this.FIRSTNAMETXT.Location = new System.Drawing.Point(402, 52);
            this.FIRSTNAMETXT.Name = "FIRSTNAMETXT";
            this.FIRSTNAMETXT.Size = new System.Drawing.Size(173, 20);
            this.FIRSTNAMETXT.TabIndex = 5;
            // 
            // LASTNAMETXT
            // 
            this.LASTNAMETXT.Location = new System.Drawing.Point(610, 52);
            this.LASTNAMETXT.Name = "LASTNAMETXT";
            this.LASTNAMETXT.Size = new System.Drawing.Size(173, 20);
            this.LASTNAMETXT.TabIndex = 6;
            // 
            // SUBMIT_BTN
            // 
            this.SUBMIT_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.SUBMIT_BTN.Font = new System.Drawing.Font("Georgia", 12F);
            this.SUBMIT_BTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(187)))));
            this.SUBMIT_BTN.Location = new System.Drawing.Point(686, 389);
            this.SUBMIT_BTN.Name = "SUBMIT_BTN";
            this.SUBMIT_BTN.Size = new System.Drawing.Size(97, 30);
            this.SUBMIT_BTN.TabIndex = 7;
            this.SUBMIT_BTN.Text = "SUBMIT";
            this.SUBMIT_BTN.UseVisualStyleBackColor = false;
            this.SUBMIT_BTN.Click += new System.EventHandler(this.SUBMIT_BTN_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(194, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(161, 264);
            this.listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(402, 93);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(173, 264);
            this.listBox2.TabIndex = 9;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(608, 93);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(173, 264);
            this.listBox3.TabIndex = 10;
            // 
            // CLEAR_BTN
            // 
            this.CLEAR_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.CLEAR_BTN.Font = new System.Drawing.Font("Georgia", 12F);
            this.CLEAR_BTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(164)))), ((int)(((byte)(187)))));
            this.CLEAR_BTN.Location = new System.Drawing.Point(686, 434);
            this.CLEAR_BTN.Name = "CLEAR_BTN";
            this.CLEAR_BTN.Size = new System.Drawing.Size(97, 30);
            this.CLEAR_BTN.TabIndex = 11;
            this.CLEAR_BTN.Text = "CLEAR";
            this.CLEAR_BTN.UseVisualStyleBackColor = false;
            // 
            // FrmInfoStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(793, 485);
            this.Controls.Add(this.CLEAR_BTN);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SUBMIT_BTN);
            this.Controls.Add(this.LASTNAMETXT);
            this.Controls.Add(this.FIRSTNAMETXT);
            this.Controls.Add(this.IDTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmInfoStudent";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox IDTXT;
        private TextBox FIRSTNAMETXT;
        private TextBox LASTNAMETXT;
        private Button SUBMIT_BTN;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Button EXIT_BTN;
        private Button CLEAR_BTN;
    }
}