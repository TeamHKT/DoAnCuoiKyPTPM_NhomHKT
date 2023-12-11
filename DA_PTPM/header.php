<?php
// Lấy tên trang hiện tại từ biến $_SERVER
$current_page = basename($_SERVER['PHP_SELF']);

// Kiểm tra xem có phải trang đăng nhập không
$is_login_page = ($current_page === 'Login.php');
session_start();
$sesionusername=($_SESSION['userName']);
if (isset($sesionusername)) {
    $welcomeMessage = "Welcome " . $_SESSION["userName"];
    $logoutButton = '<a href="logout.php">Đăng Xuất</a>';
} else {
    $welcomeMessage = "";
    $logoutButton = "";
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <!-- Liên kết với Bootstrap CSS qua CDN -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.2/css/all.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="Login.css">
    <title>Your PHP Page</title>
</head>
<body>
<nav class="navbar navbar-expand-lg navbar-light bg-light fixed-top">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">HT</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="home.php">Trang Chủ</a>
        </li>
        <form class="d-flex">
          <input class="form-control me-2" type="search" placeholder="Tìm Kiếm" aria-label="Search">
          <button class="btn btn-outline-success" type="submit">Search</button>
        </form>
        <li class="nav-item">
            <a class="nav-link active"href="ThongTinNguoiDung.php"><?=$welcomeMessage; ?></a>
        </li>
      </ul>
      <?php if (!$is_login_page): ?>
        <div class="nav-item">
        <?php if (!$sesionusername): ?>
            <a class="nav-link mb-2" href="Login.php">Đăng Nhập</a>
        <?php else: ?>
            <a class="nav-link mb-2" href="logout.php">Đăng Xuất</a>
        <?php endif; ?>
        </div>
    <?php endif; ?>
    
    </div>
  </div>
</nav>

