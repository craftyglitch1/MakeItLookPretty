namespace MakeItLookPretty
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
            comBoxColor = new ComboBox();
            txtColorCode = new TextBox();
            label1 = new Label();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // comBoxColor
            // 
            comBoxColor.FormattingEnabled = true;
            comBoxColor.Items.AddRange(new object[] { "Left half of window coloured", "Right half of window coloured", "Whole window coloured", "Normal" });
            comBoxColor.Location = new Point(292, 337);
            comBoxColor.Name = "comBoxColor";
            comBoxColor.Size = new Size(184, 28);
            comBoxColor.TabIndex = 0;
            comBoxColor.SelectionChangeCommitted += comBoxColor_SelectionChangeCommitted;
            // 
            // txtColorCode
            // 
            txtColorCode.Location = new Point(292, 371);
            txtColorCode.Name = "txtColorCode";
            txtColorCode.Size = new Size(184, 27);
            txtColorCode.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 371);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 2;
            label1.Text = "Hex Code";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(292, 404);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(184, 29);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(txtColorCode);
            Controls.Add(comBoxColor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comBoxColor;
        private TextBox txtColorCode;
        private Label label1;
        private Button btnConfirm;
    }
}
