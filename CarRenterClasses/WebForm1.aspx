<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CarRental.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <%--INPUT FIELDS--%>

        First Name:        
        <asp:TextBox ID="f_name_txtbox" runat="server"></asp:TextBox>
        <asp:Label ID="lbl_f_name" runat="server"></asp:Label>
        <br />
        Last Name:        
        <asp:TextBox ID="l_name_txtbox" runat="server"></asp:TextBox>
        <asp:Label ID="lbl_l_name" runat="server"></asp:Label>
        <br />
        What is your gender?:
        <asp:RadioButton ID="lbl_gender1" runat="server" GroupName="gender" Text="Female" />
        <asp:RadioButton ID="lbl_gender2" runat="server" GroupName="gender" Text="Male" />
        <asp:Label ID="lbl_gender" runat="server"></asp:Label>
        <br />
        Please enter your date of birth:    
        <input id="input_dob" type="date" runat ="server"/>
        <asp:Label ID="lbl_dob" runat="server"></asp:Label>
        <br />
        Please enter your license place number:        
        <asp:TextBox ID="l_num_txtbox" runat="server"></asp:TextBox>
        <asp:Label ID="lbl_l_num" runat="server"></asp:Label>
        <br />
        What province are you from?        
        <asp:TextBox ID="prov_txtbox" runat="server"></asp:TextBox>
        <asp:Label ID="lbl_prov" runat="server"></asp:Label>
        <div>
        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="button_click" />
        </div>

        <%--RESULTS DISPLAY--%>
        Full name:
        <asp:Label ID="lbl_fullname_result" runat="server"></asp:Label>    
        <asp:Label ID="lbl_fname_result" runat="server"></asp:Label>
        <br />      
        Gender:
        <asp:Label ID="lbl_gender_result" runat="server"></asp:Label>
        <br />
        Age:
        <asp:Label ID="lbl_age_result" runat="server"></asp:Label>
        <br />
        License Number:
        <asp:Label ID="lbl_lnum_result" runat="server"></asp:Label>
        <br />
        Province:
        <asp:Label ID="lbl_province_result" runat="server"></asp:Label>
    </form>
</body>
</html>
