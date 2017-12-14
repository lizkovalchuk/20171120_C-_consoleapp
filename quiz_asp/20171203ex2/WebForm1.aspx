<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_20171203ex2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <%--Question 1--%>
        <div>
            What is the capital of Latvia?
           <asp:TextBox ID="capital_textbox" runat="server"></asp:TextBox>
            <asp:Label ID="capital_label" runat="server"></asp:Label>
        </div>

        <%--Question 2--%>
        <div>
            How many provinces does Canada have?
            <asp:TextBox ID="province_textbox" runat="server"></asp:TextBox>
            <asp:Label ID="province_label" runat="server"></asp:Label>
        </div>

        <%--Question 3--%>
        <div>
            How many subway lines does Toronto have?
            <asp:TextBox ID="subway_textbox" runat="server"></asp:TextBox>
            <asp:Label ID="subway_label" runat="server"></asp:Label>
        </div>

        <%--Question 4--%>
        <div>
            If a tree falls in a forest, and no one hears, does it make a sound?
            <asp:RadioButton ID="tree1" runat="server" GroupName="tree" Text="Yes"/>
            <asp:RadioButton ID="tree2" runat="server" GroupName="tree" Text="No" Checked="true"></asp:RadioButton>
            
        </div>

        <%--Question 5--%>
        <div>
            Do you lift?
            <asp:RadioButton ID="lift1" runat="server" GroupName="lift" Text="Yes" />
            <asp:RadioButton ID="lift2" runat="server" GroupName="lift" Text="No" Checked="true" />
           
        </div>

        <%--Button and Results--%>
        <div>
            <asp:Button ID="Submit" runat="server" Text="Quiz Me" OnClick="button_click"></asp:Button>
        </div>

        <div>
            <asp:Label ID="Result" runat="server"></asp:Label>
        </div>

    </form>
</body>
</html>
