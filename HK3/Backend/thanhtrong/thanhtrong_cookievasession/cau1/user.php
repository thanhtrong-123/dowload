<?php
    class User{
        public $username;
        public $password;
        public $firstName;
        public $lastName;
        public function __construct($username, $password, $firstName, $lastName)
        {
            $this->username = $username;
            $this->password = password_hash($password,PASSWORD_DEFAULT);
            $this->firstName = $firstName;
            $this->lastName = $lastName;
        }
        public function getFullName(){
            return $this->firstName. " ". $this->lastName;
        }
        public function getUsername(){
            return $this->username;
        }
     public static function login($username,$password){
        if($username =="admin" && password_verify($password,password_hash("11112002",PASSWORD_DEFAULT))){
            
        
        return true;
        }
    }

    }
    ?>