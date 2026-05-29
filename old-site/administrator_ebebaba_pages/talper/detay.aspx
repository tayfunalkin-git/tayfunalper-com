<%@ Page Language="C#" AutoEventWireup="true" CodeFile="detay.aspx.cs" Inherits="ivfyonetici_talper_detay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
        }
        .auto-style5 {
            height: 30px;
            width: 50px;
        }
        .auto-style6 {
            width: 229px;
        }
        .auto-style7 {
            text-align: center;
            width: 147px;
        }
        .auto-style9 {
            text-align: center;
            font-size: 14px;
        }
        .auto-style10 {
            text-align: center;
            height: 36px;
            font-size: 14px;
        }
    </style>
</head>
<body style="background:#fff;">
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table cellpadding="3" cellspacing="3" class="auto-style1">
                    <tr>
                        <td style="width: 50%;">
                            <table class="auto-style1">
                                <tr>
                                    <td class="auto-style9" rowspan="2" style="font-family: arial, Helvetica, sans-serif; font-weight: bolder; border: 1px solid #808080; background-color: #009933; color: #FFFFFF;">IVF</td>
                                    <td class="auto-style9" style="font-family: arial, Helvetica, sans-serif; font-weight: bolder; border: 1px solid #808080; background-color: #009933; color: #FFFFFF;">Kategori</td>
                                    <td class="auto-style9" style="font-family: arial, Helvetica, sans-serif; font-weight: bolder; border: 1px solid #808080; background-color: #009933; color: #FFFFFF;">Malzeme Toplamı</td>
                                    <td class="auto-style9" style="font-family: arial, Helvetica, sans-serif; font-weight: bolder; border: 1px solid #808080; background-color: #009933; color: #FFFFFF;">Siklus Sayısı</td>
                                    <td class="auto-style9" style="font-family: arial, Helvetica, sans-serif; font-weight: bolder; border: 1px solid #808080; background-color: #009933; color: #FFFFFF;">Ortalama</td>
                                </tr>
                                <tr>
                                    <td class="auto-style10" style="font-family: arial, Helvetica, sans-serif; font-weight: bolder; border: 1px solid #808080">
                                        <asp:Label ID="Label0" runat="server"></asp:Label>
                                    </td>
                                    <td class="auto-style10" style="font-family: arial, Helvetica, sans-serif; font-weight: bolder; border: 1px solid #808080">
                                        <asp:Label ID="Label1" runat="server"></asp:Label>
                                    </td>
                                    <td class="auto-style10" style="font-family: arial, Helvetica, sans-serif; font-weight: bolder; border: 1px solid #808080">
                                        <asp:Label ID="Label2" runat="server"></asp:Label>
                                    </td>
                                    <td class="auto-style10" style="font-family: arial, Helvetica, sans-serif; font-weight: bolder; border: 1px solid #808080">
                                        <asp:Label ID="Label3" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                            <asp:GridView ID="malzemeList" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" Font-Names="Arial" Font-Size="13px" ForeColor="#333333" GridLines="Horizontal" Width="100%">
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                <Columns>
                                    <asp:BoundField DataField="malzemeAdi" HeaderText="Malzeme Adı">
                                    <HeaderStyle HorizontalAlign="Left" />
                                    </asp:BoundField>
                                    <asp:TemplateField HeaderText="Toplam Kullanılan">
                                        <ItemTemplate>
                                            <asp:Label ID="lblToplamKullanilan" runat="server"></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Toplam Tutar">
                                        <ItemTemplate>
                                            <asp:Label ID="lblToplamTutar" runat="server"></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:TemplateField>
                                </Columns>
                                <EditRowStyle BackColor="#999999" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            </asp:GridView>
                            <asp:DataList ID="anaListe" runat="server" Width="100%">
                                <ItemTemplate>
                                    <table cellpadding="0" cellspacing="0" class="auto-style1">
                                        <tr>
                                            <td class="auto-style5" style="background-color: #66CCFF; font-family: arial, Helvetica, sans-serif; font-size: 13px; font-weight: 700">&nbsp;&nbsp;
                                                <asp:ImageButton ID="ac" runat="server" ImageUrl="ac.gif" OnCommand="ac_Command" />
                                                <asp:ImageButton ID="kapat" runat="server" ImageUrl="kapat.gif" OnCommand="kapat_Command" Visible="False" />
                                            </td>
                                            <td class="auto-style6" style="background-color: #66CCFF; font-family: arial, Helvetica, sans-serif; font-size: 13px; font-weight: 700">
                                                <asp:Label ID="hastaAdi" runat="server"></asp:Label>
                                            </td>
                                            <td class="auto-style7" style="background-color: #66CCFF; font-family: arial, Helvetica, sans-serif; font-size: 13px; font-weight: 700;">S:<asp:Label ID="siklus" runat="server" style="text-align: center"></asp:Label>
                                            </td>
                                            <td style="text-align: right; background-color: #66CCFF; font-family: arial, Helvetica, sans-serif; font-size: 13px; font-weight: 700;">
                                                <asp:Label ID="toplam" runat="server"></asp:Label>
                                                &nbsp;&nbsp; </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2" colspan="4">
                                                <asp:GridView ID="altListe" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" Font-Names="Arial" Font-Size="12px" ForeColor="#333333" Visible="False" Width="100%">
                                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                    <Columns>
                                                        <asp:BoundField DataField="malzemeAdi" HeaderText="Malzeme">
                                                        <HeaderStyle HorizontalAlign="Left" />
                                                        </asp:BoundField>
                                                        <asp:TemplateField HeaderText="Birim Fiyatı">
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblBirimFiyat" runat="server"></asp:Label>
                                                            </ItemTemplate>
                                                            <HeaderStyle HorizontalAlign="Right" />
                                                            <ItemStyle HorizontalAlign="Right" />
                                                        </asp:TemplateField>
                                                        <asp:BoundField DataField="adet" HeaderText="Adet">
                                                        <HeaderStyle HorizontalAlign="Left" />
                                                        </asp:BoundField>
                                                        <asp:TemplateField HeaderText="Toplam Fiyat">
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblToplamFiyat" runat="server"></asp:Label>
                                                            </ItemTemplate>
                                                            <HeaderStyle HorizontalAlign="Right" />
                                                            <ItemStyle HorizontalAlign="Right" />
                                                        </asp:TemplateField>
                                                        <asp:BoundField DataField="tarih" HeaderText="Tarih">
                                                        <HeaderStyle HorizontalAlign="Left" />
                                                        </asp:BoundField>
                                                    </Columns>
                                                    <EditRowStyle BackColor="#999999" />
                                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                </asp:GridView>
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:DataList>
                        </td>
                        <td>&nbsp;</td>
                        <td style="width: 48%; vertical-align: top;">
                            <table class="auto-style1">
                                <tr>
                                    <td class="auto-style9" rowspan="2" style="font-family: arial, Helvetica, sans-serif; font-weight: bolder; border: 1px solid #808080; background-color: #3366CC; color: #FFFFFF;">FLRY</td>
                                    <td class="auto-style9" style="font-family: arial, Helvetica, sans-serif; font-weight: bolder; border: 1px solid #808080; background-color: #3366CC; color: #FFFFFF;">Kategori</td>
                                    <td class="auto-style9" style="font-family: arial, Helvetica, sans-serif; font-weight: bolder; border: 1px solid #808080; background-color: #3366CC; color: #FFFFFF;">Malzeme Toplamı</td>
                                    <td class="auto-style9" style="font-family: arial, Helvetica, sans-serif; font-weight: bolder; border: 1px solid #808080; background-color: #3366CC; color: #FFFFFF;">Siklus Sayısı</td>
                                    <td class="auto-style9" style="font-family: arial, Helvetica, sans-serif; font-weight: bolder; border: 1px solid #808080; background-color: #3366CC; color: #FFFFFF;">Ortalama</td>
                                </tr>
                                <tr>
                                    <td class="auto-style10" style="font-family: arial, Helvetica, sans-serif; font-weight: bolder; border: 1px solid #808080">
                                        <asp:Label ID="Label4" runat="server"></asp:Label>
                                    </td>
                                    <td class="auto-style10" style="font-family: arial, Helvetica, sans-serif; font-weight: bolder; border: 1px solid #808080">
                                        <asp:Label ID="Label5" runat="server"></asp:Label>
                                    </td>
                                    <td class="auto-style10" style="font-family: arial, Helvetica, sans-serif; font-weight: bolder; border: 1px solid #808080">
                                        <asp:Label ID="Label6" runat="server"></asp:Label>
                                    </td>
                                    <td class="auto-style10" style="font-family: arial, Helvetica, sans-serif; font-weight: bolder; border: 1px solid #808080">
                                        <asp:Label ID="Label7" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                          <asp:GridView ID="malzemeList0" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" Font-Names="Arial" Font-Size="13px" ForeColor="#333333" GridLines="Horizontal" Width="100%">
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                <Columns>
                                    <asp:BoundField DataField="malzemeAdi" HeaderText="Malzeme Adı">
                                    <HeaderStyle HorizontalAlign="Left" />
                                    </asp:BoundField>
                                    <asp:TemplateField HeaderText="Toplam Kullanılan">
                                        <ItemTemplate>
                                            <asp:Label ID="lblToplamKullanilan0" runat="server"></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Toplam Tutar">
                                        <ItemTemplate>
                                            <asp:Label ID="lblToplamTutar0" runat="server"></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Right" />
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:TemplateField>
                                </Columns>
                                <EditRowStyle BackColor="#999999" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            </asp:GridView>
                            <asp:DataList ID="anaListe0" runat="server" Width="100%">
                                <ItemTemplate>
                                    <table cellpadding="0" cellspacing="0" class="auto-style1">
                                        <tr>
                                            <td class="auto-style5" style="background-color: #66CCFF; font-family: arial, Helvetica, sans-serif; font-size: 13px; font-weight: 700">&nbsp;&nbsp;
                                                <asp:ImageButton ID="ac0" runat="server" ImageUrl="ac.gif" OnCommand="ac0_Command" />
                                                <asp:ImageButton ID="kapat0" runat="server" ImageUrl="kapat.gif" OnCommand="kapat0_Command" Visible="False" />
                                            </td>
                                            <td class="auto-style6" style="background-color: #66CCFF; font-family: arial, Helvetica, sans-serif; font-size: 13px; font-weight: 700">
                                                <asp:Label ID="hastaAdi0" runat="server"></asp:Label>
                                            </td>
                                            <td class="auto-style7" style="background-color: #66CCFF; font-family: arial, Helvetica, sans-serif; font-size: 13px; font-weight: 700;">S:<asp:Label ID="siklus0" runat="server" style="text-align: center"></asp:Label>
                                            </td>
                                            <td style="text-align: right; background-color: #66CCFF; font-family: arial, Helvetica, sans-serif; font-size: 13px; font-weight: 700;">
                                                <asp:Label ID="toplam0" runat="server"></asp:Label>
                                                &nbsp;&nbsp; </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2" colspan="4">
                                                <asp:GridView ID="altListe0" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" Font-Names="Arial" Font-Size="12px" ForeColor="#333333" Visible="False" Width="100%">
                                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                    <Columns>
                                                        <asp:BoundField DataField="malzemeAdi" HeaderText="Malzeme">
                                                        <HeaderStyle HorizontalAlign="Left" />
                                                        </asp:BoundField>
                                                        <asp:TemplateField HeaderText="Birim Fiyatı">
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblBirimFiyat0" runat="server"></asp:Label>
                                                            </ItemTemplate>
                                                            <HeaderStyle HorizontalAlign="Right" />
                                                            <ItemStyle HorizontalAlign="Right" />
                                                        </asp:TemplateField>
                                                        <asp:BoundField DataField="adet" HeaderText="Adet">
                                                        <HeaderStyle HorizontalAlign="Left" />
                                                        </asp:BoundField>
                                                        <asp:TemplateField HeaderText="Toplam Fiyat">
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblToplamFiyat0" runat="server"></asp:Label>
                                                            </ItemTemplate>
                                                            <HeaderStyle HorizontalAlign="Right" />
                                                            <ItemStyle HorizontalAlign="Right" />
                                                        </asp:TemplateField>
                                                        <asp:BoundField DataField="tarih" HeaderText="Tarih">
                                                        <HeaderStyle HorizontalAlign="Left" />
                                                        </asp:BoundField>
                                                    </Columns>
                                                    <EditRowStyle BackColor="#999999" />
                                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                </asp:GridView>
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:DataList>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
    
    </div>
    </form>
</body>
</html>
