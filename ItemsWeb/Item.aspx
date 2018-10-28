<%@ Page Title="Item" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Item.aspx.cs" Inherits="ItemsWeb.Item" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2> </h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
    <div class="form-horizontal">
    <div class="form-group">
         <asp:Label runat="server" AssociatedControlID="ddl_cats" CssClass="col-md-2 control-label">Category</asp:Label>
        <div class="col-md-10">
            <asp:DropDownList ID="ddl_cats" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
    </div>
    <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="item_nameEn" CssClass="col-md-2 control-label">Item name(English)</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="item_nameEn" CssClass="form-control"/>
                
            </div>
     </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="item_nameAr" CssClass="col-md-2 control-label">Item name(Arabic)</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="item_nameAr" CssClass="form-control" />
                
            </div>
        </div>
   
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="item_disc" CssClass="col-md-2 control-label">Item desc(English)</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="item_disc" CssClass="form-control" TextMode="MultiLine"/>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" AssociatedControlID="item_discAr" CssClass="col-md-2 control-label">Item desc(Arabic)</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="item_discAr" CssClass="form-control" TextMode="MultiLine"/>
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="FileUpload1" CssClass="col-md-2 control-label">Image</asp:Label>
            <div class="col-md-10"> 
                <asp:FileUpload ID="FileUpload1" runat="server"/>
            </div>
        </div>
   
        <div class="form-group">
              <asp:Label runat="server" AssociatedControlID="item_disc" CssClass="col-md-2 control-label">Price</asp:Label>
             <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                 <ContentTemplate>
                        <div class="col-md-10">
                            <asp:RadioButton ID="RadioButton1" runat="server" Text="One Size" GroupName="size" AutoPostBack="True" Checked="True" OnCheckedChanged="RadioButton1_CheckedChanged" />
                            <asp:RadioButton ID="RadioButton2" runat="server" Text="Two Size" GroupName="size" AutoPostBack="True" OnCheckedChanged="RadioButton2_CheckedChanged" />
                            <br />
                            <asp:TextBox runat="server" ID="item_size1" Width="50px" Visible="false"/>
                            <asp:TextBox runat="server" ID="item_price1" Width="120px" />
                            <br />
                            <asp:TextBox runat="server" ID="item_size2" Width="50px" Visible="false"/>
                            <asp:TextBox runat="server" ID="item_price2" Width="120px" Visible="false"/>
                        </div>
                 </ContentTemplate>
             </asp:UpdatePanel>      
              
                    </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" Text="Save" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>
