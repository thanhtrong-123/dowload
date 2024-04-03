<!DOCTYPE html>
<html lang="zxx">

    <!-- Mirrored from htmldemo.hasthemes.com/hono/hono/wishlist.html by HTTrack Website Copier/3.x [XR&CO'2014], Wed, 06 Jan 2021 00:32:25 GMT -->
    <!-- Added by HTTrack --><meta http-equiv="content-type"
        content="text/html;charset=UTF-8" /><!-- /Added by HTTrack -->
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />

        <title>HONO - Multi Purpose HTML Template</title>

        <!-- ::::::::::::::Favicon icon::::::::::::::-->
        <link rel="shortcut icon" href="assets/images/favicon.ico"
            type="image/png">

        <!-- ::::::::::::::All CSS Files here :::::::::::::: -->
        <!-- Vendor CSS -->
        <!-- <link rel="stylesheet" href="assets/css/vendor/font-awesome.min.css">
    <link rel="stylesheet" href="assets/css/vendor/ionicons.css">
    <link rel="stylesheet" href="assets/css/vendor/simple-line-icons.css">
    <link rel="stylesheet" href="assets/css/vendor/jquery-ui.min.css"> -->

        <!-- Plugin CSS -->
        <!-- <link rel="stylesheet" href="assets/css/plugins/swiper-bundle.min.css">
    <link rel="stylesheet" href="assets/css/plugins/animate.min.css">
    <link rel="stylesheet" href="assets/css/plugins/nice-select.css">
    <link rel="stylesheet" href="assets/css/plugins/venobox.min.css">
    <link rel="stylesheet" href="assets/css/plugins/jquery.lineProgressbar.css">
    <link rel="stylesheet" href="assets/css/plugins/aos.min.css"> -->

        <!-- Main CSS -->
        <!-- <link rel="stylesheet" href="assets/sass/style.css"> -->

        <!-- Use the minified version files listed below for better performance and remove the files listed above -->
        <link rel="stylesheet" href="assets/css/vendor/vendor.min.css">
        <link rel="stylesheet" href="assets/css/plugins/plugins.min.css">
        <link rel="stylesheet" href="assets/css/style.min.css">

    </head>
    <body>
        <!-- Start Header Area -->
        <header class="header-section d-none d-xl-block">
            <div class="header-wrapper">
                <div
                    class="header-bottom header-bottom-color--golden section-fluid sticky-header sticky-color--golden">
                    <div class="container-fluid">
                        <div class="row">
                            <div
                                class="col-12 d-flex align-items-center justify-content-between">
                                <!-- Start Header Logo -->
                                <div class="header-logo">
                                    <div class="logo">
                                        <a href="{{ route('index') }}"><img
                                            src="assets/images/logo/logo_black.png"
                                                alt></a>
                                    </div>
                                </div>
                                <!-- End Header Logo -->

                                <!-- Start Header Main Menu -->
                                <div
                                    class="main-menu menu-color--black menu-hover-color--golden">
                                    <nav>
                                        <ul>
                                            <li class="has-dropdown">
                                                <a class="active main-menu-link"
                                                    href="{{ route('index') }}">Home</a>
                                            </li>
                                            <li
                                                class="has-dropdown has-megaitem">
                                                <a
                                                    href="{{ route('productdetails') }}">Shop
                                                    <i
                                                        class="fa fa-angle-down"></i></a>
                                                <!-- Mega Menu -->
                                                <div class="mega-menu">
                                                    <ul class="mega-menu-inner">
                                                        <!-- Mega Menu Sub Link -->
                                                        <li
                                                            class="mega-menu-item">
                                                            <a href="#"
                                                                class="mega-menu-item-title">Shop
                                                                Layouts</a>
                                                            <ul
                                                                class="mega-menu-sub">
                                                                <li><a
                                                                    href="{{ route('productslist') }}">Products
                                                                    List</a></li>
                                                            </ul>
                                                        </li>
                                                        <!-- Mega Menu Sub Link -->
                                                        <li
                                                            class="mega-menu-item">
                                                            <a href="#"
                                                                class="mega-menu-item-title">Other
                                                                Pages</a>
                                                            <ul
                                                                class="mega-menu-sub">
                                                                <li><a
                                                                        href="{{ route('cart') }}">Cart</a></li>
                                                                <li><a
                                                                        href="{{ route('wishlist') }}">Wishlist</a></li>
                                                                <li><a
                                                                        href="{{ route('compare') }}">Compare</a></li>
                                                                <li><a
                                                                        href="{{ route('checkout') }}">Checkout</a></li>
                                                                <li><a
                                                                        href="{{ route('login') }}">Login</a></li>
                                                                <li><a
                                                                        href="{{ route('myaccount') }}">My
                                                                        Account</a></li>
                                                            </ul>
                                                        </li>
                                                    </ul>
                                                    <div class="menu-banner">
                                                        <a href="#"
                                                            class="menu-banner-link">
                                                            <img
                                                                class="menu-banner-img"
                                                                src="assets/images/banner/menu-banner.jpg"
                                                                alt>
                                                        </a>
                                                    </div>
                                                </div>
                                            </li>
                                            <li class="has-dropdown">
                                                <a
                                                    href="{{ route('blog') }}">Blog</a>
                                            </li>
                                            <li class="has-dropdown">
                                                <a href="#">Pages <i
                                                        class="fa fa-angle-down"></i></a>
                                                <!-- Sub Menu -->
                                                <ul class="sub-menu">
                                                    <li><a
                                                            href="{{ route('faq') }}">Frequently
                                                            Questions</a></li>
                                                    <li><a
                                                            href="{{ route('privacypolicy') }}">Privacy
                                                            Policy</a></li>
                                                </ul>
                                            </li>
                                            <li>
                                                <a href="{{ route('aboutus') }}">About
                                                    Us</a>
                                            </li>
                                            <li>
                                                <a
                                                    href="{{ route('contactus') }}">Contact
                                                    Us</a>
                                            </li>
                                        </ul>
                                    </nav>
                                </div>
                                <!-- End Header Main Menu Start -->

                                <!-- Start Header Action Link -->
                                <ul
                                    class="header-action-link action-color--black action-hover-color--golden">
                                    <li>
                                        <a href="#offcanvas-wishlish"
                                            class="offcanvas-toggle">
                                            <i class="icon-heart"></i>
                                            <span class="item-count">3</span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#offcanvas-add-cart"
                                            class="offcanvas-toggle">
                                            <i class="icon-bag"></i>
                                            <span class="item-count">3</span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#search">
                                            <i class="icon-magnifier"></i>
                                        </a>
                                    </li>
                                    <li>
                                        <a href="#offcanvas-about"
                                            class="offacnvas offside-about offcanvas-toggle">
                                            <i class="icon-menu"></i>
                                        </a>
                                    </li>
                                </ul>
                                <!-- End Header Action Link -->
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </header>
        <!-- Start Header Area -->

        <!-- Start Offcanvas Mobile Menu Section -->
        <div id="offcanvas-about"
            class="offcanvas offcanvas-rightside offcanvas-mobile-about-section">
            <!-- Start Offcanvas Header -->
            <div class="offcanvas-header text-right">
                <button class="offcanvas-close"><i
                        class="ion-android-close"></i></button>
            </div> <!-- End Offcanvas Header -->
            <!-- Start Offcanvas Mobile Menu Wrapper -->
            <!-- Start Mobile contact Info -->
            <div class="mobile-contact-info">
                <div class="logo">
                    <a href="{{ route('index') }}"><img
                        src="assets/images/logo/logo_white.png" alt></a>
                </div>

                <address class="address">
                    <span>Address: 4710-4890 Breckinridge St, Fayettevill</span>
                    <span>Call Us: (+800) 345 678, (+800) 123 456</span>
                    <span>Email: yourmail@mail.com</span>
                </address>

                <ul class="social-link">
                    <li><a href="#"><i class="fa fa-facebook"></i></a></li>
                    <li><a href="#"><i class="fa fa-twitter"></i></a></li>
                    <li><a href="#"><i class="fa fa-instagram"></i></a></li>
                    <li><a href="#"><i class="fa fa-linkedin"></i></a></li>
                </ul>

                <ul class="user-link">
                    <li><a href="{{ route('wishlist') }}">Wishlist</a></li>
                    <li><a href="{{ route('cart') }}">Cart</a></li>
                    <li><a href="{{ route('checkout') }}">Checkout</a></li>
                </ul>
            </div>
            <!-- End Mobile contact Info -->
        </div> <!-- ...:::: End Offcanvas Mobile Menu Section:::... -->

        <!-- Start Offcanvas Addcart Section -->
        <div id="offcanvas-add-cart"
            class="offcanvas offcanvas-rightside offcanvas-add-cart-section">
            <!-- Start Offcanvas Header -->
            <div class="offcanvas-header text-right">
                <button class="offcanvas-close"><i
                        class="ion-android-close"></i></button>
            </div> <!-- End Offcanvas Header -->

            <!-- Start  Offcanvas Addcart Wrapper -->
            <div class="offcanvas-add-cart-wrapper">
                <h4 class="offcanvas-title">Shopping Cart</h4>
                <ul class="offcanvas-cart">
                    <li class="offcanvas-cart-item-single">
                        <div class="offcanvas-cart-item-block">
                            <a href="#" class="offcanvas-cart-item-image-link">
                                <img
                                src="assets/images/product/default/home-1/default-1.jpg"
                                    alt class="offcanvas-cart-image">
                            </a>
                            <div class="offcanvas-cart-item-content">
                                <a href="#" class="offcanvas-cart-item-link">Car
                                    Wheel</a>
                                <div class="offcanvas-cart-item-details">
                                    <span
                                        class="offcanvas-cart-item-details-quantity">1
                                        x </span>
                                    <span
                                        class="offcanvas-cart-item-details-price">$49.00</span>
                                </div>
                            </div>
                        </div>
                        <div class="offcanvas-cart-item-delete text-right">
                            <a href="#" class="offcanvas-cart-item-delete"><i
                                    class="fa fa-trash-o"></i></a>
                        </div>
                    </li>
                    <li class="offcanvas-cart-item-single">
                        <div class="offcanvas-cart-item-block">
                            <a href="#" class="offcanvas-cart-item-image-link">
                                <img
                                src="assets/images/product/default/home-2/default-1.jpg"
                                    alt class="offcanvas-cart-image">
                            </a>
                            <div class="offcanvas-cart-item-content">
                                <a href="#" class="offcanvas-cart-item-link">Car
                                    Vails</a>
                                <div class="offcanvas-cart-item-details">
                                    <span
                                        class="offcanvas-cart-item-details-quantity">3
                                        x </span>
                                    <span
                                        class="offcanvas-cart-item-details-price">$500.00</span>
                                </div>
                            </div>
                        </div>
                        <div class="offcanvas-cart-item-delete text-right">
                            <a href="#" class="offcanvas-cart-item-delete"><i
                                    class="fa fa-trash-o"></i></a>
                        </div>
                    </li>
                    <li class="offcanvas-cart-item-single">
                        <div class="offcanvas-cart-item-block">
                            <a href="#" class="offcanvas-cart-item-image-link">
                                <img
                                src="assets/images/product/default/home-3/default-1.jpg"
                                    alt class="offcanvas-cart-image">
                            </a>
                            <div class="offcanvas-cart-item-content">
                                <a href="#"
                                    class="offcanvas-cart-item-link">Shock
                                    Absorber</a>
                                <div class="offcanvas-cart-item-details">
                                    <span
                                        class="offcanvas-cart-item-details-quantity">1
                                        x </span>
                                    <span
                                        class="offcanvas-cart-item-details-price">$350.00</span>
                                </div>
                            </div>
                        </div>
                        <div class="offcanvas-cart-item-delete text-right">
                            <a href="#" class="offcanvas-cart-item-delete"><i
                                    class="fa fa-trash-o"></i></a>
                        </div>
                    </li>
                </ul>
                <div class="offcanvas-cart-total-price">
                    <span
                        class="offcanvas-cart-total-price-text">Subtotal:</span>
                    <span
                        class="offcanvas-cart-total-price-value">$170.00</span>
                </div>
                <ul class="offcanvas-cart-action-button">
                    <li><a href="{{ route('cart') }}"
                            class="btn btn-block btn-golden">View Cart</a></li>
                    <li><a href="{{ route('compare') }}"
                            class=" btn btn-block btn-golden mt-5">Checkout</a></li>
                </ul>
            </div> <!-- End  Offcanvas Addcart Wrapper -->

        </div> <!-- End  Offcanvas Addcart Section -->

        <!-- Start Offcanvas Mobile Menu Section -->
        <div id="offcanvas-wishlish"
            class="offcanvas offcanvas-rightside offcanvas-add-cart-section">
            <!-- Start Offcanvas Header -->
            <div class="offcanvas-header text-right">
                <button class="offcanvas-close"><i
                        class="ion-android-close"></i></button>
            </div> <!-- ENd Offcanvas Header -->

            <!-- Start Offcanvas Mobile Menu Wrapper -->
            <div class="offcanvas-wishlist-wrapper">
                <h4 class="offcanvas-title">Wishlist</h4>
                <ul class="offcanvas-wishlist">
                    <li class="offcanvas-wishlist-item-single">
                        <div class="offcanvas-wishlist-item-block">
                            <a href="#"
                                class="offcanvas-wishlist-item-image-link">
                                <img
                                src="assets/images/product/default/home-1/default-1.jpg"
                                    alt class="offcanvas-wishlist-image">
                            </a>
                            <div class="offcanvas-wishlist-item-content">
                                <a href="#"
                                    class="offcanvas-wishlist-item-link">Car
                                    Wheel</a>
                                <div class="offcanvas-wishlist-item-details">
                                    <span
                                        class="offcanvas-wishlist-item-details-quantity">1
                                        x </span>
                                    <span
                                        class="offcanvas-wishlist-item-details-price">$49.00</span>
                                </div>
                            </div>
                        </div>
                        <div class="offcanvas-wishlist-item-delete text-right">
                            <a href="#"
                                class="offcanvas-wishlist-item-delete"><i
                                    class="fa fa-trash-o"></i></a>
                        </div>
                    </li>
                    <li class="offcanvas-wishlist-item-single">
                        <div class="offcanvas-wishlist-item-block">
                            <a href="#"
                                class="offcanvas-wishlist-item-image-link">
                                <img
                                src="assets/images/product/default/home-2/default-1.jpg"
                                    alt class="offcanvas-wishlist-image">
                            </a>
                            <div class="offcanvas-wishlist-item-content">
                                <a href="#"
                                    class="offcanvas-wishlist-item-link">Car
                                    Vails</a>
                                <div class="offcanvas-wishlist-item-details">
                                    <span
                                        class="offcanvas-wishlist-item-details-quantity">3
                                        x </span>
                                    <span
                                        class="offcanvas-wishlist-item-details-price">$500.00</span>
                                </div>
                            </div>
                        </div>
                        <div class="offcanvas-wishlist-item-delete text-right">
                            <a href="#"
                                class="offcanvas-wishlist-item-delete"><i
                                    class="fa fa-trash-o"></i></a>
                        </div>
                    </li>
                    <li class="offcanvas-wishlist-item-single">
                        <div class="offcanvas-wishlist-item-block">
                            <a href="#"
                                class="offcanvas-wishlist-item-image-link">
                                <img
                                src="assets/images/product/default/home-3/default-1.jpg"
                                    alt class="offcanvas-wishlist-image">
                            </a>
                            <div class="offcanvas-wishlist-item-content">
                                <a href="#"
                                    class="offcanvas-wishlist-item-link">Shock
                                    Absorber</a>
                                <div class="offcanvas-wishlist-item-details">
                                    <span
                                        class="offcanvas-wishlist-item-details-quantity">1
                                        x </span>
                                    <span
                                        class="offcanvas-wishlist-item-details-price">$350.00</span>
                                </div>
                            </div>
                        </div>
                        <div class="offcanvas-wishlist-item-delete text-right">
                            <a href="#"
                                class="offcanvas-wishlist-item-delete"><i
                                    class="fa fa-trash-o"></i></a>
                        </div>
                    </li>
                </ul>
                <ul class="offcanvas-wishlist-action-button">
                    <li><a href="#" class="btn btn-block btn-golden">View
                            wishlist</a></li>
                </ul>
            </div> <!-- End Offcanvas Mobile Menu Wrapper -->

        </div> <!-- End Offcanvas Mobile Menu Section -->

        <!-- Start Offcanvas Search Bar Section -->
        <div id="search" class="search-modal">
            <button type="button" class="close">×</button>
            <form>
                <input type="search" placeholder="type keyword(s) here" />
                <button type="submit"
                    class="btn btn-lg btn-golden">Search</button>
            </form>
        </div>
        <!-- End Offcanvas Search Bar Section -->

        <!-- Offcanvas Overlay -->
        <div class="offcanvas-overlay"></div>

        <!-- ...:::: Start Breadcrumb Section:::... -->
        <div class="breadcrumb-section breadcrumb-bg-color--golden">
            <div class="breadcrumb-wrapper">
                <div class="container">
                    <div class="row">
                        <div class="col-12">
                            <h3 class="breadcrumb-title">Wishlist</h3>
                            <div
                                class="breadcrumb-nav breadcrumb-nav-color--black breadcrumb-nav-hover-color--golden">
                                <nav aria-label="breadcrumb">
                                    <ul>
                                        <li><a href="{{ route('index') }}">Home</a></li>
                                        <li><a
                                                href="{{ route('productslist') }}">Shop</a></li>
                                        <li class="active"
                                            aria-current="page">Wishlist</li>
                                    </ul>
                                </nav>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div> <!-- ...:::: End Breadcrumb Section:::... -->

        <!-- ...:::: Start Wishlist Section:::... -->
        <div class="wishlist-section">
            <!-- Start Cart Table -->
            <div class="wishlish-table-wrapper" data-aos="fade-up"
                data-aos-delay="0">
                <div class="container">
                    <div class="row">
                        <div class="col-12">
                            <div class="table_desc">
                                <div class="table_page table-responsive">
                                    <table>
                                        <!-- Start Wishlist Table Head -->
                                        <thead>
                                            <tr>
                                                <th
                                                    class="product_remove">Delete</th>
                                                <th
                                                    class="product_thumb">Image</th>
                                                <th
                                                    class="product_name">Product</th>
                                                <th
                                                    class="product-price">Price</th>
                                                <th class="product_stock">Stock
                                                    Status</th>
                                                <th class="product_addcart">Add
                                                    To Cart</th>
                                            </tr>
                                        </thead> <!-- End Cart Table Head -->
                                        <tbody>
                                            <!-- Start Wishlist Single Item-->
                                            <tr>
                                                <td class="product_remove"><a
                                                        href="#"><i
                                                            class="fa fa-trash-o"></i></a></td>
                                                <td class="product_thumb"><a
                                                        href="{{ route('productdetails') }}"><img
                                                        src="assets/images/product/default/home-1/default-1.jpg"
                                                            alt></a></td>
                                                <td class="product_name"><a
                                                        href="{{ route('productdetails') }}">Handbag
                                                        fringilla</a></td>
                                                <td
                                                    class="product-price">$65.00</td>
                                                <td class="product_stock">In
                                                    Stock</td>
                                                <td class="product_addcart"><a
                                                        href="#"
                                                        class="btn btn-md btn-golden"
                                                        data-bs-toggle="modal"
                                                        data-bs-target="#modalAddcart">Add
                                                        To Cart</a></td>
                                            </tr>
                                            <!-- End Wishlist Single Item-->
                                            <!-- Start Wishlist Single Item-->
                                            <tr>
                                                <td class="product_remove"><a
                                                        href="#"><i
                                                            class="fa fa-trash-o"></i></a></td>
                                                <td class="product_thumb"><a
                                                        href="{{ route('productdetails') }}"><img
                                                        src="assets/images/product/default/home-1/default-2.jpg"
                                                            alt></a></td>
                                                <td class="product_name"><a
                                                        href="{{ route('productdetails') }}">Handbags
                                                        justo</a></td>
                                                <td
                                                    class="product-price">$90.00</td>
                                                <td class="product_stock">In
                                                    Stock</td>
                                                <td class="product_addcart"><a
                                                        href="#"
                                                        class="btn btn-md btn-golden"
                                                        data-bs-toggle="modal"
                                                        data-bs-target="#modalAddcart">Add
                                                        To Cart</a></td>
                                            </tr>
                                            <!-- End Wishlist Single Item-->
                                            <!-- Start Wishlist Single Item-->
                                            <tr>
                                                <td class="product_remove"><a
                                                        href="#"><i
                                                            class="fa fa-trash-o"></i></a></td>
                                                <td class="product_thumb"><a
                                                        href="{{ route('productdetails') }}"><img
                                                        src="assets/images/product/default/home-1/default-3.jpg"
                                                            alt></a></td>
                                                <td class="product_name"><a
                                                        href="{{ route('productdetails') }}">Handbag
                                                        elit</a></td>
                                                <td
                                                    class="product-price">$80.00</td>
                                                <td class="product_stock">In
                                                    Stock</td>
                                                <td class="product_addcart"><a
                                                        href="#"
                                                        class="btn btn-md btn-golden"
                                                        data-bs-toggle="modal"
                                                        data-bs-target="#modalAddcart">Add
                                                        To Cart</a></td>
                                            </tr>
                                            <!-- End Wishlist Single Item-->
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div> <!-- End Cart Table -->
        </div> <!-- ...:::: End Wishlist Section:::... -->

        <!-- Start Footer Section -->
        <footer class="footer-section footer-bg section-top-gap-100">
            <div class="footer-wrapper">
                <!-- Start Footer Top -->
                <div class="footer-top">
                    <div class="container">
                        <div class="row mb-n6">
                            <div class="col-lg-3 col-sm-6 mb-6">
                                <!-- Start Footer Single Item -->
                                <div
                                    class="footer-widget-single-item footer-widget-color--golden"
                                    data-aos="fade-up" data-aos-delay="0">
                                    <h5 class="title">INFORMATION</h5>
                                    <ul class="footer-nav">
                                        <li><a href="#">Delivery
                                                Information</a></li>
                                        <li><a href="#">Terms &
                                                Conditions</a></li>
                                        <li><a
                                                href="{{ route('contactus') }}">Contact</a></li>
                                        <li><a href="#">Returns</a></li>
                                    </ul>
                                </div>
                                <!-- End Footer Single Item -->
                            </div>
                            <div class="col-lg-3 col-sm-6 mb-6">
                                <!-- Start Footer Single Item -->
                                <div
                                    class="footer-widget-single-item footer-widget-color--golden"
                                    data-aos="fade-up" data-aos-delay="200">
                                    <h5 class="title">MY ACCOUNT</h5>
                                    <ul class="footer-nav">
                                        <li><a href="{{ route('myaccount') }}">My
                                                account</a></li>
                                        <li><a
                                                href="{{ route('wishlist') }}">Wishlist</a></li>
                                        <li><a
                                                href="{{ route('privacypolicy') }}">Privacy
                                                Policy</a></li>
                                        <li><a href="{{ route('faq') }}">Frequently
                                                Questions</a></li>
                                        <li><a href="#">Order History</a></li>
                                    </ul>
                                </div>
                                <!-- End Footer Single Item -->
                            </div>
                            <div class="col-lg-3 col-sm-6 mb-6">
                                <!-- Start Footer Single Item -->
                                <div
                                    class="footer-widget-single-item footer-widget-color--golden"
                                    data-aos="fade-up" data-aos-delay="400">
                                    <h5 class="title">CATEGORIES</h5>
                                    <ul class="footer-nav">
                                        <li><a href="#">Decorative</a></li>
                                        <li><a href="#">Kitchen
                                                utensils</a></li>
                                        <li><a href="#">Chair & Bar
                                                stools</a></li>
                                        <li><a href="#">Sofas and
                                                Armchairs</a></li>
                                        <li><a href="#">Interior
                                                lighting</a></li>
                                    </ul>
                                </div>
                                <!-- End Footer Single Item -->
                            </div>
                            <div class="col-lg-3 col-sm-6 mb-6">
                                <!-- Start Footer Single Item -->
                                <div
                                    class="footer-widget-single-item footer-widget-color--golden"
                                    data-aos="fade-up" data-aos-delay="600">
                                    <h5 class="title">ABOUT US</h5>
                                    <div class="footer-about">
                                        <p>We are a team of designers and
                                            developers that create high quality
                                            Magento, Prestashop, Opencart.</p>

                                        <address class="address">
                                            <span>Address: 4710-4890
                                                Breckinridge St,
                                                Fayettevill</span>
                                            <span>Email:
                                                yourmail@mail.com</span>
                                        </address>
                                    </div>
                                </div>
                                <!-- End Footer Single Item -->
                            </div>
                        </div>
                    </div>
                </div>
                <!-- End Footer Top -->

                <!-- Start Footer Center -->
                <div class="footer-center">
                    <div class="container">
                        <div class="row mb-n6">
                            <div class="col-xl-3 col-lg-4 col-md-6 mb-6">
                                <div class="footer-social" data-aos="fade-up"
                                    data-aos-delay="0">
                                    <h4 class="title">FOLLOW US</h4>
                                    <ul class="footer-social-link">
                                        <li><a href="#"><i
                                                    class="fa fa-facebook"></i></a></li>
                                        <li><a href="#"><i
                                                    class="fa fa-twitter"></i></a></li>
                                        <li><a href="#"><i
                                                    class="fa fa-instagram"></i></a></li>
                                        <li><a href="#"><i
                                                    class="fa fa-linkedin"></i></a></li>
                                    </ul>
                                </div>
                            </div>
                            <div class="col-xl-7 col-lg-6 col-md-6 mb-6">
                                <div class="footer-newsletter"
                                    data-aos="fade-up" data-aos-delay="200">
                                    <h4 class="title">DON'T MISS OUT ON THE
                                        LATEST</h4>
                                    <div class="form-newsletter">
                                        <form action="#" method="post">
                                            <div
                                                class="form-fild-newsletter-single-item input-color--golden">
                                                <input type="email"
                                                    placeholder="Your email address..."
                                                    required>
                                                <button
                                                    type="submit">SUBSCRIBE!</button>
                                            </div>
                                        </form>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Start Footer Center -->

                <!-- Start Footer Bottom -->
                <div class="footer-bottom">
                    <div class="container">
                        <div
                            class="row justify-content-between align-items-center align-items-center flex-column flex-md-row mb-n6">
                            <div class="col-auto mb-6">
                                <div class="footer-copyright">
                                    <p> COPYRIGHT &copy; <a
                                            href="https://hasthemes.com/"
                                            target="_blank">HasThemes</a>. ALL
                                        RIGHTS RESERVED.</p>
                                </div>
                            </div>
                            <div class="col-auto mb-6">
                                <div class="footer-payment">
                                    <div class="image">
                                        <img
                                        src="assets/images/company-logo/payment.png"
                                            alt>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Start Footer Bottom -->
            </div>
        </footer>
        <!-- End Footer Section -->

        <!-- material-scrolltop button -->
        <button class="material-scrolltop" type="button"></button>

        <!-- Start Modal Add cart -->
        <div class="modal fade" id="modalAddcart" tabindex="-1" role="dialog"
            aria-hidden="true">
            <div class="modal-dialog  modal-dialog-centered modal-xl"
                role="document">
                <div class="modal-content">
                    <div class="modal-body">
                        <div class="container-fluid">
                            <div class="row">
                                <div class="col text-right">
                                    <button type="button"
                                        class="close modal-close"
                                        data-bs-dismiss="modal"
                                        aria-label="Close">
                                        <span aria-hidden="true"> <i
                                                class="fa fa-times"></i></span>
                                    </button>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-7">
                                    <div class="row">
                                        <div class="col-md-4">
                                            <div
                                                class="modal-add-cart-product-img">
                                                <img class="img-fluid"
                                                src="assets/images/product/default/home-1/default-1.jpg"
                                                    alt>
                                            </div>
                                        </div>
                                        <div class="col-md-8">
                                            <div class="modal-add-cart-info"><i
                                                    class="fa fa-check-square"></i>Added
                                                to cart successfully!</div>
                                            <div
                                                class="modal-add-cart-product-cart-buttons">
                                                <a href="{{ route('cart') }}">View
                                                    Cart</a>
                                                <a
                                                    href="{{ route('checkout') }}">Checkout</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-5 modal-border">
                                    <ul
                                        class="modal-add-cart-product-shipping-info">
                                        <li> <strong><i
                                                    class="icon-shopping-cart"></i>
                                                There Are 5 Items In Your
                                                Cart.</strong></li>
                                        <li> <strong>TOTAL PRICE: </strong>
                                            <span>$187.00</span></li>
                                        <li class="modal-continue-button"><a
                                                href="#"
                                                data-bs-dismiss="modal">CONTINUE
                                                SHOPPING</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div> <!-- End Modal Add cart -->

        <!-- Start Modal Quickview cart -->
        <div class="modal fade" id="modalQuickview" tabindex="-1" role="dialog"
            aria-hidden="true">
            <div class="modal-dialog  modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-body">
                        <div class="container-fluid">
                            <div class="row">
                                <div class="col text-right">
                                    <button type="button"
                                        class="close modal-close"
                                        data-bs-dismiss="modal"
                                        aria-label="Close">
                                        <span aria-hidden="true"> <i
                                                class="fa fa-times"></i></span>
                                    </button>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <div
                                        class="product-details-gallery-area mb-7">
                                        <!-- Start Large Image -->
                                        <div
                                            class="product-large-image modal-product-image-large swiper-container">
                                            <div class="swiper-wrapper">
                                                <div
                                                    class="product-image-large-image swiper-slide img-responsive">
                                                    <img
                                                    src="assets/images/product/default/home-1/default-1.jpg"
                                                        alt>
                                                </div>
                                                <div
                                                    class="product-image-large-image swiper-slide img-responsive">
                                                    <img
                                                    src="assets/images/product/default/home-1/default-2.jpg"
                                                        alt>
                                                </div>
                                                <div
                                                    class="product-image-large-image swiper-slide img-responsive">
                                                    <img
                                                    src="assets/images/product/default/home-1/default-3.jpg"
                                                        alt>
                                                </div>
                                                <div
                                                    class="product-image-large-image swiper-slide img-responsive">
                                                    <img
                                                    src="assets/images/product/default/home-1/default-4.jpg"
                                                        alt>
                                                </div>
                                                <div
                                                    class="product-image-large-image swiper-slide img-responsive">
                                                    <img
                                                    src="assets/images/product/default/home-1/default-5.jpg"
                                                        alt>
                                                </div>
                                                <div
                                                    class="product-image-large-image swiper-slide img-responsive">
                                                    <img
                                                    src="assets/images/product/default/home-1/default-6.jpg"
                                                        alt>
                                                </div>
                                            </div>
                                        </div>
                                        <!-- End Large Image -->
                                        <!-- Start Thumbnail Image -->
                                        <div
                                            class="product-image-thumb modal-product-image-thumb swiper-container pos-relative mt-5">
                                            <div class="swiper-wrapper">
                                                <div
                                                    class="product-image-thumb-single swiper-slide">
                                                    <img class="img-fluid"
                                                    src="assets/images/product/default/home-1/default-1.jpg"
                                                        alt>
                                                </div>
                                                <div
                                                    class="product-image-thumb-single swiper-slide">
                                                    <img class="img-fluid"
                                                    src="assets/images/product/default/home-1/default-2.jpg"
                                                        alt>
                                                </div>
                                                <div
                                                    class="product-image-thumb-single swiper-slide">
                                                    <img class="img-fluid"
                                                    src="assets/images/product/default/home-1/default-3.jpg"
                                                        alt>
                                                </div>
                                                <div
                                                    class="product-image-thumb-single swiper-slide">
                                                    <img class="img-fluid"
                                                    src="assets/images/product/default/home-1/default-4.jpg"
                                                        alt>
                                                </div>
                                                <div
                                                    class="product-image-thumb-single swiper-slide">
                                                    <img class="img-fluid"
                                                    src="assets/images/product/default/home-1/default-5.jpg"
                                                        alt>
                                                </div>
                                                <div
                                                    class="product-image-thumb-single swiper-slide">
                                                    <img class="img-fluid"
                                                    src="assets/images/product/default/home-1/default-6.jpg"
                                                        alt>
                                                </div>
                                            </div>
                                            <!-- Add Arrows -->
                                            <div
                                                class="gallery-thumb-arrow swiper-button-next"></div>
                                            <div
                                                class="gallery-thumb-arrow swiper-button-prev"></div>
                                        </div>
                                        <!-- End Thumbnail Image -->
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div
                                        class="modal-product-details-content-area">
                                        <!-- Start  Product Details Text Area-->
                                        <div class="product-details-text">
                                            <h4 class="title">Nonstick
                                                Dishwasher PFOA</h4>
                                            <div
                                                class="price"><del>$70.00</del>$80.00</div>
                                        </div>
                                        <!-- End  Product Details Text Area-->
                                        <!-- Start Product Variable Area -->
                                        <div class="product-details-variable">
                                            <!-- Product Variable Single Item -->
                                            <div class="variable-single-item">
                                                <span>Color</span>
                                                <div
                                                    class="product-variable-color">
                                                    <label
                                                        for="modal-product-color-red">
                                                        <input
                                                            name="modal-product-color"
                                                            id="modal-product-color-red"
                                                            class="color-select"
                                                            type="radio"
                                                            checked>
                                                        <span
                                                            class="product-color-red"></span>
                                                    </label>
                                                    <label
                                                        for="modal-product-color-tomato">
                                                        <input
                                                            name="modal-product-color"
                                                            id="modal-product-color-tomato"
                                                            class="color-select"
                                                            type="radio">
                                                        <span
                                                            class="product-color-tomato"></span>
                                                    </label>
                                                    <label
                                                        for="modal-product-color-green">
                                                        <input
                                                            name="modal-product-color"
                                                            id="modal-product-color-green"
                                                            class="color-select"
                                                            type="radio">
                                                        <span
                                                            class="product-color-green"></span>
                                                    </label>
                                                    <label
                                                        for="modal-product-color-light-green">
                                                        <input
                                                            name="modal-product-color"
                                                            id="modal-product-color-light-green"
                                                            class="color-select"
                                                            type="radio">
                                                        <span
                                                            class="product-color-light-green"></span>
                                                    </label>
                                                    <label
                                                        for="modal-product-color-blue">
                                                        <input
                                                            name="modal-product-color"
                                                            id="modal-product-color-blue"
                                                            class="color-select"
                                                            type="radio">
                                                        <span
                                                            class="product-color-blue"></span>
                                                    </label>
                                                    <label
                                                        for="modal-product-color-light-blue">
                                                        <input
                                                            name="modal-product-color"
                                                            id="modal-product-color-light-blue"
                                                            class="color-select"
                                                            type="radio">
                                                        <span
                                                            class="product-color-light-blue"></span>
                                                    </label>
                                                </div>
                                            </div>
                                            <!-- Product Variable Single Item -->
                                            <div
                                                class="d-flex align-items-center flex-wrap">
                                                <div
                                                    class="variable-single-item ">
                                                    <span>Quantity</span>
                                                    <div
                                                        class="product-variable-quantity">
                                                        <input min="1" max="100"
                                                            value="1"
                                                            type="number">
                                                    </div>
                                                </div>

                                                <div
                                                    class="product-add-to-cart-btn">
                                                    <a href="#"
                                                        data-bs-toggle="modal"
                                                        data-bs-target="#modalAddcart">Add
                                                        To Cart</a>
                                                </div>
                                            </div>
                                        </div>
                                        <!-- End Product Variable Area -->
                                        <div class="modal-product-about-text">
                                            <p>Lorem ipsum dolor sit amet,
                                                consectetur adipisicing elit.
                                                Mollitia iste laborum ad impedit
                                                pariatur esse optio tempora sint
                                                ullam autem deleniti nam in quos
                                                qui nemo ipsum numquam,
                                                reiciendis maiores quidem
                                                aperiam, rerum vel
                                                recusandae</p>
                                        </div>
                                        <!-- Start  Product Details Social Area-->
                                        <div
                                            class="modal-product-details-social">
                                            <span class="title">SHARE THIS
                                                PRODUCT</span>
                                            <ul>
                                                <li><a href="#"
                                                        class="facebook"><i
                                                            class="fa fa-facebook"></i></a></li>
                                                <li><a href="#"
                                                        class="twitter"><i
                                                            class="fa fa-twitter"></i></a></li>
                                                <li><a href="#"
                                                        class="pinterest"><i
                                                            class="fa fa-pinterest"></i></a></li>
                                                <li><a href="#"
                                                        class="google-plus"><i
                                                            class="fa fa-google-plus"></i></a></li>
                                                <li><a href="#"
                                                        class="linkedin"><i
                                                            class="fa fa-linkedin"></i></a></li>
                                            </ul>

                                        </div>
                                        <!-- End  Product Details Social Area-->
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div> <!-- End Modal Quickview cart -->

        <!-- ::::::::::::::All JS Files here :::::::::::::: -->
        <!-- Global Vendor, plugins JS -->
        <!-- <script src="assets/js/vendor/modernizr-3.11.2.min.js"></script>
    <script src="assets/js/vendor/jquery-3.5.1.min.js"></script>
    <script src="assets/js/vendor/jquery-migrate-3.3.0.min.js"></script>
    <script src="assets/js/vendor/popper.min.js"></script>
    <script src="assets/js/vendor/bootstrap.min.js"></script>
    <script src="assets/js/vendor/jquery-ui.min.js"></script>  -->

        <!--Plugins JS-->
        <!-- <script src="assets/js/plugins/swiper-bundle.min.js"></script>
    <script src="assets/js/plugins/material-scrolltop.js"></script>
    <script src="assets/js/plugins/jquery.nice-select.min.js"></script>
    <script src="assets/js/plugins/jquery.zoom.min.js"></script>
    <script src="assets/js/plugins/venobox.min.js"></script>
    <script src="assets/js/plugins/jquery.waypoints.js"></script>
    <script src="assets/js/plugins/jquery.lineProgressbar.js"></script>
    <script src="assets/js/plugins/aos.min.js"></script>
    <script src="assets/js/plugins/jquery.instagramFeed.js"></script>
    <script src="assets/js/plugins/ajax-mail.js"></script> -->

        <!-- Use the minified version files listed below for better performance and remove the files listed above -->
        <script src="assets/js/vendor/vendor.min.js"></script>
        <script src="assets/js/plugins/plugins.min.js"></script>

        <!-- Main JS -->
        <script src="assets/js/main.js"></script>
    </body>

    <!-- Mirrored from htmldemo.hasthemes.com/hono/hono/wishlist.html by HTTrack Website Copier/3.x [XR&CO'2014], Wed, 06 Jan 2021 00:32:25 GMT -->
</html>