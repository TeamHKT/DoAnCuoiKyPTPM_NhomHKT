<?


include "header.php";
include_once 'GetDaTa.php';

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Lấy thông tin từ form
    $userName = $_POST["userName"];
    $password = $_POST["password"];

    if (login($userName, $password)) {
        // Đăng nhập thành công, chuyển hướng hoặc thực hiện các hành động khác  
        $_SESSION['userName'] = $userName;
        header("location:home.php");
        exit();
    } else {
        // Đăng nhập thất bại, có thể thông báo lỗi hoặc thực hiện các hành động khác
        echo '<script>alert("Đăng nhập thất bại!");</script>';
    }
} 
?>

<div class="wrapper">
        <div class="logo">
            <img src="https://www.shutterstock.com/image-vector/initial-letter-logo-ht-company-260nw-1019163220.jpg" alt="">
        </div>
        <div class="text-center mt-4 name">
            HT
        </div>
        <form method="POST" class="p-3 mt-3" >
            <div class="form-field d-flex align-items-center" >
                <span class="far fa-user"></span>
                <input type="text" name="userName" id="userName" placeholder="Username">
            </div>
            <div class="form-field d-flex align-items-center">
                <span class="fas fa-key"></span>
                <input type="password" name="password" id="pwd" placeholder="Password">
            </div>
            <button class="btn mt-3" type="submit">Login</button>
        </form>
        <div class="text-center fs-6">
            <a href="#">Forget password?</a> or <a href="#">Sign up</a>
        </div>
    </div>
<?
require "footer.php "
?>