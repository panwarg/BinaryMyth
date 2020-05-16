<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Share.aspx.cs" Inherits="BM.Share" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Share Files</title>
    <link href="css/main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--OnItemCommand="ButtonDownloadContent"--%>
            <asp:DataList ID="files" runat="server" 

                RepeatDirection="Vertical" BorderStyle="None" Style="padding: 0px!important">

                <ItemTemplate>

                    <div style="border: solid; margin: 20px; padding: 20px;">

                        <asp:Label runat="server"
                            Font-Size="XX-Large"
                            Text=' <%# DataBinder.Eval(Container.DataItem,"FileName") %>' />

                        <br /><br />

                        <a runat="server" 
                            href='<%# DataBinder.Eval(Container.DataItem,"DownloadLink") %>'><img runat="server" 
                                src="~/images/download.png" /></a>

                        
                        &nbsp;&nbsp;

                        <a runat="server" 
                            href='<%# DataBinder.Eval(Container.DataItem,"WhatsAppLink") %>'><img runat="server" 
                                src="~/images/whatsapp.png" /></a>

                    </div>

                </ItemTemplate>

            </asp:DataList>

        </div>
    </form>
</body>
</html>
