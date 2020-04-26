<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test1.aspx.cs" Inherits="test.Test1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        html {
            background-color: silver;
        }
        .tabs {
            position: relative;
            top: 1px;
            left: 10px;
        }
        .tab{
            border:solid 1px black;
            background-color:dimgray;
            padding:5px 10px;
        }
        .selectedTab
        {
            background-color:white;
            border-bottom:solid 1px white;
        }
        .tabContents{
            border: solid 1px black;
            padding: 10px;
            background-color:white;
        }
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" Orientation ="Horizontal"  StaticMenuItemStyle-CssClass="tab" Font-Size ="Large"
                StaticSelectedStyle-CssClass="selectedTab" StaticMenuItemStyle-HorizontalPadding="50px"
                StaticSelectedStyle-BackColor ="White" CssClass="tabs" runat="server" OnMenuItemClick="Menu1_MenuItemClick">
            <Items>
                <asp:MenuItem Text="Product list" Value="0" Selected="true"></asp:MenuItem>
                <asp:MenuItem Text="Product details" Value="1"></asp:MenuItem>
            </Items>
            </asp:Menu>

            <div class="tabContents">
                <asp:Multiview ID="Multiview1" ActiveViewIndex="0" runat="server">
                    <asp:View ID="View1" runat="server">
                        <asp:DropDownList ID="SortList" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>
                        <br />
                        <br />
                        <asp:Panel ID="MasterPanel" runat="server" BorderStyle="Inset" Height="392px" Width="666px" HorizontalAlign="Left" ScrollBars="Auto">
                        </asp:Panel>
                        <br />
                        <br />
                        <br />
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                        Product Details
                        <asp:Panel ID="Panel3" runat="server" BorderStyle="Inset" Height="343px" Width="536px">
                            <asp:Image ID="D_ProdImg1" runat="server" Height="64px" ImageAlign="Left" Width="64px" style="margin-top: 33px" />
                            <asp:Label ID="D_ProdTitle" runat="server" Text="Product Title"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Panel ID="D_Prod_Description" runat="server" Height="86px" Width="485px">
                                Product Description:Description<br />
                                <asp:Label ID="D_Price" runat="server" Text="Price:"></asp:Label>
                            </asp:Panel>
                            <asp:Panel ID="Panel5" runat="server" Height="164px">
                                Specifications<br />
                                <br />
                                <asp:Label ID="D_spec1" runat="server" Text="Label"></asp:Label>
                                <br />
                                <asp:Label ID="D_spec2" runat="server" Text="Label"></asp:Label>
                                <br />
                                <asp:Label ID="D_spec3" runat="server" Text="Label"></asp:Label>
                                <br />
                                <asp:Label ID="D_spec4" runat="server" Text="Label"></asp:Label>
                            </asp:Panel>
                        </asp:Panel>

                    </asp:View>
                    </asp:Multiview>
            </div>
        </div>
    </form>
</body>
</html>
