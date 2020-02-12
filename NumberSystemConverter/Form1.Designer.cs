namespace NumberSystemConverter
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_from = new System.Windows.Forms.Label();
            this.btn_convert = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label_to = new System.Windows.Forms.Label();
            this.label_input = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_output = new System.Windows.Forms.ComboBox();
            this.comboBox_input = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ascii_reminder = new System.Windows.Forms.Label();
            this.label_output = new System.Windows.Forms.Label();
            this.txt_output = new System.Windows.Forms.RichTextBox();
            this.txt_input = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Location = new System.Drawing.Point(3, 23);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(60, 23);
            this.label_from.TabIndex = 0;
            this.label_from.Text = "From:";
            // 
            // btn_convert
            // 
            this.btn_convert.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (169)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))));
            this.btn_convert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (169)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.btn_convert.FlatAppearance.BorderSize = 0;
            this.btn_convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_convert.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_convert.ForeColor = System.Drawing.Color.White;
            this.btn_convert.Location = new System.Drawing.Point(649, -1);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(126, 33);
            this.btn_convert.TabIndex = 1;
            this.btn_convert.Text = "CONVERT";
            this.btn_convert.UseVisualStyleBackColor = false;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.ForeColor = System.Drawing.Color.White;
            this.label_to.Location = new System.Drawing.Point(242, 23);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(36, 23);
            this.label_to.TabIndex = 2;
            this.label_to.Text = "To:";
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Location = new System.Drawing.Point(-4, 3);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(79, 23);
            this.label_input.TabIndex = 3;
            this.label_input.Text = "Decimal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_output);
            this.panel1.Controls.Add(this.comboBox_input);
            this.panel1.Controls.Add(this.label_from);
            this.panel1.Controls.Add(this.label_to);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 71);
            this.panel1.TabIndex = 4;
            // 
            // comboBox_output
            // 
            this.comboBox_output.BackColor = System.Drawing.Color.White;
            this.comboBox_output.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_output.Font = new System.Drawing.Font("Roboto Condensed", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_output.FormattingEnabled = true;
            this.comboBox_output.Items.AddRange(new object[] {"Decimal", "ASCII", "Binary", "Hex"});
            this.comboBox_output.Location = new System.Drawing.Point(284, 23);
            this.comboBox_output.Name = "comboBox_output";
            this.comboBox_output.Size = new System.Drawing.Size(121, 27);
            this.comboBox_output.TabIndex = 8;
            this.comboBox_output.SelectedIndexChanged +=
                new System.EventHandler(this.ComboBox_output_SelectedIndexChanged);
            // 
            // comboBox_input
            // 
            this.comboBox_input.BackColor = System.Drawing.Color.White;
            this.comboBox_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_input.Font = new System.Drawing.Font("Roboto Condensed", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_input.FormattingEnabled = true;
            this.comboBox_input.Items.AddRange(new object[] {"Decimal", "ASCII", "Binary", "Hex"});
            this.comboBox_input.Location = new System.Drawing.Point(69, 23);
            this.comboBox_input.Name = "comboBox_input";
            this.comboBox_input.Size = new System.Drawing.Size(121, 27);
            this.comboBox_input.TabIndex = 7;
            this.comboBox_input.SelectedIndexChanged +=
                new System.EventHandler(this.ComboBox_input_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ascii_reminder);
            this.panel2.Controls.Add(this.label_output);
            this.panel2.Controls.Add(this.txt_output);
            this.panel2.Controls.Add(this.txt_input);
            this.panel2.Controls.Add(this.label_input);
            this.panel2.Location = new System.Drawing.Point(12, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 309);
            this.panel2.TabIndex = 5;
            // 
            // ascii_reminder
            // 
            this.ascii_reminder.AutoSize = true;
            this.ascii_reminder.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ascii_reminder.Location = new System.Drawing.Point(81, 7);
            this.ascii_reminder.Name = "ascii_reminder";
            this.ascii_reminder.Size = new System.Drawing.Size(312, 18);
            this.ascii_reminder.TabIndex = 8;
            this.ascii_reminder.Text = "(Remember to set a \'0\' in front of the number)";
            this.ascii_reminder.Visible = false;
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(-4, 156);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(62, 23);
            this.label_output.TabIndex = 7;
            this.label_output.Text = "Binary";
            // 
            // txt_output
            // 
            this.txt_output.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (62)))), ((int) (((byte) (62)))),
                ((int) (((byte) (62)))));
            this.txt_output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_output.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_output.ForeColor = System.Drawing.Color.White;
            this.txt_output.Location = new System.Drawing.Point(1, 182);
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(772, 111);
            this.txt_output.TabIndex = 6;
            this.txt_output.Text = "";
            // 
            // txt_input
            // 
            this.txt_input.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (62)))), ((int) (((byte) (62)))),
                ((int) (((byte) (62)))));
            this.txt_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_input.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_input.ForeColor = System.Drawing.Color.White;
            this.txt_input.Location = new System.Drawing.Point(0, 29);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(772, 111);
            this.txt_input.TabIndex = 5;
            this.txt_input.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_copy);
            this.panel3.Controls.Add(this.btn_clear);
            this.panel3.Controls.Add(this.btn_convert);
            this.panel3.Location = new System.Drawing.Point(13, 406);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 32);
            this.panel3.TabIndex = 6;
            // 
            // btn_copy
            // 
            this.btn_copy.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (169)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))));
            this.btn_copy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (169)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.btn_copy.FlatAppearance.BorderSize = 0;
            this.btn_copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_copy.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.btn_copy.Location = new System.Drawing.Point(131, 0);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(126, 33);
            this.btn_copy.TabIndex = 1;
            this.btn_copy.Text = "COPY";
            this.btn_copy.UseVisualStyleBackColor = false;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (169)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))));
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (169)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(-1, 0);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(126, 33);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (30)))),
                ((int) (((byte) (30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Number System Converter";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox txt_input;
        private System.Windows.Forms.RichTextBox txt_output;
        private System.Windows.Forms.ComboBox comboBox_input;
        private System.Windows.Forms.ComboBox comboBox_output;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label ascii_reminder;
        private System.Windows.Forms.Button btn_copy;
    }
}

