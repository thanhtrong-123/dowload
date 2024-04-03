<?php
class Product extends Db
{
    public function getAllProducts()
    {
        $sql = self::$connection->prepare("SELECT * FROM products");
        $sql->execute(); //return an object
        $item = array();
        $item = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $item; //return an array
    }

    public function get3NewProductsByID($type_id)
    {
        $sql = self::$connection->prepare("SELECT * FROM products WHERE `type_id` = ? ORDER BY `created_at` DESC LIMIT 0,3  ");
        $sql->bind_param("i", $type_id);
        $sql->execute(); //return an object
        $item = array();
        $item = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $item; //return an array
    }

    public function getAllNewProducts()
    {
        $sql = self::$connection->prepare("SELECT * FROM products ORDER BY id DESC LIMIT 0,10");
        $sql->execute(); //return an object
        $item = array();
        $item = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $item; //return an array
    }
    public function getProductById1($type_id)
    {
    }
    public function getProductsTopSellingByType1($type_id)
    {
        $sql = self::$connection->prepare("SELECT * FROM products,`sales` WHERE `Sell_number`>= 200 AND products.id = sales.id AND type_id = " . $type_id);
        $sql->execute(); //return an object
        $items = array();
        $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $items; //return an array
    }
    public function getTopSellingProducts()
    {
        $sql = self::$connection->prepare("SELECT * FROM `sales`,products WHERE `Sell_number`>= 200 AND products.id = sales.id ");
        $sql->execute(); //return an object
        $item = array();
        $item = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $item; //return an array
    }
    public function getProductById($id)
    {
        $sql = self::$connection->prepare("SELECT * FROM products WHERE id = ?");
        $sql->bind_param("i", $id);
        $sql->execute();
        $item = array();
        $item = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $item; //return an array
    }
    public function getProductsByType($type_id)
    {
        $sql = self::$connection->prepare("SELECT * FROM products WHERE type_id = ?");
        $sql->bind_param("i", $type_id);
        $sql->execute(); //return an object
        $items = array();
        $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $items; //return an array
    }
    public function getProductsTopSellingByType($type_id)
    {
        $sql = self::$connection->prepare("SELECT * FROM `sales`,products WHERE products.type_id = ? AND products.id = sales.id AND `Sell_number`>= 200");
        $sql->bind_param("i", $type_id);
        $sql->execute(); //return an object
        $items = array();
        $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $items; //return an array
    }
    public function getFeaturedPhone()
    {
        $sql = self::$connection->prepare("SELECT * FROM products WHERE `feature` = 1 AND `type_id` = 1 LIMIT 3");
        $sql->execute(); //return an object
        $item = array();
        $item = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $item; //return an array
    }
    public function getFeaturedPhonePlus()
    {
        $sql = self::$connection->prepare("SELECT * FROM products WHERE `manu_id` = 4 AND `type_id` = 1 AND `feature` = 1");
        $sql->execute(); //return an object
        $item = array();
        $item = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $item; //return an array
    }
    public function getAllFeaturedLaptop()
    {
        $sql = self::$connection->prepare("SELECT * FROM products WHERE `feature` = 1 AND `type_id` = 2");
        $sql->execute(); //return an object
        $item = array();
        $item = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $item; //return an array
    }
    public function getAllFeaturedSmartwatch()
    {
        $sql = self::$connection->prepare("SELECT * FROM products WHERE `feature` = 1 AND `type_id` = 4 LIMIT 3");
        $sql->execute(); //return an object
        $item = array();
        $item = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $item; //return an array
    }
    public function getAllFeaturedSmartwatchPlus()
    {
        $sql = self::$connection->prepare("SELECT * FROM products WHERE `manu_id` BETWEEN 4 AND 5 AND `feature` = 1 AND `type_id` = 4");
        $sql->execute(); //return an object
        $item = array();
        $item = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $item; //return an array
    }
    public function get3ProductsByType($type_id, $page, $perPage)
    {
        // Tính số thứ tự trang bắt đầu
        $firstLink = ($page - 1) * $perPage;
        $sql = self::$connection->prepare("SELECT * FROM products
        WHERE type_id = ? LIMIT ?, ?");
        $sql->bind_param("iii", $type_id, $firstLink, $perPage);
        $sql->execute(); //return an object
        $items = array();
        $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
        return $items; //return an array
    }



    public function paginate($url, $total, $perPage, $page)
    {
        $totalLinks = ceil($total / $perPage);
        $link = "";
        for ($j = 1; $j <= $totalLinks; $j++) {
            if ($page == $j) {
                $link = $link . "<li class ='active'> $j </a></li>";
            } else {
                $link = $link . "<li><a href='$url&page=$j'> $j </a></li>";
            }
        }
        return $link;
    }
    public function search($keyword, $searchCol)
    {
        if ($searchCol == 1 || $searchCol == 2 || $searchCol == 3 || $searchCol == 4 || $searchCol == 5) {
            
            $sql = self::$connection->prepare("SELECT * FROM products WHERE `name` LIKE ? AND `type_id` = ? ");
            $keyword = "%$keyword%";
            $sql->bind_param("si", $keyword, $searchCol);
            $sql->execute(); //return an object
            $items = array();
            $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
            return $items; //return an array
        } else {
            $sql = self::$connection->prepare("SELECT * FROM products WHERE `name` LIKE ?");
            $keyword = "%$keyword%";
            $sql->bind_param("s", $keyword);
            $sql->execute(); //return an object
            $items = array();
            $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
            return $items; //return an array
        }
    }
    public function search1($keyword, $searchCol, $page, $perPage)
    {
        if ($searchCol == 1 || $searchCol == 2 || $searchCol == 3 || $searchCol == 4 || $searchCol == 5) {
            $firstLink = ($page - 1) * $perPage;
            $sql = self::$connection->prepare("SELECT * FROM products WHERE `name` LIKE ? AND `type_id` = ? LIMIT ?, ?");
            $keyword = "%$keyword%";
            $sql->bind_param("siii", $keyword, $searchCol,$firstLink, $perPage);
            $sql->execute(); //return an object
            $items = array();
            $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
            return $items; //return an array
        } else {
            $firstLink = ($page - 1) * $perPage;
            $sql = self::$connection->prepare("SELECT * FROM products WHERE `name` LIKE ? LIMIT ?, ?");
            $keyword = "%$keyword%";
            $sql->bind_param("sii", $keyword,$firstLink, $perPage);
            $sql->execute(); //return an object
            $items = array();
            $items = $sql->get_result()->fetch_all(MYSQLI_ASSOC);
            return $items; //return an array
        }
    }
}
