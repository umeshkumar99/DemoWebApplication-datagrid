<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Imageuploaddisplay.aspx.cs" Inherits="DemoWebApplication2.Imageuploaddisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
    
        <div>
    <div>
    
    
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
        <br />
        <asp:Image ID="imgDemo" runat="server" Width="200" Height="200" />
    
                </div>
    </div>
    </form>
</body>
</html>
