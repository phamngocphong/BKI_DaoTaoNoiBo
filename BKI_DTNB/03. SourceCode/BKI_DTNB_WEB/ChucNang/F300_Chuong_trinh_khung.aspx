﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SiteDTNB.Master" AutoEventWireup="true" CodeBehind="F300_Chuong_trinh_khung.aspx.cs" Inherits="BKI_DTNB_WEB.ChucNang.F300_Chuong_trinh_khung" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <dx:ASPxGridView ID="m_grv" runat="server" AutoGenerateColumns="False" Width="799px" ClientIDMode="Static">
        <Columns>
            <dx:GridViewDataTextColumn Caption="TRUNG TÂM" FieldName="MA_TRUNG_TAM" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="NGẠCH" FieldName="MA_NGACH" VisibleIndex="2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="CHỨC VỤ" FieldName="CHUC_VU" VisibleIndex="3">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="NGHIỆP VỤ" FieldName="TEN_NGHIEP_VU" VisibleIndex="4">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="MÔN HỌC" FieldName="TEN_MON_HOC" VisibleIndex="5">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="ĐIỂM CHUYÊN CẦN" FieldName="diem_chuyen_can" VisibleIndex="6">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="DIỂM THI" FieldName="diem_thi" VisibleIndex="7">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="ĐIỂM KIỂM TRA" FieldName="diem_kiem_tra" VisibleIndex="8">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="KẾT QUẢ" FieldName="TEN" VisibleIndex="9">
            </dx:GridViewDataTextColumn>
        </Columns>
        <SettingsPager PageSize="100">
        </SettingsPager>
        <Settings ShowGroupPanel="True" />
        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
    </dx:ASPxGridView>
</asp:Content>

