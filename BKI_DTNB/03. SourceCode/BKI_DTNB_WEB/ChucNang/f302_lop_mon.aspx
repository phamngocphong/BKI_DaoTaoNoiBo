<%@ Page Title="" Language="C#" MasterPageFile="~/SiteDTNB.Master" AutoEventWireup="true" CodeBehind="f302_lop_mon.aspx.cs" Inherits="BKI_DTNB_WEB.ChucNang.f302_lop_mon" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <dx:ASPxGridView ID="m_grv" runat="server" AutoGenerateColumns="False" Width="977px">
        <Columns>
            <dx:GridViewDataTextColumn Caption="MÃ LỚP HỌC" FieldName="MA_LOP_HOC" VisibleIndex="0">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="TÊN MÔN HỌC" FieldName="MA_TEN_MON_HOC" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="MA_VERSION" FieldName="MA_VERSION" VisibleIndex="2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="THOI_GIAN" FieldName="THOI_GIAN" VisibleIndex="3">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="ĐỊA ĐIỂM" FieldName="DIA_DIEM" VisibleIndex="4">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="SỐ LƯỢNG" FieldName="SO_LUONG" VisibleIndex="5">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="ĐIỂM QUA MÔN" FieldName="DIEM_QUA_MON" VisibleIndex="6">
            </dx:GridViewDataTextColumn>
          
                <dx:GridViewCommandColumn VisibleIndex="8" ButtonType="Button" Caption="ĐĂNG KÍ" ShowEditButton="True">
            </dx:GridViewCommandColumn>
          
            
        </Columns>
    </dx:ASPxGridView>
</asp:Content>

