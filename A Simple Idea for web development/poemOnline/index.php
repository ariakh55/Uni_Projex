<?php
require_once('query.php');
?>

<!DOCTYPE html>
<html>
  <head>
    <title>شعرآنلاین</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    
    <link href="https://fonts.googleapis.com/css2?family=Open+Sans:wght@400;600;700&display=swap" rel="stylesheet">
		<link href="https://fonts.googleapis.com/css2?family=Raleway:wght@400;500;600;700;800;900&display=swap" rel="stylesheet">

		<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">


    <link rel="stylesheet" href="css/animate.css">
    <link rel="shortcut icon" href="./images/favicon.ico" type="image/x-icon">
    <link rel="stylesheet" href="css/owl.carousel.min.css">
    <link rel="stylesheet" href="css/owl.theme.default.min.css">
    <link rel="stylesheet" href="css/magnific-popup.css">
    
	<link rel="stylesheet" href="css/flaticon.css">
    <link rel="stylesheet" href="css/style.css">
  </head>
  <body data-spy="scroll" data-target=".site-navbar-target" data-offset="300">
	  
	<script>
		object.addEventListener("click",alertFun);
		alertFun(){
			alert("Coming soon!");
		}
	</script>  
	<style>
		@font-face {
			font-family: "Samim FD", "Tanha FD", "Vazir FD";
			src: url("../fonts/Samim-FD.ttf") format("truetype"),
				url("../fonts/Samim-FD.woff") format("woff");
			src: url("../fonts/Tanha-FD.ttf") format("truetype"),
				url("../fonts/Tanha-FD.woff") format("woff");
			src: url("../fonts/Vazir-FD.ttf") format("truetype"),
				url("../fonts/Vazir-FD.woff") format("woff");
			font-weight: normal;
			font-style: normal;
		}
		body{
  			font-family: "Samim FD","Vazir FD","Tanha FD";
		}
		.circleAvatar{
			border-radius: 100px;
			width: 200px;
			height: 200px;
		}
	</style>
    <nav class="navbar navbar-expand-lg navbar-dark ftco_navbar ftco-navbar-light site-navbar-target" id="ftco-navbar">
	    <div class="container">
	      <a class="navbar-brand" href="index.php" style="font-family: Vazir FD;">شعرآنلاین<span>.</span></a>
	      <button class="navbar-toggler js-fh5co-nav-toggle fh5co-nav-toggle" type="button" data-toggle="collapse" data-target="#ftco-nav" aria-controls="ftco-nav" aria-expanded="false" aria-label="Toggle navigation">
	        <span class="oi oi-menu"></span> Menu
	      </button>

	      <div class="collapse navbar-collapse" id="ftco-nav">
	        <ul class="navbar-nav nav ml-auto">
	          <li class="nav-item"><a href="#home-section" class="nav-link"><span>خانه</span></a></li>
	          <li class="nav-item"><a href="#chapter-section" class="nav-link"><span>اشعار برتر</span></a></li>
	          <li class="nav-item"><a href="#projects-section" class="nav-link"><span>کتب و آثار</span></a></li>
	          <li class="nav-item"><a href="#author-section" class="nav-link"><span>نویسندگان</span></a></li>
	          <li class="nav-item"><a href="#about-section" class="nav-link"><span>درباره ما</span></a></li>
	          <li class="nav-item"><a href="#contact-section" class="nav-link"><span>ارتباط با ما</span></a></li>
	        </ul>
	      </div>
	    </div>
	  </nav>

	  <section class="hero-wrap js-fullheight">
      <div class="overlay"></div>
      <div class="container-fluid px-0">
      	<div class="row d-md-flex no-gutters slider-text align-items-center text-right js-fullheight justify-content-end">
	      	<img class="one-third" src="images/logo.png" alt="">
	        <div class="one-forth d-flex align-items-center ftco-animate js-fullheight">
	        	<div class="text mt-5">
	        		<span class="subheading">شعر و ادبیات فارسی</span>
		  				<h1 style="font-family: Tanha FD;">شعرآنلاین</h1>
						  <p>هدف ما در این سایت بخشیدن جان دوباره به شعر و ادب شیرین فارسی است. ما به گسترش  زبان و ادب فارسی در فضای وب می پردازیم.</p>
						  <p>علاوه بر شعر و ادب فارسی، به ادبیات جهان نیز  می پردازیم</p>
						  <p>برای شما با <span class="icon fa fa-heart"></span></p>
	          </div>
	        </div>
	    	</div>
      </div>
    </section>

    <section class="ftco-section ftco-no-pb ftco-no-pt" id="chapter-section">
    	<div class="container">
    		<div class="row justify-content-center py-5 mt-5">
          <div class="col-md-12 heading-section text-center ftco-animate">
            <h2 class="mb-4" style="font-family: Tanha FD;">اشعار برتر</h2>
          </div>
        </div>
    		<div class="row">
    			<div class="col-md-3 mb-4">
				    <nav id="navi">
					    <ul>
					      <li><a href="#page-1">3 روز اخیر</a></li>
					      <li><a href="#page-2">هفته</a></li>
					      <li><a href="#page-3">ماه</a></li>
					      <li><a href="#page-4">سال</a></li>
					    </ul>
					  </nav>
					</div>
					<div class="col-md-9 text-right">
					  <div id="page-1" class= "page bg-light one">
					  	<h2 class="heading" style="font-family: Vazir FD;">3 روز اخیر</h2>
					  	<?php
						  $poem = mysqli_query($conn, $poemsql);
						  while($row = mysqli_fetch_assoc($poem)){
							  if($row["ID"]==300){
								  $link = sprintf("<a href=\"poem.php?id=%s\">%s</a>",$row["ID"],$row["ID"]." - ".$row["Author"]." - ".$row["Title"]);
								  echo($link);
							  }
						  }
						?>
					  </div>
					  <div id="page-2" class= "page bg-light two">
					  	<h2 class="heading" style="font-family: Vazir FD;">هفته</h2>	
					  	<?php
						  $poem = mysqli_query($conn, $poemsql);
						  while($row = mysqli_fetch_assoc($poem)){
							  if($row["ID"]<=301){
								  $link = sprintf("<a href=\"poem.php?id=%s\">%s</a>",$row["ID"],$row["ID"]." - ".$row["Author"]." - ".$row["Title"]);
								  echo($link."<br>");
							  }
						  }
						?>
					  </div>
					  <div id="page-3" class= "page bg-light three">
					  	<h2 class="heading" style="font-family: Vazir FD;">ماه</h2>
					  	<?php
						  $poem = mysqli_query($conn, $poemsql);
						  while($row = mysqli_fetch_assoc($poem)){
							  if($row["ID"]<=302){
								  $link = sprintf("<a href=\"poem.php?id=%s\">%s</a>",$row["ID"],$row["ID"]." - ".$row["Author"]." - ".$row["Title"]);
								  echo($link."<br>");
							  }
						  }
						?>
					  </div>
					  <div id="page-4" class= "page bg-light four">
					    <h2 class="heading" style="font-family: Vazir FD;">سال</h2>
					    <?php
						  $poem = mysqli_query($conn, $poemsql);
						  while($row = mysqli_fetch_assoc($poem)){
							  if($row["ID"]<=303){
								  $link = sprintf("<a href=\"poem.php?id=%s\">%s</a>",$row["ID"],$row["ID"]." - ".$row["Author"]." - ".$row["Title"]);
								  echo($link."<br>");
							  }
						  }
						?>
					  </div>
					</div>
			  </div>
    	</div>
	</section>

    <section class="ftco-section ftco-project" id="projects-section">
    	<div class="container">
    		<div class="row no-gutters justify-content-center pb-5">
          <div class="col-md-12 heading-section text-center ftco-animate">
          	<span class="subheading">پیشنهاد سایت</span>
            <h2 class="mb-4" style="font-family: Tanha FD;">کتب و آثار</h2>
          </div>
        </div>
    		<div class="row">
				<?php 
					$book = mysqli_query($conn, $booksql);
					while($row = mysqli_fetch_assoc($book)){
						$text = sprintf(
						"<div class=\"col-md-3\">"
						."<div class=\"project img ftco-animate d-flex justify-content-center align-items-end\" style=\"background-image: url(".$row["cover"].".jpg);\">"
							."<div class=\"overlay\"></div>"
							."<div class=\"text p-4\">"
								."<h3 style=\"font-family: Vazir FD\"><a href=\"book.php?id=%s\">".$row["Title"]."</a></h3>"
								."<span>".$row["Author"]."</span>"
							."</div>"
						."</div>"
						."</div>",$row["ID"]
						);
						echo($text);
					}
				?>
    		</div>
    	</div>
    </section>

		<section class="ftco-about img ftco-section ftco-no-pt ftco-no-pb" id="author-section">
			<div class="col-md-12 heading-section text-center ftco-animate">
				<h2 class="mb-4" style="font-family: Tanha FD;">نویسندگان</h2>
			</div>
			<br>
    	<div class="container">
    		<div class="row d-flex no-gutters">
				<?php
					$author = mysqli_query($conn, $authorsql);
					while($row = mysqli_fetch_assoc($author)){
						$text = sprintf(
							"<div class=\"col-md-6 col-lg-6 d-flex\">"
								."<div class=\"py-md-5 w-100 bg-light px-md-5\">"
									."<div class=\"py-md-5\">"
										."<div class=\"row text-center pb-3\">"
											."<div class=\"col-md-12 heading-section ftco-animate\">"
												."<a href=\"author.php?id=%s\">"
												."<img class=\"circleAvatar\" src=\"".$row["img"].".jpg\" />"
												."<h2 class=\"mb-4\" style=\"font-family: Samim FD\">".$row["Name"]."</h2>"
												."</a>"
											."</div>"
										."</div>"
									."</div>"
								."</div>"
							."</div>",$row["ID"]
						);
						echo($text);
					}
				?>
        </div>
    	</div>
		</div>
    </section>

	<section class="ftco-about img ftco-section" id="about-section">
		<div class="container">
			<div class="row d-flex no-gutters">
				<div class="col-md-12 col-lg-12 pl-md-5">
					<div class="row justify-content-start text-center pb-3">
						<div class="col-md-12 heading-section ftco-animate">
							<h2 class="mb-4" style="font-family: Tanha FD;">درباره ما</h2>
							<div class="text-about">
								<h4 style="font-family: Vazir FD">طراحی و پیاده سازی: آریا خوشنود</h4>
								<h4 style="font-family: Vazir FD">دانشگاه فنی و حرفه ای شمسی پور</h4>
								<h4 style="font-family: Vazir FD">طراحی وب</h4>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>

    <section class="ftco-section contact-section ftco-no-pb" id="contact-section">
      <div class="container">
      	<div class="row justify-content-center mb-5 pb-3">
          <div class="col-md-7 heading-section text-center ftco-animate">
            <h2 class="mb-4" style="font-family: Tanha FD;">ارتباط با ما</h2>
          </div>
        </div>

        <div class="row d-flex contact-info mb-5">
          <div class="col-md-6 col-lg-6 d-flex ftco-animate">
          	<div class="align-self-stretch box text-center p-4 bg-light">
          		<div class="icon d-flex align-items-center justify-content-center">
          			<span class="fa fa-paper-plane"></span>
          		</div>
          		<div>
	          		<h3 class="mb-4" style="font-family: Samim FD">رایانامه</h3>
		            <p><a href="mailto:aria_khoshnood@yahoo.com">aria_khoshnood@yahoo.com</a></p>
		          </div>
	          </div>
          </div>
          <div class="col-md-6 col-lg-6 d-flex ftco-animate">
          	<div class="align-self-stretch box text-center p-4 bg-light">
          		<div class="icon d-flex align-items-center justify-content-center">
          			<span class="fa fa-globe"></span>
          		</div>
          		<div>
	          		<h3 class="mb-4" style="font-family: Samim FD">وب سایت</h3>
		            <p><a href="http://ariakh55.ir">ariakh55.ir</a></p>
	            </div>
	          </div>
          </div>
        </div>

        <div class="row no-gutters block-9">
          <div class="col-md-12 order-md-last d-flex">
            <form action="#" class="bg-light p-4 p-md-5 contact-form">
              <div class="form-group">
                <input type="text" class="form-control" placeholder="نام">
              </div>
              <div class="form-group">
                <input type="text" class="form-control" placeholder="رایانامه">
              </div>
              <div class="form-group">
                <input type="text" class="form-control" placeholder="موضوع">
              </div>
              <div class="form-group">
                <textarea name="" id="" cols="30" rows="7" class="form-control" placeholder="پیام"></textarea>
              </div>
              <div class="form-group">
                <input type="submit" value="ارسال پیام" class="btn btn-primary py-3 px-5">
              </div>
            </form>
          </div>
    </section>
		

    <footer class="ftco-footer ftco-section" style="background-color: #000C29;">
      <div class="container">
        <div class="row mb-5">
		<div class="col-md">
			<div class="ftco-footer-widget mb-4 text-center">
				<a class="navbar-brand" href="index.php" style="font-family: Vazir FD;">
					<img src="./images/logo-black.png" /><br>
					شعرآنلاین<span>.</span>
				</a>
			</div>
		  </div>
          <div class="col-md">
            <div class="ftco-footer-widget mb-4 ml-md-4">
              <h2 class="ftco-heading-2" style="font-family: Vazir FD;">لینک ها</h2>
              <ul class="list-unstyled">
                <li><a href="#"></span>خانه</a></li>
                <li><a href="#chapter-section"></span>برتر ها</a></li>
                <li><a href="#projects-section"></span>آثار</a></li>
                <li><a href="#author-section"></span>نویسندگان</a></li>
                <li><a href="#about-section"></span>درباره ما</a></li>
                <li><a href="#contact-section"></span>ارتباط با ما</a></li>
              </ul>
            </div>
          </div>
          <div class="col-md" style="direction: ltr;">
            <div class="ftco-footer-widget mb-4">
            	<h2 class="ftco-heading-2" style="font-family: Vazir FD;">سوالی پیش آمده؟</h2>
            	<div class="block-23 mb-3">
	              <ul>
	                <li><a href="mailto:aria_khoshnood@yahoo.com"><span class="icon fa fa-paper-plane"></span><span class="text">aria_khoshnood@yahoo.com</span></a></li>
	                <li><a href="http://ariakh55.ir"><span class="icon fa fa-globe"></span><span class="text">ariakh55.ir</span></a></li>
	              </ul>
	            </div>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-md-12 text-center">

            <p>
  Copyright &copy;<script>document.write(new Date().getFullYear());</script> All rights reserved | Made with <i class="fa fa-heart" aria-hidden="true"></i> by Aria Khoshnood</a>
  </p>
          </div>
        </div>
      </div>
    </footer>
    
  

  <!-- loader -->
  <div id="ftco-loader" class="show fullscreen"><svg class="circular" width="48px" height="48px"><circle class="path-bg" cx="24" cy="24" r="22" fill="none" stroke-width="4" stroke="#eeeeee"/><circle class="path" cx="24" cy="24" r="22" fill="none" stroke-width="4" stroke-miterlimit="10" stroke="#F96D00"/></svg></div>


  <script src="js/jquery.min.js"></script>
  <script src="js/jquery-migrate-3.0.1.min.js"></script>
  <script src="js/popper.min.js"></script>
  <script src="js/bootstrap.min.js"></script>
  <script src="js/jquery.easing.1.3.js"></script>
  <script src="js/jquery.waypoints.min.js"></script>
  <script src="js/jquery.stellar.min.js"></script>
  <script src="js/owl.carousel.min.js"></script>
  <script src="js/jquery.magnific-popup.min.js"></script>
  <script src="js/jquery.animateNumber.min.js"></script>
  <script src="js/scrollax.min.js"></script>
  <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBVWaKrjvy3MaE7SQ74_uJiULgl1JY0H2s&sensor=false"></script>
  <script src="js/google-map.js"></script>
  
  <script src="js/main.js"></script>
    
  </body>
</html>