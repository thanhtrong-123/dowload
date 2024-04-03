<!-- footer section -->
<footer class="footer_section">
  <div class="container">
    <div class="row">
      <div class="col-md-4 footer-col">
        <div class="footer_contact">
          <h4>
            Contact Us
          </h4>
          <div class="contact_link_box">
            <a href="about.php" style="text-align: justify;">
              <i class="fa fa-map-marker" aria-hidden="true"></i>
              <span style="text-align: left;;">
                <?php echo $getALLstore[0]['Location'] ?>
              </span>
            </a>
            <a href="about.php" style="text-align: justify;">
              <i class="fa fa-phone" aria-hidden="true"></i>
              <span style="text-align:left ;">
                Call <?php echo $getALLstore[0]['Phone_Number'] ?><br>
              </span>
            </a>
            <a href="about.php" style="text-align: justify;">
              <i class="fa fa-envelope" aria-hidden="true"></i>
              <span style="text-align:left ;">
                <?php echo $getALLstore[0]['Email'] ?><br>
              </span>
            </a>
          </div>
        </div>
      </div>
      <div class="col-md-4 footer-col">
        <div class="footer_detail">
          <a href="" class="footer-logo">
            <?php echo $getALLstore[0]['Store_Name'] ?>
          </a>
          <p style="text-align:justify;">
            <?php echo $getALLstore[0]['Short description'] ?><br><br>
          </p>
          <div class="footer_social">
            <a href="<?php echo $getALLstore[0]['Facebook'] ?>">
              <i class="fa fa-facebook" aria-hidden="true"></i>
            </a>
            <a href="<?php echo $getALLstore[0]['Twitter'] ?>">
              <i class="fa fa-twitter" aria-hidden="true"></i>
              <link rel="stylesheet" href="facebook.com">
            </a>
            <a href="<?php echo $getALLstore[0]['Linkedin'] ?>">
              <i class="fa fa-linkedin" aria-hidden="true"></i>
            </a>
            <a href="<?php echo $getALLstore[0]['Instagram'] ?>">
              <i class="fa fa-instagram" aria-hidden="true"></i>
            </a>
            <a href="<?php echo $getALLstore[0]['Pinterest'] ?>">
              <i class="fa fa-pinterest" aria-hidden="true"></i>
            </a>
          </div>
        </div>
      </div>
      <div class="col-md-4 footer-col">
        <h4>
          Opening Hours
        </h4>
        <p>
          <?php echo $getALLstore[0]['Opening day'] ?><br>
        </p>
        <p>
          <?php echo $getALLstore[0]['Open time'] ?><br>
        </p>
      </div>
    </div>
    <div class="footer-info">
      <p>
        &copy; <span id="displayYear"></span> All Rights Reserved By
        <a href="https://html.design/">Free Html Templates</a><br><br>
        &copy; <span id="displayYear"></span> Distributed By
        <a href="https://themewagon.com/" target="_blank">ThemeWagon</a>
      </p>
    </div>
  </div>
</footer>
<!-- footer section -->

<!-- jQery -->
<script src="js/jquery-3.4.1.min.js"></script>
<!-- popper js -->
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous">
</script>
<!-- bootstrap js -->
<script src="js/bootstrap.js"></script>
<!-- owl slider -->
<script src="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/owl.carousel.min.js">
</script>
<!-- isotope js -->
<script src="https://unpkg.com/isotope-layout@3.0.4/dist/isotope.pkgd.min.js"></script>
<!-- nice select -->
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-nice-select/1.1.0/js/jquery.nice-select.min.js"></script>
<!-- custom js -->
<script src="js/custom.js"></script>
<!-- Google Map -->
<script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCh39n5U-4IoWpsVGUHWdqB6puEkhRLdmI&callback=myMap">
</script>
<!-- End Google Map -->
<?php
if (isset($_SESSION['username'])) {
?>
    <script>
      document.getElementById("login").style.display = 'none';
      document.getElementById("logout").style.display = 'inline';
    </script>
<?php
}
?>
</body>

</html>