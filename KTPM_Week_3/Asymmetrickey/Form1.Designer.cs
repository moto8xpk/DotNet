namespace Asymmetrickey
{
    partial class Form1
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
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_secrect_key_2 = new System.Windows.Forms.TextBox();
            this.txt_secrect_key_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Public_Key = new System.Windows.Forms.RichTextBox();
            this.txt_Private_Key = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_encrypted = new System.Windows.Forms.RichTextBox();
            this.txt_Decrypt_Message = new System.Windows.Forms.RichTextBox();
            this.txt_Encrypted_Message = new System.Windows.Forms.RichTextBox();
            this.txt_message = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Decrypt.Location = new System.Drawing.Point(898, 574);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(115, 35);
            this.btn_Decrypt.TabIndex = 31;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Encrypt.Location = new System.Drawing.Point(239, 574);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(115, 35);
            this.btn_Encrypt.TabIndex = 30;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(666, 628);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "Decrypt message";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(666, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "Input Private key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(666, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Encrypt message";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(29, 628);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Encrypt message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(31, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Input Public key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(31, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Input messeage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(666, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Decryption";
            // 
            // txt_secrect_key_2
            // 
            this.txt_secrect_key_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_secrect_key_2.Location = new System.Drawing.Point(883, 534);
            this.txt_secrect_key_2.Name = "txt_secrect_key_2";
            this.txt_secrect_key_2.Size = new System.Drawing.Size(390, 28);
            this.txt_secrect_key_2.TabIndex = 22;
            // 
            // txt_secrect_key_1
            // 
            this.txt_secrect_key_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_secrect_key_1.Location = new System.Drawing.Point(225, 530);
            this.txt_secrect_key_1.Name = "txt_secrect_key_1";
            this.txt_secrect_key_1.Size = new System.Drawing.Size(406, 28);
            this.txt_secrect_key_1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(31, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Encryption";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(29, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "Generate key pair";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.Location = new System.Drawing.Point(29, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 24);
            this.label10.TabIndex = 33;
            this.label10.Text = "Public Key";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.Location = new System.Drawing.Point(600, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 24);
            this.label11.TabIndex = 34;
            this.label11.Text = "Private Key";
            // 
            // txt_Public_Key
            // 
            this.txt_Public_Key.Location = new System.Drawing.Point(134, 78);
            this.txt_Public_Key.Name = "txt_Public_Key";
            this.txt_Public_Key.Size = new System.Drawing.Size(376, 96);
            this.txt_Public_Key.TabIndex = 35;
            this.txt_Public_Key.Text = "";
            // 
            // txt_Private_Key
            // 
            this.txt_Private_Key.Location = new System.Drawing.Point(709, 78);
            this.txt_Private_Key.Name = "txt_Private_Key";
            this.txt_Private_Key.Size = new System.Drawing.Size(376, 96);
            this.txt_Private_Key.TabIndex = 36;
            this.txt_Private_Key.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 52);
            this.button1.TabIndex = 37;
            this.button1.Text = "Generate K-P";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_encrypted
            // 
            this.txt_encrypted.Location = new System.Drawing.Point(225, 625);
            this.txt_encrypted.Name = "txt_encrypted";
            this.txt_encrypted.Size = new System.Drawing.Size(406, 96);
            this.txt_encrypted.TabIndex = 38;
            this.txt_encrypted.Text = "";
            // 
            // txt_Decrypt_Message
            // 
            this.txt_Decrypt_Message.Location = new System.Drawing.Point(883, 625);
            this.txt_Decrypt_Message.Name = "txt_Decrypt_Message";
            this.txt_Decrypt_Message.Size = new System.Drawing.Size(390, 96);
            this.txt_Decrypt_Message.TabIndex = 39;
            this.txt_Decrypt_Message.Text = "";
            // 
            // txt_Encrypted_Message
            // 
            this.txt_Encrypted_Message.Location = new System.Drawing.Point(883, 418);
            this.txt_Encrypted_Message.Name = "txt_Encrypted_Message";
            this.txt_Encrypted_Message.Size = new System.Drawing.Size(390, 96);
            this.txt_Encrypted_Message.TabIndex = 40;
            this.txt_Encrypted_Message.Text = "";
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(225, 418);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(406, 96);
            this.txt_message.TabIndex = 41;
            this.txt_message.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 733);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.txt_Encrypted_Message);
            this.Controls.Add(this.txt_Decrypt_Message);
            this.Controls.Add(this.txt_encrypted);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Private_Key);
            this.Controls.Add(this.txt_Public_Key);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_secrect_key_2);
            this.Controls.Add(this.txt_secrect_key_1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_secrect_key_2;
        private System.Windows.Forms.TextBox txt_secrect_key_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txt_Public_Key;
        private System.Windows.Forms.RichTextBox txt_Private_Key;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txt_encrypted;
        private System.Windows.Forms.RichTextBox txt_Decrypt_Message;
        private System.Windows.Forms.RichTextBox txt_Encrypted_Message;
        private System.Windows.Forms.RichTextBox txt_message;
    }
}

