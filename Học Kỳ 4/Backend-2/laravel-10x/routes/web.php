<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\UserController;
use App\Http\Controllers\CustomAuthController;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "web" middleware group. Make something great!
|
*/

Route::get('home', function () {
    return view('welcome');
});
Route::get('dashboard', [CustomAuthController::class, 'dashboard']);
Route::get('login', [CustomAuthController::class, 'index'])->name('login');
Route::post('custom-login', [CustomAuthController::class, 'customLogin'])->name('login.custom');
Route::get('registration', [CustomAuthController::class, 'registration'])->name('register-user');
Route::post('custom-registration', [CustomAuthController::class, 'customRegistration'])->name('register.custom');
Route::get('signout', [CustomAuthController::class, 'signOut'])->name('signout');
Route::get('/users/{id}', [UserController::class, 'show'])->name('users.show');
// Route::get('home', function () {
//     return view('user');
// });
// Route::prefix('group-route')->group(function () {
//     Route::get('home', function () {
//         return view('welcome');
//     })->name('nameRoute');
    
//     Route::get('user', function () {
//         //xử lý data
//         return view('user');
//     });
    
//     // Route::get('user', [UserController::class, 'index'])->middleware('auth');
//     // // resource
// });

