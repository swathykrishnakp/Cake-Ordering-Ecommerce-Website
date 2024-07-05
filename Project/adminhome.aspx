<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminhome.aspx.cs" Inherits="Project.adminhome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 32px;
        }
        .auto-style6 {
            width: 129px;
        }
        .auto-style7 {
            height: 32px;
            width: 129px;
        }
        .auto-style16 {
            width: 122px;
        }
        .auto-style17 {
            height: 32px;
            width: 122px;
        }
        .auto-style18 {
            width: 123px;
        }
        .auto-style19 {
            height: 32px;
            width: 123px;
        }
        .auto-style20 {
            width: 119px;
        }
        .auto-style21 {
            height: 32px;
            width: 119px;
        }
        .auto-style22 {
            width: 234px;
        }
        .auto-style23 {
            height: 32px;
            width: 234px;
        }
        .auto-style24 {
            width: 188px;
        }
        .auto-style25 {
            height: 32px;
            width: 188px;
        }
        .auto-style26 {
            width: 211px;
        }
        .auto-style27 {
            height: 32px;
            width: 211px;
        }
        .auto-style30 {
            width: 273px;
        }
        .auto-style31 {
            height: 32px;
            width: 273px;
        }
        .auto-style32 {
            width: 117px;
        }
        .auto-style33 {
            height: 32px;
            width: 117px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
    <tr>
        <td class="auto-style32">
            &nbsp;</td>
        <td class="auto-style6">
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Font-Bold="True">Add Category</asp:LinkButton>
        </td>
        <td class="auto-style16">
            <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click" Font-Bold="True">Edit Category</asp:LinkButton>
        </td>
        <td class="auto-style18">
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" Font-Bold="True">Add Product</asp:LinkButton>
        </td>
        <td class="auto-style20">
            <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click" Font-Bold="True">Edit Product</asp:LinkButton>
        </td>
        <td class="auto-style22">
            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" Font-Bold="True">View Registered UserList</asp:LinkButton>
        </td>
        <td class="auto-style24">
            <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click" PostBackUrl="~/Viewfeedback.aspx" Font-Bold="True">View User Feedback</asp:LinkButton>
        </td>
        <td class="auto-style30">
            <asp:LinkButton ID="LinkButton7" runat="server" Font-Bold="True" OnClick="LinkButton7_Click" PostBackUrl="~/Viewpaid.aspx">VIew Paid orders</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td class="auto-style33">&nbsp;</td>
        <td class="auto-style7"></td>
        <td class="auto-style17"></td>
        <td class="auto-style19"></td>
        <td class="auto-style21"></td>
        <td class="auto-style23"></td>
        <td class="auto-style25"></td>
        <td class="auto-style31">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style32">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style16">&nbsp;</td>
        <td class="auto-style18">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td class="auto-style24">&nbsp;</td>
        <td class="auto-style30">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style32">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style16">&nbsp;</td>
        <td class="auto-style18">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td class="auto-style24">&nbsp;</td>
        <td class="auto-style30">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style32">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style16">&nbsp;</td>
        <td class="auto-style18">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td class="auto-style24">&nbsp;</td>
        <td class="auto-style30">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style33">&nbsp;</td>
        <td class="auto-style7"></td>
        <td class="auto-style17"></td>
        <td class="auto-style19"></td>
        <td class="auto-style21"></td>
        <td class="auto-style23"></td>
        <td class="auto-style25"></td>
        <td class="auto-style31">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style32">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style16">&nbsp;</td>
        <td class="auto-style18">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td class="auto-style24">&nbsp;</td>
        <td class="auto-style30">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style32">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style16">&nbsp;</td>
        <td class="auto-style18">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td class="auto-style24">&nbsp;</td>
        <td class="auto-style30">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style32">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style16">&nbsp;</td>
        <td class="auto-style18">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td class="auto-style24">&nbsp;</td>
        <td class="auto-style30">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style32">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style16">&nbsp;</td>
        <td class="auto-style18">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td class="auto-style24">&nbsp;</td>
        <td class="auto-style30">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style32">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style16">&nbsp;</td>
        <td class="auto-style18">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td class="auto-style24">&nbsp;</td>
        <td class="auto-style30">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style32">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style16">&nbsp;</td>
        <td class="auto-style18">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td class="auto-style24">&nbsp;</td>
        <td class="auto-style30">&nbsp;</td>
    </tr>
</table>
</asp:Content>
