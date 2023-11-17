<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RequestFunds.aspx.cs" Inherits="FundRaiser.RequestFunds" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <script>
    function countWords() {
        // get the input text and split it into words
        var input = document.getElementById('<%=story.ClientID%>').value;
        var words = input.split(' ');

        // get the word count and the maximum allowed count
        var count = words.length;
        var maxCount = 200; // change this to the desired word count limit

        // update the count label
        var label = document.getElementById('<%=lblCount.ClientID%>');
        label.innerHTML = count + ' of ' + maxCount + ' words';

        // disable the text box if the limit is exceeded
        if (count > maxCount) {
            document.getElementById('<%=story.ClientID%>').disabled = true;
        }
        else {
            document.getElementById('<%=story.ClientID%>').disabled = false;
        }
    }
    </script>



    <h1 style="padding-top:2%">Request funds here</h1>
    <div style="padding-top:5%">
        
        <div class="col-lg-8 mt-5 mt-lg-0" data-aos="fade-left">

          
              <div class="row">
                <div class="col-md-6 form-group">
                 
                    <asp:TextBox runat="server" ID="funddesc" placeholder="Fund Description" cssclass="form-control" ></asp:TextBox>
                </div>
                <div class="col-md-6 form-group mt-3 mt-md-0">
                   <asp:TextBox runat="server" ID="amountrequired" placeholder="Amount Required" cssclass="form-control"></asp:TextBox>
                </div>
              </div>
             <div class="row">
                  <div class="col-md-6 form-group">
                       <div class="form-group mt-3">
                <asp:DropDownList runat="server" cssclass="form-control" placeholder="Fund Type" ID="fundtype"></asp:DropDownList>
              </div>
                      </div>
                  <div class="col-md-6 form-group">
                        <div class="form-group mt-3">
                <asp:DropDownList runat="server" cssclass="form-control" placeholder="Featured" ID="featured"></asp:DropDownList>
              </div>
                      </div>
            
                 </div>
              <div class="row form-group">
                  <asp:TextBox runat="server" onkeyup="countWords();" ID="story" cssclass="form-control" TextMode="MultiLine" Rows="10" placeholder="Share your emotional story with us here...."/>
                 
                  <asp:Label runat="server" ID="lblCount" />
              
              </div>


             <div class="row">
                  <div class="col-md-6 form-group">
                       <div class="form-group mt-3">
                 <asp:FileUpload ID="uploadimg" runat="server"  placeholder="Upload a image here (if available)"/>
              </div>
                      </div>
                 
            
                 </div>



              <div class="my-3">
                
              </div>
              <div class="text-center" style="text-align:center">
                  
                  <asp:Button Text="Send Request" runat="server" ID="sendreq" OnClick="sendreq_Click" cssclass="form-control" 
                      BackColor="#e3dfd5" />
              </div>
           

          </div>

    </div>

      



    <div style="padding-top:40%">
          <!-- ======= Footer ======= -->
  

    </div>








</asp:Content>
