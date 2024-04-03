@extends('user/layout/index')

@section('title')
Liên hệ - Trung tâm Minh Duy
@endsection

@section('content')
<!-- Begin Li's Breadcrumb Area -->
<div class="breadcrumb-area">
	<div class="container">
		<div class="breadcrumb-content">
			<ul>
				<li><a href="trang-chu.html">Trang chủ</a></li>
				<li class="active">Liên hệ</li>
			</ul>
		</div>
	</div>
</div>
<!-- Li's Breadcrumb Area End Here -->     
<!-- Begin Contact Main Page Area -->
<div class="contact-main-page mt-60 mb-40 mb-md-40 mb-sm-40 mb-xs-40">
	<div class="container mb-60">
		<div id="google-map"></div>
	</div>
	<div class="container">
		<div class="row">
			<div class="col-lg-5 offset-lg-1 col-md-12 order-1 order-lg-2">
				<div class="contact-page-side-content">
					<h3 class="contact-page-title">Thời gian làm việc</h3>
					<p class="contact-page-message mb-25">Claritas est etiam processus dynamicus, qui sequitur mutationem consuetudium lectorum. Mirum est notare quam littera gothica, quam nunc putamus parum claram anteposuerit litterarum formas human.</p>
					<div class="single-contact-block">
						<h4><i class="fa fa-fax"></i> Địa chỉ</h4>
						<p>{{$all_share_sp_cai_dat_trang_chu->dia_chi}}</p>
					</div>
					<div class="single-contact-block">
						<h4><i class="fa fa-phone"></i> Điện thoại</h4>
						<p>Di động: {{$all_share_sp_cai_dat_trang_chu->dien_thoai}}</p> 
					</div>
					<div class="single-contact-block last-child">
						<h4><i class="fa fa-envelope-o"></i> Email</h4>
						<p>{{$all_share_sp_cai_dat_trang_chu->email}}</p> 
					</div>
				</div>
			</div>
			<div class="col-lg-6 col-md-12 order-2 order-lg-1">
				<div class="contact-form-content pt-sm-55 pt-xs-55">
                    @if(Session::get('thong_bao_ho_tro') == '1')
                    <div class="alert alert-success">
                        <strong>Thành công!</strong> Yêu cầu của bạn đã được gửi, chúng tôi sẽ liên hệ lại sớm nhất.
                    </div>
                    @endif
                    @if(Session::get('thong_bao_ho_tro') == '0')
                    <div class="alert alert-danger">
                        <strong>Thất bại!</strong> Yêu cầu của bạn đã được gửi, vui lòng kiểm tra lại.
                    </div>
                    @endif
                    <h3 class="contact-page-title">Gởi yêu cầu đến chúng tôi</h3>
                    <div class="contact-form">
                      <form action="lien-he.html" method="post">
                        @csrf
                        <div class="form-group">
                            <label>Họ và tên <span class="required">*</span></label>
                            <input type="text" name="ten_lien_he" id="customername" required maxlength="70">
                        </div>
                        <div class="form-group">
                            <label>Email của bạn <span class="required">*</span></label>
                            <input type="email" name="mail_lien_he" id="customerEmail" required>
                        </div>
                        <div class="form-group">
                            <label>Liên hệ <span class="required">*</span></label>
                            <input type="text" name="lien_he" id="contactSubject" required>
                        </div>
                        <div class="form-group mb-30">
                            <label>Lời nhắn <span class="required">*</span></label>
                            <textarea name="loi_nhan" id="contactMessage" required></textarea>
                        </div>
                        <div class="form-group">
                            <button type="submit" value="submit" id="submit" class="li-btn-3" name="submit">Gửi</button>
                        </div>
                    </form>
                </div>
                <p class="form-messege"></p>
            </div>
        </div>
    </div>
</div>
</div>
<!-- Contact Main Page Area End Here -->
@endsection

@section('script')
<!-- Google Map -->
<script src="https://maps.google.com/maps/api/js?sensor=false&amp;libraries=geometry&amp;v=3.22&amp;key=AIzaSyChs2QWiAhnzz0a4OEhzqCXwx_qA9ST_lE"></script>

<script>
                // When the window has finished loading create our google map below
                google.maps.event.addDomListener(window, 'load', init);
                function init() {
                    // Basic options for a simple Google Map
                    // For more options see: https://developers.google.com/maps/documentation/javascript/reference#MapOptions
                    var mapOptions = {
                        // How zoomed in you want the map to start at (always required)
                        zoom: 12,
                        scrollwheel: false,
                        // The latitude and longitude to center the map (always required)
                        center: new google.maps.LatLng(15.565047, 108.478220), // New York
                        // How you would like to style the map. 
                        // This is where you would paste any style found on
                        styles: [{
                            "featureType": "water",
                            "elementType": "geometry",
                            "stylers": [{
                                "color": "#e9e9e9"
                            },
                            {
                                "lightness": 17
                            }
                            ]
                        },
                        {
                            "featureType": "landscape",
                            "elementType": "geometry",
                            "stylers": [{
                                "color": "#f5f5f5"
                            },
                            {
                                "lightness": 20
                            }
                            ]
                        },
                        {
                            "featureType": "road.highway",
                            "elementType": "geometry.fill",
                            "stylers": [{
                                "color": "#ffffff"
                            },
                            {
                                "lightness": 17
                            }
                            ]
                        },
                        {
                            "featureType": "road.highway",
                            "elementType": "geometry.stroke",
                            "stylers": [{
                                "color": "#ffffff"
                            },
                            {
                                "lightness": 29
                            },
                            {
                                "weight": 0.2
                            }
                            ]
                        },
                        {
                            "featureType": "road.arterial",
                            "elementType": "geometry",
                            "stylers": [{
                                "color": "#ffffff"
                            },
                            {
                                "lightness": 18
                            }
                            ]
                        },
                        {
                            "featureType": "road.local",
                            "elementType": "geometry",
                            "stylers": [{
                                "color": "#ffffff"
                            },
                            {
                                "lightness": 16
                            }
                            ]
                        },
                        {
                            "featureType": "poi",
                            "elementType": "geometry",
                            "stylers": [{
                                "color": "#f5f5f5"
                            },
                            {
                                "lightness": 21
                            }
                            ]
                        },
                        {
                            "featureType": "poi.park",
                            "elementType": "geometry",
                            "stylers": [{
                                "color": "#dedede"
                            },
                            {
                                "lightness": 21
                            }
                            ]
                        },
                        {
                            "elementType": "labels.text.stroke",
                            "stylers": [{
                                "visibility": "on"
                            },
                            {
                                "color": "#ffffff"
                            },
                            {
                                "lightness": 16
                            }
                            ]
                        },
                        {
                            "elementType": "labels.text.fill",
                            "stylers": [{
                                "saturation": 36
                            },
                            {
                                "color": "#333333"
                            },
                            {
                                "lightness": 40
                            }
                            ]
                        },
                        {
                            "elementType": "labels.icon",
                            "stylers": [{
                                "visibility": "off"
                            }]
                        },
                        {
                            "featureType": "transit",
                            "elementType": "geometry",
                            "stylers": [{
                                "color": "#f2f2f2"
                            },
                            {
                                "lightness": 19
                            }
                            ]
                        },
                        {
                            "featureType": "administrative",
                            "elementType": "geometry.fill",
                            "stylers": [{
                                "color": "#fefefe"
                            },
                            {
                                "lightness": 20
                            }
                            ]
                        },
                        {
                            "featureType": "administrative",
                            "elementType": "geometry.stroke",
                            "stylers": [{
                                "color": "#fefefe"
                            },
                            {
                                "lightness": 17
                            },
                            {
                                "weight": 1.2
                            }
                            ]
                        }
                        ]
                    };

                    // Get the HTML DOM element that will contain your map 
                    // We are using a div with id="map" seen below in the <body>
                    var mapElement = document.getElementById('google-map');

                    // Create the Google Map using our element and options defined above
                    var map = new google.maps.Map(mapElement, mapOptions);

                    // Let's also add a marker while we're at it
                    var marker = new google.maps.Marker({
                        position: new google.maps.LatLng(15.565047, 108.478220),
                        map: map,
                        title: 'Limupa',
                        animation: google.maps.Animation.BOUNCE
                    });
                }
            </script>
            @endsection