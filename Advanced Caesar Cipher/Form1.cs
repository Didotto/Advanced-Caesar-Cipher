using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//SOCKETS
using System.Net;
using System.Net.Sockets;

/// <summary>
/// Author: Davide Balice
/// Version: 1.0.0.0
/// Last Change Date: 20/02/2017
/// License: GNU General Public License v 3.0
/// ChangeLog: CHANGELOG.md
/// </summary>

namespace CryptMessageSystem {
    public partial class AdvancedCaesarCipher : Form {
        public const int PORT = 56969;
        public const int MINCHAR = 32; //32
        public const int MAXCHAR = 126; //126
        public const int NUMCHAR = 95; //95

        Socket server;
        Socket client;
        IPEndPoint toIP;
        Socket srvAcc;
        Thread srvSocketTh;

        public AdvancedCaesarCipher() {
            InitializeComponent();
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            toIP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), PORT);
            txtClient.Enabled = false;
            txtTuring.Enabled = false;

            srvSocketTh = new Thread(() => {
                server.Bind(new IPEndPoint(0, PORT));
                server.Listen(0);
                while (true) {
                    try {
                        srvAcc = server.Accept();
                    } catch {
                        break;
                    }
                    byte[] buffer = new byte[srvAcc.SendBufferSize];
                    int bytesRead = srvAcc.Receive(buffer);
                    byte[] formatted = new byte[bytesRead];
                    for(int i=0; i<bytesRead; i++) {
                        if(buffer[i]>=32 && buffer[i]<=126)
                        formatted[i] = buffer[i];
                    }
                    Invoke(new Action(() => { lstBoxMessage.Items.Add(Encoding.ASCII.GetString(formatted)); })); 
                }
                server.Close();
                srvAcc.Close();
            });
            srvSocketTh.Start();
        }

        private void chBoxEnc_CheckedChanged(object sender, EventArgs e) {
            if (!(chBoxEnc.CheckState == CheckState.Checked)) {
                txtClient.Enabled = false;
            } else {
                txtClient.Enabled = true;
            }
        }

        private void chBoxTuring_CheckedChanged(object sender, EventArgs e) {
            if (!(chBoxTuring.CheckState == CheckState.Checked)) {
                txtTuring.Enabled = false;
            } else {
                txtTuring.Enabled = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e) {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                toIP.Address = IPAddress.Parse(txtIP.Text);
                client.Connect(toIP);
                byte[] msgBuffer;
                if (chBoxEnc.CheckState == CheckState.Checked && !string.IsNullOrEmpty(txtClient.Text)) {
                    string msg = encryption(txtMessage.Text, Convert.ToInt32(txtClient.Text));
                    msgBuffer = Encoding.Default.GetBytes(msg);
                } else {
                    msgBuffer = Encoding.Default.GetBytes(txtMessage.Text);
                }
                client.Send(msgBuffer, 0, msgBuffer.Length, 0);
                client.Close();
                txtMessage.Text = "";
            } catch {
                MessageBox.Show("Insert a IP Address!");
                client.Close();
            }
            
        }

        private void btnRead_Click(object sender, EventArgs e) {
            if((chBoxTuring.CheckState == CheckState.Checked && !string.IsNullOrEmpty(txtTuring.Text))) {
                int key = getTuringKey(lstBoxMessage.SelectedItem.ToString(), txtTuring.Text);
                MessageBox.Show(key.ToString());
            }else {
                try {
                    string msg = lstBoxMessage.SelectedItem.ToString();
                    int key = Convert.ToInt32(txtServer.Text);
                    string msgEnc = encryption(msg, -key);
                    MessageBox.Show(msgEnc);
                } catch {
                    MessageBox.Show("Insert a Key!");
                }
            }
        }

        //Func: encryption
        //Type: String
        //*x (String): the string to encrypt/decrypt
        //*offSet (int): the offset given
        //°return: crypted/decrypted string
        private String encryption(String x, int offSet) {
            //CHARS FROM 32 TO 126 http://www.asciitable.com/
            char c;
            int qnt = offSet % NUMCHAR;
            int aux;
            for (int i = 0; i < x.Length; i++) {
                c = (char)x[i];
                if (x[i] + qnt > MAXCHAR && qnt>0) {
                    aux = MAXCHAR - x[i];
                    c = (char)((MINCHAR - 1) + (qnt - aux));
                }else if (x[i] + qnt < MINCHAR && qnt<0 ) {
                    aux = MINCHAR - x[i];
                    c = (char)((MAXCHAR + 1) + (qnt - aux));
                } else {
                    c = (char)(x[i] + qnt);
                }
                x = charSwap(c, i, x);
            }
            return x;
        }

        //Func: getTouringKey
        //Type: Integer
        //*crypted (string): crypted string
        //*turing (string): the clue to find the key
        //°return: 0 if it doesn't find any key
        //         X if it finds a key
        private int getTuringKey(string crypted, string turing) {
            char[] arrayCry = crypted.ToCharArray();
            char[] arrayTur = turing.ToCharArray();
            if (arrayTur.Length > arrayCry.Length) return 0;
            bool[] arrayBool = new bool[arrayTur.Length];
            for (int i = 0; i < arrayBool.Length; i++) arrayBool[i] = false;
            int key = 0;
            char c;
            for(int i = 0; i< arrayCry.Length; i++) {
                key = arrayCry[i] - arrayTur[0];
                for(int j = 0; j< arrayTur.Length && (i+j)<arrayCry.Length; j++) {
                    c = Convert.ToChar(encryption(arrayTur[j].ToString(), key));
                    if(arrayCry[i+j] == c) {
                        arrayBool[j] = true;
                    } else {
                        for (int k = 0; k < j; k++) arrayBool[k] = false;
                        break;
                    }
                }
                if (isAllTrue(arrayBool)) return key;
            }
            return 0;
        }

        //Func: isAllTrue
        //Type: Boolean
        //*b ([]bool): array of boolean values
        //°return: TRUE if all the elements inside the array are "true"
        //         FALSE if there is at least one element "false"
        private bool isAllTrue(bool[] b) {
            for(int i =0; i<b.Length; i++) {
                if (!b[i]) return false;
            }
            return true;
        }

        //Func: charSwap
        //Type: String
        //*c (char): new char
        //*i (int): string index
        //*x (string): string to modify
        //°return: modified string
        private string charSwap(char c, int i, string x) {
            char[] cArray = x.ToCharArray();
            cArray[i] = c;
            return string.Join("", cArray);
        }

        void CryptMassageSystem_FormClosed(object sender, FormClosedEventArgs e) {
            server.Close();
            srvSocketTh.Abort();
        }
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

