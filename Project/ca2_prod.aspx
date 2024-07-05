<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ca2_prod.aspx.cs" Inherits="Project.ca2_prod" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 32px;
        }
        .auto-style2 {
            width: 11px;
        }
        .auto-style4 {
            width: 61px;
        }
        .auto-style5 {
            width: 74px;
        }
        .auto-style10 {
            width: 120px;
        }
        .auto-style11 {
            width: 120px;
            height: 32px;
        }
        .auto-style12 {
            height: 32px;
            width: 50px;
        }
        .auto-style13 {
            width: 50px;
        }
        .auto-style14 {
            height: 32px;
            width: 175px;
        }
        .auto-style15 {
            width: 175px;
        }
        .auto-style16 {
            width: 61px;
            height: 32px;
        }
        .auto-style17 {
            width: 74px;
            height: 32px;
        }
        .auto-style18 {
            width: 11px;
            height: 32px;
        }
        .auto-style19 {
            height: 32px;
            width: 12px;
        }
        .auto-style20 {
            width: 12px;
        }
        .auto-style21 {
            margin-top: 19;
        }
        .auto-style22 {
            width: 100%;
        }
        .auto-style23 {
            height: 715px;
        }
        .auto-style25 {
            width: 150px;
        }
        .auto-style26 {
            width: 99px;
        }
        .auto-style27 {
            width: 184px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="1" OnItemCommand="DataList1_ItemCommand">
                    <ItemTemplate>
                        <table class="w-100">
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:ImageButton ID="ImageButton1" runat="server" BorderColor="Black" BorderWidth="1px" Height="334px" ImageUrl='<%# Eval("prod_image") %>' Width="334px" />
                                </td>
                                <td>&nbsp;</td>
                                <td>
                                    <table border="0" class="w-100">
                                        <tr>
                                            <td class="auto-style1">&nbsp;</td>
                                            <td class="auto-style19">&nbsp;</td>
                                            <td class="auto-style1">&nbsp;</td>
                                            <td class="auto-style1">&nbsp;</td>
                                            <td class="auto-style14">&nbsp;</td>
                                            <td class="auto-style12">&nbsp;</td>
                                            <td class="auto-style11"></td>
                                            <td class="auto-style1"></td>
                                            <td class="auto-style19">&nbsp;</td>
                                            <td class="auto-style1">&nbsp;</td>
                                            <td class="auto-style1">&nbsp;</td>
                                            <td class="auto-style1">&nbsp;</td>
                                            <td class="auto-style1">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style1"></td>
                                            <td class="auto-style19"></td>
                                            <td class="auto-style1"></td>
                                            <td class="auto-style1">
                                                <asp:Label ID="Label3" runat="server" Font-Size="Large" ForeColor="Black" Text='<%# Eval("prod_description") %>'></asp:Label>
                                            </td>
                                            <td class="auto-style14"></td>
                                            <td class="auto-style12"></td>
                                            <td class="auto-style11"></td>
                                            <td class="auto-style1"></td>
                                            <td class="auto-style19"></td>
                                            <td class="auto-style1"></td>
                                            <td class="auto-style1"></td>
                                            <td class="auto-style1"></td>
                                            <td class="auto-style1"></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style1"></td>
                                            <td class="auto-style19"></td>
                                            <td class="auto-style1"></td>
                                            <td class="auto-style1">&nbsp;</td>
                                            <td class="auto-style14"></td>
                                            <td class="auto-style12">&nbsp;</td>
                                            <td class="auto-style11"></td>
                                            <td class="auto-style1"></td>
                                            <td class="auto-style19">&nbsp;</td>
                                            <td class="auto-style1">&nbsp;</td>
                                            <td class="auto-style1">&nbsp;</td>
                                            <td class="auto-style1">&nbsp;</td>
                                            <td class="auto-style1">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style20">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Black" Text='<%# Eval("prod_name") %>'></asp:Label>
                                            </td>
                                            <td class="auto-style15">&nbsp;</td>
                                            <td class="auto-style13">&nbsp;</td>
                                            <td class="auto-style10">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style20">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style20">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style15">&nbsp;</td>
                                            <td class="auto-style13">&nbsp;</td>
                                            <td class="auto-style10">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style20">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style20">&nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label4" runat="server" ForeColor="Black" Text="Rs"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label2" runat="server" ForeColor="Black" Text='<%# Eval("prod_prize") %>'></asp:Label>
                                            </td>
                                            <td class="auto-style15">&nbsp;</td>
                                            <td class="auto-style13">&nbsp;</td>
                                            <td class="auto-style10">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style20">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style20">&nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label5" runat="server" ForeColor="Black" Text="Quantity"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                            </td>
                                            <td class="auto-style15">&nbsp;</td>
                                            <td class="auto-style13">
                                                &nbsp;</td>
                                            <td class="auto-style10">&nbsp;</td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please enter the quantity"></asp:RequiredFieldValidator>
                                            </td>
                                            <td class="auto-style20">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style20">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style15">&nbsp;</td>
                                            <td class="auto-style13">&nbsp;</td>
                                            <td class="auto-style10">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style20">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style20">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style15">&nbsp;</td>
                                            <td class="auto-style13">&nbsp;</td>
                                            <td class="auto-style10">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td class="auto-style20">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                                <td class="auto-style20">
                                    &nbsp;</td>
                                <td class="auto-style4">&nbsp;</td>
                                <td class="auto-style5">&nbsp;</td>
                                <td class="auto-style20">&nbsp;</td>
                                <td class="auto-style20">&nbsp;</td>
                                <td class="auto-style2">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <table class="w-100">
                                        <tr>
                                            <td>
                                                <asp:Button ID="Button1" runat="server" CssClass="auto-style21" Font-Bold="True" ForeColor="Black" Text="Add To Cart" Width="153px" CommandName="AddToTheCart"  />
                                            </td>
                                            <td class="auto-style20">
                                                <asp:Button ID="Button2" runat="server" Font-Bold="True" Height="35px" Width="153px"  CommandName="BackToUserPage" Text="Continue" />
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style20">&nbsp;</td>
                                <td class="auto-style4">&nbsp;</td>
                                <td class="auto-style5">&nbsp;</td>
                                <td class="auto-style20">&nbsp;</td>
                                <td class="auto-style20">&nbsp;</td>
                                <td class="auto-style2">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style1"></td>
                                <td class="auto-style1"></td>
                                <td class="auto-style1"></td>
                                <td class="auto-style1"></td>
                                <td class="auto-style19">
                                </td>
                                <td class="auto-style16"></td>
                                <td class="auto-style17"></td>
                                <td class="auto-style19"></td>
                                <td class="auto-style19"></td>
                                <td class="auto-style18"></td>
                                <td class="auto-style1"></td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <table class="auto-style22">
                    <tr>
                        <td class="auto-style27">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style27">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <table class="auto-style22">
                    <tr>
                        <td class="auto-style25">&nbsp;</td>
                        <td class="auto-style26">&nbsp;</td>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
            <td class="auto-style1">
                <table class="auto-style22">
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                <table class="auto-style22">
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style23"></td>
            <td class="auto-style23"></td>
            <td class="auto-style23">
                &nbsp;</td>
            <td class="auto-style23"></td>
            <td class="auto-style23"></td>
            <td class="auto-style23"></td>
        </tr>
        <tr>
            <td class="auto-style23">&nbsp;</td>
            <td class="auto-style23">&nbsp;</td>
            <td class="auto-style23">
                &nbsp;</td>
            <td class="auto-style23">&nbsp;</td>
            <td class="auto-style23">&nbsp;</td>
            <td class="auto-style23">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <table class="auto-style22">
                    <tr>
                        <td>
                            <table class="auto-style22">
                                <tr>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
