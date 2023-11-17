<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageAccess.aspx.cs" Inherits="FundRaiser.ManageAccess" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h1 style="padding-top:2%">Manage Access/Users</h1>
    <div style="padding-top:5%">
        
        <div class="col-lg-8 mt-5 mt-lg-0" data-aos="fade-left">



             <div class="row">
                <div class="col-md-6 form-group">
                 
                    <asp:TextBox runat="server" ID="EmailUserID" placeholder="Email/UserID" cssclass="form-control" ></asp:TextBox>
                </div>
                <div class="col-md-6 form-group mt-3 mt-md-0">
                   <asp:TextBox runat="server" ID="UserRole" placeholder="Role" cssclass="form-control" Enabled="false"></asp:TextBox>
                </div>
              </div>


             <div class="row">
                <div class="col-md-6 form-group">
                 
                    <asp:Button runat="server" Text="Fetch Current Role" ID="FetchCurrentRole" OnClick="FetchCurrentRole_Click" cssclass="form-control" BackColor="#e3dfd5"/> 
                </div>
                <div class="col-md-6 form-group mt-3 mt-md-0">
                   
                </div>
              </div>



             <div class="row">
                <div class="col-md-6 form-group">
                 
                    <asp:DropDownList runat="server" ID="NewRole" cssclass="form-control">
                         <asp:listitem text="--Select Role--" value="Select"></asp:listitem>
     <asp:listitem text="Admin" value="Admin"></asp:listitem>
     <asp:listitem text="User" value="User"></asp:listitem>
     <asp:listitem text="Donor" value="Donor"></asp:listitem>
                    </asp:DropDownList>
                </div>
                <div class="col-md-6 form-group mt-3 mt-md-0">
                    <asp:Button runat="server" Text="Update Role" ID="UpdateRole" OnClick="UpdateRole_Click" cssclass="form-control" BackColor="#e3dfd5"/> 
                </div>
              </div>





            </div>

        </div>








</asp:Content>
