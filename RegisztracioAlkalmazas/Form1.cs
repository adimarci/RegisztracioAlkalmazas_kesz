using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void button_Hozzaad_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textbox_ujHobbi.Text))
            {
                MessageBox.Show("Üres mező");
                return;
            }
            if (listBoxHobbi.Items.Contains(textbox_ujHobbi.Text.Trim()))
            {
                MessageBox.Show("Már létezik ilyen hobbi");
                return;
            }
            listBoxHobbi.Items.Add(textbox_ujHobbi.Text.Trim());
            textbox_ujHobbi.Text=" ";

                
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK) 
            {
                var fajlnev = saveFileDialog.FileName;
                StreamWriter sw = new StreamWriter(fajlnev);
                if (String.IsNullOrWhiteSpace(textbox_Nev.Text)|| radioNo.Checked==false && rafioFerfi.Checked==false )
                {
                    MessageBox.Show("Töltsön ki minden adatot");
                    return;
                }
                
                sw.Write(textbox_Nev.Text+";");
                sw.Write(szul_datum.Value + ";");
                sw.Write(radioNo.Checked + ";");
                sw.Write(rafioFerfi.Checked + ";");
                foreach (var f in listBoxHobbi.Items)
                {
                    sw.Write(f+",");
                    
                }
                
                sw.Close();
            }
        }

        private void buttonBetoltes_Click(object sender, EventArgs e)
        {
            
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
               
                
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    listBoxHobbi.Items.Clear();
                    
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string[] elemek;
                        elemek = reader.ReadToEnd().Split(';');
                        textbox_Nev.Text = elemek[0];
                        szul_datum.Value = Convert.ToDateTime(elemek[1]);
                        radioNo.Checked = Convert.ToBoolean(elemek[2]);
                        rafioFerfi.Checked = Convert.ToBoolean(elemek[3]);
                        string[] hobbik = elemek[4].Split(',');

                        foreach (var f in hobbik)
                        {
                            listBoxHobbi.Items.Add(f);
                        }
                        
                        
                        
                    }
                }
            }

           
        }
    }
}
