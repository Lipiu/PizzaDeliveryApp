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
            checkBoxNoKetchup = new CheckBox();
            menuStrip1 = new MenuStrip();
            jSONSERIALIZATIONToolStripMenuItem = new ToolStripMenuItem();
            serializeToolStripMenuItem = new ToolStripMenuItem();
            deserializeToolStripMenuItem = new ToolStripMenuItem();
            aboutAppToolStripMenuItem = new ToolStripMenuItem();
            aboutPizzaToolStripMenuItem = new ToolStripMenuItem();
            pizzaToolStripMenuItem = new ToolStripMenuItem();
            labelSize = new Label();
            comboBoxPizzaSize = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPizza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxPizzaChoice
            // 
            comboBoxPizzaChoice.FormattingEnabled = true;
            comboBoxPizzaChoice.Location = new Point(178, 239);
            comboBoxPizzaChoice.Name = "comboBoxPizzaChoice";
            comboBoxPizzaChoice.Size = new Size(152, 36);
            comboBoxPizzaChoice.TabIndex = 0;
            comboBoxPizzaChoice.SelectedIndexChanged += comboBoxPizzaChoice_SelectedIndexChanged;
            // 
            // labelSelectPizza
            // 
            labelSelectPizza.AutoSize = true;
            labelSelectPizza.Location = new Point(12, 242);
            labelSelectPizza.Name = "labelSelectPizza";
            labelSelectPizza.Size = new Size(154, 28);
            labelSelectPizza.TabIndex = 1;
            labelSelectPizza.Text = "Select pizza 🍕";
            // 
            // pictureBoxPizza
            // 
            pictureBoxPizza.Image = (Image)resources.GetObject("pictureBoxPizza.Image");
            pictureBoxPizza.Location = new Point(299, 72);
            pictureBoxPizza.Name = "pictureBoxPizza";
            pictureBoxPizza.Size = new Size(151, 141);
            pictureBoxPizza.TabIndex = 2;
            pictureBoxPizza.TabStop = false;
            pictureBoxPizza.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 41);
            label2.Name = "label2";
            label2.Size = new Size(185, 28);
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
            labelKetchup.Location = new Point(12, 356);
            labelKetchup.Name = "labelKetchup";
            labelKetchup.Size = new Size(97, 28);
            labelKetchup.TabIndex = 4;
            labelKetchup.Text = "Ketchup?";
            // 
            // checkBoxKetchup
            // 
            checkBoxKetchup.AutoSize = true;
            checkBoxKetchup.Location = new Point(155, 356);
            checkBoxKetchup.Name = "checkBoxKetchup";
            checkBoxKetchup.Size = new Size(65, 32);
            checkBoxKetchup.TabIndex = 5;
            checkBoxKetchup.TabStop = false;
            checkBoxKetchup.Text = "yes";
            checkBoxKetchup.UseVisualStyleBackColor = true;
            checkBoxKetchup.CheckedChanged += checkBoxKetchup_CheckedChanged;
            // 
            // checkBoxSpicy
            // 
            checkBoxSpicy.AutoSize = true;
            checkBoxSpicy.Location = new Point(155, 389);
            checkBoxSpicy.Name = "checkBoxSpicy";
            checkBoxSpicy.Size = new Size(165, 32);
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
            button1.Location = new Point(12, 463);
            button1.Name = "button1";
            button1.Size = new Size(175, 35);
            button1.TabIndex = 7;
            button1.Text = "Go to checkout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBoxNoKetchup
            // 
            checkBoxNoKetchup.AutoSize = true;
            checkBoxNoKetchup.Location = new Point(244, 356);
            checkBoxNoKetchup.Name = "checkBoxNoKetchup";
            checkBoxNoKetchup.Size = new Size(55, 32);
            checkBoxNoKetchup.TabIndex = 8;
            checkBoxNoKetchup.Text = "no";
            checkBoxNoKetchup.UseVisualStyleBackColor = true;
            checkBoxNoKetchup.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 128, 128);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { jSONSERIALIZATIONToolStripMenuItem, aboutAppToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 29);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // jSONSERIALIZATIONToolStripMenuItem
            // 
            jSONSERIALIZATIONToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 128);
            jSONSERIALIZATIONToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { serializeToolStripMenuItem, deserializeToolStripMenuItem });
            jSONSERIALIZATIONToolStripMenuItem.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jSONSERIALIZATIONToolStripMenuItem.Name = "jSONSERIALIZATIONToolStripMenuItem";
            jSONSERIALIZATIONToolStripMenuItem.Size = new Size(202, 25);
            jSONSERIALIZATIONToolStripMenuItem.Text = "JSON SERIALIZATION";
            jSONSERIALIZATIONToolStripMenuItem.Click += jSONSERIALIZATIONToolStripMenuItem_Click;
            // 
            // serializeToolStripMenuItem
            // 
            serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            serializeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            serializeToolStripMenuItem.Size = new Size(228, 26);
            serializeToolStripMenuItem.Text = "Serialize";
            serializeToolStripMenuItem.Click += serializeToolStripMenuItem_Click;
            // 
            // deserializeToolStripMenuItem
            // 
            deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            deserializeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            deserializeToolStripMenuItem.Size = new Size(228, 26);
            deserializeToolStripMenuItem.Text = "Deserialize";
            deserializeToolStripMenuItem.Click += deserializeToolStripMenuItem_Click;
            // 
            // aboutAppToolStripMenuItem
            // 
            aboutAppToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutPizzaToolStripMenuItem, pizzaToolStripMenuItem });
            aboutAppToolStripMenuItem.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aboutAppToolStripMenuItem.Name = "aboutAppToolStripMenuItem";
            aboutAppToolStripMenuItem.Size = new Size(67, 25);
            aboutAppToolStripMenuItem.Text = "About";
            aboutAppToolStripMenuItem.Click += aboutAppToolStripMenuItem_Click;
            // 
            // aboutPizzaToolStripMenuItem
            // 
            aboutPizzaToolStripMenuItem.Name = "aboutPizzaToolStripMenuItem";
            aboutPizzaToolStripMenuItem.Size = new Size(224, 26);
            aboutPizzaToolStripMenuItem.Text = "App features";
            aboutPizzaToolStripMenuItem.Click += aboutPizzaToolStripMenuItem_Click;
            // 
            // pizzaToolStripMenuItem
            // 
            pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            pizzaToolStripMenuItem.Size = new Size(224, 26);
            pizzaToolStripMenuItem.Text = "Pizza info";
            pizzaToolStripMenuItem.Click += pizzaToolStripMenuItem_Click;
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new Point(12, 298);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(115, 28);
            labelSize.TabIndex = 10;
            labelSize.Text = "Select size";
            // 
            // comboBoxPizzaSize
            // 
            comboBoxPizzaSize.FormattingEnabled = true;
            comboBoxPizzaSize.Location = new Point(178, 295);
            comboBoxPizzaSize.Name = "comboBoxPizzaSize";
            comboBoxPizzaSize.Size = new Size(151, 36);
            comboBoxPizzaSize.TabIndex = 11;
            comboBoxPizzaSize.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(784, 561);
            Controls.Add(comboBoxPizzaSize);
            Controls.Add(labelSize);
            Controls.Add(checkBoxNoKetchup);
            Controls.Add(button1);
            Controls.Add(checkBoxSpicy);
            Controls.Add(checkBoxKetchup);
            Controls.Add(labelKetchup);
            Controls.Add(label2);
            Controls.Add(pictureBoxPizza);
            Controls.Add(labelSelectPizza);
            Controls.Add(comboBoxPizzaChoice);
            Controls.Add(menuStrip1);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPizza).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private CheckBox checkBoxNoKetchup;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem jSONSERIALIZATIONToolStripMenuItem;
        private ToolStripMenuItem serializeToolStripMenuItem;
        private ToolStripMenuItem deserializeToolStripMenuItem;
        private ToolStripMenuItem aboutAppToolStripMenuItem;
        private ToolStripMenuItem aboutPizzaToolStripMenuItem;
        private ToolStripMenuItem pizzaToolStripMenuItem;
        private Label labelSize;
        private ComboBox comboBoxPizzaSize;
    }
}
