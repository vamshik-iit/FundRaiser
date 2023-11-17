<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="FundRaiser.EditProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



     <h1 style="padding-top:2%">View/Edit Profile</h1>
    <div style="padding-top:5%">
        
        <div class="col-lg-8 mt-5 mt-lg-0" data-aos="fade-left">

          
              <div class="row">
                <div class="col-md-6 form-group">
                 
                    <asp:TextBox runat="server" ID="firstname" placeholder="First Name" cssclass="form-control" ></asp:TextBox>
                </div>
                <div class="col-md-6 form-group mt-3 mt-md-0">
                   <asp:TextBox runat="server" ID="lastname" placeholder="Last Name" cssclass="form-control"></asp:TextBox>
                </div>
              </div>
             <div class="row">
                  <div class="col-md-6 form-group">
                       <div class="form-group mt-3">
              <asp:TextBox runat="server" ID="address" placeholder="Address" cssclass="form-control"></asp:TextBox>
              </div>
                      </div>
                  <div class="col-md-6 form-group">
                        <div class="form-group mt-3">
               <asp:TextBox runat="server" ID="zipcode" placeholder="Zipcode/ Postal code" cssclass="form-control"></asp:TextBox>
              </div>
                      </div>
            
                 </div>



             <div class="row">
                  <div class="col-md-6 form-group">
                       <div class="form-group mt-3">
              <asp:TextBox runat="server" ID="bankacc" placeholder="Bank Account Number" cssclass="form-control"></asp:TextBox>
              </div>
                      </div>
                  <div class="col-md-6 form-group">
                        <div class="form-group mt-3">
               <asp:TextBox runat="server" ID="routingno" placeholder="Routing Number" cssclass="form-control"></asp:TextBox>
              </div>
                      </div>
            
                 </div>


             <div class="row">
                  <div class="col-md-6 form-group">
                       <div class="form-group mt-3">
              <asp:TextBox runat="server" ID="mobile" placeholder="Mobile Number" cssclass="form-control"></asp:TextBox>
              </div>
                      </div>
                
            
                 </div>




             
              <div class="my-3">
                
              </div>
              <div class="text-center" style="text-align:center">
                  
                  <asp:Button Text="Save" runat="server" ID="savedetails" OnClick="savedetails_Click" cssclass="form-control" 
                      BackColor="#e3dfd5" />
              </div>
           

          </div>

    </div>

      



    <div style="padding-top:40%">
          <!-- ======= Footer ======= -->
  <footer id="footer">
    <div class="container">
      <h3>Fund Raiser</h3>
      <p>Helping hands</p>
      <div class="social-links">
        <a href="#" class="twitter"><i class="bx bxl-twitter"></i></a>
        <a href="#" class="facebook"><i class="bx bxl-facebook"></i></a>
        <a href="#" class="instagram"><i class="bx bxl-instagram"></i></a>
        <a href="#" class="google-plus"><i class="bx bxl-skype"></i></a>
        <a href="#" class="linkedin"><i class="bx bxl-linkedin"></i></a>
      </div>
      <div class="copyright">
        &copy; Copyright <strong><span>Fund Raiser</span></strong>. All Rights Reserved
      </div>
      <div class="credits">
        <!-- All the links in the footer should remain intact. -->
        <!-- You can delete the links only if you purchased the pro version. -->
        <!-- Licensing information: https://bootstrapmade.com/license/ -->
        <!-- Purchase the pro version with working PHP/AJAX contact form: https://bootstrapmade.com/selecao-bootstrap-template/ -->
        Designed by <a href="https://bootstrapmade.com/">BootstrapMade</a>
      </div>
    </div>
  </footer><!-- End Footer -->


    </div>



</asp:Content>
