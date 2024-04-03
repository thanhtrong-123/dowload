<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\PageController;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return view('welcome');
});

Route::get('index', [PageController::class, 'index'])->name('index');
Route::get('aboutus', [PageController::class, 'aboutus'])->name('aboutus');
Route::get('blog', [PageController::class, 'blog'])->name('blog');
Route::get('cart', [PageController::class, 'cart'])->name('cart');
Route::get('checkout', [PageController::class, 'checkout'])->name('checkout');
Route::get('compare', [PageController::class, 'compare'])->name('compare');
Route::get('contactus', [PageController::class, 'contactus'])->name('contactus');
Route::get('faq', [PageController::class, 'faq'])->name('faq');
Route::get('login', [PageController::class, 'login'])->name('login');
Route::get('myaccount', [PageController::class, 'myaccount'])->name('myaccount');
Route::get('privacypolicy', [PageController::class, 'privacypolicy'])->name('privacypolicy');
Route::get('productdetails', [PageController::class, 'productdetails'])->name('productdetails');
Route::get('productslist', [PageController::class, 'productslist'])->name('productslist');
Route::get('wishlist', [PageController::class, 'wishlist'])->name('wishlist');
Route::get('detailblog', [PageController::class, 'detailblog'])->name('detailblog');
