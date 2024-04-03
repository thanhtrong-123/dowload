<?php
class account{
    public $username;
    public $password;

    public function __construct($username,$password){
        $this->username = $username;
        $this->password = $password;
    }
    /*public function ktra($username,$password){
        $hash = password_hash("12345",PASSWORD_DEFAULT);
        if($username == "admin" && password_verify($password,$hash)){
            return true;
        }
        else {
            return false;
        }
    }*/
}
?>