<?php
require_once('query.php');
?>

<!DOCTYPE html>
<html>
<head>
    <title><?php
        $id = $_GET['id'];
        $res = mysqli_query($conn, $booksql);
        while($row = mysqli_fetch_assoc($res)){
             if($row["ID"] == $id){
                $title = $row["Title"];
                $author = $row["Author"];
                $description = $row["Description"];
                $cover = $row["cover"];
                echo $author." - ".$title;
            }
        }
        ?>
    </title>
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
	      <a class="navbar-brand" href="index.html" style="font-family: Vazir FD;">شعرآنلاین<span>.</span></a>
	      <a href="/poemOnline/index.php#projects-section"><button class="btn" type="button">
	        بازگشت
          </button></a>
	    </div>
      </nav>
      
    <section class="ftco-about img ftco-section" id="about-section">
		<div class="container">
			<div class="row d-flex no-gutters">
				<div class="col-md-12 col-lg-12 pl-md-5">
					<div class="row justify-content-start text-right pb-3">
						<div class="col-md-12 heading-section ftco-animate">
							<h2 class="mb-4" style="font-family: Tanha FD;"><?php echo $title?></h2>
							<div class="text-about justify-content-start">
                                <img src="<?php echo $cover?>" />
                                <h4 style="font-family: Vazir FD"><?php echo $author?></h4>
                                <p><?php echo $description?></p>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>

	<footer class="ftco-footer ftco-section" style="background-color: #000C29;">
      <div class="container">
	  <div class="col-md">
			<div class="ftco-footer-widget mb-4 text-center">
				<a class="navbar-brand" href="index.php" style="font-family: Vazir FD;">
					<img widget="150px" height="150px" src="./images/logo-black.png" /><br>
					شعرآنلاین<span>.</span>
				</a>
			</div>
		  </div>
          <div class="col-md-12 text-center">

            <p>
  Copyright &copy;<script>document.write(new Date().getFullYear());</script> All rights reserved | Made with <i class="fa fa-heart" aria-hidden="true"></i> by Aria Khoshnood</a>
  </p>
          </div>
        </div>
      </div>
    </footer>

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