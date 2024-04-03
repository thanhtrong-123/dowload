<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\User;
use Illuminate\Support\Facades\Hash;

class AuthController extends Controller
{
    public function showRegistrationForm()
    {
        return view('auth.register');
    }

    public function register(Request $request)
    {
        $validatedData = $request->validate([
            'phone' => 'required|unique:users',
            'image' => 'required|image|mimes:jpeg,png,jpg,gif|max:2048',
        ]);

        $user = new User;
        $user->phone = $validatedData['phone'];
        
        $image = $request->file('image');
        $image_name = time() . '_' . $image->getClientOriginalName();
        $image_path = $image->storeAs('public/images', $image_name);
        $user->image = $image_name;

        $user->save();

        return redirect('/')->with('success', 'Đăng ký thành công!');
    }
}
