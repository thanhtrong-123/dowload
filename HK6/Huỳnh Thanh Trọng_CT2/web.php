<?php

use Illuminate\Support\Facades\Route;

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


Route::get('/hi', function () {
    return view('hi',['name' => 'Trọng']);
});

Route::get('/goodbye', function () {
    return view('goodbye',['day' => 'Ngày 26']);
});

Route::get('/page1', function () {
    return view('page1',['trangchu' => 'Trang chủ']);
});
Route::get('/page2', function () {
    return view('page2',['gioithieu' => 'Giới Thiệu']);
});
Route::get('/page3', function () {
    return view('page3',['sanpham1' => 'Bàn']);
});
Route::get('/page3', function () {
    return view('page3',['sanpham2' => 'Ghế']);
});
Route::get('/page4', function () {
    return view('page4',['lienhe' => 'Liên Hệ']);
});