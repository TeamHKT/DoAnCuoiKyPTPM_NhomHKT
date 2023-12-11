<?php
session_start();

// Hủy session
session_destroy();

// Chuyển hướng về trang đăng nhập (hoặc trang chính)
header("Location: home.php");
exit();
?>
