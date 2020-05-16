<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="BM.Upload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Upload files</title>
    <style>
        body{
            padding: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="fileUploader" runat="server" Font-Size="XX-Large" Width="500px" />
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;
            <asp:Button ID="btnUpload" runat="server" Font-Size="XX-Large" OnClick="btnUpload_Click" Text="Start Upload" />
        </div>
    </form>
</body>
</html>
