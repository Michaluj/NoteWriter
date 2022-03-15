using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace toDoListRemaster
{
    public partial class toDoList : Form
    {
        private bool isClicked = false;
        private bool isButtonCollorClicked = false;
        int customX = 0;
        int customY = 0;

        public toDoList()
        {
            InitializeComponent();
            bScale.Hide();
            bNotesColor.Hide();
            bNotesTextColor.Hide();

            lbNotes.ContextMenuStrip = cm;

            if (File.Exists("data.xml")) //check - existuje soubor? - nacteni ze souboru
            {
                XmlDocument xml = new XmlDocument();
                xml.Load("data.xml");

                XmlElement elem = xml.DocumentElement;
                XmlNodeList elemList = elem.GetElementsByTagName("notes");

                string attrVal;

                for (int i = 0; i < elemList.Count; i++)
                {
                    attrVal = elemList[i].Attributes["note"].Value;
                    lbNotes.Items.Add(attrVal);
                }
            }
            else //:)
            {
                lbNotes.Items.Add(":)");
            }

            //check - existuje soubor? - nacteni barvy pozadi
            if (File.Exists("color.txt"))
            {
                StreamReader colorLoad = new StreamReader("color.txt", Encoding.UTF8);
                Color colorFromFile = ColorTranslator.FromHtml(File.ReadAllText("color.txt"));
                lbNotes.BackColor = colorFromFile;
                bNotesColor.BackColor = colorFromFile;
                colorLoad.Close();
            }

            //check - existuje soubor? - nacteni barvy textu
            if (File.Exists("colorText.txt"))
            {
                StreamReader colorTextLoad = new StreamReader("colorText.txt", Encoding.UTF8);
                Color colorFromFile = ColorTranslator.FromHtml(File.ReadAllText("colorText.txt"));
                lbNotes.ForeColor = colorFromFile;
                bNotesTextColor.BackColor = colorFromFile;
                colorTextLoad.Close();
            }

            if (File.Exists("scaleX.txt"))
            {
                StreamReader scaleLoadX = new StreamReader("scaleX.txt", Encoding.UTF8);
                customX = Convert.ToInt32(scaleLoadX.ReadToEnd());
                this.Width = customX;
                scaleLoadX.Close();


                if (File.Exists("scaleY.txt"))
                {
                    StreamReader scaleLoadY = new StreamReader("scaleY.txt", Encoding.UTF8);
                    customY = Convert.ToInt32(scaleLoadY.ReadToEnd());
                    this.Height = customY;
                    scaleLoadY.Close();
                }
            }
        }


        private void bNewNote_Click(object sender, EventArgs e) //formular pro zadani nove poznamky
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

            if(f2.NoteText == string.Empty || f2.NoteNameText == string.Empty)
            {
            }
            else
            {
                lbNotes.Items.Add(f2.NoteNameText + " / " + Environment.NewLine + Environment.NewLine + f2.NoteText + " / " + Environment.NewLine + Environment.NewLine + DateTime.Now);
            }
        }

        private void bLoad_Click(object sender, EventArgs e) //nacteni vybrane poznamky
        {
            int index = lbNotes.SelectedIndex;
            string notes = (string)lbNotes.Items[index];
            string[] splitNotes = notes.Split('/');
            
            Form2 f2 = new Form2();
            f2.NoteNameText = splitNotes[0];
            f2.NoteText = splitNotes[1];
            
            f2.ShowDialog();

            if (f2.NoteText == string.Empty || f2.NoteNameText == string.Empty)
            {
            }
            else
            {
                lbNotes.Items.RemoveAt(index);
                lbNotes.Items.Add(f2.NoteNameText + " / " + Environment.NewLine + Environment.NewLine + f2.NoteText + " / " + Environment.NewLine + Environment.NewLine + DateTime.Now);
            }
        }

        private void bDelete_Click(object sender, EventArgs e) //smazani vybrane poznamky
        {
            if (lbNotes.SelectedIndex == 0)
            {
                MessageBox.Show(":)", ":)", MessageBoxButtons.OK); //nesmazatelny smajlik / opatreni proti padu
            }
            else
            {
                while (lbNotes.SelectedItems.Count > 0)
                {
                    lbNotes.Items.Remove(lbNotes.SelectedItems[0]);
                }
            }
        }

        private void bSave_Click(object sender, EventArgs e) //ulozeni
        {
            try //check jestli lze ulozit
            {
                XmlWriterSettings cfg = new XmlWriterSettings();
                cfg.Encoding = Encoding.UTF8;
                cfg.Indent = true;
                cfg.IndentChars = "\t";

                using (XmlWriter save = XmlWriter.Create("data.xml", cfg))
                {
                    save.WriteStartDocument();
                    save.WriteStartElement("noteList");
                    foreach (var item in lbNotes.Items)
                    {
                        save.WriteStartElement("notes");
                        save.WriteAttributeString("note", item.ToString());
                        save.WriteEndElement();
                    }
                    save.WriteEndElement();
                    save.WriteEndDocument();
                }
                MessageBox.Show("Úspěšně uloženo", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception) //zachyceni nemoznosti ulozeni - nemelo by dojit
            {
                MessageBox.Show("Došlo k neočekáváné chybě, program se nyní vypne.", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void toDoList_Load(object sender, EventArgs e)
        {
            //hodiny
            var time = DateTime.Now.ToString();
            lTime.Text = time;

            if (WindowState == FormWindowState.Minimized)
            {
                //prevence pred zobrazenim msgBoxu s min. vyskou / sirkou
            }
            else if (this.Width < 1119)
            {
                tClock.Enabled = false;
                MessageBox.Show("Minimální šířka dosažena!", "WARN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Width = 1120;
                lTime.Text = time;
                tClock.Enabled = true;
            }
            else if (this.Height < 759)
            {
                tClock.Enabled = false;
                MessageBox.Show("Minimální výška dosažena!", "WARN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Height = 760;
                lTime.Text = time;
                tClock.Enabled = true;
            }

            else
            {
                tClock.Enabled = true;
            }
            int customX = this.Width;
            int customY = this.Height;

        }

        private void tClock_Tick(object sender, EventArgs e)
        {
            //casovac
        }

        //export do .txt
        private void bExport_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Pozor, funkce EXPORT nenačte poznámky při znovuotevření programu. Pro opětovné načtení poznámek klikni na tlačítko uložit! \n\nExportovat?", "WARN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SaveFileDialog dlg = new SaveFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string path = Path.GetFullPath(dlg.FileName);
                    try //check jestli lze ulozit
                    {
                        StreamWriter export = new StreamWriter(path + ".txt"); //zjisteni cesty
                        foreach (var item in lbNotes.Items)
                        {
                            export.WriteLine(item); //export
                        }
                        export.Close();

                        MessageBox.Show("Úspěšně exportováno", "EXPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception) //zachyceni nemoznosti ulozeni - nemelo by dojit
                    {
                        MessageBox.Show("Došlo k neočekáváné chybě, program se nyní vypne.", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }

                }
            }

        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            //dropdown nastaveni
            if (!isClicked)
            {
                bScale.Show();
                bNotesColor.Show();
                bNotesTextColor.Show();
                isClicked = true;
            }
            else
            {
                bScale.Hide();
                bNotesColor.Hide();
                bNotesTextColor.Hide();
                isClicked = false;
            }
        }

        private void bScale_Click(object sender, EventArgs e)
        {
            //soubory - X a Y souradnice pro skalovani programu
            StreamWriter scaleSaveX = new StreamWriter("scaleX.txt", false, Encoding.UTF8);
            StreamWriter scaleSaveY = new StreamWriter("scaleY.txt", false, Encoding.UTF8);

            //skalovani
            if (!isButtonCollorClicked)
            {
                bScale.BackColor = Color.Green;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.MaximizeBox = true;
                isButtonCollorClicked = true;

                customX = this.Width;
                customY = this.Height;
                customX.ToString();
                customY.ToString();
                scaleSaveX.Write(customX);
                scaleSaveX.Close();
                scaleSaveY.Write(customY);
                scaleSaveY.Close();
            }
            else
            {
                bScale.BackColor = Color.Red;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.MaximizeBox = true;
                isButtonCollorClicked = false;

                scaleSaveX.Write(customX);
                scaleSaveX.Close();
                scaleSaveY.Write(customY);
                scaleSaveY.Close();
            }
        }

        private void bNotesColor_Click(object sender, EventArgs e)
        {
            //barvy - dialog
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.ShowDialog();
            lbNotes.BackColor = dlgColor.Color; //prebarveni pozadi listboxu
            bNotesColor.BackColor = dlgColor.Color; //prebarveni buttonu

            //ulozeni barvy do souboru
            string color = ColorTranslator.ToHtml(dlgColor.Color);
            StreamWriter colorSettings = new StreamWriter("color.txt", false, Encoding.UTF8);
            colorSettings.Write(color);
            colorSettings.Close();
        }

        private void bNotesTextColor_Click(object sender, EventArgs e)
        {
            //barvy - dialog
            ColorDialog dlgTextColor = new ColorDialog();
            dlgTextColor.ShowDialog();
            lbNotes.ForeColor = dlgTextColor.Color;
            bNotesTextColor.BackColor = dlgTextColor.Color;

            //ulozeni barvy do souboru
            string colorText = ColorTranslator.ToHtml(dlgTextColor.Color);
            StreamWriter colorSettings = new StreamWriter("colorText.txt", false, Encoding.UTF8);
            colorSettings.Write(colorText);
            colorSettings.Close();
        }

        private void lbNotes_DoubleClick(object sender, EventArgs e)
        {
            if (lbNotes.SelectedItem == null) //crash prevence pred dvojklikem do prazdna
            {

            }
            else
            {
                MessageBox.Show(lbNotes.SelectedItem.ToString());
            }
        }

        private void barvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //barvy - dialog
            ColorDialog dlgTextColor = new ColorDialog();
            dlgTextColor.ShowDialog();
            lbNotes.ForeColor = dlgTextColor.Color;
            bNotesTextColor.BackColor = dlgTextColor.Color;

            //ulozeni barvy do souboru
            string colorText = ColorTranslator.ToHtml(dlgTextColor.Color);
            StreamWriter colorSettings = new StreamWriter("colorText.txt", false, Encoding.UTF8);
            colorSettings.Write(colorText);
            colorSettings.Close();
        }

        private void barvaPlátnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //barvy - dialog
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.ShowDialog();
            lbNotes.BackColor = dlgColor.Color; //prebarveni pozadi listboxu
            bNotesColor.BackColor = dlgColor.Color; //prebarveni buttonu

            //ulozeni barvy do souboru
            string color = ColorTranslator.ToHtml(dlgColor.Color);
            StreamWriter colorSettings = new StreamWriter("color.txt", false, Encoding.UTF8);
            colorSettings.Write(color);
            colorSettings.Close();
        }
    }
}