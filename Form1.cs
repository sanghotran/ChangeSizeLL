using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChangeSizeLangLa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            MySize mySize = null;
            try
            {
                try
                {
                    File.Delete(this.string_0);
                }catch(Exception ex)
                {
                }

                try
                {
                    fileStream = new FileStream(this.string_0, FileMode.Create);
                    mySize = new MySize(fileStream);
                    mySize.ChangeSize((short)this.Width.Value);
                    mySize.ChangeSize((short)this.Height.Value);
                }catch(Exception ex)
                {
                }
                for(int i = 0; i < 10000; i++)
                {
                    try
                    {
                        File.Delete(string.Concat(new object[]
                        {
                            this.string_1,
                            "\\mapmini_",
                            i,
                            ".bin"
                        }));
                    }catch(Exception ex)
                    {

                    }
                    try
                    {
                        File.Delete(string.Concat(new object[]
                        {
                            this.string_1,
                            "\\mapscale_",
                            i,
                            ".bin"
                        }));
                    }catch (Exception ex)
                    {

                    }
                    try
                    {
                        File.Delete(string.Concat(new object[]
                        {
                            this.string_1,
                            "\\arr_map_",
                            i,
                            ".bin"
                        }));
                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        File.Delete(string.Concat(new object[]
                        {
                            this.string_1,
                            "\\arr_check_",
                            i,
                            ".bin"
                        }));
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }catch (Exception ex)
            {
            }
            finally
            {
                if(fileStream != null)
                    fileStream.Close();
                if(mySize != null)
                    mySize.Close();
                MessageBox.Show("Done");
            }
        }

        private string string_0 = string.Empty;
        private string string_1 = string.Empty;
        private string string_2 = string.Empty;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.string_2 = Environment.UserName;//System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            this.string_1 = "C:\\Users\\" + this.string_2 + "\\" +"animesoft";
            this.string_0 = this.string_1 + "\\" + "arr_sc.bin";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\LangLa\\LangLa.exe");
        }
    }
}
