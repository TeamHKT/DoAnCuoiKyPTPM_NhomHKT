<?php

session_start();
if (isset($_SESSION['userName']))
{
    require "GetDaTa.php";
}
else
{
    header("Location: Login.php");
    exit; 
}
// Kiểm tra xem tham số 'id' có tồn tại trong URL không
if(isset($_GET['id'])) {
    // Lấy giá trị 'id' từ URL
    $suKienId = $_GET['id'];
    $sukien=getDataSuKien();
    // Gọi hàm getOneVeBySuKienId với giá trị 'id' lấy từ URL
    $veData = getOneVeBySuKienId($suKienId);

} else {
    // Nếu không có tham số 'id' trong URL, xử lý hoặc thông báo lỗi
    echo "Tham số 'id' không được cung cấp.";
}
include "header.php"
?>
 <div class="spacer "style="height: 56px;"></div>
 <div class="container">
    <div class="row justify-content-center">
        <!-- Phần hiển thị card -->
        <div class="col-md-6">
            <div class="card mx-auto">
                <?php if (!empty($sukien[$suKienId]['HinhAnh'])): ?>
                    <?php $hinhAnh = $sukien[$suKienId]['HinhAnh']; ?>
                    <img src="./img/<?= $hinhAnh ?>" class="card-img-top" alt="Hình ảnh sự kiện">
                <?php else: ?>
                    <p class="card-text text-center">Không có hình ảnh</p>
                <?php endif; ?>
                <div class="card-body text-center">
                    <?php if (!empty($sukien[$suKienId]['TenSuKien'])): ?>
                        <?php $TenSuKien = $sukien[$suKienId]['TenSuKien']; ?>
                        <h5 class="card-title"><?= $TenSuKien ?></h5>
                    <?php endif; ?>
                    <?php if (!empty($veData)): ?>
                        <p class="card-text">Mã vé: <?= $veData['Id'] ?></p>
                        <p class="card-text">Giá vé: <?= number_format($veData['GiaVe'], 0, ',', '.') ?> VND</p>
                        <a href="home.php" class="btn btn-danger">Hủy</a>
                        <a href="xacnhandatve.php?idVe=<?=$veData['Id']?>" class="btn btn-success">Xác Nhận Đặt Vé</a>
                    <?php else: ?>
                        <p class="card-text">Bạn đã đặt vé cho sự kiện này.Vui lòng kiểm tra lại trong lịch sử vé đã đặt</p>
                        <a href="ThongTinNguoiDung.php">Lịch Sử Vé Đã Đặt</a>
                    <?php endif; ?>
                </div>
            </div>
        </div>
    </div>
</div>

<?
require "footer.php"
?>