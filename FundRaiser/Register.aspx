<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FundRaiser.Register" %>

<!DOCTYPE html>

<html>
<head runat="server">
      	<title>Fund Raiser Register</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

	<link href="https://fonts.googleapis.com/css?family=Lato:300,400,700&display=swap" rel="stylesheet">

	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
	
	<link rel="stylesheet" href="css/style.css">
</head>
<body>
   	<section class="ftco-section">
		<div class="container">
			<div class="row justify-content-center">
				<div class="col-md-6 text-center mb-5">
					<h2 class="heading-section">Registration</h2>
				</div>
			</div>
			<div class="row justify-content-center">
				<div class="col-md-6 col-lg-4">
					<div class="login-wrap py-5">
		      	<div class="img d-flex align-items-center justify-content-center" style="background-image: url(images/bg.jpg);"></div>
		      	<h3 class="text-center mb-0">Welcome</h3>
		      	<p class="text-center">Sign up by entering the information below</p>
						<form action="#" class="login-form" runat="server">

							<div class="form-group">
		      			<div class="icon d-flex align-items-center justify-content-center"><span class="fa fa-user"></span></div>
		      			
						  <asp:TextBox runat="server" CssClass="form-control" placeholder="First Name" ID="firstname"></asp:TextBox>
		      		</div>

							<div class="form-group">
		      			<div class="icon d-flex align-items-center justify-content-center"><span class="fa fa-user"></span></div>
		      			
						  <asp:TextBox runat="server" CssClass="form-control" placeholder="Last Name" ID="lastname"></asp:TextBox>
		      		</div>


		      		<div class="form-group">
		      			<div class="icon d-flex align-items-center justify-content-center"><span class="fa fa-user"></span></div>
		      			
						  <asp:TextBox runat="server" CssClass="form-control" placeholder="Email" ID="email"></asp:TextBox>
		      		</div>
	            <div class="form-group">
	            	<div class="icon d-flex align-items-center justify-content-center"><span class="fa fa-lock"></span></div>
	            

					 <asp:TextBox runat="server" CssClass="form-control" placeholder="Password" ID="Password" Type="password"></asp:TextBox>

	            </div>

 <div class="form-group">
	            	<div class="icon d-flex align-items-center justify-content-center"><span class="fa fa-lock"></span></div>
	            

					 <asp:TextBox runat="server" CssClass="form-control" placeholder="Confirm Password" ID="cpassword" Type="password"></asp:TextBox>

	            </div>

	            <div class="form-group d-md-flex">
								<div class="w-100 text-md-right">
									<a href="#">Forgot Password</a>
								</div>
	            </div>
	            <div class="form-group">
	            	
					<asp:Button runat="server" CssClass="btn form-control btn-primary rounded submit px-3" Text="Register" ID="registerbtn" OnClick="registerbtn_Click" />



	            </div>
	          </form>
	          <div class="w-100 text-center mt-4 text">
	          	<p class="mb-0">Having an account?</p>
		          <a href="Login.aspx">Sign On</a>
	          </div>
	        </div>
				</div>
			</div>
		</div>
	</section>

	<script src="js/jquery.min.js"></script>
  <script src="js/popper.js"></script>
  <script src="js/bootstrap.min.js"></script>
  <script src="js/main.js"></script>
</body>
</html>




