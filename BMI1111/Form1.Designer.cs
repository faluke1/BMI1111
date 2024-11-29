namespace BMI1111
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
            txtName = new TextBox();
            txtAge = new TextBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            btnBMI = new Button();
            lblResult = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(154, 113);
            txtName.Name = "txtName";
            txtName.Size = new Size(191, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(154, 164);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(120, 27);
            txtAge.TabIndex = 2;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(154, 210);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(120, 27);
            txtHeight.TabIndex = 3;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(154, 257);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(120, 27);
            txtWeight.TabIndex = 4;
            // 
            // btnBMI
            // 
            btnBMI.Location = new Point(575, 113);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(159, 142);
            btnBMI.TabIndex = 5;
            btnBMI.Text = "ค่าBMI";
            btnBMI.UseVisualStyleBackColor = true;
            btnBMI.Click += btnBMI_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = SystemColors.AppWorkspace;
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Location = new Point(1, 405);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(907, 201);
            lblResult.TabIndex = 6;
            lblResult.Text = "....";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 120);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 7;
            label1.Text = "ชื่อ-นามสกุล";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 32);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 8;
            label2.Text = "โปรแกรมคำนวณน้ำหนัก";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 167);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 9;
            label3.Text = "อายุ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 217);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 10;
            label4.Text = "ส่วนสูง(cm)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 264);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 11;
            label5.Text = "น้ำหนัก (kg)";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(575, 285);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(159, 41);
            btnClear.TabIndex = 12;
            btnClear.Text = "เริ่มใหม่";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 603);
            Controls.Add(btnClear);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(btnBMI);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Button btnBMI;
        private Label lblResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnClear;
    }
}
