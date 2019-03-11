namespace Symmetrickey
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
            this.txt_message = new System.Windows.Forms.TextBox();
            this.txt_encrypted = new System.Windows.Forms.TextBox();
            this.txt_Encrypted_Message = new System.Windows.Forms.TextBox();
            this.txt_Decrypt_Message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_secrect_key_1 = new System.Windows.Forms.TextBox();
            this.txt_secrect_key_2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_message
            // 
            this.txt_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_message.Location = new System.Drawing.Point(233, 165);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(406, 28);
            this.txt_message.TabIndex = 0;
            // 
            // txt_encrypted
            // 
            this.txt_encrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_encrypted.Location = new System.Drawing.Point(233, 353);
            this.txt_encrypted.Name = "txt_encrypted";
            this.txt_encrypted.Size = new System.Drawing.Size(406, 28);
            this.txt_encrypted.TabIndex = 1;
            // 
            // txt_Encrypted_Message
            // 
            this.txt_Encrypted_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_Encrypted_Message.Location = new System.Drawing.Point(891, 165);
            this.txt_Encrypted_Message.Name = "txt_Encrypted_Message";
            this.txt_Encrypted_Message.Size = new System.Drawing.Size(390, 28);
            this.txt_Encrypted_Message.TabIndex = 2;
            // 
            // txt_Decrypt_Message
            // 
            this.txt_Decrypt_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_Decrypt_Message.Location = new System.Drawing.Point(891, 353);
            this.txt_Decrypt_Message.Name = "txt_Decrypt_Message";
            this.txt_Decrypt_Message.Size = new System.Drawing.Size(390, 28);
            this.txt_Decrypt_Message.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Encryption";
            // 
            // txt_secrect_key_1
            // 
            this.txt_secrect_key_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_secrect_key_1.Location = new System.Drawing.Point(233, 237);
            this.txt_secrect_key_1.Name = "txt_secrect_key_1";
            this.txt_secrect_key_1.Size = new System.Drawing.Size(406, 28);
            this.txt_secrect_key_1.TabIndex = 5;
            // 
            // txt_secrect_key_2
            // 
            this.txt_secrect_key_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_secrect_key_2.Location = new System.Drawing.Point(891, 237);
            this.txt_secrect_key_2.Name = "txt_secrect_key_2";
            this.txt_secrect_key_2.Size = new System.Drawing.Size(390, 28);
            this.txt_secrect_key_2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(674, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Decryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(37, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Input messeage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(37, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Input secrect key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(37, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Encrypt message";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(674, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Encrypt message";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(674, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Input secrect key";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(674, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Decrypt message";
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Encrypt.Location = new System.Drawing.Point(247, 294);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(115, 35);
            this.btn_Encrypt.TabIndex = 14;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Decrypt.Location = new System.Drawing.Point(905, 294);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(115, 35);
            this.btn_Decrypt.TabIndex = 15;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 513);
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
            this.Controls.Add(this.txt_Decrypt_Message);
            this.Controls.Add(this.txt_Encrypted_Message);
            this.Controls.Add(this.txt_encrypted);
            this.Controls.Add(this.txt_message);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.TextBox txt_encrypted;
        private System.Windows.Forms.TextBox txt_Encrypted_Message;
        private System.Windows.Forms.TextBox txt_Decrypt_Message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_secrect_key_1;
        private System.Windows.Forms.TextBox txt_secrect_key_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
    }
}

