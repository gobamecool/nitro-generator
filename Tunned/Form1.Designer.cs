
namespace Tunned
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.codes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPathFile = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TokenInput = new System.Windows.Forms.TextBox();
            this.SaveToken = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.results_output = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.WHSaved = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WHInput = new System.Windows.Forms.TextBox();
            this.SaveWH = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.panel1.Location = new System.Drawing.Point(-46, -14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 35);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.codes);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(24, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // codes
            // 
            this.codes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.codes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codes.Font = new System.Drawing.Font("ProggyCleanTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.codes.Location = new System.Drawing.Point(15, 44);
            this.codes.Name = "codes";
            this.codes.Size = new System.Drawing.Size(151, 16);
            this.codes.TabIndex = 3;
            this.codes.Text = "Number of codes";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(15, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Generate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ProggyCleanTT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tunned";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPathFile);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.ForeColor = System.Drawing.Color.Silver;
            this.groupBox2.Location = new System.Drawing.Point(24, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 144);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check";
            // 
            // txtPathFile
            // 
            this.txtPathFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtPathFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPathFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.txtPathFile.Location = new System.Drawing.Point(15, 44);
            this.txtPathFile.Name = "txtPathFile";
            this.txtPathFile.Size = new System.Drawing.Size(148, 16);
            this.txtPathFile.TabIndex = 4;
            this.txtPathFile.Text = "Path";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(15, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TokenInput);
            this.groupBox3.Controls.Add(this.SaveToken);
            this.groupBox3.ForeColor = System.Drawing.Color.Silver;
            this.groupBox3.Location = new System.Drawing.Point(239, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 143);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AutoClaim";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // TokenInput
            // 
            this.TokenInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TokenInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TokenInput.Font = new System.Drawing.Font("ProggyCleanTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TokenInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.TokenInput.Location = new System.Drawing.Point(15, 44);
            this.TokenInput.Name = "TokenInput";
            this.TokenInput.Size = new System.Drawing.Size(151, 16);
            this.TokenInput.TabIndex = 3;
            this.TokenInput.Text = "Token";
            // 
            // SaveToken
            // 
            this.SaveToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.SaveToken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveToken.FlatAppearance.BorderSize = 0;
            this.SaveToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SaveToken.Location = new System.Drawing.Point(15, 86);
            this.SaveToken.Name = "SaveToken";
            this.SaveToken.Size = new System.Drawing.Size(151, 23);
            this.SaveToken.TabIndex = 3;
            this.SaveToken.Text = "Save";
            this.SaveToken.UseVisualStyleBackColor = false;
            this.SaveToken.Click += new System.EventHandler(this.SaveToken_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.results_output);
            this.groupBox4.ForeColor = System.Drawing.Color.Silver;
            this.groupBox4.Location = new System.Drawing.Point(475, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 310);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Results";
            // 
            // results_output
            // 
            this.results_output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.results_output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.results_output.Location = new System.Drawing.Point(1, 15);
            this.results_output.Name = "results_output";
            this.results_output.Size = new System.Drawing.Size(327, 295);
            this.results_output.TabIndex = 0;
            this.results_output.Tag = "results_output";
            this.results_output.Text = "";
            this.results_output.TextChanged += new System.EventHandler(this.results_output_TextChanged);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("ProggyCleanTT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.button4.Location = new System.Drawing.Point(780, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("ProggyCleanTT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.button5.Location = new System.Drawing.Point(750, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 30);
            this.button5.TabIndex = 7;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.WHSaved);
            this.groupBox5.Controls.Add(this.panel2);
            this.groupBox5.Controls.Add(this.WHInput);
            this.groupBox5.Controls.Add(this.SaveWH);
            this.groupBox5.ForeColor = System.Drawing.Color.Silver;
            this.groupBox5.Location = new System.Drawing.Point(239, 258);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(192, 144);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "WebHook";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // WHSaved
            // 
            this.WHSaved.AutoSize = true;
            this.WHSaved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.WHSaved.Location = new System.Drawing.Point(18, 117);
            this.WHSaved.Name = "WHSaved";
            this.WHSaved.Size = new System.Drawing.Size(15, 16);
            this.WHSaved.TabIndex = 5;
            this.WHSaved.Text = " ";
            this.WHSaved.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Location = new System.Drawing.Point(-200, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 16);
            this.panel2.TabIndex = 4;
            // 
            // WHInput
            // 
            this.WHInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.WHInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WHInput.Font = new System.Drawing.Font("ProggyCleanTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WHInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.WHInput.Location = new System.Drawing.Point(15, 44);
            this.WHInput.Name = "WHInput";
            this.WHInput.Size = new System.Drawing.Size(151, 16);
            this.WHInput.TabIndex = 3;
            this.WHInput.Text = "URL";
            // 
            // SaveWH
            // 
            this.SaveWH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.SaveWH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveWH.FlatAppearance.BorderSize = 0;
            this.SaveWH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveWH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SaveWH.Location = new System.Drawing.Point(15, 86);
            this.SaveWH.Name = "SaveWH";
            this.SaveWH.Size = new System.Drawing.Size(151, 23);
            this.SaveWH.TabIndex = 3;
            this.SaveWH.Text = "Save";
            this.SaveWH.UseVisualStyleBackColor = false;
            this.SaveWH.Click += new System.EventHandler(this.SaveWH_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(827, 454);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("ProggyCleanTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox codes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TokenInput;
        private System.Windows.Forms.Button SaveToken;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox results_output;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox WHInput;
        private System.Windows.Forms.Button SaveWH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtPathFile;
        private System.Windows.Forms.Label WHSaved;
    }
}

