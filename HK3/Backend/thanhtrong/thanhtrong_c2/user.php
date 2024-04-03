<?php
class User{
    public $username;
    public $password; 
    public $firstName;
    public $lastName;
    public function __construct($username, $password, $firstName, $lastName){
        $this -> username = $username;
        $this -> password = password_hash($password, PASSWORD_DEFAULT);
        $this -> firstName = $firstName;
        $this -> lastName = $lastName;
    }
    public function getFullname(){
        return $this -> firstName." ".$this -> lastName;
    }
    public function getUsername(){
        return $this -> username;
    }
    public static function login($username, $password)
    {
        if ($username == "admin" && password_verify($password, password_hash("12345", PASSWORD_DEFAULT))) {
            return true;
        }
    }
}
class Student extends User{
    public $gpa;
    public function __construct($username, $password, $firstName, $lastName, $gpa){
        $this -> username = $username;
        $this -> password = password_hash($password, PASSWORD_DEFAULT);
        $this -> firstName = $firstName;
        $this -> lastName = $lastName;
        $this -> gpa = $gpa;
    }
    public function getGpa(){
        return $this -> gpa;
    }
    public function rank(){
        if ($this -> gpa < 5 ) {
            return "Yếu";
        }
        elseif ($this -> gpa < 7) {
            return "Trung Bình";
        }
        elseif ($this -> gpa < 8) {
            return "Khá";
        }
        else{
            return "Giỏi";
        }
    }
}
?>