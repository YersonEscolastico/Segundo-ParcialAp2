﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="cReportes.aspx.cs" Inherits="Parcial2.Consultas.cReportes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 
        <div class="panel-heading" style="font-family: Arial Black; font-size: 20px; text-align:center; color: Black">Consulta de Transacciones</div>
    </div>

    <div class="panel panel-primary">
        <div class="panel-body">

            <div class="form-group row">
                <label for="Desde" class="col-sm-1 col-md-offset-2 col-form-label">Desde</label>
                <div class="col-md-2">
                    <asp:TextBox type="date" runat="server" ID="DesdeFecha" Class="form-control input-sm"></asp:TextBox>
                </div>
            </div>

            <div class="form-group row">
                <label for="Hasta" class="col-sm-1 col-md-offset-2 col-form-label">Hasta</label>
                <div class="col-md-2">
                    <asp:TextBox type="date" runat="server" ID="HastaFecha" Class="form-control input-sm"></asp:TextBox>
                </div>
            </div>

            <div class="form-group row">
                <label for="Filtro" class="col-sm-1 col-md-offset-2 col-form-label">Filtro</label>
                <div class="col-md-2">
                    <asp:DropDownList ID="FiltroDropDown" runat="server" CssClass="form-control input-sm">
                        <asp:ListItem>Todo</asp:ListItem>
                        <asp:ListItem>ID</asp:ListItem>
                        <asp:ListItem>Monto</asp:ListItem>
                        <asp:ListItem>Tipo</asp:ListItem>
                    </asp:DropDownList>
                </div>
                 
                <label for="CheckBox" class="col-sm-1 col-md-offset-1 col-form-label">Desea Agregar Fecha</label>
               <asp:CheckBox runat="server" CssClass="custom-checkbox" ID="CheckBoxFecha" />
            </div>

            <div class="form-group row">
                <label for="Criterio" class="col-sm-1 col-md-offset-2 col-form-label">Criterio</label>
                <div class="col-md-3">
                    <asp:TextBox ID="CriterioTextBox" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:Button ID="ConsultarButton" runat="server" Class="btn btn-primary input-sm" Text="Consultar" OnClick="ConsultarButton_Click"  />
        
                </div>
            </div>

        </div>
        <asp:GridView ID="Grid" runat="server" class="table table-condensed table-responsive" AutoGenerateColumns="true" ShowHeaderWhenEmpty="True" DataKeyNames="TransaccionId" CellPadding="4" ForeColor="Black" GridLines="None">
            <EmptyDataTemplate>
                <div style="text-align: center">No hay datos.</div>
            </EmptyDataTemplate>
            <AlternatingRowStyle BackColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
        </asp:GridView>

             <%--Imprimir--%>
       <div class="col-md-4">
                    <asp:Button ID="ImprimirButton" runat="server" Class="btn btn-primary input-sm" Text="Imprimnir" OnClick="ImprimirButton_Click" />
        
                </div>    </div>

   
</asp:Content>