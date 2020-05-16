using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BM
{
    public partial class Share : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GenerateDownloadLinks();
        }

        private void GenerateDownloadLinks()

        {

            string path = @"D:\downloads"; 
            if (Directory.Exists(path))

            {
                DataTable ShowContent = new DataTable();

                ShowContent.Columns.Add("DownloadLink", typeof(string));

                ShowContent.Columns.Add("FileName", typeof(string));

                ShowContent.Columns.Add("Size", typeof(string));

                ShowContent.Columns.Add("CreatedAt", typeof(string));

                ShowContent.Columns.Add("WhatsAppLink", typeof(string));


                DirectoryInfo di = new DirectoryInfo(path);



                foreach (FileInfo fi in di.GetFiles().OrderByDescending(f => f.LastWriteTime))
                {

                    DataRow dr = ShowContent.NewRow();

                    dr["FileName"] = fi.Name;

                    dr["DownloadLink"] = ResolveUrl("~/downloads/"  + fi.Name);

                    float sizeInMb = fi.Length / (1024 * 1024);

                    dr["Size"] = sizeInMb.ToString() + " MB";

                    dr["CreatedAt"] = fi.LastWriteTime;

                    dr["WhatsAppLink"] = "whatsapp://send?text=https://www.binarymyth.com" + dr["DownloadLink"].ToString();

                    //https://wa.me/whatsappphonenumber/?text=urlencodedtext

                    ShowContent.Rows.Add(dr);
                }

                files.DataSource = ShowContent;

                files.DataBind();

            }

        }
    }
}