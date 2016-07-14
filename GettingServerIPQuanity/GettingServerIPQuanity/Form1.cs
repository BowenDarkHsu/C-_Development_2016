using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GettingServerIPQuanity
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            String str;
            str = webBrowser1.Url.ToString();
            textBox1.Text = str;
            DisplayMetaDescription();

        }
        private void DisplayMetaDescription()
        {
            if (webBrowser1.Document != null)
            {
                HtmlElementCollection elems = webBrowser1.Document.GetElementsByTagName("META");
                foreach (HtmlElement elem in elems)
                {
                    String nameStr = elem.GetAttribute("name");
                    if (nameStr != null && nameStr.Length != 0)
                    {
                        String contentStr = elem.GetAttribute("content");
                        MessageBox.Show("__" + contentStr + "\r\n");
                        //MessageBox.Show("Document: " + webBrowser1.Url.ToString() + "\nDescription: " + contentStr);
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }
       

        
    }
}
