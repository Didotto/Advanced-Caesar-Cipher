namespace CryptMessageSystem {
    partial class AdvancedCaesarCipher {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedCaesarCipher));
            this.lstBoxMessage = new System.Windows.Forms.ListBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblKeyServer = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.chBoxEnc = new System.Windows.Forms.CheckBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtTuring = new System.Windows.Forms.TextBox();
            this.chBoxTuring = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstBoxMessage
            // 
            this.lstBoxMessage.FormattingEnabled = true;
            this.lstBoxMessage.Location = new System.Drawing.Point(12, 25);
            this.lstBoxMessage.Name = "lstBoxMessage";
            this.lstBoxMessage.Size = new System.Drawing.Size(232, 199);
            this.lstBoxMessage.TabIndex = 0;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 282);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(232, 57);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read Message";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(250, 282);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(232, 57);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send Message";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(96, 230);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(148, 20);
            this.txtServer.TabIndex = 3;
            // 
            // lblKeyServer
            // 
            this.lblKeyServer.AutoSize = true;
            this.lblKeyServer.Location = new System.Drawing.Point(62, 233);
            this.lblKeyServer.Name = "lblKeyServer";
            this.lblKeyServer.Size = new System.Drawing.Size(28, 13);
            this.lblKeyServer.TabIndex = 4;
            this.lblKeyServer.Text = "Key:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(250, 25);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(232, 199);
            this.txtMessage.TabIndex = 5;
            this.txtMessage.Text = "";
            // 
            // chBoxEnc
            // 
            this.chBoxEnc.AutoSize = true;
            this.chBoxEnc.Location = new System.Drawing.Point(250, 259);
            this.chBoxEnc.Name = "chBoxEnc";
            this.chBoxEnc.Size = new System.Drawing.Size(74, 17);
            this.chBoxEnc.TabIndex = 6;
            this.chBoxEnc.Text = "Encrypted";
            this.chBoxEnc.UseVisualStyleBackColor = true;
            this.chBoxEnc.CheckedChanged += new System.EventHandler(this.chBoxEnc_CheckedChanged);
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(330, 256);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(150, 20);
            this.txtClient.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Message Box";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Write a Message:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "IP Address:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(330, 230);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(150, 20);
            this.txtIP.TabIndex = 11;
            // 
            // txtTuring
            // 
            this.txtTuring.Location = new System.Drawing.Point(96, 256);
            this.txtTuring.Name = "txtTuring";
            this.txtTuring.Size = new System.Drawing.Size(148, 20);
            this.txtTuring.TabIndex = 13;
            // 
            // chBoxTuring
            // 
            this.chBoxTuring.AutoSize = true;
            this.chBoxTuring.Location = new System.Drawing.Point(44, 258);
            this.chBoxTuring.Name = "chBoxTuring";
            this.chBoxTuring.Size = new System.Drawing.Size(46, 17);
            this.chBoxTuring.TabIndex = 14;
            this.chBoxTuring.Text = "Find";
            this.chBoxTuring.UseVisualStyleBackColor = true;
            this.chBoxTuring.CheckedChanged += new System.EventHandler(this.chBoxTuring_CheckedChanged);
            // 
            // AdvancedCaesarCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 351);
            this.Controls.Add(this.chBoxTuring);
            this.Controls.Add(this.txtTuring);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.chBoxEnc);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblKeyServer);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lstBoxMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdvancedCaesarCipher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Caesar Cipher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CryptMassageSystem_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxMessage;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblKeyServer;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.CheckBox chBoxEnc;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtTuring;
        private System.Windows.Forms.CheckBox chBoxTuring;
    }
}

/*
    Advanced Caesar Cipher Copyright (C) 2017  Davide Balice

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.

    If you have any questions contact me at: davide_balice@outlook.com
*/