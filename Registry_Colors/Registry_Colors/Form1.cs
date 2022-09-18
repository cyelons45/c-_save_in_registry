using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Registry_Colors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.colorDialog1.ShowDialog();
                this.color_textBox1.BackColor = this.colorDialog1.Color;

                //Color convert
                ColorConverter cc = new ColorConverter();

                string cn = cc.ConvertToString(this.color_textBox1.BackColor);

                //Save in registry
                Microsoft.Win32.RegistryKey k;
                k = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\cyelons45\\POS", true);
                if (k == null)
                {
                    k = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\cyelons45\\POS", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);

                }
                k.SetValue("Back_Color", cn);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
  
        }

        private IDictionary<string,string> load_font(string path, string fontname, string textname)
        {
           

            try
            {
                IDictionary<string, string> d = new Dictionary<string, string>();


                Microsoft.Win32.RegistryKey k;
                k = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(path, true);
                if (k != null)
                {
                    d.Add(new KeyValuePair<string, string>("font", k.GetValue(fontname, "Microsoft YaHei UI, 14.25pt, style=Bold").ToString()));
                    d.Add(new KeyValuePair<string, string>("text", k.GetValue(textname, "").ToString()));
                    return d;
                };
                return null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
    

        }



        private string load_color(string path, string color_name)
        {


            try
            {
                Microsoft.Win32.RegistryKey k;
                k = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(path, true);
                if (k != null)
                {
                    return k.GetValue(color_name, "White").ToString();
                }
                return null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
           
        }

        private string load_size(string path, string size_name)
        {


            try
            {
                Microsoft.Win32.RegistryKey k;
                k = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(path, true);
                if (k != null)
                {
                    return k.GetValue(size_name, "492,40").ToString();
                }
                return null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.colorDialog1.ShowDialog();
                this.color_textBox1.ForeColor = this.colorDialog1.Color;

                //Color convert
                ColorConverter cc = new ColorConverter();

                string cn = cc.ConvertToString(this.color_textBox1.ForeColor);
                //Save in registry
                Microsoft.Win32.RegistryKey k;
                k = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("software\\cyelons45\\POS", true);
                if (k == null)
                {
                    k = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("software\\cyelons45\\POS", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);
                }
                k.SetValue("Fore_Color", cn);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
              
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Text", this.font_textBox1.Text);
                //k.SetValue("Font


                ColorConverter cc = new ColorConverter();
                FontConverter fc = new FontConverter();

                IDictionary<string,string> fontstr=load_font("SOFTWARE\\cyelons45\\POS", "Font", "Text");
                var forecolor = load_color("SOFTWARE\\cyelons45\\POS", "Fore_Color");
                var backcolor = load_color("SOFTWARE\\cyelons45\\POS", "Back_Color");
                if (forecolor != null)
                {
                    this.color_textBox1.ForeColor = (Color)cc.ConvertFromString(forecolor);
                }
                if (backcolor != null)
                {
                    this.color_textBox1.BackColor = (Color)cc.ConvertFromString(backcolor);
                }


                if (fontstr!=null)
                {
                    var font=fontstr["font"];
                    var text = fontstr["text"];
                    this.font_textBox1.Text = text;
                    this.font_textBox1.Font = (Font)fc.ConvertFromString(font);
                
                }

                //Load size
                var size = load_size("SOFTWARE\\cyelons45\\POS", "size");
                SizeConverter sc = new SizeConverter();
                var nwsize = sc.ConvertFromString(size);
                this.size_textBox1.Size = (Size)nwsize;
                this.trackBar1.Value = this.size_textBox1.Size.Width;
                this.trackBar2.Value = this.size_textBox1.Size.Height;



                //Load location
                string loc=load_location("SOFTWARE\\cyelons45\\POS", "location");
                PointConverter location = new PointConverter();
                var ln = location.ConvertFromString(loc);
                this.location_textBox1.Location=(Point)ln;
                this.x_trackBar3.Value = this.location_textBox1.Location.X;
                this.y_trackBar4.Value = this.location_textBox1.Location.Y;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.fontDialog1.ShowDialog();
                var fc = new FontConverter();
                var fontstr = fc.ConvertToString(this.fontDialog1.Font);
                this.font_textBox1.Font = this.fontDialog1.Font;


                Microsoft.Win32.RegistryKey k;
                k = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("software\\cyelons45\\POS", true);
                if (k == null)
                {
                    k = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("software\\cyelons45\\POS", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);
                }
                k.SetValue("Text", this.font_textBox1.Text);
                k.SetValue("Font", fontstr);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.size_textBox1.Size = new Size(this.trackBar1.Value, this.size_textBox1.Size.Height);
           
        }

        private void store_size(System.Drawing.Size textbox_size)
        {
            //Size convert
            SizeConverter sc = new SizeConverter();

            string sn = sc.ConvertToString(new Size((Point)textbox_size));
            //Save in registry
            Microsoft.Win32.RegistryKey k;
            k = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("software\\cyelons45\\POS", true);
            if (k == null)
            {
                k = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("software\\cyelons45\\POS", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);
            }
            k.SetValue("size", sn);

        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            this.size_textBox1.Size = new Size(this.size_textBox1.Size.Width,  this.trackBar2.Value);
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            store_size(this.size_textBox1.Size);
            MessageBox.Show("Changes Saved", "Success");


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //location

        private void store_location(int X,int Y)
        {
            PointConverter location= new PointConverter();
            var ln=location.ConvertToString(new Point(X,Y));
            //Save in registry
            Microsoft.Win32.RegistryKey k;
            k = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("software\\cyelons45\\POS", true);
            if (k == null)
            {
                k = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("software\\cyelons45\\POS", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);
            }
            k.SetValue("location", ln);

        }


        private string load_location(string path,string location)
        {
            try
            {
                Microsoft.Win32.RegistryKey k;
                k = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(path, true);
                if (k != null)
                {
                    return k.GetValue(location, "28, 107").ToString();
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        private void x_trackBar3_ValueChanged(object sender, EventArgs e)
        {
            this.location_textBox1.Location=new Point(this.x_trackBar3.Value, this.location_textBox1.Location.Y);
           
        }

        private void y_trackBar4_ValueChanged(object sender, EventArgs e)
        {
            this.location_textBox1.Location = new Point(this.location_textBox1.Location.X, this.y_trackBar4.Value);
           
        }

        private void y_trackBar4_Scroll(object sender, EventArgs e)
        {

        }

        private void location_save_button5_Click(object sender, EventArgs e)
        {
            store_location(this.x_trackBar3.Value, this.location_textBox1.Location.Y);
            MessageBox.Show("Changes Saved", "Success");
        }
    }
}
