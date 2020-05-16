using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BM
{
    public partial class Upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (!fileUploader.HasFile)
                return;
            var downloadLocation = ConfigurationManager.AppSettings["DownloadLocation"];
            if (string.IsNullOrEmpty(downloadLocation))
                downloadLocation = @"D:\downloads";
            downloadLocation = Path.Combine(downloadLocation, fileUploader.FileName);

            fileUploader.SaveAs(downloadLocation);

        }
    }
}