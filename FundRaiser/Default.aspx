<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FundRaiser._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

      <style>
        .card {
            height: auto;
        }

            .card:hover {
                box-shadow: -1px 9px 40px -12px #808080;
            }

        .button1 {
            display: block;
            width: 330px;
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


  <section id="hero" class="d-flex flex-column justify-content-end align-items-center">
    <div id="heroCarousel" data-bs-interval="5000" class="container carousel carousel-fade" data-bs-ride="carousel">

      <!-- Slide 1 -->
      <div class="carousel-item active">
        <div class="carousel-container">
          <h2 class="animate__animated animate__fadeInDown"> Welcome to <span>Fund Raiser</span></h2>
          <p class="animate__animated fanimate__adeInUp">Hi, you can donate funds here</p>
          <a href="#about" class="btn-get-started animate__animated animate__fadeInUp scrollto">Read More</a>
        </div>
      </div>


    

      <a class="carousel-control-prev" href="#heroCarousel" role="button" data-bs-slide="prev">
        <span class="carousel-control-prev-icon bx bx-chevron-left" aria-hidden="true"></span>
      </a>

      <a class="carousel-control-next" href="#heroCarousel" role="button" data-bs-slide="next">
        <span class="carousel-control-next-icon bx bx-chevron-right" aria-hidden="true"></span>
      </a>

    </div>

    <svg class="hero-waves" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" viewBox="0 24 150 28 " preserveAspectRatio="none">
      <defs>
        <path id="wave-path" d="M-160 44c30 0 58-18 88-18s 58 18 88 18 58-18 88-18 58 18 88 18 v44h-352z">
      </defs>
      <g class="wave1">
        <use xlink:href="#wave-path" x="50" y="3" fill="rgba(255,255,255, .1)">
      </g>
      <g class="wave2">
        <use xlink:href="#wave-path" x="50" y="0" fill="rgba(255,255,255, .2)">
      </g>
      <g class="wave3">
        <use xlink:href="#wave-path" x="50" y="9" fill="#fff">
      </g>
    </svg>




      <br />
      <br />


     

  </section>

     <div>

          <center>

     <div style="padding-top:2%">
                <h1>Featured fund requests</h1>
         <br />
            </div>

                  
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
