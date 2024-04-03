@extends('user/layout/index')

@section('title')
Thông tin - Trung tâm Minh Duy
@endsection

@section('css')
<style>
	.icon-view-about{
		font-size: 50px;
	}
</style>
@endsection

@section('content')
<!-- Begin Li's Breadcrumb Area -->
<div class="breadcrumb-area">
	<div class="container">
		<div class="breadcrumb-content">
			<ul>
				<li><a href="trang-chu.html">Trang chủ</a></li>
				<li class="active">Thông tin</li>
			</ul>
		</div>
	</div>
</div>
<!-- Li's Breadcrumb Area End Here -->
<!-- about wrapper start -->
<div class="about-us-wrapper pt-60 pb-40">
	<div class="container">
		<div class="row">
			<!-- About Text Start -->
			<div class="col-lg-12">
				<div class="about-text-wrap">
					<h2>Công ty công nghệ ứng dụng Minh Duy</h2>
					<p>We provide the best Beard oile all over the world. We are the worldd best store in indi for Beard Oil. You can buy our product without any hegitation because they truste us and buy our product without any hagitation because they belive and always happy buy our product.</p>
					<p>Some of our customer say’s that they trust us and buy our product without any hagitation because they belive us and always happy to buy our product.</p>
					<p>We provide the beshat they trusted us and buy our product without any hagitation because they belive us and always happy to buy.</p>
				</div>

				<div class="li-blog-blockquote">
					<blockquote>
						<p>Mặc thắc mắc xin vui lòng gửi đến hòm thư hổ trợ của Công ty Công nghệ Ứng dụng Minh Duy. Chúng tôi trả lời cho bạn sớm nhất!</p>
						 <a href="giai-dap-thac-mac.html"><i class="fa fa-hand-o-right"></i> Câu hỏi thường gặp!</a>
					</blockquote>
				</div>

			</div>
			<!-- About Text End --> 
		</div>
	</div>
</div>
<!-- about wrapper end -->
<!-- Begin Counterup Area -->
<div class="counterup-area">
	<div class="container-fluid p-0">
		<div class="row no-gutters">
			<div class="col-lg-3 col-md-6">
				<!-- Begin Limupa Counter Area -->
				<div class="limupa-counter white-smoke-bg">
					<div class="container">
						<div class="counter-img">
							<i class="icon-view-about fa fa-users"></i>
						</div>
						<div class="counter-info">
							<div class="counter-number">
								<h3 class="counter">{{count($all_share_users)}}</h3>
							</div>
							<div class="counter-text">
								<span>Tổng số người dùng</span>
							</div>
						</div>
					</div>
				</div>
				<!-- limupa Counter Area End Here -->
			</div>
			<div class="col-lg-3 col-md-6">
				<!-- Begin limupa Counter Area -->
				<div class="limupa-counter gray-bg">
					<div class="counter-img">
						<i class="icon-view-about fa fa-gift"></i>
					</div>
					<div class="counter-info">
						<div class="counter-number">
							<h3 class="counter">{{count($all_share_san_pham)}}</h3>
						</div>
						<div class="counter-text">
							<span>Sản phẩm</span>
						</div>
					</div>
				</div>
				<!-- limupa Counter Area End Here -->
			</div>
			<div class="col-lg-3 col-md-6">
				<!-- Begin limupa Counter Area -->
				<div class="limupa-counter white-smoke-bg">
					<div class="counter-img">
						<i class="icon-view-about fa fa-newspaper-o"></i>
					</div>
					<div class="counter-info">
						<div class="counter-number">
							<h3 class="counter">{{count($all_share_tin_tucs)}}</h3>
						</div>
						<div class="counter-text">
							<span>Tin tức tổng hợp</span>
						</div>
					</div>
				</div>
				<!-- limupa Counter Area End Here -->
			</div>
			<div class="col-lg-3 col-md-6">
				<!-- Begin limupa Counter Area -->
				<div class="limupa-counter gray-bg">
					<div class="counter-img">
						<i class="icon-view-about fa fa-building"></i>
					</div>
					<div class="counter-info">
						<div class="counter-number">
							<h3 class="counter">{{count($all_share_dich_vus)}}</h3>
						</div>
						<div class="counter-text">
							<span>Dịch vụ hiện có</span>
						</div>
					</div>
				</div>
				<!-- limupa Counter Area End Here -->
			</div>
		</div>
	</div>
</div>
<!-- Counterup Area End Here -->
<!-- team area wrapper start -->
<div class="team-area pt-60 pt-sm-44">
	<div class="container">
		<div class="row">
			<div class="col-12">
				<div class="li-section-title capitalize mb-25">
					<h2><span>Nhân sự</span></h2>
				</div>
			</div>
		</div> <!-- section title end -->
		<div class="row">
			<div class="col-lg-3 col-md-6 col-sm-6">
				<div class="team-member mb-60 mb-sm-30 mb-xs-30">
					<div class="team-thumb">
						<img src="user/assets/images/team/1.png" alt="Our Team Member">
					</div>
					<div class="team-content text-center">
						<h3>Jonathan Scott</h3>
						<p>IT Expert</p>
						
					</div>
				</div>
			</div> <!-- end single team member -->
			<div class="col-lg-3 col-md-6 col-sm-6">
				<div class="team-member mb-60 mb-sm-30 mb-xs-30">
					<div class="team-thumb">
						<img src="user/assets/images/team/2.png" alt="Our Team Member">
					</div>
					<div class="team-content text-center">
						<h3>Oliver Bastin</h3>
						<p>Web Designer</p>
						
					</div>
				</div>
			</div> <!-- end single team member -->
			<div class="col-lg-3 col-md-6 col-sm-6">
				<div class="team-member mb-30 mb-sm-60">
					<div class="team-thumb">
						<img src="user/assets/images/team/3.png" alt="Our Team Member">
					</div>
					<div class="team-content text-center">
						<h3>Erik Jonson</h3>
						<p>Web Developer</p>
						
					</div>
				</div>
			</div> <!-- end single team member -->
			<div class="col-lg-3 col-md-6 col-sm-6">
				<div class="team-member mb-30 mb-sm-60 mb-xs-60">
					<div class="team-thumb">
						<img src="user/assets/images/team/4.png" alt="Our Team Member">
					</div>
					<div class="team-content text-center">
						<h3>Maria Mandy</h3>
						<p>Marketing officer</p>
						
					</div>
				</div>
			</div> <!-- end single team member -->
		</div>
	</div>
</div>
<!-- team area wrapper end -->
@endsection