<!DOCTYPE html>
<html lang="en">
<!-- Basic -->

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">

    <!-- Mobile Metas -->
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Site Metas -->
    <title>Freshshop - Ecommerce Bootstrap 4 HTML Template</title>
    <meta name="keywords" content="">
    <meta name="description" content="">
    <meta name="author" content="">

    <!-- Site Icons -->
    <link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon">
    <link rel="apple-touch-icon" href="images/apple-touch-icon.png">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="{{ url ('css/bootstrap.min.css') }}">
    <!-- Site CSS -->
    <link rel="stylesheet" href="{{ url('css/style.css') }}">
    <!-- Responsive CSS -->
    <link rel="stylesheet" href="{{ url('css/responsive.css') }}">
    <!-- Custom CSS -->
    <link rel="stylesheet" href="{{ url ('css/custom.css') }}">
    <!-- <link href="{{ url('http://maxcdn.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.min.css')}}" rel="stylesheet"> -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.12.0-2/css/fontawesome.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.12.0-2/css/all.min.css" />
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
      <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

</head>

<body>
    <!-- Start Main Top -->
    <div class="main-top">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                    <div class="custom-select-box">
                        <select id="basic" class="selectpicker show-tick form-control" data-placeholder="$ USD">
                            <option>¥ JPY</option>
                            <option>$ USD</option>
                            <option>€ EUR</option>
                        </select>
                    </div>
                    <div class="our-link">
                        <ul>
                            <li><a href="#"><i class="fa fa-user s_color"></i> My Account</a></li>
                            <li><a href="#"><i class="fas fa-location-arrow"></i> Our location</a></li>
                            <li><a href="{{ url('contact-us')}}"><i class="fas fa-headset"></i> Contact Us</a></li>
                        </ul>
                    </div>

                </div>

                <!-- Authentication -->
                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                    @if (Auth::check())
                    <div class="login-box">
                        <form method="POST" action="{{ route('logout') }}">
                            @csrf

                            <x-dropdown-link style="color:white" :href="route('logout')" onclick="event.preventDefault();
                                                this.closest('form').submit();">
                                {{ __('Log Out') }}
                            </x-dropdown-link>
                        </form>
                    </div>

                    @else
                    <div class="login-box">
                        <b><a style="color:white" href="{{ url('auth.login')}}">login</a></b>
                    </div>
                    @endif



                    <div class="text-slid-box">
                        <div id="offer-box" class="carouselTicker">
                            <ul class="offer-box">
                                <li>
                                    <i class="fab fa-opencart"></i> 20% off Entire Purchase Promo code: offT80
                                </li>
                                <li>
                                    <i class="fab fa-opencart"></i> 50% - 80% off on Vegetables
                                </li>
                                <li>
                                    <i class="fab fa-opencart"></i> Off 10%! Shop Vegetables
                                </li>
                                <li>
                                    <i class="fab fa-opencart"></i> Off 50%! Shop Now
                                </li>
                                <li>
                                    <i class="fab fa-opencart"></i> Off 10%! Shop Vegetables
                                </li>
                                <li>
                                    <i class="fab fa-opencart"></i> 50% - 80% off on Vegetables
                                </li>
                                <li>
                                    <i class="fab fa-opencart"></i> 20% off Entire Purchase Promo code: offT30
                                </li>
                                <li>
                                    <i class="fab fa-opencart"></i> Off 50%! Shop Now
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- End Main Top -->

    <!-- Start Main Top -->
    <header class="main-header">
        <!-- Start Navigation -->
        <nav class="navbar navbar-expand-lg navbar-light bg-light navbar-default bootsnav">
            <div class="container">
                <!-- Start Header Navigation -->
                <div class="navbar-header">
                    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbar-menu" aria-controls="navbars-rs-food" aria-expanded="false" aria-label="Toggle navigation">
                        <i class="fa fa-bars"></i>
                    </button>
                    <a class="navbar-brand" href="{{url('/')}}"><img src="{{ asset('images/logo.png')}}" class="logo" alt=""></a>
                </div>
                <!-- End Header Navigation -->

                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class="collapse navbar-collapse" id="navbar-menu">
                    <ul class="nav navbar-nav ml-auto" data-in="fadeInDown" data-out="fadeOutUp">
                        <li class="nav-item active"><a class="nav-link" href="{{url('/')}}">Home</a></li>
                        <li class="nav-item"><a class="nav-link" href="{{ url('about')}}">About Us</a></li>
                        <li class="dropdown">
                            <a href="#" class="nav-link dropdown-toggle" data-toggle="dropdown">SHOP</a>
                            <ul class="dropdown-menu">
                                <li><a href="{{url('shop')}}">Sidebar Shop</a></li>
                                <li><a href="{{url('cart')}}">Cart</a></li>
                                <li><a href="{{url('checkout')}}">Checkout</a></li>
                                <li><a href="{{url('order')}}">My Order</a></li>
                                <li><a href="{{url('wishlist')}}">Wishlist</a></li>
                            </ul>
                        </li>
                        <li class="nav-item"><a class="nav-link" href="{{url('shop')}}">Gallery</a></li>
                        <li class="nav-item"><a class="nav-link" href="{{ url('contact-us')}}">Contact Us</a></li>
                    </ul>
                </div>
                <!-- /.navbar-collapse -->

                <!-- Start Atribute Navigation -->
                <div class="attr-nav">
                    <ul>
                        <li class="search"><a href="#"><i class="fa fa-search"></i></a></li>
                        <li class="side-menu">
                            <a href="#">

                                <i class="fa fa-shopping-bag"></i>
                                <span class="badge">{{Cart::getContent()->count()}}</span>
                                <p>My Cart</p>
                            </a>
                        </li>

                    </ul>
                </div>
                <!-- End Atribute Navigation -->
            </div>
            <!-- Start Side Menu -->
            <div class="side">
                <a href="#" class="close-side"><i class="fa fa-times"></i></a>
                <li class="cart-box">
                    @if( Cart::getContent() != null)
                    <ul class="cart-list">

                        @foreach($cart = Cart::getContent() as $item)


                        <li class="cart-item">
                            <a href="{{ url('shop-detail/'.$item->id)}}" class="photo"><img src="{{url('images/'.$item['attributes']->img)}}" class="cart-thumb" alt="" /></a>
                            <h6><a href="{{ url('shop-detail/'.$item->id)}}">{{$item->name}} </a> <a onclick="DeleteCart('{{$item->id}}')" href="javascript:" class="fa fa-times" style="padding-left: 70px;"></a></h6>
                            <p>{{$item['quantity']}}x - <span class="price"> {{number_format($item->price)}}</span> </p>

                        </li>

                        @endforeach
                        <li class="total">
                            <a href="{{url('/cart')}}" class="btn btn-default hvr-hover btn-cart">VIEW CART</a>
                            <span class="float-right"><strong>Total</strong>:{{ number_format($total=Cart::getTotal())}} </span>
                        </li>

                    </ul>
                    <input id="badgevalue" type="hidden" value="{{Cart::getContent()->count()}}">
                    @endif
                </li>
            </div>
            <!-- End Side Menu -->
        </nav>
        <!-- End Navigation -->
    </header>
    <!-- End Main Top -->

    <!-- Start Top Search -->
    <div class="top-search">
        <div class="container">
            <div class="input-group">
                <form action="{{ url('/search-result') }}" method="get">
                    <span class="input-group-addon"><i class="fa fa-search"></i></span>
                    <input type="text" name="key" class="form-control" placeholder="Search">
                    <input type="submit" style="display:none" />
                    <span class="input-group-addon close-search"><i class="fa fa-times"></i></span>
                </form>
            </div>
        </div>
    </div>
    <!-- End Top Search -->
    @yield('content')
    <!-- Start Footer  -->
    <footer>
        <div class="footer-main">
            <div class="container">
                <div class="row">
                    <div class="col-lg-4 col-md-12 col-sm-12">
                        <div class="footer-top-box">
                            <h3>Business Time</h3>
                            <ul class="list-time">
                                <li>Monday - Friday: 08.00am to 05.00pm</li>
                                <li>Saturday: 10.00am to 08.00pm</li>
                                <li>Sunday: <span>Closed</span></li>
                            </ul>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-12 col-sm-12">
                        <div class="footer-top-box">
                            <h3>Newsletter</h3>
                            <form action="" method="post" class="newsletter-box">
                                @csrf
                                <div class="form-group">
                                    <input class="" type="email" name="email" placeholder="Email Address*" />
                                    <i class="fa fa-envelope"></i>
                                </div>
                                <button type="submit">Submit</button>
                            </form>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-12 col-sm-12">
                        <div class="footer-top-box">
                            <h3>Social Media</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                            <ul>
                                <li><a href="#"><i class="fab fa-facebook" aria-hidden="true"></i></a></li>
                                <li><a href="#"><i class="fab fa-twitter" aria-hidden="true"></i></a></li>
                                <li><a href="#"><i class="fab fa-linkedin" aria-hidden="true"></i></a></li>
                                <li><a href="#"><i class="fab fa-google-plus" aria-hidden="true"></i></a></li>
                                <li><a href="#"><i class="fa fa-rss" aria-hidden="true"></i></a></li>
                                <li><a href="#"><i class="fab fa-pinterest-p" aria-hidden="true"></i></a></li>
                                <li><a href="#"><i class="fab fa-whatsapp" aria-hidden="true"></i></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <hr>
                <div class="row">
                    <div class="col-lg-4 col-md-12 col-sm-12">
                        <div class="footer-widget">
                            <h4>About Freshshop</h4>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. </p>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-12 col-sm-12">
                        <div class="footer-link">
                            <h4>Information</h4>
                            <ul>
                                <li><a href="#">About Us</a></li>
                                <li><a href="#">Customer Service</a></li>
                                <li><a href="#">Our Sitemap</a></li>
                                <li><a href="#">Terms &amp; Conditions</a></li>
                                <li><a href="#">Privacy Policy</a></li>
                                <li><a href="#">Delivery Information</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-12 col-sm-12">
                        <div class="footer-link-contact">
                            <h4>Contact Us</h4>
                            <ul>
                                <li>
                                    <p><i class="fas fa-map-marker-alt"></i>Address: Michael I. Days 3756 <br>Preston Street Wichita,<br> KS 67213 </p>
                                </li>
                                <li>
                                    <p><i class="fas fa-phone-square"></i>Phone: <a href="tel:+1-888705770">+1-888 705 770</a></p>
                                </li>
                                <li>
                                    <p><i class="fas fa-envelope"></i>Email: <a href="mailto:contactinfo@gmail.com">contactinfo@gmail.com</a></p>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <!-- End Footer  -->

    <!-- Start copyright  -->
    <div class="footer-copyright">
        <p class="footer-company">All Rights Reserved. &copy; 2018 <a href="#">ThewayShop</a> Design By :
            <a href="https://html.design/">html design</a>
        </p>
    </div>
    <!-- End copyright  -->

    <a href="#" id="back-to-top" title="Back to top" style="display: none;">&uarr;</a>

    <!-- ALL JS FILES -->
    <script src="{{ asset('js/jquery-3.2.1.min.js ') }}"></script>
    <script src="{{ asset('js/popper.min.js ') }}"></script>
    <script src="{{ asset('js/bootstrap.min.js') }}"></script>
    <!-- ALL PLUGINS -->
    <script src="{{ asset('js/jquery.superslides.min.js ') }}"></script>
    <script src="{{ asset('js/bootstrap-select.js') }}"></script>
    <script src="{{ asset('js/inewsticker.js ') }}"></script>
    <script src="{{ asset('js/bootsnav.js') }}"></script>
    <script src="{{ asset('js/images-loded.min.js') }}"></script>
    <script src="{{ asset('js/isotope.min.js') }}"></script>
    <script src="{{ asset('js/owl.carousel.min.js') }}"></script>
    <script src="{{ asset('js/baguetteBox.min.js') }}"></script>
    <script src="{{ asset('js/form-validator.min.js') }}"></script>
    <script src="{{ asset('js/contact-form-script.js') }}"></script>
    <script src="{{ asset('js/custom.js') }}"></script>
    <!-- JavaScript -->
    <script src="{{ asset('//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/alertify.min.js') }}"></script>

    <!-- CSS -->
    <link rel="stylesheet" href="{{ asset('//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/css/alertify.min.css') }}" />
    <!-- Default theme -->
    <link rel="stylesheet" href="{{ asset('//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/css/themes/default.min.css') }}" />
    <!-- Semantic UI theme -->
    <link rel="stylesheet" href="{{ asset('//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/css/themes/semantic.min.css') }}" />
    <!-- Bootstrap theme -->
    <link rel="stylesheet" href="{{ asset('//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/css/themes/bootstrap.min.css') }}" />

    <script>
        $(document).ready(function() {
            
            load_comment();

            function load_comment(){

                var product_id = $('.comment_product_id').val();
                var _token = $('input[name="_token"]').val();

                $.ajax({
                    url : "{{url('/load-comment')}}",
                    method : "POST",
                    data:{product_id:product_id, _token:_token},
                    success:function(data){
                        $('#comment_show').html(data);
                    }
                });
            }

            $('.send-comment').click(function() {
                var product_id = $('.comment_product_id').val();
                var comment_name = $('.comment_name').val();
                var comment_content = $('.comment_content').val();
                var rating = $('.rating').val();
                var _token = $('input[name="_token"]').val();
                $.ajax({
                    url : "{{url('/send-comment')}}",
                    method : "POST",
                    data:{product_id:product_id, comment_name: comment_name, comment_content:comment_content, rating:rating,  _token:_token},
                    success:function(data){
                        load_comment();
                        $('#nottìy_comment').fadeOut(5000);
                        $('.comment_name').val(' ');
                        $('.comment_content').val(' ');
                        $('.rating').val('');
                        
                    }
                });

            });

            $('.delete-comment').click(function() {
                var comment_id = $('.comment_id').val();
                var product_id = $('.comment_product_id').val();
                var _token = $('input[name="_token"]').val();
                $.ajax({
                    url : "{{url('/del-comment')}}",
                    method : "POST",
                    data:{comment_id:comment_id, product_id:product_id, _token:_token},
                    success:function(data){
                        load_comment();
                    }
                });

            });

        });
        function Addcart(id) {
            $.ajax({
                url: '/addcart/' + id,
                type: 'GET',
            }).done(function(res) {
                RenderCart(res);
                alertify.success('Add to cart successfully');
            });
        }

        function Addwishlist(id) {
            $.ajax({
                url: '/addwl/' + id,
                type: 'GET',
            }).done(function(res) {

                alertify.success('Add to Wishlist successfulsly');
            });
        }

        function AddComment(id) {
            $.ajax({
                url: '/addcm/' + id,
                type: 'GET',
            }).done(function(res) {

                alertify.success('Add Comment successfulsly');
            });
        }

        function dell(id) {
            $.ajax({
                url: '/deletecm/' + id,
                type: 'GET',
            }).done(function(res) {

                load_comment();
                alertify.success('Delete Comment successfulsly');
            });
        }

        function deletewl(id) {
            $.ajax({
                url: '/deletewl/' + id,
                type: 'GET',
            }).done(function(res) {
                RenderListCart(res);
                alertify.success('Delete Wishlist Item successfulsly');
            });
        }


        function DeleteCart(id) {
            $.ajax({
                url: '/delcart/' + id,
                type: 'GET',
            }).done(function(res) {
                RenderCart(res);
                alertify.success('Delete successfully');
            });
        }

        function DeleteListCart(id) {
            $.ajax({
                url: 'dellistcart/' + id,
                type: 'GET',
            }).done(function(res) {
                RenderListCart(res);
                DeleteCart(id);

            });
        }

        function UpdateListCart(id) {

            $.ajax({
                url: 'updatelistcart/' + id + '/' + $("#quantity" + id).val(),
                type: 'GET',
            }).done(function(res) {
                RenderListCart(res);
                DeleteCart(null);


            });
        }



        function RenderCart(res) {
            $(".cart-list").empty();
            $(".cart-list").html(res);
            $(".badge").text($("#badgevalue").val());
        }

        function RenderListCart(res) {
            $(".cart-box-main").empty();
            $(".cart-box-main").html(res);

        }

        function RenderGallery(res) {
            $(".product-categorie-box").empty();
            $(".product-categorie-box").html(res);

        }

        $("#shop-sort").change(function() {

            ShowGallery();
        });

        function ShowGalleryBytype(id) {
            $.ajax({
                url: '/showbytype/' + id,
                type: 'GET',
            }).done(function(res) {
                RenderGallery(res);
                alertify.success('Update successfully');

            });
        }

        function ShowGalleryByManu(id) {
            $.ajax({
                url: '/showbymanu/' + id,
                type: 'GET',
            }).done(function(res) {
                RenderGallery(res);
                alertify.success('Update successfully');

            });
        }

        function ShowGallery() {

            if ($('#shop-sort option:selected').val() == 0) {

                $.ajax({
                    url: '/showall',
                    type: 'GET',
                }).done(function(res) {
                    RenderGallery(res);
                    alertify.success('Update successfully');

                });

            } else if ($('#shop-sort option:selected').val() == 1) {
                $.ajax({
                    url: '/showfeature',
                    type: 'GET',
                }).done(function(res) {
                    RenderGallery(res);
                    alertify.success('Update successfully');

                });

            } else if ($('#shop-sort option:selected').val() == 2) {
                console.log(3);
                $.ajax({
                    url: '/showhightolow',
                    type: 'GET',
                }).done(function(res) {
                    RenderGallery(res);
                    alertify.success('Update successfully');

                });

            } else if ($('#shop-sort option:selected').val() == 3) {
                $.ajax({
                    url: '/showlowtohigh',
                    type: 'GET',
                }).done(function(res) {
                    RenderGallery(res);
                    alertify.success('Update successfully');

                });

            } else if ($('#shop-sort option:selected').val() == 4) {
                $.ajax({
                    url: '/showbestselling',
                    type: 'GET',
                }).done(function(res) {
                    RenderGallery(res);
                    alertify.success('Update successfully');

                });

            }

        }
    </script>

</body>

</html>