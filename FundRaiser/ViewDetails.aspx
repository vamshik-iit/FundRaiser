<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewDetails.aspx.cs" Inherits="FundRaiser.ViewDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



     <style>
        .card {
            box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
            transition: 0.3s;
            width: 1300px;
            height:auto;
            padding: 12px 16px;
            
        }
        
        .card:hover {
            box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
        }
        
        .container {
            padding: 2px 16px;
            width: 1300px;
            height: 800px;
        }




        .col {
            display: flex;
            flex-wrap: wrap;
        }
        
        .col > div {
            flex: 1;
            padding: 10px;
        }

        .neat-button {
    background-color: #9e8f82;
    border: none;
    color: #fff;
    padding: 10px 20px;
    font-size: 16px;
    border-radius: 4px;
    box-shadow: 2px 2px 4px rgba(0,0,0,0.4);
    width:1000px;
}

.neat-button:hover {
    background-color: #FFA000;
    cursor: pointer;
}

    </style>



    <div style="padding-top:3%;padding-left:5%">
        <div class="row">
             <div class="card">
             <div class="col">
                 <div>
                     <asp:Image ID="uploadedimage" runat="server" Width="500px" Height="500px" />
                 </div>
                  <div>
                <h4>
                    <b>
                        <asp:Label runat="server" ID="title"></asp:Label>
                    </b>

                </h4>
                      
                <p>
                   <asp:Label runat="server" ID="emotionalstory"></asp:Label>

                </p>


                     


                       <h4>
                    <b>Amount Required: 
                        <asp:Label runat="server" ID="amountrequired"></asp:Label>
                    </b>

                </h4>


                      <h4>
                    <b>Amount Collected: 
                        <asp:Label runat="server" ID="amountcollected"></asp:Label>
                    </b>

                </h4>



                        <h4>
                    <b>Organized by: 
                        <asp:Label runat="server" ID="postedby"></asp:Label>
                    </b>

                </h4>

                       <p>Posted On: 
                   <asp:Label runat="server" ID="postedon"></asp:Label>

                </p>
                       

                      <br />
                     
                      <br />
                      <h4>
                      <b>Enter amount to donate: 
                        <asp:TextBox runat="server" ID="amountdonate"></asp:TextBox>
                    </b>
                      <br />
                          <br />
                      <b>Confirm amount to donate: 
                        <asp:TextBox runat="server" ID="confirmamountdonate"></asp:TextBox>
                    </b>
                      </h4>


                           <br />
                     
                      <br />


                      <asp:Button ID="Donate" runat="server" Text="Donate" CssClass="neat-button" OnClick="Donate_Click" />


            </div>






             </div>
           
            
        </div>
        </div>
        

       
    </div>

   







</asp:Content>
