<%@ Control Language="C#" AutoEventWireup="true"  CodeFile="in_ts.ascx.cs" Inherits="ivfyonetici_hasta_modulu_in_ts" %>

<style type="text/css">
    .style1
    {
        font-family: Arial, Helvetica, sans-serif;
        font-size: 11px;
    }
    .style222
    {
        height: 21px;
        width: 173px;
    }
    .style3
    {
        height: 21px;
        width: 8px;
    }
    .style444
    {
        width: 100%;
    }
    .style555
    {
        width: 129px;
    }
</style>

<table border="0" cellpadding="0" id = "tsson" runat=Server cellspacing="0" style="width: 96%" align=center>
    <tr>
        <td><asp:Panel ID="snc" runat="server" Visible="False" Width="99%">
                    <table align="center" border="0" cellpadding="0" cellspacing="0" width="100%" style="border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                        <tr>
                            <td valign="top">
                                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                    <tr>
                                        <td style="border-bottom-width: 1px; border-bottom-color: #d3d3d3; height: 22px; font-size: 12pt; font-family: Times New Roman; border-top-width: 1px; border-top-color: #d3d3d3; border-right-style: none; border-left-style: none;" valign="top">
                                            <asp:Panel ID="Panel4" runat="server" Width="100%">
                                                <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; border-bottom-width: 1px; border-bottom-color: lightgrey; border-top-style: none; border-right-style: none; border-left-style: none;" height="24">
                                                    <tr>
                                                        <td background="images/ust_menu_bg.jpg" class="style3">
                                                        </td>
                                                        <td background="images/ust_menu_bg.jpg" style="width: 20px; height: 21px">
                                                            <img id="ac1" src="images/ac.gif" runat="server" onclick ="ac();" /><img id="kapa1" runat="server" src="images/kapat.gif" onclick ="kapa();" style ="display:none;" /></td>
                                                        <td style="text-align: left; " background="images/ust_menu_bg.jpg" 
                                                            class="style222">
                                                            <table cellpadding="0" cellspacing="0" class="style444">
                                                                <tr>
                                                                    <td class="style555">
                                                                        <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                            Font-Size="11px">Takipli Siklus</asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Button ID="Button7" runat="server" BackColor="White" BorderColor="DimGray" 
                                                                            BorderStyle="Solid" BorderWidth="1px" Font-Names="Arial" Font-Size="11px" 
                                                                            ForeColor="Black" Height="20px" OnClick="Button7_Click" 
                                                                            OnClientClick="return confirm('Bu siklus aktif siklus olarak ayarlanacaktır.Onaylıyor musunuz?')" 
                                                                            Text="Aktif Siklus Yap" Width="86px" Visible="False" />
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            </td>
                                                        <td style="text-align: right; height: 21px; font-size: 12pt; font-family: Times New Roman;" background="images/ust_menu_bg.jpg" valign="middle">
                                                            <asp:Button ID="Button2" runat="server" BackColor="White" BorderColor="#E0E0E0" BorderStyle="Solid"
                                                                Font-Names="Arial" Font-Size="11px" ForeColor="#CC0000" OnClick="Button2_Click"
                                                                OnClientClick="return confirm('Bu siklus başlangıç siklusu olarak kalacaktır.Onaylıyormusunuz?')"
                                                                Text="Bu Siklus Başlangıç Siklusu Olarak Kalsın" Width="207px" />
                                                            <asp:Button ID="Button1" runat="server" BackColor="White" BorderColor="#E0E0E0" BorderStyle="Solid"
                                                                Font-Names="Arial" Font-Size="11px" ForeColor="#CC0000" OnClick="Button1_Click"
                                                                OnClientClick="return confirm('Bu siklus başlangıç siklusundan çıkartılıp normal siklus haline getirilecektir.Onaylıyormusunuz?')"
                                                                Text="Bu Siklusu Normal Siklus Haline Getir " Width="186px" />
                                                            &nbsp;<asp:Label ID="Label8" runat="server" CssClass="style1" Font-Bold="True" 
                                                                Text=" Dr : "></asp:Label>
                                                            <asp:Label ID="lblDr" runat="server" CssClass="style1"></asp:Label>
                                                            <asp:DropDownList ID="dr" runat="server" BackColor="White" SkinID="drop" 
                                                                Visible="False">
                                                            </asp:DropDownList>
                                                            &nbsp;<asp:Label ID="Label9" runat="server" CssClass="style1" Font-Bold="True"> Sonraki Kontrol : </asp:Label>
                                                            <asp:DropDownList ID="sonrakiKontrol" runat="server" BackColor="White" 
                                                                SkinID="drop" Visible="False">
                                                            </asp:DropDownList>
                                                            <asp:Label ID="lblSonrakiKontrol" runat="server" CssClass="style1"></asp:Label>
                                                            &nbsp;<asp:Label ID="Label12" runat="server" CssClass="style1" Font-Bold="True"> İstenecek Tetkikler : </asp:Label>
                                                            <asp:Label ID="lblistenecek" runat="server" CssClass="style1"></asp:Label>
                                                            <asp:DropDownList ID="istenecek" runat="server" BackColor="White" 
                                                                SkinID="drop" Visible="False">
                                                                <asp:ListItem Text="Seçiniz" Value=""></asp:ListItem>
                                                                <asp:ListItem>e2</asp:ListItem>
                                                                <asp:ListItem>FSH,LH,e2</asp:ListItem>
                                                                <asp:ListItem>e2,LH</asp:ListItem>
                                                                <asp:ListItem>e2,LH,Prog</asp:ListItem>
                                                            </asp:DropDownList>
                                                            &nbsp;<asp:ImageButton ID="Button6" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/imgs/btntabloekle.gif"
                                                                OnClick="Button6_Click1" OnClientClick="return confirm('Tablo Eklemek İstediğinize Emin Misiniz?')"
                                                                Visible="False" />
                                                            <asp:ImageButton ID="Button4" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/imgs/btn_kaydet.gif"
                                                                OnClick="Button4_Click1" OnClientClick="return confirm('Değişiklikleri Kaydetmek İstediğinize Emin misiniz?')"
                                                                Visible="False" />&nbsp;<asp:ImageButton ID="Button5" runat="server" ImageAlign="AbsMiddle"
                                                                    ImageUrl="~/imgs/btniptl.gif" OnClick="Button5_Click1" Visible="False" />
                                                            <asp:ImageButton ID="Button3" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/btnguncelle.gif"
                                                                OnClick="Button3_Click1" Visible="False" />
                                                         &nbsp;
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </td>
                                    </tr>
                                </table>
                                
                                
                               
                                <asp:Panel ID="Panel5" runat="server" Visible="False" Width="100%">
                                    <table border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1px; width: 100%; border-top-color: #d3d3d3; border-left-width: 1px; border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3;">
                                        <tr>
                                            <td style="height: 30px; text-align: center">
                                                <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                                    ForeColor="Black"></asp:Label></td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td valign="top" id="Td2">
                                <div id="gizlenecek" runat="server" style="width:100% ; display:none">
                               
                                <asp:Panel ID="ts1" runat="server" Width="100%">
                                    <table style="width: 100%">
                                        <tr>
                                            <td bgcolor="lightgrey" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                font-size: 11px; border-left: lightgrey 1px solid; width: 108px; color: black;
                                                border-bottom: lightgrey 1px solid; font-family: arial; text-align: right;
                                                text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label></td>
                                            <td align="center" bgcolor="lightgrey" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr1" runat="server" Font-Names="Arial" Font-Size="11px"></asp:Label></td>
                                            <td align="center" bgcolor="lightgrey" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                &nbsp;<asp:Label ID="tr2" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="lightgrey" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr3" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="lightgrey" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr4" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="lightgrey" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr5" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="lightgrey" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr6" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="lightgrey" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr7" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="lightgrey" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr8" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="lightgrey" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr9" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr10" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr11" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr12" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr13" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr14" runat="server"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="ghostwhite" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-align: right; text-decoration: none; background-color: lightblue;">
                                                SİKLUS GÜNÜ</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                1</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                2</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                3</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                4</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                5</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                6</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                7</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                8</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                9</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                10</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                11</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                12</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                13</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                14</td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; text-decoration: none; background-color: white;" bgcolor="#ffffff">
                                                <asp:DropDownList ID="txtalnbaslik" runat="server" Visible="False" SkinID="drop">
                                                </asp:DropDownList><asp:Label ID="alnbaslik" runat="server" Font-Names="Arial" Font-Size="11px" Font-Bold="True"></asp:Label></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="aln1" runat="server"></asp:Label><asp:TextBox ID="txtaln1" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="aln2" runat="server"></asp:Label><asp:TextBox ID="txtaln2" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="aln3" runat="server"></asp:Label><asp:TextBox ID="txtaln3" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="aln4" runat="server"></asp:Label><asp:TextBox ID="txtaln4" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="aln5" runat="server"></asp:Label><asp:TextBox ID="txtaln5" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="aln6" runat="server"></asp:Label><asp:TextBox ID="txtaln6" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="aln7" runat="server"></asp:Label><asp:TextBox ID="txtaln7" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="aln8" runat="server"></asp:Label><asp:TextBox ID="txtaln8" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="aln9" runat="server"></asp:Label><asp:TextBox ID="txtaln9" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="aln10" runat="server"></asp:Label><asp:TextBox ID="txtaln10" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="aln11" runat="server"></asp:Label><asp:TextBox ID="txtaln11" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="aln12" runat="server"></asp:Label><asp:TextBox ID="txtaln12" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="aln13" runat="server"></asp:Label><asp:TextBox ID="txtaln13" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="aln14" runat="server"></asp:Label><asp:TextBox ID="txtaln14" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid; font-weight: normal;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:DropDownList ID="txtikibaslik" runat="server" Visible="False" SkinID="drop">
                                                </asp:DropDownList><asp:Label ID="ikibaslik" runat="server" Font-Names="Arial" Font-Size="11px" Font-Bold="True"></asp:Label></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="iki1" runat="server"></asp:Label><asp:TextBox ID="txtiki1" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="iki2" runat="server"></asp:Label><asp:TextBox ID="txtiki2" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="iki3" runat="server"></asp:Label><asp:TextBox ID="txtiki3" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="iki4" runat="server"></asp:Label><asp:TextBox ID="txtiki4" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="iki5" runat="server"></asp:Label><asp:TextBox ID="txtiki5" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="iki6" runat="server"></asp:Label><asp:TextBox ID="txtiki6" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="iki7" runat="server"></asp:Label><asp:TextBox ID="txtiki7" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="iki8" runat="server"></asp:Label><asp:TextBox ID="txtiki8" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="iki9" runat="server"></asp:Label><asp:TextBox ID="txtiki9" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="iki10" runat="server"></asp:Label><asp:TextBox ID="txtiki10" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="iki11" runat="server"></asp:Label><asp:TextBox ID="txtiki11" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="iki12" runat="server"></asp:Label><asp:TextBox ID="txtiki12" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="iki13" runat="server"></asp:Label><asp:TextBox ID="txtiki13" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="iki14" runat="server"></asp:Label><asp:TextBox ID="txtiki14" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; text-decoration: none" bgcolor="#ffffff">
                                                <asp:DropDownList ID="txtucbaslik" runat="server" Visible="False" SkinID="drop">
                                                </asp:DropDownList><asp:Label ID="ucbaslik" runat="server" Font-Names="Arial" Font-Size="11px" Font-Bold="True"></asp:Label></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="uc1" runat="server"></asp:Label><asp:TextBox ID="txtuc1" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="uc2" runat="server"></asp:Label><asp:TextBox ID="txtuc2" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="uc3" runat="server"></asp:Label><asp:TextBox ID="txtuc3" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="uc4" runat="server"></asp:Label><asp:TextBox ID="txtuc4" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="uc5" runat="server"></asp:Label><asp:TextBox ID="txtuc5" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="uc6" runat="server"></asp:Label><asp:TextBox ID="txtuc6" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none;" bgcolor="#ffffff">
                                                <asp:Label ID="uc7" runat="server"></asp:Label><asp:TextBox ID="txtuc7" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none;" bgcolor="#ffffff">
                                                <asp:Label ID="uc8" runat="server"></asp:Label><asp:TextBox ID="txtuc8" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none;">
                                                <asp:Label ID="uc9" runat="server"></asp:Label><asp:TextBox ID="txtuc9" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none;">
                                                <asp:Label ID="uc10" runat="server"></asp:Label><asp:TextBox ID="txtuc10" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none;">
                                                <asp:Label ID="uc11" runat="server"></asp:Label><asp:TextBox ID="txtuc11" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none;">
                                                <asp:Label ID="uc12" runat="server"></asp:Label><asp:TextBox ID="txtuc12" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none;">
                                                <asp:Label ID="uc13" runat="server"></asp:Label><asp:TextBox ID="txtuc13" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none;">
                                                <asp:Label ID="uc14" runat="server"></asp:Label><asp:TextBox ID="txtuc14" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid; font-weight: normal;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:DropDownList ID="txtdortbaslik" runat="server" Visible="False" SkinID="drop">
                                                </asp:DropDownList><asp:Label ID="dortbaslik" runat="server" Font-Names="Arial" Font-Size="11px" Font-Bold="True"></asp:Label></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="dort1" runat="server"></asp:Label><asp:TextBox ID="txtdort1" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="dort2" runat="server"></asp:Label><asp:TextBox ID="txtdort2" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="dort3" runat="server"></asp:Label><asp:TextBox ID="txtdort3" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="dort4" runat="server"></asp:Label><asp:TextBox ID="txtdort4" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="dort5" runat="server"></asp:Label><asp:TextBox ID="txtdort5" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="dort6" runat="server"></asp:Label><asp:TextBox ID="txtdort6" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="dort7" runat="server"></asp:Label><asp:TextBox ID="txtdort7" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="dort8" runat="server"></asp:Label><asp:TextBox ID="txtdort8" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="dort9" runat="server"></asp:Label>
                                                <asp:TextBox ID="txtdort9" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="dort10" runat="server"></asp:Label><asp:TextBox ID="txtdort10" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="dort11" runat="server"></asp:Label><asp:TextBox ID="txtdort11" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="dort12" runat="server"></asp:Label><asp:TextBox ID="txtdort12" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="dort13" runat="server"></asp:Label><asp:TextBox ID="txtdort13" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="dort14" runat="server"></asp:Label><asp:TextBox ID="txtdort14" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; text-decoration: none" bgcolor="#ffffff">
                                                <asp:DropDownList ID="txtbesbaslik" runat="server" Visible="False" SkinID="drop">
                                                </asp:DropDownList><asp:Label ID="besbaslik" runat="server" Font-Names="Arial" Font-Size="11px" Font-Bold="True"></asp:Label></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="bes1" runat="server"></asp:Label><asp:TextBox ID="txtbes1" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="bes2" runat="server"></asp:Label><asp:TextBox ID="txtbes2" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="bes3" runat="server"></asp:Label><asp:TextBox ID="txtbes3" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="bes4" runat="server"></asp:Label><asp:TextBox ID="txtbes4" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="bes5" runat="server"></asp:Label><asp:TextBox ID="txtbes5" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none" bgcolor="#ffffff">
                                                <asp:Label ID="bes6" runat="server"></asp:Label><asp:TextBox ID="txtbes6" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none;" bgcolor="#ffffff">
                                                <asp:Label ID="bes7" runat="server"></asp:Label><asp:TextBox ID="txtbes7" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none;" bgcolor="#ffffff">
                                                <asp:Label ID="bes8" runat="server"></asp:Label><asp:TextBox ID="txtbes8" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none;">
                                                <asp:Label ID="bes9" runat="server"></asp:Label><asp:TextBox ID="txtbes9" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none;">
                                                <asp:Label ID="bes10" runat="server"></asp:Label><asp:TextBox ID="txtbes10" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none;">
                                                <asp:Label ID="bes11" runat="server"></asp:Label><asp:TextBox ID="txtbes11" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none;">
                                                <asp:Label ID="bes12" runat="server"></asp:Label><asp:TextBox ID="txtbes12" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none;">
                                                <asp:Label ID="bes13" runat="server"></asp:Label><asp:TextBox ID="txtbes13" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none;">
                                                <asp:Label ID="bes14" runat="server"></asp:Label><asp:TextBox ID="txtbes14" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid; font-weight: normal;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <strong>E2</strong></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="alti1" runat="server"></asp:Label><asp:TextBox ID="txtalti1" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="alti2" runat="server"></asp:Label><asp:TextBox ID="txtalti2" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="alti3" runat="server"></asp:Label><asp:TextBox ID="txtalti3" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="alti4" runat="server"></asp:Label><asp:TextBox ID="txtalti4" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="alti5" runat="server"></asp:Label><asp:TextBox ID="txtalti5" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="alti6" runat="server"></asp:Label><asp:TextBox ID="txtalti6" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="alti7" runat="server"></asp:Label><asp:TextBox ID="txtalti7" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="alti8" runat="server"></asp:Label><asp:TextBox ID="txtalti8" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="alti9" runat="server"></asp:Label><asp:TextBox ID="txtalti9" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="alti10" runat="server"></asp:Label><asp:TextBox ID="txtalti10" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="alti11" runat="server"></asp:Label><asp:TextBox ID="txtalti11" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="alti12" runat="server"></asp:Label><asp:TextBox ID="txtalti12" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="alti13" runat="server"></asp:Label><asp:TextBox ID="txtalti13" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="alti14" runat="server"></asp:Label><asp:TextBox ID="txtalti14" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <strong>PROGESTERON</strong></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc1" runat="server"></asp:Label><asp:TextBox ID="txtonuc1" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc2" runat="server"></asp:Label><asp:TextBox ID="txtonuc2" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc3" runat="server"></asp:Label><asp:TextBox ID="txtonuc3" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc4" runat="server"></asp:Label><asp:TextBox ID="txtonuc4" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc5" runat="server"></asp:Label><asp:TextBox ID="txtonuc5" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc6" runat="server"></asp:Label><asp:TextBox ID="txtonuc6" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc7" runat="server"></asp:Label><asp:TextBox ID="txtonuc7" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc8" runat="server"></asp:Label><asp:TextBox ID="txtonuc8" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc9" runat="server"></asp:Label><asp:TextBox ID="txtonuc9" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc10" runat="server"></asp:Label><asp:TextBox ID="txtonuc10" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc11" runat="server"></asp:Label><asp:TextBox ID="txtonuc11" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc12" runat="server"></asp:Label><asp:TextBox ID="txtonuc12" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc13" runat="server"></asp:Label><asp:TextBox ID="txtonuc13" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc14" runat="server"></asp:Label><asp:TextBox ID="txtonuc14" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <strong>LH</strong></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort1" runat="server"></asp:Label><asp:TextBox ID="txtondort1" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort2" runat="server"></asp:Label><asp:TextBox ID="txtondort2" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort3" runat="server"></asp:Label><asp:TextBox ID="txtondort3" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort4" runat="server"></asp:Label><asp:TextBox ID="txtondort4" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort5" runat="server"></asp:Label><asp:TextBox ID="txtondort5" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort6" runat="server"></asp:Label><asp:TextBox ID="txtondort6" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort7" runat="server"></asp:Label><asp:TextBox ID="txtondort7" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort8" runat="server"></asp:Label><asp:TextBox ID="txtondort8" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort9" runat="server"></asp:Label><asp:TextBox ID="txtondort9" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort10" runat="server"></asp:Label><asp:TextBox ID="txtondort10"
                                                    runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort11" runat="server"></asp:Label><asp:TextBox ID="txtondort11"
                                                    runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort12" runat="server"></asp:Label><asp:TextBox ID="txtondort12"
                                                    runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort13" runat="server"></asp:Label><asp:TextBox ID="txtondort13"
                                                    runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort14" runat="server"></asp:Label><asp:TextBox ID="txtondort14"
                                                    runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <strong>&gt; = 17 mm&nbsp;FOLİKÜL</strong></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes1" runat="server"></asp:Label><asp:TextBox ID="txtonbes1" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes2" runat="server"></asp:Label><asp:TextBox ID="txtonbes2" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes3" runat="server"></asp:Label><asp:TextBox ID="txtonbes3" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes4" runat="server"></asp:Label><asp:TextBox ID="txtonbes4" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes5" runat="server"></asp:Label><asp:TextBox ID="txtonbes5" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes6" runat="server"></asp:Label><asp:TextBox ID="txtonbes6" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes7" runat="server"></asp:Label><asp:TextBox ID="txtonbes7" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes8" runat="server"></asp:Label><asp:TextBox ID="txtonbes8" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes9" runat="server"></asp:Label><asp:TextBox ID="txtonbes9" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes10" runat="server"></asp:Label><asp:TextBox ID="txtonbes10" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes11" runat="server"></asp:Label><asp:TextBox ID="txtonbes11" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes12" runat="server"></asp:Label><asp:TextBox ID="txtonbes12" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes13" runat="server"></asp:Label><asp:TextBox ID="txtonbes13" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                               <asp:Label ID="onbes14" runat="server"></asp:Label><asp:TextBox ID="txtonbes14" runat="server" SkinID="txtsiklus"
                                                            Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid; font-weight: bold;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                ENDOMETRİYUM</td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="yedi1" runat="server"></asp:Label><asp:TextBox ID="txtyedi1" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="yedi2" runat="server"></asp:Label><asp:TextBox ID="txtyedi2" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="yedi3" runat="server"></asp:Label><asp:TextBox ID="txtyedi3" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="yedi4" runat="server"></asp:Label><asp:TextBox ID="txtyedi4" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="yedi5" runat="server"></asp:Label><asp:TextBox ID="txtyedi5" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="yedi6" runat="server"></asp:Label><asp:TextBox ID="txtyedi6" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="yedi7" runat="server"></asp:Label><asp:TextBox ID="txtyedi7" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="yedi8" runat="server"></asp:Label><asp:TextBox ID="txtyedi8" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="yedi9" runat="server"></asp:Label><asp:TextBox ID="txtyedi9" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="yedi10" runat="server"></asp:Label><asp:TextBox ID="txtyedi10" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="yedi11" runat="server"></asp:Label><asp:TextBox ID="txtyedi11" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="yedi12" runat="server"></asp:Label><asp:TextBox ID="txtyedi12" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="yedi13" runat="server"></asp:Label><asp:TextBox ID="txtyedi13" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="yedi14" runat="server"></asp:Label><asp:TextBox ID="txtyedi14" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: white; font-weight: normal;" bgcolor="#ffffff">
                                                <strong>SAĞ &gt; 10 SAYI</strong></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="sekiz1" runat="server"></asp:Label><asp:TextBox ID="txtsekiz1" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="sekiz2" runat="server"></asp:Label><asp:TextBox ID="txtsekiz2" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="sekiz3" runat="server"></asp:Label><asp:TextBox ID="txtsekiz3" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="sekiz4" runat="server"></asp:Label><asp:TextBox ID="txtsekiz4" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="sekiz5" runat="server"></asp:Label><asp:TextBox ID="txtsekiz5" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="sekiz6" runat="server"></asp:Label><asp:TextBox ID="txtsekiz6" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="sekiz7" runat="server"></asp:Label><asp:TextBox ID="txtsekiz7" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="sekiz8" runat="server"></asp:Label><asp:TextBox ID="txtsekiz8" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="sekiz9" runat="server"></asp:Label><asp:TextBox ID="txtsekiz9" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="sekiz10" runat="server"></asp:Label><asp:TextBox ID="txtsekiz10" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="sekiz11" runat="server"></asp:Label><asp:TextBox ID="txtsekiz11" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="sekiz12" runat="server"></asp:Label><asp:TextBox ID="txtsekiz12" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="sekiz13" runat="server"></asp:Label><asp:TextBox ID="txtsekiz13" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="sekiz14" runat="server"></asp:Label><asp:TextBox ID="txtsekiz14" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid; font-weight: bold;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                SAĞ FOL</td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="dokuz1" runat="server"></asp:Label><asp:TextBox ID="txtdokuz1" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="dokuz2" runat="server"></asp:Label><asp:TextBox ID="txtdokuz2" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="dokuz3" runat="server"></asp:Label><asp:TextBox ID="txtdokuz3" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="dokuz4" runat="server"></asp:Label><asp:TextBox ID="txtdokuz4" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="dokuz5" runat="server"></asp:Label><asp:TextBox ID="txtdokuz5" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="dokuz6" runat="server"></asp:Label><asp:TextBox ID="txtdokuz6" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="dokuz7" runat="server"></asp:Label><asp:TextBox ID="txtdokuz7" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="dokuz8" runat="server"></asp:Label><asp:TextBox ID="txtdokuz8" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="dokuz9" runat="server"></asp:Label><asp:TextBox ID="txtdokuz9" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="dokuz10" runat="server"></asp:Label><asp:TextBox ID="txtdokuz10" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="dokuz11" runat="server"></asp:Label><asp:TextBox ID="txtdokuz11" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="dokuz12" runat="server"></asp:Label><asp:TextBox ID="txtdokuz12" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="dokuz13" runat="server"></asp:Label><asp:TextBox ID="txtdokuz13" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="dokuz14" runat="server"></asp:Label><asp:TextBox ID="txtdokuz14" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: white; font-weight: normal;" bgcolor="#ffffff">
                                                <strong>SOL &gt; 10 SAYI</strong></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="on1" runat="server"></asp:Label><asp:TextBox ID="txton1" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="on2" runat="server"></asp:Label><asp:TextBox ID="txton2" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="on3" runat="server"></asp:Label><asp:TextBox ID="txton3" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="on4" runat="server"></asp:Label><asp:TextBox ID="txton4" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="on5" runat="server"></asp:Label><asp:TextBox ID="txton5" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="on6" runat="server"></asp:Label><asp:TextBox ID="txton6" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="on7" runat="server"></asp:Label><asp:TextBox ID="txton7" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="on8" runat="server"></asp:Label><asp:TextBox ID="txton8" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="on9" runat="server"></asp:Label><asp:TextBox ID="txton9" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="on10" runat="server"></asp:Label><asp:TextBox ID="txton10" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="on11" runat="server"></asp:Label><asp:TextBox ID="txton11" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="on12" runat="server"></asp:Label><asp:TextBox ID="txton12" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="on13" runat="server"></asp:Label>
                                                <asp:TextBox ID="txton13" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="on14" runat="server"></asp:Label><asp:TextBox ID="txton14" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid; font-weight: bold;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                SOL FOL</td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="onbir1" runat="server"></asp:Label><asp:TextBox ID="txtonbir1" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="onbir2" runat="server"></asp:Label><asp:TextBox ID="txtonbir2" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="onbir3" runat="server"></asp:Label><asp:TextBox ID="txtonbir3" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="onbir4" runat="server"></asp:Label>
                                                <asp:TextBox ID="txtonbir4" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="onbir5" runat="server"></asp:Label>
                                                <asp:TextBox ID="txtonbir5" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="onbir6" runat="server"></asp:Label><asp:TextBox ID="txtonbir6" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="onbir7" runat="server"></asp:Label>
                                                <asp:TextBox ID="txtonbir7" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;" bgcolor="#ffffff">
                                                <asp:Label ID="onbir8" runat="server"></asp:Label><asp:TextBox ID="txtonbir8" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="onbir9" runat="server"></asp:Label><asp:TextBox ID="txtonbir9" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="onbir10" runat="server"></asp:Label><asp:TextBox ID="txtonbir10" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="onbir11" runat="server"></asp:Label><asp:TextBox ID="txtonbir11" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="onbir12" runat="server"></asp:Label><asp:TextBox ID="txtonbir12" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="onbir13" runat="server"></asp:Label><asp:TextBox ID="txtonbir13" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="onbir14" runat="server"></asp:Label><asp:TextBox ID="txtonbir14" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid; font-weight: normal;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: white;" bgcolor="#ffffff">
                                                <strong>MUDAHALELER</strong></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="oniki1" runat="server"></asp:Label>
                                                <asp:TextBox ID="txtoniki1" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="oniki2" runat="server"></asp:Label><asp:TextBox ID="txtoniki2" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="oniki3" runat="server"></asp:Label><asp:TextBox ID="txtoniki3" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="oniki4" runat="server"></asp:Label><asp:TextBox ID="txtoniki4" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="oniki5" runat="server"></asp:Label><asp:TextBox ID="txtoniki5" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="oniki6" runat="server"></asp:Label><asp:TextBox ID="txtoniki6" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="oniki7" runat="server"></asp:Label><asp:TextBox ID="txtoniki7" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;" bgcolor="#ffffff">
                                                <asp:Label ID="oniki8" runat="server"></asp:Label><asp:TextBox ID="txtoniki8" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="oniki9" runat="server"></asp:Label><asp:TextBox ID="txtoniki9" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="oniki10" runat="server"></asp:Label><asp:TextBox ID="txtoniki10" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="oniki11" runat="server"></asp:Label><asp:TextBox ID="txtoniki11" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="oniki12" runat="server"></asp:Label>
                                                <asp:TextBox ID="txtoniki12" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="oniki13" runat="server"></asp:Label><asp:TextBox ID="txtoniki13" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; font-weight: normal;">
                                                <asp:Label ID="oniki14" runat="server"></asp:Label><asp:TextBox ID="txtoniki14" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                    </table>
                                    <br />
                                </asp:Panel>
                                                               
                                
                                <asp:Panel ID="ts2" runat="server"  Visible="false" Width="100%">
                                    <table style="width: 100%">
                                        <tr>
                                            <td bgcolor="gainsboro" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                font-size: 11px; border-left: lightgrey 1px solid; width: 108px; color: black;
                                                border-bottom: lightgrey 1px solid; font-family: verdana; text-align: right;
                                                text-decoration: none">
                                                <asp:Label ID="ts2label" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr15" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                &nbsp;<asp:Label ID="tr16" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr17" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr18" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr19" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr20" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr21" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr22" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr23" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr24" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr25" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr26" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr27" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px;">
                                                <asp:Label ID="tr28" runat="server"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="ghostwhite" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-align: right; text-decoration: none; background-color: lightblue;">
                                                <span style="font-size: 11px; font-family: Arial">SİKLUS GÜNÜ</span></td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                15</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                16</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                17</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                18</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                19</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                20</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                21</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                22</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                23</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                24</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                25</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                26</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                27</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                28</td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; text-decoration: none; width: 108px; background-color: #ffffff;">
                                                <asp:Label ID="aln2baslik" runat="server" Font-Names="Arial" Font-Size="11px" Font-Bold="True"></asp:Label></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none; background-color: #ffffff;">
                                                <asp:Label ID="aln21" runat="server"></asp:Label><asp:TextBox ID="txtaln21" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none; background-color: #ffffff;">
                                                <asp:Label ID="aln22" runat="server"></asp:Label><asp:TextBox ID="txtaln22" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none; background-color: #ffffff;">
                                                <asp:Label ID="aln23" runat="server"></asp:Label><asp:TextBox ID="txtaln23" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none; background-color: #ffffff;">
                                                <asp:Label ID="aln24" runat="server"></asp:Label><asp:TextBox ID="txtaln24" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none; background-color: #ffffff;">
                                                <asp:Label ID="aln25" runat="server"></asp:Label><asp:TextBox ID="txtaln25" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none; background-color: #ffffff;">
                                                <asp:Label ID="aln26" runat="server"></asp:Label><asp:TextBox ID="txtaln26" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none; background-color: #ffffff;">
                                                <asp:Label ID="aln27" runat="server"></asp:Label><asp:TextBox ID="txtaln27" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none; background-color: #ffffff;">
                                                <asp:Label ID="aln28" runat="server"></asp:Label><asp:TextBox ID="txtaln28" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none; background-color: #ffffff;">
                                                <asp:Label ID="aln29" runat="server"></asp:Label><asp:TextBox ID="txtaln29" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none; background-color: #ffffff;">
                                                <asp:Label ID="aln210" runat="server"></asp:Label><asp:TextBox ID="txtaln210" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none; background-color: #ffffff;">
                                                <asp:Label ID="aln211" runat="server"></asp:Label><asp:TextBox ID="txtaln211" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none; background-color: #ffffff;">
                                                <asp:Label ID="aln212" runat="server"></asp:Label><asp:TextBox ID="txtaln212" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none; background-color: #ffffff;">
                                                <asp:Label ID="aln213" runat="server"></asp:Label><asp:TextBox ID="txtaln213" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; text-decoration: none; background-color: #ffffff;">
                                                <asp:Label ID="aln214" runat="server"></asp:Label><asp:TextBox ID="txtaln214" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; text-decoration: none; background-color: ghostwhite; width: 108px;">
                                                <asp:Label ID="iki2baslik" runat="server" Font-Names="Arial" Font-Size="11px" Font-Bold="True"></asp:Label></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki21" runat="server"></asp:Label><asp:TextBox ID="txtiki21" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki22" runat="server"></asp:Label><asp:TextBox ID="txtiki22" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki23" runat="server"></asp:Label><asp:TextBox ID="txtiki23" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki24" runat="server"></asp:Label><asp:TextBox ID="txtiki24" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki25" runat="server"></asp:Label><asp:TextBox ID="txtiki25" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki26" runat="server"></asp:Label><asp:TextBox ID="txtiki26" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki27" runat="server"></asp:Label><asp:TextBox ID="txtiki27" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki28" runat="server"></asp:Label><asp:TextBox ID="txtiki28" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki29" runat="server"></asp:Label><asp:TextBox ID="txtiki29" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki210" runat="server"></asp:Label><asp:TextBox ID="txtiki210" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki211" runat="server"></asp:Label><asp:TextBox ID="txtiki211" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki212" runat="server"></asp:Label><asp:TextBox ID="txtiki212" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki213" runat="server"></asp:Label><asp:TextBox ID="txtiki213" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki214" runat="server"></asp:Label><asp:TextBox ID="txtiki214" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; text-decoration: none; background-color: #ffffff; width: 108px;">
                                                <asp:Label ID="uc2baslik" runat="server" Font-Names="Arial" Font-Size="11px" Font-Bold="True"></asp:Label></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="uc21" runat="server"></asp:Label><asp:TextBox ID="txtuc21" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="uc22" runat="server"></asp:Label><asp:TextBox ID="txtuc22" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="uc23" runat="server"></asp:Label><asp:TextBox ID="txtuc23" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="uc24" runat="server"></asp:Label><asp:TextBox ID="txtuc24" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="uc25" runat="server"></asp:Label><asp:TextBox ID="txtuc25" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="uc26" runat="server"></asp:Label><asp:TextBox ID="txtuc26" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="uc27" runat="server"></asp:Label><asp:TextBox ID="txtuc27" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="uc28" runat="server"></asp:Label><asp:TextBox ID="txtuc28" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="uc29" runat="server"></asp:Label><asp:TextBox ID="txtuc29" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="uc210" runat="server"></asp:Label><asp:TextBox ID="txtuc210" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="uc211" runat="server"></asp:Label><asp:TextBox ID="txtuc211" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="uc212" runat="server"></asp:Label><asp:TextBox ID="txtuc212" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="uc213" runat="server"></asp:Label><asp:TextBox ID="txtuc213" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="uc214" runat="server"></asp:Label><asp:TextBox ID="txtuc214" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; text-decoration: none; background-color: ghostwhite; width: 108px; height: 43px;">
                                                <asp:Label ID="dort2baslik" runat="server" Font-Names="Arial" Font-Size="11px" Font-Bold="True"></asp:Label></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; height: 43px;">
                                                <asp:Label ID="dort21" runat="server"></asp:Label><asp:TextBox ID="txtdort21" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; height: 43px;">
                                                <asp:Label ID="dort22" runat="server"></asp:Label><asp:TextBox ID="txtdort22" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; height: 43px;">
                                                <asp:Label ID="dort23" runat="server"></asp:Label><asp:TextBox ID="txtdort23" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; height: 43px;">
                                                <asp:Label ID="dort24" runat="server"></asp:Label><asp:TextBox ID="txtdort24" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; height: 43px;">
                                                <asp:Label ID="dort25" runat="server"></asp:Label><asp:TextBox ID="txtdort25" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; height: 43px;">
                                                <asp:Label ID="dort26" runat="server"></asp:Label><asp:TextBox ID="txtdort26" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; height: 43px;">
                                                <asp:Label ID="dort27" runat="server"></asp:Label><asp:TextBox ID="txtdort27" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; height: 43px;">
                                                <asp:Label ID="dort28" runat="server"></asp:Label><asp:TextBox ID="txtdort28" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; height: 43px;">
                                                <asp:Label ID="dort29" runat="server"></asp:Label><asp:TextBox ID="txtdort29" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; height: 43px;">
                                                <asp:Label ID="dort210" runat="server"></asp:Label><asp:TextBox ID="txtdort210" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; height: 43px;">
                                                <asp:Label ID="dort211" runat="server"></asp:Label><asp:TextBox ID="txtdort211" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; height: 43px;">
                                                <asp:Label ID="dort212" runat="server"></asp:Label><asp:TextBox ID="txtdort212" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; height: 43px;">
                                                <asp:Label ID="dort213" runat="server"></asp:Label><asp:TextBox ID="txtdort213" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none; height: 43px;">
                                                <asp:Label ID="dort214" runat="server"></asp:Label><asp:TextBox ID="txtdort214" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; text-decoration: none; background-color: #ffffff; width: 108px;">
                                                <asp:Label ID="bes2baslik" runat="server" Font-Names="Arial" Font-Size="11px" Font-Bold="True"></asp:Label></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="bes21" runat="server"></asp:Label><asp:TextBox ID="txtbes21" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="bes22" runat="server"></asp:Label><asp:TextBox ID="txtbes22" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="bes23" runat="server"></asp:Label><asp:TextBox ID="txtbes23" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="bes24" runat="server"></asp:Label><asp:TextBox ID="txtbes24" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="bes25" runat="server"></asp:Label><asp:TextBox ID="txtbes25" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="bes26" runat="server"></asp:Label><asp:TextBox ID="txtbes26" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="bes27" runat="server"></asp:Label><asp:TextBox ID="txtbes27" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="bes28" runat="server"></asp:Label><asp:TextBox ID="txtbes28" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="bes29" runat="server"></asp:Label><asp:TextBox ID="txtbes29" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="bes210" runat="server"></asp:Label><asp:TextBox ID="txtbes210" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="bes211" runat="server"></asp:Label><asp:TextBox ID="txtbes211" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="bes212" runat="server"></asp:Label><asp:TextBox ID="txtbes212" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="bes213" runat="server"></asp:Label><asp:TextBox ID="txtbes213" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: #ffffff; text-decoration: none">
                                                <asp:Label ID="bes214" runat="server"></asp:Label><asp:TextBox ID="txtbes214" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite; width: 108px;">
                                                <strong>E2</strong></td>
                                             
                                             
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti21" runat="server"></asp:Label><asp:TextBox ID="txtalti21" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti22" runat="server"></asp:Label><asp:TextBox ID="txtalti22" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti23" runat="server"></asp:Label><asp:TextBox ID="txtalti23" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti24" runat="server"></asp:Label><asp:TextBox ID="txtalti24" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti25" runat="server"></asp:Label><asp:TextBox ID="txtalti25" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti26" runat="server"></asp:Label><asp:TextBox ID="txtalti26" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti27" runat="server"></asp:Label><asp:TextBox ID="txtalti27" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti28" runat="server"></asp:Label><asp:TextBox ID="txtalti28" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti29" runat="server"></asp:Label><asp:TextBox ID="txtalti29" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti210" runat="server"></asp:Label><asp:TextBox ID="txtalti210" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti211" runat="server"></asp:Label><asp:TextBox ID="txtalti211" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti212" runat="server"></asp:Label><asp:TextBox ID="txtalti212" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti213" runat="server"></asp:Label><asp:TextBox ID="txtalti213" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti214" runat="server"></asp:Label><asp:TextBox ID="txtalti214" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                          <tr>
                                            <td bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <strong>PROGESTERON</strong></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc21" runat="server"></asp:Label><asp:TextBox ID="txtonuc21" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc22" runat="server"></asp:Label><asp:TextBox ID="txtonuc22" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc23" runat="server"></asp:Label><asp:TextBox ID="txtonuc23" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc24" runat="server"></asp:Label><asp:TextBox ID="txtonuc24" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc25" runat="server"></asp:Label><asp:TextBox ID="txtonuc25" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc26" runat="server"></asp:Label><asp:TextBox ID="txtonuc26" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc27" runat="server"></asp:Label><asp:TextBox ID="txtonuc27" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc28" runat="server"></asp:Label><asp:TextBox ID="txtonuc28" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc29" runat="server"></asp:Label><asp:TextBox ID="txtonuc29" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc210" runat="server"></asp:Label><asp:TextBox ID="txtonuc210" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc211" runat="server"></asp:Label><asp:TextBox ID="txtonuc211" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc212" runat="server"></asp:Label><asp:TextBox ID="txtonuc212" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc213" runat="server"></asp:Label><asp:TextBox ID="txtonuc213" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onuc214" runat="server"></asp:Label><asp:TextBox ID="txtonuc214" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <strong>LH</strong></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort21" runat="server"></asp:Label><asp:TextBox ID="txtondort21" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort22" runat="server"></asp:Label><asp:TextBox ID="txtondort22" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort23" runat="server"></asp:Label><asp:TextBox ID="txtondort23" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort24" runat="server"></asp:Label><asp:TextBox ID="txtondort24" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort25" runat="server"></asp:Label><asp:TextBox ID="txtondort25" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort26" runat="server"></asp:Label><asp:TextBox ID="txtondort26" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort27" runat="server"></asp:Label><asp:TextBox ID="txtondort27" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort28" runat="server"></asp:Label><asp:TextBox ID="txtondort28" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort29" runat="server"></asp:Label><asp:TextBox ID="txtondort29" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort210" runat="server"></asp:Label><asp:TextBox ID="txtondort210"
                                                    runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort211" runat="server"></asp:Label><asp:TextBox ID="txtondort211"
                                                    runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort212" runat="server"></asp:Label><asp:TextBox ID="txtondort212"
                                                    runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort213" runat="server"></asp:Label><asp:TextBox ID="txtondort213"
                                                    runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: ghostwhite;
                                                text-decoration: none">
                                                <asp:Label ID="ondort214" runat="server"></asp:Label><asp:TextBox ID="txtondort214"
                                                    runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <strong>&gt; = 17 mm&nbsp;FOLİKÜL</strong></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes21" runat="server"></asp:Label><asp:TextBox ID="txtonbes21" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes22" runat="server"></asp:Label><asp:TextBox ID="txtonbes22" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes23" runat="server"></asp:Label><asp:TextBox ID="txtonbes23" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes24" runat="server"></asp:Label><asp:TextBox ID="txtonbes24" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes25" runat="server"></asp:Label><asp:TextBox ID="txtonbes25" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes26" runat="server"></asp:Label><asp:TextBox ID="txtonbes26" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes27" runat="server"></asp:Label><asp:TextBox ID="txtonbes27" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" bgcolor="#ffffff" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes28" runat="server"></asp:Label><asp:TextBox ID="txtonbes28" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes29" runat="server"></asp:Label><asp:TextBox ID="txtonbes29" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes210" runat="server"></asp:Label><asp:TextBox ID="txtonbes210" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes211" runat="server"></asp:Label><asp:TextBox ID="txtonbes211" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes212" runat="server"></asp:Label><asp:TextBox ID="txtonbes212" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                                <asp:Label ID="onbes213" runat="server"></asp:Label><asp:TextBox ID="txtonbes213" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: normal; font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; background-color: white;
                                                text-decoration: none">
                                               <asp:Label ID="onbes214" runat="server"></asp:Label><asp:TextBox ID="txtonbes214" runat="server" SkinID="txtsiklus"
                                                            Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite; width: 108px;">
                                                <strong>ENDOMETRİYUM</strong></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="yedi21" runat="server"></asp:Label><asp:TextBox ID="txtyedi21" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="yedi22" runat="server"></asp:Label><asp:TextBox ID="txtyedi22" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="yedi23" runat="server"></asp:Label><asp:TextBox ID="txtyedi23" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="yedi24" runat="server"></asp:Label><asp:TextBox ID="txtyedi24" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="yedi25" runat="server"></asp:Label><asp:TextBox ID="txtyedi25" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="yedi26" runat="server"></asp:Label><asp:TextBox ID="txtyedi26" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="yedi27" runat="server"></asp:Label><asp:TextBox ID="txtyedi27" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="yedi28" runat="server"></asp:Label><asp:TextBox ID="txtyedi28" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="yedi29" runat="server"></asp:Label><asp:TextBox ID="txtyedi29" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="yedi210" runat="server"></asp:Label><asp:TextBox ID="txtyedi210" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="yedi211" runat="server"></asp:Label><asp:TextBox ID="txtyedi211" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="yedi212" runat="server"></asp:Label><asp:TextBox ID="txtyedi212" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="yedi213" runat="server"></asp:Label><asp:TextBox ID="txtyedi213" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="yedi214" runat="server"></asp:Label><asp:TextBox ID="txtyedi214" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: white; width: 108px;">
                                                <strong>SAĞ &gt; 10 SAYI</strong></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="sekiz21" runat="server"></asp:Label><asp:TextBox ID="txtsekiz21" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="sekiz22" runat="server"></asp:Label><asp:TextBox ID="txtsekiz22" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="sekiz23" runat="server"></asp:Label><asp:TextBox ID="txtsekiz23" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="sekiz24" runat="server"></asp:Label><asp:TextBox ID="txtsekiz24" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="sekiz25" runat="server"></asp:Label><asp:TextBox ID="txtsekiz25" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="sekiz26" runat="server"></asp:Label><asp:TextBox ID="txtsekiz26" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="sekiz27" runat="server"></asp:Label><asp:TextBox ID="txtsekiz27" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="sekiz28" runat="server"></asp:Label><asp:TextBox ID="txtsekiz28" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="sekiz29" runat="server"></asp:Label><asp:TextBox ID="txtsekiz29" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="sekiz210" runat="server"></asp:Label><asp:TextBox ID="txtsekiz210" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="sekiz211" runat="server"></asp:Label><asp:TextBox ID="txtsekiz211" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="sekiz212" runat="server"></asp:Label><asp:TextBox ID="txtsekiz212" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="sekiz213" runat="server"></asp:Label><asp:TextBox ID="txtsekiz213" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="sekiz214" runat="server"></asp:Label><asp:TextBox ID="txtsekiz214" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite; width: 108px;">
                                                <strong>SAĞ FOL</strong></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dokuz21" runat="server"></asp:Label><asp:TextBox ID="txtdokuz21" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dokuz22" runat="server"></asp:Label><asp:TextBox ID="txtdokuz22" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dokuz23" runat="server"></asp:Label><asp:TextBox ID="txtdokuz23" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dokuz24" runat="server"></asp:Label><asp:TextBox ID="txtdokuz24" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dokuz25" runat="server"></asp:Label><asp:TextBox ID="txtdokuz25" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dokuz26" runat="server"></asp:Label><asp:TextBox ID="txtdokuz26" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dokuz27" runat="server"></asp:Label><asp:TextBox ID="txtdokuz27" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dokuz28" runat="server"></asp:Label><asp:TextBox ID="txtdokuz28" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dokuz29" runat="server"></asp:Label><asp:TextBox ID="txtdokuz29" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dokuz210" runat="server"></asp:Label><asp:TextBox ID="txtdokuz210" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dokuz211" runat="server"></asp:Label><asp:TextBox ID="txtdokuz211" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dokuz212" runat="server"></asp:Label><asp:TextBox ID="txtdokuz212" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dokuz213" runat="server"></asp:Label><asp:TextBox ID="txtdokuz213" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dokuz214" runat="server"></asp:Label><asp:TextBox ID="txtdokuz214" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: white; width: 108px;">
                                                <strong>SOL &gt; 10 SAYI</strong></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="on21" runat="server"></asp:Label><asp:TextBox ID="txton21" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="on22" runat="server"></asp:Label><asp:TextBox ID="txton22" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="on23" runat="server"></asp:Label><asp:TextBox ID="txton23" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="on24" runat="server"></asp:Label><asp:TextBox ID="txton24" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="on25" runat="server"></asp:Label><asp:TextBox ID="txton25" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="on26" runat="server"></asp:Label><asp:TextBox ID="txton26" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="on27" runat="server"></asp:Label><asp:TextBox ID="txton27" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="on28" runat="server"></asp:Label><asp:TextBox ID="txton28" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="on29" runat="server"></asp:Label><asp:TextBox ID="txton29" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="on210" runat="server"></asp:Label><asp:TextBox ID="txton210" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="on211" runat="server"></asp:Label><asp:TextBox ID="txton211" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="on212" runat="server"></asp:Label><asp:TextBox ID="txton212" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="on213" runat="server"></asp:Label><asp:TextBox ID="txton213" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="on214" runat="server"></asp:Label><asp:TextBox ID="txton214" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite; width: 108px;">
                                                <strong>SOL FOL</strong></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="onbir21" runat="server"></asp:Label><asp:TextBox ID="txtonbir21" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="onbir22" runat="server"></asp:Label><asp:TextBox ID="txtonbir22" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="onbir23" runat="server"></asp:Label><asp:TextBox ID="txtonbir23" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="onbir24" runat="server"></asp:Label><asp:TextBox ID="txtonbir24" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="onbir25" runat="server"></asp:Label><asp:TextBox ID="txtonbir25" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="onbir26" runat="server"></asp:Label><asp:TextBox ID="txtonbir26" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="onbir27" runat="server"></asp:Label><asp:TextBox ID="txtonbir27" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="onbir28" runat="server"></asp:Label><asp:TextBox ID="txtonbir28" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="onbir29" runat="server"></asp:Label><asp:TextBox ID="txtonbir29" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="onbir210" runat="server"></asp:Label><asp:TextBox ID="txtonbir210" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="onbir211" runat="server"></asp:Label><asp:TextBox ID="txtonbir211" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="onbir212" runat="server"></asp:Label><asp:TextBox ID="txtonbir212" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="onbir213" runat="server"></asp:Label><asp:TextBox ID="txtonbir213" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="onbir214" runat="server"></asp:Label><asp:TextBox ID="txtonbir214" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: white; width: 108px;">
                                                <strong>MUDAHALELER</strong></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="oniki21" runat="server"></asp:Label><asp:TextBox ID="txtoniki21" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="oniki22" runat="server"></asp:Label><asp:TextBox ID="txtoniki22" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="oniki23" runat="server"></asp:Label><asp:TextBox ID="txtoniki23" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="oniki24" runat="server"></asp:Label><asp:TextBox ID="txtoniki24" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="oniki25" runat="server"></asp:Label><asp:TextBox ID="txtoniki25" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="oniki26" runat="server"></asp:Label><asp:TextBox ID="txtoniki26" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="oniki27" runat="server"></asp:Label><asp:TextBox ID="txtoniki27" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="oniki28" runat="server"></asp:Label><asp:TextBox ID="txtoniki28" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="oniki29" runat="server"></asp:Label><asp:TextBox ID="txtoniki29" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="oniki210" runat="server"></asp:Label><asp:TextBox ID="txtoniki210" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="oniki211" runat="server"></asp:Label><asp:TextBox ID="txtoniki211" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="oniki212" runat="server"></asp:Label><asp:TextBox ID="txtoniki212" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="oniki213" runat="server"></asp:Label><asp:TextBox ID="txtoniki213" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="oniki214" runat="server"></asp:Label><asp:TextBox ID="txtoniki214" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                    </table>
                                    <br />
                                </asp:Panel>
                                
                                
                                
                                <asp:Panel ID="ts3" runat="server" Visible="false" Width="100%">
                                    <table style="width: 100%">
                                        <tr>
                                            <td bgcolor="gainsboro" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                font-size: 11px; border-left: lightgrey 1px solid; width: 108px; color: black;
                                                border-bottom: lightgrey 1px solid; font-family: arial; text-align: right;
                                                text-decoration: none; font-weight: bold; height: 15px; background-color: gainsboro;">
                                                <asp:Label ID="ts3label" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px; background-color: gainsboro;">
                                                <asp:Label ID="tr29" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px; background-color: gainsboro;">
                                                <asp:Label ID="tr30" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px; background-color: gainsboro;">
                                                <asp:Label ID="tr31" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px; background-color: gainsboro;">
                                                <asp:Label ID="tr32" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px; background-color: gainsboro;">
                                                <asp:Label ID="tr33" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px; background-color: gainsboro;">
                                                <asp:Label ID="tr34" runat="server"></asp:Label></td>
                                            <td align="center" bgcolor="gainsboro" style="border-right: lightgrey 1px solid;
                                                border-top: lightgrey 1px solid; font-size: 11px; border-left: lightgrey 1px solid;
                                                color: black; border-bottom: lightgrey 1px solid; font-family: arial; text-decoration: none; font-weight: bold; height: 15px; background-color: gainsboro;">
                                                <asp:Label ID="tr35" runat="server" Font-Bold="True"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="ghostwhite" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: lightblue; text-align: right;">
                                                SİKLUS GÜNÜ</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                29</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                30</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                31</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                32</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                33</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-weight: bold; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue;">
                                                34</td>
                                            <td align="center" bgcolor="ghostwhite" style="border-right: lightgrey 0px solid;
                                                border-top: lightgrey 0px solid; font-size: 11px; border-left: lightgrey 0px solid;
                                                color: black; border-bottom: lightgrey 0px solid; font-family: arial; height: 15px;
                                                text-decoration: none; background-color: lightblue; font-weight: bold;">
                                                <strong>
                                                35</strong></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; width: 108px; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; text-decoration: none; background-color: white;">
                                                <asp:Label ID="aln3baslik" runat="server" Font-Names="Arial" Font-Size="11px" Font-Bold="True"></asp:Label></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none">
                                                <asp:Label ID="aln31" runat="server"></asp:Label><asp:TextBox ID="txtaln31" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="aln32" runat="server"></asp:Label><asp:TextBox ID="txtaln32" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="aln33" runat="server"></asp:Label><asp:TextBox ID="txtaln33" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="aln34" runat="server"></asp:Label><asp:TextBox ID="txtaln34" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="aln35" runat="server"></asp:Label><asp:TextBox ID="txtaln35" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="aln36" runat="server"></asp:Label><asp:TextBox ID="txtaln36" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="aln37" runat="server"></asp:Label><asp:TextBox ID="txtaln37" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; width: 108px; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="iki3baslik" runat="server" Font-Names="Arial" Font-Size="11px" Font-Bold="True"></asp:Label></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki31" runat="server"></asp:Label><asp:TextBox ID="txtiki31" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki32" runat="server"></asp:Label><asp:TextBox ID="txtiki32" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki33" runat="server"></asp:Label><asp:TextBox ID="txtiki33" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki34" runat="server"></asp:Label><asp:TextBox ID="txtiki34" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki35" runat="server"></asp:Label><asp:TextBox ID="txtiki35" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki36" runat="server"></asp:Label><asp:TextBox ID="txtiki36" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="iki37" runat="server"></asp:Label><asp:TextBox ID="txtiki37" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; width: 108px; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; text-decoration: none; background-color: white;">
                                                <asp:Label ID="uc3baslik" runat="server" Font-Names="Arial" Font-Size="11px" Font-Bold="True"></asp:Label></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none">
                                                <asp:Label ID="uc31" runat="server"></asp:Label><asp:TextBox ID="txtuc31" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="uc32" runat="server"></asp:Label><asp:TextBox ID="txtuc32" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="uc33" runat="server"></asp:Label><asp:TextBox ID="txtuc33" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="uc34" runat="server"></asp:Label><asp:TextBox ID="txtuc34" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="uc35" runat="server"></asp:Label><asp:TextBox ID="txtuc35" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="uc36" runat="server"></asp:Label><asp:TextBox ID="txtuc36" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="uc37" runat="server"></asp:Label><asp:TextBox ID="txtuc37" runat="server" SkinID="txtsiklus" Width="50px" Visible="False"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; width: 108px; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; text-decoration: none; background-color: ghostwhite;">
                                                <asp:Label ID="dort3baslik" runat="server" Font-Names="Arial" Font-Size="11px" Font-Bold="True"></asp:Label></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dort31" runat="server"></asp:Label><asp:TextBox ID="txtdort31" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dort32" runat="server"></asp:Label><asp:TextBox ID="txtdort32" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dort33" runat="server"></asp:Label><asp:TextBox ID="txtdort33" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dort34" runat="server"></asp:Label><asp:TextBox ID="txtdort34" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dort35" runat="server"></asp:Label><asp:TextBox ID="txtdort35" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dort36" runat="server"></asp:Label><asp:TextBox ID="txtdort36" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="dort37" runat="server"></asp:Label><asp:TextBox ID="txtdort37" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; width: 108px; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; text-decoration: none; background-color: white;">
                                                <asp:Label ID="bes3baslik" runat="server" Font-Names="Arial" Font-Size="11px" Font-Bold="True"></asp:Label></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none">
                                                <asp:Label ID="bes31" runat="server"></asp:Label><asp:TextBox ID="txtbes31" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="bes32" runat="server"></asp:Label><asp:TextBox ID="txtbes32" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="bes33" runat="server"></asp:Label><asp:TextBox ID="txtbes33" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="bes34" runat="server"></asp:Label><asp:TextBox ID="txtbes34" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="bes35" runat="server"></asp:Label><asp:TextBox ID="txtbes35" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="bes36" runat="server"></asp:Label><asp:TextBox ID="txtbes36" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="bes37" runat="server"></asp:Label><asp:TextBox ID="txtbes37" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; width: 108px; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <strong>E2</strong></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti31" runat="server"></asp:Label><asp:TextBox ID="txtalti31" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti32" runat="server"></asp:Label><asp:TextBox ID="txtalti32" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti33" runat="server"></asp:Label><asp:TextBox ID="txtalti33" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti34" runat="server"></asp:Label><asp:TextBox ID="txtalti34" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti35" runat="server"></asp:Label><asp:TextBox ID="txtalti35" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti36" runat="server"></asp:Label><asp:TextBox ID="txtalti36" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="alti37" runat="server"></asp:Label><asp:TextBox ID="txtalti37" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; width: 108px; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: white;">
                                                <strong>ENDOMETRİYUM</strong></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="yedi31" runat="server"></asp:Label><asp:TextBox ID="txtyedi31" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="yedi32" runat="server"></asp:Label><asp:TextBox ID="txtyedi32" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="yedi33" runat="server"></asp:Label><asp:TextBox ID="txtyedi33" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="yedi34" runat="server"></asp:Label><asp:TextBox ID="txtyedi34" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="yedi35" runat="server"></asp:Label><asp:TextBox ID="txtyedi35" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="yedi36" runat="server"></asp:Label><asp:TextBox ID="txtyedi36" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="yedi37" runat="server"></asp:Label><asp:TextBox ID="txtyedi37" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; width: 108px; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <strong>SAĞ &gt; 10 SAYI</strong></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="sekiz31" runat="server"></asp:Label><asp:TextBox ID="txtsekiz31" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="sekiz32" runat="server"></asp:Label><asp:TextBox ID="txtsekiz32" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="sekiz33" runat="server"></asp:Label><asp:TextBox ID="txtsekiz33" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="sekiz34" runat="server"></asp:Label><asp:TextBox ID="txtsekiz34" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="sekiz35" runat="server"></asp:Label><asp:TextBox ID="txtsekiz35" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="sekiz36" runat="server"></asp:Label><asp:TextBox ID="txtsekiz36" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="sekiz37" runat="server"></asp:Label><asp:TextBox ID="txtsekiz37" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; width: 108px; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: white;">
                                                <strong>SAĞ FOL</strong></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="dokuz31" runat="server"></asp:Label><asp:TextBox ID="txtdokuz31" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="dokuz32" runat="server"></asp:Label><asp:TextBox ID="txtdokuz32" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="dokuz33" runat="server"></asp:Label><asp:TextBox ID="txtdokuz33" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="dokuz34" runat="server"></asp:Label><asp:TextBox ID="txtdokuz34" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="dokuz35" runat="server"></asp:Label><asp:TextBox ID="txtdokuz35" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="dokuz36" runat="server"></asp:Label><asp:TextBox ID="txtdokuz36" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="dokuz37" runat="server"></asp:Label><asp:TextBox ID="txtdokuz37" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; width: 108px; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <strong>SOL &gt; 10 SAYI</strong></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="on31" runat="server"></asp:Label><asp:TextBox ID="txton31" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="on32" runat="server"></asp:Label><asp:TextBox ID="txton32" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="on33" runat="server"></asp:Label><asp:TextBox ID="txton33" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="on34" runat="server"></asp:Label><asp:TextBox ID="txton34" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="on35" runat="server"></asp:Label><asp:TextBox ID="txton35" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="on36" runat="server"></asp:Label><asp:TextBox ID="txton36" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="on37" runat="server"></asp:Label><asp:TextBox ID="txton37" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; width: 108px; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: white;">
                                                <strong>SOL FOL</strong></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none">
                                                <asp:Label ID="onbir31" runat="server"></asp:Label><asp:TextBox ID="txtonbir31" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="onbir32" runat="server"></asp:Label><asp:TextBox ID="txtonbir32" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="onbir33" runat="server"></asp:Label><asp:TextBox ID="txtonbir33" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="onbir34" runat="server"></asp:Label><asp:TextBox ID="txtonbir34" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="onbir35" runat="server"></asp:Label><asp:TextBox ID="txtonbir35" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="onbir36" runat="server"></asp:Label><asp:TextBox ID="txtonbir36" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: white; text-decoration: none; width: 108px;">
                                                <asp:Label ID="onbir37" runat="server"></asp:Label><asp:TextBox ID="txtonbir37" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; width: 108px; color: black;
                                                border-bottom: lightgrey 0px solid; font-family: arial; height: 15px; text-decoration: none; background-color: ghostwhite;">
                                                <strong>MUDAHALELER</strong></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="oniki31" runat="server"></asp:Label><asp:TextBox ID="txtoniki31" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="oniki32" runat="server"></asp:Label><asp:TextBox ID="txtoniki32" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="oniki33" runat="server"></asp:Label><asp:TextBox ID="txtoniki33" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="oniki34" runat="server"></asp:Label><asp:TextBox ID="txtoniki34" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="oniki35" runat="server"></asp:Label><asp:TextBox ID="txtoniki35" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="oniki36" runat="server"></asp:Label><asp:TextBox ID="txtoniki36" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                            <td align="center" style="border-right: lightgrey 0px solid; border-top: lightgrey 0px solid;
                                                font-size: 11px; border-left: lightgrey 0px solid; color: black; border-bottom: lightgrey 0px solid;
                                                font-family: arial; height: 15px; background-color: ghostwhite; text-decoration: none">
                                                <asp:Label ID="oniki37" runat="server"></asp:Label><asp:TextBox ID="txtoniki37" runat="server" SkinID="txtsiklus" Visible="False" Width="50px"></asp:TextBox></td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                
                                </div>
                                
                                </td>
                        </tr>
                    </table>
                    <br />
                </asp:Panel>
        </td>
    </tr>
</table>
