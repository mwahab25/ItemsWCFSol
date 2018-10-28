<%@ Page Title="Category" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="ItemsWeb.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2> </h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
    <div class="form-horizontal">

     <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="cat_nameEn" CssClass="col-md-2 control-label">English name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="cat_nameEn" CssClass="form-control"/>
                
            </div>
     </div>

     <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="cat_nameAr" CssClass="col-md-2 control-label">Arabic name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="cat_nameAr" CssClass="form-control" />
                
            </div>
        </div>
     <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="FileUpload1" CssClass="col-md-2 control-label">Image</asp:Label>
            <div class="col-md-10"> 
                <asp:FileUpload ID="FileUpload1" runat="server"/>
            </div>
        </div>

     <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" Text="Save" CssClass="btn btn-default" OnClick="Save_Click" />
            </div>
        </div>
    <div class="form-group">
        <asp:GridView ID="GridView_cats" runat="server"></asp:GridView>
    </div>
    </div>
</asp:Content>
