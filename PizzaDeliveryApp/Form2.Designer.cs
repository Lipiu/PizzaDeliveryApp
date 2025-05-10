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
            textBoxPayment = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            buttonOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // labelCheckout
            // 
            labelCheckout.AutoSize = true;
            labelCheckout.Location = new Point(278, 9);
            labelCheckout.Margin = new Padding(4, 0, 4, 0);
            labelCheckout.Name = "labelCheckout";
            labelCheckout.Size = new Size(230, 23);
            labelCheckout.TabIndex = 0;
            labelCheckout.Text = "Welcome to the checkout page";
            labelCheckout.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(313, 35);
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
            label1.Size = new Size(70, 23);
            label1.TabIndex = 2;
            label1.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 215);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 259);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 4;
            label3.Text = "Phone number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 340);
            label4.Name = "label4";
            label4.Size = new Size(125, 23);
            label4.TabIndex = 5;
            label4.Text = "Payment method";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(174, 215);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(126, 30);
            textBoxName.TabIndex = 6;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(174, 259);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(126, 30);
            textBoxPhoneNumber.TabIndex = 7;
            textBoxPhoneNumber.TextChanged += textBoxPhoneNumber_TextChanged;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(174, 301);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(126, 30);
            textBoxAddress.TabIndex = 8;
            textBoxAddress.TextChanged += textBoxAddress_TextChanged;
            // 
            // textBoxPayment
            // 
            textBoxPayment.Location = new Point(174, 340);
            textBoxPayment.Name = "textBoxPayment";
            textBoxPayment.Size = new Size(126, 30);
            textBoxPayment.TabIndex = 9;
            textBoxPayment.TextChanged += textBoxPayment_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // buttonOrder
            // 
            buttonOrder.BackColor = Color.FromArgb(255, 128, 128);
            buttonOrder.FlatStyle = FlatStyle.Flat;
            buttonOrder.Location = new Point(174, 411);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(103, 30);
            buttonOrder.TabIndex = 10;
            buttonOrder.Text = "Place order";
            buttonOrder.UseVisualStyleBackColor = false;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(784, 561);
            Controls.Add(buttonOrder);
            Controls.Add(textBoxPayment);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private TextBox textBoxPayment;
        private ErrorProvider errorProvider1;
        private Button buttonOrder;
    }
}