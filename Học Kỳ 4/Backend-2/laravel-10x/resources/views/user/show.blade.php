@extends('dashboard')

@section('content')
    <div class="container">
        <h1>{{ $user->name }}</h1>
        <p>Email: {{ $user->email }}</p>
        <p>Phone: {{ $user->phone }}</p>
        <p>password: {{ $user->password }}</p>
        <p>Image: {{ $user->image }}</p>
        
        <!-- Hiển thị thông tin khác của user tại đây -->
    </div>
    <a href="{{ route('users.show', $user->id) }}">{{ $user->name }}</a>
@endsection