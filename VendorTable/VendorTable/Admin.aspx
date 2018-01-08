<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="VendorTable.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

<br />
<br />
VENDORS TABLES
<br />
    <asp:Label ID="lbl_contraints" runat="server"></asp:Label>
<br />

<%--= = = = = = = = = = TABLE = = = = = = = = = = = = = =--%>

     <asp:Table ID="table_vendors" runat="server" BorderWidth="1px" BorderColor="Blue" BorderStyle="Dashed">
        <asp:TableHeaderRow>

            <%--vendor ID column--%>
            <asp:TableHeaderCell>Vendor ID
                <ul id="ul_vendor_id" runat="server"><li></li></ul>
           </asp:TableHeaderCell>

            <%--vendor name column--%>
            <asp:TableHeaderCell>Vendor Name
                <ul id="ul_vname" runat="server"><li></li></ul>
            </asp:TableHeaderCell>

            <%--vendor address 1 column--%>
            <asp:TableHeaderCell>Vendor Address 1
                <ul id="ul_v_address1" runat="server"><li></li></ul>
            </asp:TableHeaderCell>

            <%--vendor address 2 column--%>                                      
            <asp:TableHeaderCell>Vendor Address 2
                <ul id="ul_v_address2" runat="server"><li></li></ul>
            </asp:TableHeaderCell>
     
            <%--vendor city column--%>
            <asp:TableHeaderCell>Vendor City
                <ul id="ul_vendor_city" runat="server"><li></li></ul>
            </asp:TableHeaderCell>

            <%--vendor state column--%>
            <asp:TableHeaderCell>Vendor State
                <ul id="ul_vendor_state" runat="server"><li></li></ul>
            </asp:TableHeaderCell>
            
            <%--vendor zip code column--%>
            <asp:TableHeaderCell>Vendor Zip Code
                <ul id="ul_vendor_zip_code" runat="server"><li></li></ul>
            </asp:TableHeaderCell>

        </asp:TableHeaderRow>
    </asp:Table>


   <%-- = = = = = = = = = = FORM = = = = = = = = = = = = = =--%>

    <form id="form1" runat="server">
        <asp:Label ID="lbl_oracle_message" runat="server"></asp:Label>
        <br />
        ______________________________________________
        <br />
        <br />

        ADD VENDOR
        <br />
        _______________________________________________
        <br />

        <br />
        <asp:Label ID="lbl_vid" runat="server">Vendor Id (required feild):</asp:Label>
        <asp:TextBox ID="txtbox_add_vendor_id" runat="server"></asp:TextBox>
        
        <br />
        <asp:Label ID="lbl_vname" runat="server">Vendor Name:</asp:Label>
        <asp:TextBox ID="txtbox_add_vendor_name" runat="server"></asp:TextBox>

        <br />
        <asp:Label ID="lbl_v_add1" runat="server">Vendor Address 1:</asp:Label>
        <asp:TextBox ID="txtbox_add_vendor_address1" runat="server"></asp:TextBox>

        <br />
        <asp:Label ID="lbl_v_add2" runat="server">Vendor Address 2:</asp:Label>
        <asp:TextBox ID="txtbox_add_vendor_address2" runat="server"></asp:TextBox>

        <br />
        <asp:Label ID="lbl_v_city" runat="server">Vendor City:</asp:Label>
        <asp:TextBox ID="txtbox_add_vendor_city" runat="server"></asp:TextBox>
        
        <br />
        <asp:Label ID="lbl_v_state" runat="server">Vendor State:</asp:Label>
        <asp:TextBox ID="txtbox_add_vendor_state" runat="server"></asp:TextBox>

        <br />
        <asp:Label ID="lbl_v_zipcode" runat="server">Vendor Zip Code:</asp:Label>
        <asp:TextBox ID="txtbox_add_vendor_zipcode" runat="server"></asp:TextBox>




        <asp:Button ID="btn_add_vendor" runat="server" OnClick="btn_add_vendor_Click" Text="Add Vendor"/>
        <asp:Button ID="btb_refresh1" runat="server" OnClick="btn_refresh1_Click" Text="Refresh Table Above" />

        <br />
        _______________________________________________
        <br />
        <br />
        UPDATE EXISTING VENDOR INFORMATION
        <br />
        _______________________________________________
        <br />
        <br />
        <asp:Label ID="lbl_drpdwnvid" runat="server">Vendor Id (required feild):</asp:Label>
        <asp:DropDownList ID="drpdwn_v_id" runat="server"></asp:DropDownList>
        
        <br />
        <asp:Label ID="lbl_vname_up" runat="server">Vendor Name:</asp:Label>
        <asp:TextBox ID="txtbox_up_vendor_name" runat="server"></asp:TextBox>

        <br />
        <asp:Label ID="lbl_v_add1_up" runat="server">Vendor Address 1:</asp:Label>
        <asp:TextBox ID="txtbox_up_vendor_address1" runat="server"></asp:TextBox>

        <br />
        <asp:Label ID="lbl_v_add2_up" runat="server">Vendor Address 2:</asp:Label>
        <asp:TextBox ID="txtbox_up_vendor_address2" runat="server"></asp:TextBox>

        <br />
        <asp:Label ID="lbl_v_city_up" runat="server">Vendor City:</asp:Label>
        <asp:TextBox ID="txtbox_up_vendor_city" runat="server"></asp:TextBox>
        
        <br />
        <asp:Label ID="lbl_v_state_up" runat="server">Vendor State:</asp:Label>
        <asp:TextBox ID="txtbox_up_state_state" runat="server"></asp:TextBox>

        <br />
        <asp:Label ID="lbl_v_zipcode_up" runat="server">Vendor Zip Code:</asp:Label>
        <asp:TextBox ID="txtbox_v_zipcode_up" runat="server"></asp:TextBox>

        <asp:Button ID="btn_up_vendor" runat="server" OnClick="btn_up_vendor_Click" Text="Update Vendor Info"/>
        <asp:Button ID="btb_refresh2" runat="server" OnClick="btn_refresh2_Click" Text="Refresh Table Above" />


        <br />
        _______________________________________________
        <br />
        <br />
        DELETE VENDOR
        <br />
        _______________________________________________
        <br />
        <asp:Label ID="lbl_delete_v" runat="server">Vendor Id (required feild):</asp:Label>
        <asp:DropDownList ID="drpdwn_v_id_delete" runat="server"></asp:DropDownList>
        <asp:Button ID="btn_delete_vendor" runat="server" OnClick="btn_delete_vendor_Click" Text="Delete Vendor"/>
        <asp:Button ID="btn_refresh3" runat="server" OnClick="btn_refresh3_Click" Text="Refresh Table Above" />
    </form>


</body>
</html>
