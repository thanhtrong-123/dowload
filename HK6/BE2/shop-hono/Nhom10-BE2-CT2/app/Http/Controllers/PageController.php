<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Http\Controllers\Controller;

class PageController extends Controller
{
    public function index()
    {
        return view('index');
    }

    public function cart()
    {
        return view('cart');
    }

    public function aboutus()
    {
        return view('aboutus');
    }

    public function blog()
    {
        return view('blog');
    }

    public function checkout()
    {
        return view('checkout');
    }

    public function compare()
    {
        return view('compare');
    }

    public function contactus()
    {
        return view('contactus');
    }

    public function faq()
    {
        return view('faq');
    }

    public function login()
    {
        return view('login');
    }

    public function myaccount()
    {
        return view('myaccount');
    }

    public function privacypolicy()
    {
        return view('privacypolicy');
    }

    public function productdetails()
    {
        return view('productdetails');
    }

    public function productslist()
    {
        return view('productslist');
    }

    public function wishlist()
    {
        return view('wishlist');
    }

    public function detailblog()
    {
        return view('detailblog');
    }
}
