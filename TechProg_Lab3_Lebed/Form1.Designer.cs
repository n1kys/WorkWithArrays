namespace TechProg_Lab3_Lebed
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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            generationButton = new Button();
            openArray = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            median_rbutton = new RadioButton();
            evds_rbutton = new RadioButton();
            runButton = new Button();
            saveArrayToJson_button = new Button();
            saveOper_button = new Button();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label4 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(138, 30);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(138, 59);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(138, 88);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 2;
            // 
            // generationButton
            // 
            generationButton.Location = new Point(7, 119);
            generationButton.Name = "generationButton";
            generationButton.Size = new Size(119, 23);
            generationButton.TabIndex = 3;
            generationButton.Text = "Generation";
            generationButton.UseVisualStyleBackColor = true;
            generationButton.Click += generationButton_Click;
            // 
            // openArray
            // 
            openArray.Location = new Point(132, 119);
            openArray.Name = "openArray";
            openArray.Size = new Size(126, 23);
            openArray.TabIndex = 4;
            openArray.Text = "Open Array";
            openArray.UseVisualStyleBackColor = true;
            openArray.Click += openArray_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(232, 337);
            dataGridView1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(openArray);
            groupBox1.Controls.Add(numericUpDown3);
            groupBox1.Controls.Add(generationButton);
            groupBox1.Location = new Point(8, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 148);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 96);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 14;
            label3.Text = "Max value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 67);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 13;
            label2.Text = "Min value";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 38);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 12;
            label1.Text = "Size of array";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(median_rbutton);
            groupBox2.Controls.Add(evds_rbutton);
            groupBox2.Location = new Point(9, 182);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(264, 50);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operations";
            // 
            // median_rbutton
            // 
            median_rbutton.AutoSize = true;
            median_rbutton.Location = new Point(138, 25);
            median_rbutton.Name = "median_rbutton";
            median_rbutton.Size = new Size(65, 19);
            median_rbutton.TabIndex = 1;
            median_rbutton.TabStop = true;
            median_rbutton.Text = "Median";
            median_rbutton.UseVisualStyleBackColor = true;
            // 
            // evds_rbutton
            // 
            evds_rbutton.AutoSize = true;
            evds_rbutton.Location = new Point(6, 25);
            evds_rbutton.Name = "evds_rbutton";
            evds_rbutton.Size = new Size(98, 19);
            evds_rbutton.TabIndex = 0;
            evds_rbutton.TabStop = true;
            evds_rbutton.Text = "EV/Dispersion";
            evds_rbutton.UseVisualStyleBackColor = true;
            // 
            // runButton
            // 
            runButton.Location = new Point(6, 22);
            runButton.Name = "runButton";
            runButton.Size = new Size(119, 23);
            runButton.TabIndex = 8;
            runButton.Text = "Run";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += runButton_Click;
            // 
            // saveArrayToJson_button
            // 
            saveArrayToJson_button.Location = new Point(131, 22);
            saveArrayToJson_button.Name = "saveArrayToJson_button";
            saveArrayToJson_button.Size = new Size(126, 23);
            saveArrayToJson_button.TabIndex = 9;
            saveArrayToJson_button.Text = "Save Array";
            saveArrayToJson_button.UseVisualStyleBackColor = true;
            saveArrayToJson_button.Click += saveArrayToJson_button_Click;
            // 
            // saveOper_button
            // 
            saveOper_button.Location = new Point(6, 51);
            saveOper_button.Name = "saveOper_button";
            saveOper_button.Size = new Size(251, 23);
            saveOper_button.TabIndex = 10;
            saveOper_button.Text = "Save operation";
            saveOper_button.UseVisualStyleBackColor = true;
            saveOper_button.Click += saveOper_button_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(runButton);
            groupBox3.Controls.Add(saveOper_button);
            groupBox3.Controls.Add(saveArrayToJson_button);
            groupBox3.Location = new Point(9, 246);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(264, 82);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actions";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ControlDark;
            groupBox4.Controls.Add(groupBox1);
            groupBox4.Controls.Add(groupBox2);
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Location = new Point(261, 54);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(278, 337);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 19);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 12;
            label4.Text = "Information";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(434, 23);
            textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 403);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(groupBox4);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Button generationButton;
        private Button openArray;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton median_rbutton;
        private RadioButton evds_rbutton;
        private Button runButton;
        private Button saveArrayToJson_button;
        private Button saveOper_button;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label4;
        private TextBox textBox1;
    }
}