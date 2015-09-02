<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="main_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<body>
    <form id="form1" runat="server">
    
     <p>
         &nbsp;</p>
        <p>
            <asp:TextBox ID="error" runat="server" BorderStyle="None" EnableTheming="False" ForeColor="Red" Visible="False" Width="219px">	Invalid Username / Password</asp:TextBox>
        </p>
        <p>
         Username
         <asp:TextBox ID="userName" runat="server"></asp:TextBox>
        </p>
     <p>
         Password 
         <asp:TextBox ID="password" runat="server"></asp:TextBox>
        </p>
    </form>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" />

</body>
</html>

    
   
