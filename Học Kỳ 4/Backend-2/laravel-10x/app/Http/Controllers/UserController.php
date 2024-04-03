<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\User;


class UserController extends Controller
{
    // public function index(Request $rq)
    // {
    //     if($rq-> $token){
    //         dd('co token');
    //     }
    //     else {
    //         return redirect()->route('nameRoute');
    //     }
    //     // dd($rq->key1, $rq->token);
    //     // return view('user',[
    //     //     'token' => $rq->token
    //     // ]);
    // }
    public function show($id)
    {
        $user = User::findOrFail($id);
        return view('users.show', compact('user'));
    }
}
