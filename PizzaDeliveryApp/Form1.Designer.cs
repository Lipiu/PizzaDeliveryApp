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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBoxPizzaChoice = new ComboBox();
            labelSelectPizza = new Label();
            pictureBoxPizza = new PictureBox();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            labelKetchup = new Label();
            checkBoxKetchup = new CheckBox();
            checkBoxSpicy = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPizza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            // labelSelectPizza
            // 
            labelSelectPizza.AutoSize = true;
            labelSelectPizza.Location = new Point(12, 242);
            labelSelectPizza.Name = "labelSelectPizza";
            labelSelectPizza.Size = new Size(124, 23);
            labelSelectPizza.TabIndex = 1;
            labelSelectPizza.Text = "Select pizza 🍕";
            // 
            // pictureBoxPizza
            // 
            pictureBoxPizza.Image = (Image)resources.GetObject("pictureBoxPizza.Image");
            pictureBoxPizza.Location = new Point(355, 35);
            pictureBoxPizza.Name = "pictureBoxPizza";
            pictureBoxPizza.Size = new Size(151, 141);
            pictureBoxPizza.TabIndex = 2;
            pictureBoxPizza.TabStop = false;
            pictureBoxPizza.Click += pictureBox1_Click;
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
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // labelKetchup
            // 
            labelKetchup.AutoSize = true;
            labelKetchup.Location = new Point(12, 305);
            labelKetchup.Name = "labelKetchup";
            labelKetchup.Size = new Size(77, 23);
            labelKetchup.TabIndex = 4;
            labelKetchup.Text = "Ketchup?";
            // 
            // checkBoxKetchup
            // 
            checkBoxKetchup.AutoSize = true;
            checkBoxKetchup.Location = new Point(155, 305);
            checkBoxKetchup.Name = "checkBoxKetchup";
            checkBoxKetchup.Size = new Size(53, 27);
            checkBoxKetchup.TabIndex = 5;
            checkBoxKetchup.TabStop = false;
            checkBoxKetchup.Text = "yes";
            checkBoxKetchup.UseVisualStyleBackColor = true;
            checkBoxKetchup.CheckedChanged += checkBoxKetchup_CheckedChanged;
            // 
            // checkBoxSpicy
            // 
            checkBoxSpicy.AutoSize = true;
            checkBoxSpicy.Location = new Point(155, 334);
            checkBoxSpicy.Name = "checkBoxSpicy";
            checkBoxSpicy.Size = new Size(134, 27);
            checkBoxSpicy.TabIndex = 6;
            checkBoxSpicy.Text = "make it spicy?";
            checkBoxSpicy.UseVisualStyleBackColor = true;
            checkBoxSpicy.Visible = false;
            checkBoxSpicy.CheckedChanged += checkBoxSpicy_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 409);
            button1.Name = "button1";
            button1.Size = new Size(144, 30);
            button1.TabIndex = 7;
            button1.Text = "Go to checkout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(842, 486);
            Controls.Add(button1);
            Controls.Add(checkBoxSpicy);
            Controls.Add(checkBoxKetchup);
            Controls.Add(labelKetchup);
            Controls.Add(label2);
            Controls.Add(pictureBoxPizza);
            Controls.Add(labelSelectPizza);
            Controls.Add(comboBoxPizzaChoice);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPizza).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPizzaChoice;
        private Label labelSelectPizza;
        private PictureBox pictureBoxPizza;
        private Label label2;
        private ErrorProvider errorProvider1;
        private CheckBox checkBoxKetchup;
        private Label labelKetchup;
        private CheckBox checkBoxSpicy;
        private Button button1;
    }
}
