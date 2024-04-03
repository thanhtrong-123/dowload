<?php
        Class User{
         // Properties
        public $username;
        public $password;
        public $firstname;
        public $lastname;
        
         // Methods
        public function __construct($username, $password, $firstname, $lastname) {
            $this->username = $username;
            $this->password = password_hash($password, PASSWORD_DEFAULT);
            $this->firstname = $firstname;
            $this->lastname = $lastname;
        }
        public function getFullname() {
            return $this->firstname." ".$this->lastname;
        }
        public function getUsername(){
            return $this->username;
        }
        public function login($username,$password){
            $hash = password_hash("12345", PASSWORD_DEFAULT); 
            if( $username == "admin" && password_verify($password,$hash)){
                return true;
            }
            else{
                return false;
            }
        }
    }
        //Class Student ke thua tu User
        class Student extends User 
        {
            public $gpa;
            //Methods
            public function __construct($username, $password, $firstname, $lastname, $gpa) {
                $this->username = $username;
                $this->password = password_hash($password, PASSWORD_DEFAULT);
                $this->firstname = $firstname;
                $this->lastname = $lastname;
                $this->gpa = $gpa;
            }
            public function getGPA() {
                return $this->gpa;
            }
            public function getXepLoai($gpa){
                $xepLoai ="";
                if($gpa <= 10 && $gpa >= 8)
                {
                    return $xepLoai = "Gioi";
                }
                else if($gpa < 8 && $gpa >= 7)
                {
                    return $xepLoai = "Kha";
                }
                else if($gpa < 7 && $gpa >= 5 )
                {
                    return $xepLoai = "Trung Binh";
                }
                else{
                    return $xepLoai = "Yeu";
                }
            }      
    }
?>