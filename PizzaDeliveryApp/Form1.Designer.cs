namespace PizzaDeliveryApp
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
            comboBoxPizzaChoice = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxPizzaChoice
            // 
            comboBoxPizzaChoice.FormattingEnabled = true;
            comboBoxPizzaChoice.Location = new Point(155, 239);
            comboBoxPizzaChoice.Name = "comboBoxPizzaChoice";
            comboBoxPizzaChoice.Size = new Size(121, 31);
            comboBoxPizzaChoice.TabIndex = 0;
            comboBoxPizzaChoice.SelectedIndexChanged += comboBoxPizzaChoice_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 242);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 1;
            label1.Text = "Select pizza 🍕";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(355, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 141);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 9);
            label2.Name = "label2";
            label2.Size = new Size(147, 23);
            label2.TabIndex = 3;
            label2.Text = "Lipiu's pizza store";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(842, 486);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(comboBoxPizzaChoice);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPizzaChoice;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
