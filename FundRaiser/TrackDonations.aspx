<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TrackDonations.aspx.cs" Inherits="FundRaiser.TrackDonations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">





      <div>
        <br />
        <br />
        <center>
           

            <div class="five">
                <h1>Track Donations</h1>
            </div>
            <br />

            <div class="row">
                <h4>
                    <b>Select Fund Request ID: 
                       <asp:DropDownList runat="server" ID="fundid"  OnSelectedIndexChanged="fundid_SelectedIndexChanged" AutoPostBack="True" ></asp:DropDownList>
                    </b>

                </h4>
            </div>

     
            <asp:GridView ID="GridView1" runat="server" CssClass="leftmargin table table-bordered table-condensed table-responsive table-hover" AutoGenerateColumns="false" AllowPaging="false"
                OnPageIndexChanging="OnPaging" PageSize="10">
                <Columns>
                    <asp:BoundField ItemStyle-Width="150px" DataField="PostID" HeaderText="PostID" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="FundDescription" HeaderText="FundDescription" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="Type" HeaderText="Type" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="AmountRequired" HeaderText="AmountRequired" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="PostedOn" HeaderText="PostedOn" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="IsFeatured" HeaderText="IsFeatured" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="EmotionalStory" HeaderText="EmotionalStory" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="Title" HeaderText="Title" />
                     <asp:BoundField ItemStyle-Width="150px" DataField="UserName" HeaderText="UserName" />




                   
                </Columns>
            </asp:GridView>
         



          <div class="five">
                <h1>Donations Details</h1>
            </div>
            <br />


             <asp:GridView ID="GridView2" runat="server" CssClass="leftmargin table table-bordered table-condensed table-responsive table-hover" AutoGenerateColumns="false" AllowPaging="false"
                OnPageIndexChanging="OnPaging" PageSize="10">
                <Columns>
                    <asp:BoundField ItemStyle-Width="150px" DataField="PostID" HeaderText="PostID" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="DonatedAmount" HeaderText="DonatedAmount" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="DonationStatus" HeaderText="DonationStatus" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="DonatedOn" HeaderText="DonatedOn" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="UserName" HeaderText="UserName" />
                   



                   
                </Columns>
            </asp:GridView>

    
        </center>
    </div>







</asp:Content>
