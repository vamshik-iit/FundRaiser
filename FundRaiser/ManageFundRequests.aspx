<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageFundRequests.aspx.cs" Inherits="FundRaiser.ManageFundRequests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




        <div>
        <br />
        <br />
        <center>
           

            <div class="five">
                <h1>Request a Delete</h1>
            </div>
            <br />

            <%-- Grid View to show list of job poster by login recuiter --%>
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



                    <asp:TemplateField ShowHeader="False" ItemStyle-Width="150px">
                        <ItemTemplate>
                            <asp:Button ID="Deletion" runat="server" CommandArgument='<%#Eval("PostID")%>' Text="Delete"
                                CommandName="ThisBtnClick" CssClass="badge-danger" OnClick="Deletion_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <%-- Grid View Ends --%>
    
        </center>
    </div>







</asp:Content>
