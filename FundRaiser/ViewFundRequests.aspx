<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewFundRequests.aspx.cs" Inherits="FundRaiser.ViewFundRequests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <style>
        .card {
            height: auto;
        }

            .card:hover {
                box-shadow: -1px 9px 40px -12px #808080;
            }

        .button1 {
            display: block;
            width: 130px;
            height: 50px;
            background: #9e8f82;
            padding: 10px;
            text-align: center;
            border-radius: 5px;
            color: white;
            font-weight: bold;
            line-height: 25px;
        }


    </style>

<div>
<center>

     <div style="padding-top:2%">
                <h1>Available fund requests</h1>
         <br />
            </div>


    <br />
    <br />
        <div>
          <h6>Filter</h6>
            <div>
                
                <table>
                    <tr>
                        <th>
                            <asp:TextBox runat="server" CssClass="input-form" ID="FundTitle" placeholder="Fund Title"></asp:TextBox>
                        </th>
                        <th>
                            <div style="padding-left: 10px">
                                  <asp:DropDownList ID="category" runat="server" placeholder="category">
                                
                                
                            </asp:DropDownList>

                               
                            </div>
                        </th>
                        <th>
                            <div style="padding-left: 10px">
                            <asp:DropDownList ID="Location" runat="server" placeholder="Location">
                                
                                
                            </asp:DropDownList>
                                </div>
                        </th>
                        <th>
                           
                        </th>
                        <th>
                            <div style="padding-left: 10px">
                                <asp:DropDownList ID="Featured" runat="server" placeholder="Featured">
                                   
                                </asp:DropDownList>
                            </div>
                        </th>
                        <th>
                            <div style="padding-left: 10px">
                                <asp:Button runat="server" CssClass="button" Text="Filter" ID="Filter" onclick="Filter_Click" />
                            </div>
                        </th>
                    </tr>
                    <tr>
                    </tr>
                </table>
                <%-- Filter Option Ends --%>
            </div>

    </div>


    <br />
    <br />

                  
            <div class="col" style="margin-left: 10px; margin-right: 20px">
                <% foreach (var i in DataClass1)
                    { %>

                <div class="card" style="width: 1000px; margin: 12px">
                    <div class="card-body">
                        <div class="card-title">

                            <div class="five">
                                

                                  <h6>ID - <%= i.PostID %></h6>
                                <h1><%= i.Title%></h1>

                            </div>                            
                        </div>

                        <div class="card-text">
                             <p>Amount Required: <%= i.AmountReq%></p>
                           
                            <p>Posted On: <%= i.PostedOn%></p>
                            <p>PostedBy: <%= i.PostedBy %></p>
                          
                            <h2>
                                <a href="ViewDetails.aspx?PostID=<%= i.PostID %>" class="button1">View</a>
                            </h2>

                        </div>




                    </div>
                </div>

                <% } %>
            </div>

          


    </center>
    </div>






</asp:Content>
