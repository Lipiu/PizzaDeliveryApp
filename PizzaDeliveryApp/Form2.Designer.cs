namespace PizzaDeliveryApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            labelCheckout = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxAddress = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            buttonOrder = new Button();
            checkBoxCash = new CheckBox();
            checkBoxCard = new CheckBox();
            labelCardNumber = new Label();
            textBoxCardNumber = new TextBox();
            labelCardHolder = new Label();
            textBoxCardHolder = new TextBox();
            labelExpDate = new Label();
            textBoxExpDate = new TextBox();
            textBoxCvv = new TextBox();
            labelCvv = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            serializationToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            serializationToolStripMenuItem1 = new ToolStripMenuItem();
            serializeToolStripMenuItem = new ToolStripMenuItem();
            deserializeToolStripMenuItem = new ToolStripMenuItem();
            xMLToolStripMenuItem = new ToolStripMenuItem();
            serializeToolStripMenuItem1 = new ToolStripMenuItem();
            deserializeToolStripMenuItem1 = new ToolStripMenuItem();
            exportToTxtToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelCheckout
            // 
            labelCheckout.AutoSize = true;
            labelCheckout.Location = new Point(266, 29);
            labelCheckout.Margin = new Padding(4, 0, 4, 0);
            labelCheckout.Name = "labelCheckout";
            labelCheckout.Size = new Size(295, 28);
            labelCheckout.TabIndex = 0;
            labelCheckout.Text = "Welcome to the checkout page";
            labelCheckout.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(329, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 160);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 304);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 2;
            label1.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 215);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 259);
            label3.Name = "label3";
            label3.Size = new Size(140, 28);
            label3.TabIndex = 4;
            label3.Text = "Phone number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 340);
            label4.Name = "label4";
            label4.Size = new Size(161, 28);
            label4.TabIndex = 5;
            label4.Text = "Payment method";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(174, 215);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(126, 35);
            textBoxName.TabIndex = 6;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(174, 259);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(126, 35);
            textBoxPhoneNumber.TabIndex = 7;
            textBoxPhoneNumber.TextChanged += textBoxPhoneNumber_TextChanged;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(174, 301);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(126, 35);
            textBoxAddress.TabIndex = 8;
            textBoxAddress.TextChanged += textBoxAddress_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // buttonOrder
            // 
            buttonOrder.BackColor = Color.FromArgb(255, 128, 128);
            buttonOrder.FlatStyle = FlatStyle.Flat;
            buttonOrder.Location = new Point(382, 507);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(103, 30);
            buttonOrder.TabIndex = 10;
            buttonOrder.Text = "Place order";
            buttonOrder.UseVisualStyleBackColor = false;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // checkBoxCash
            // 
            checkBoxCash.AutoSize = true;
            checkBoxCash.Location = new Point(173, 340);
            checkBoxCash.Name = "checkBoxCash";
            checkBoxCash.Size = new Size(78, 32);
            checkBoxCash.TabIndex = 11;
            checkBoxCash.Text = "Cash";
            checkBoxCash.UseVisualStyleBackColor = true;
            checkBoxCash.CheckedChanged += checkBoxCash_CheckedChanged;
            // 
            // checkBoxCard
            // 
            checkBoxCard.AutoSize = true;
            checkBoxCard.Location = new Point(241, 340);
            checkBoxCard.Name = "checkBoxCard";
            checkBoxCard.Size = new Size(78, 32);
            checkBoxCard.TabIndex = 12;
            checkBoxCard.Text = "Card";
            checkBoxCard.UseVisualStyleBackColor = true;
            checkBoxCard.CheckedChanged += checkBoxCard_CheckedChanged;
            // 
            // labelCardNumber
            // 
            labelCardNumber.AutoSize = true;
            labelCardNumber.Location = new Point(12, 424);
            labelCardNumber.Name = "labelCardNumber";
            labelCardNumber.Size = new Size(130, 28);
            labelCardNumber.TabIndex = 13;
            labelCardNumber.Text = "Card number";
            // 
            // textBoxCardNumber
            // 
            textBoxCardNumber.Location = new Point(173, 421);
            textBoxCardNumber.Name = "textBoxCardNumber";
            textBoxCardNumber.Size = new Size(127, 35);
            textBoxCardNumber.TabIndex = 14;
            // 
            // labelCardHolder
            // 
            labelCardHolder.AutoSize = true;
            labelCardHolder.Location = new Point(12, 385);
            labelCardHolder.Name = "labelCardHolder";
            labelCardHolder.Size = new Size(123, 28);
            labelCardHolder.TabIndex = 15;
            labelCardHolder.Text = "Card holder";
            // 
            // textBoxCardHolder
            // 
            textBoxCardHolder.Location = new Point(173, 382);
            textBoxCardHolder.Name = "textBoxCardHolder";
            textBoxCardHolder.Size = new Size(127, 35);
            textBoxCardHolder.TabIndex = 16;
            // 
            // labelExpDate
            // 
            labelExpDate.AutoSize = true;
            labelExpDate.Location = new Point(12, 465);
            labelExpDate.Name = "labelExpDate";
            labelExpDate.Size = new Size(121, 28);
            labelExpDate.TabIndex = 17;
            labelExpDate.Text = "Expire date";
            labelExpDate.Click += labelExpDate_Click;
            // 
            // textBoxExpDate
            // 
            textBoxExpDate.Location = new Point(173, 462);
            textBoxExpDate.Name = "textBoxExpDate";
            textBoxExpDate.Size = new Size(127, 35);
            textBoxExpDate.TabIndex = 18;
            // 
            // textBoxCvv
            // 
            textBoxCvv.Location = new Point(174, 507);
            textBoxCvv.Name = "textBoxCvv";
            textBoxCvv.Size = new Size(126, 35);
            textBoxCvv.TabIndex = 19;
            // 
            // labelCvv
            // 
            labelCvv.AutoSize = true;
            labelCvv.Location = new Point(12, 510);
            labelCvv.Name = "labelCvv";
            labelCvv.Size = new Size(50, 28);
            labelCvv.TabIndex = 20;
            labelCvv.Text = "CVV";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { serializationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(161, 28);
            // 
            // serializationToolStripMenuItem
            // 
            serializationToolStripMenuItem.Name = "serializationToolStripMenuItem";
            serializationToolStripMenuItem.Size = new Size(160, 24);
            serializationToolStripMenuItem.Text = "Serialization";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 128, 128);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { serializationToolStripMenuItem1, xMLToolStripMenuItem, exportToTxtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 29);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // serializationToolStripMenuItem1
            // 
            serializationToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { serializeToolStripMenuItem, deserializeToolStripMenuItem });
            serializationToolStripMenuItem1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            serializationToolStripMenuItem1.Name = "serializationToolStripMenuItem1";
            serializationToolStripMenuItem1.Size = new Size(68, 25);
            serializationToolStripMenuItem1.Text = "JSON";
            // 
            // serializeToolStripMenuItem
            // 
            serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            serializeToolStripMenuItem.Size = new Size(171, 26);
            serializeToolStripMenuItem.Text = "Serialize";
            // 
            // deserializeToolStripMenuItem
            // 
            deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            deserializeToolStripMenuItem.Size = new Size(171, 26);
            deserializeToolStripMenuItem.Text = "Deserialize";
            // 
            // xMLToolStripMenuItem
            // 
            xMLToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { serializeToolStripMenuItem1, deserializeToolStripMenuItem1 });
            xMLToolStripMenuItem.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            xMLToolStripMenuItem.Size = new Size(56, 25);
            xMLToolStripMenuItem.Text = "XML";
            // 
            // serializeToolStripMenuItem1
            // 
            serializeToolStripMenuItem1.Name = "serializeToolStripMenuItem1";
            serializeToolStripMenuItem1.Size = new Size(224, 26);
            serializeToolStripMenuItem1.Text = "Serialize";
            // 
            // deserializeToolStripMenuItem1
            // 
            deserializeToolStripMenuItem1.Name = "deserializeToolStripMenuItem1";
            deserializeToolStripMenuItem1.Size = new Size(224, 26);
            deserializeToolStripMenuItem1.Text = "Deserialize";
            // 
            // exportToTxtToolStripMenuItem
            // 
            exportToTxtToolStripMenuItem.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exportToTxtToolStripMenuItem.Name = "exportToTxtToolStripMenuItem";
            exportToTxtToolStripMenuItem.Size = new Size(124, 25);
            exportToTxtToolStripMenuItem.Text = "Export to txt";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(784, 561);
            Controls.Add(menuStrip1);
            Controls.Add(labelCvv);
            Controls.Add(textBoxCvv);
            Controls.Add(textBoxExpDate);
            Controls.Add(labelExpDate);
            Controls.Add(textBoxCardHolder);
            Controls.Add(labelCardHolder);
            Controls.Add(textBoxCardNumber);
            Controls.Add(labelCardNumber);
            Controls.Add(checkBoxCard);
            Controls.Add(checkBoxCash);
            Controls.Add(buttonOrder);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(labelCheckout);
            Font = new Font("Comic Sans MS", 12F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCheckout;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxName;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxAddress;
        private Pizza pizza;
        private ErrorProvider errorProvider1;
        private Button buttonOrder;
        private CheckBox checkBoxCard;
        private CheckBox checkBoxCash;
        private Label labelCardNumber;
        private TextBox textBoxCardNumber;
        private Label labelCvv;
        private TextBox textBoxCvv;
        private TextBox textBoxExpDate;
        private Label labelExpDate;
        private TextBox textBoxCardHolder;
        private Label labelCardHolder;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem serializationToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem serializationToolStripMenuItem1;
        private ToolStripMenuItem serializeToolStripMenuItem;
        private ToolStripMenuItem deserializeToolStripMenuItem;
        private ToolStripMenuItem xMLToolStripMenuItem;
        private ToolStripMenuItem serializeToolStripMenuItem1;
        private ToolStripMenuItem deserializeToolStripMenuItem1;
        private ToolStripMenuItem exportToTxtToolStripMenuItem;
    }
}