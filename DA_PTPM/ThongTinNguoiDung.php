<?php

include 'GetData.php';
session_start();
$TenNguoiDung = strval($_SESSION["userName"]);
// Gọi hàm GetNguoiDung() để lấy dữ liệu người dùng
$nguoiDungData = getDataNguoiDungByTenNguoiDung($TenNguoiDung);
require "header.php";
?>
     <div class="container mt-5">
        <h2>Thông Tin Người Dùng</h2>
        <?php if (!empty($nguoiDungData)): ?>
            <table class="table">
                <tbody>
                    <?php foreach ($nguoiDungData as $nguoiDung): ?>
                        <tr>
                            <th scope="row">  <td>ID</td></th>
                            <td><?= $nguoiDung['Id']; ?></td>
                        </tr>
                        <tr>
                            <th scope="row"><td>Tên Người Dùng</td></th>
                            
                            <td><?= $nguoiDung['TenNguoiDung']; ?></td>
                        </tr>
                        <tr>
                            <th scope="row"><td>Họ Tên</td></th>
                            
                            <td><?= $nguoiDung['HoTen']; ?></td>
                        </tr>
                        <tr>
                            <th scope="row">         <td>Giới Tính</td></th>
                   
                            <td><?= $nguoiDung['GioiTinh']; ?></td>
                        </tr>
                        <tr>
                            <th scope="row"><td>Số Điện Thoại</td></th>
                 
                            <td><?= $nguoiDung['SoDienThoai']; ?></td>
                        </tr>
                        <tr>
                            <th scope="row">   <td>Quyền</td></th>
                         
                            <td><?= $nguoiDung['Quyen']; ?></td>
                        </tr>
                    <?php endforeach; ?>
                </tbody>
            </table>
        <?php else: ?>
            <p>Không có dữ liệu người dùng.</p>
        <?php endif; ?>
    </div>

    <div class="container mt-5">
    <h2>Lịch Sử Vé Đã Đặt</h2>
    <?php
    $bookingData = getDataChiTietVe();

    if (!empty($bookingData)) {
    ?>
          <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Mã Vé</th>
                        <th>TenSuKien</th>
                        <th>NgayMua</th>
                        <th>GiaVe</th>
                        <!-- Add more columns as needed -->
                    </tr>
                </thead>
                <tbody>
                    <?php foreach ($bookingData as $booking): ?>
                        <tr>
                            <td><?= $booking['IdVe'] ?></td>
                            <td><?= $booking['TenSuKien'] ?></td>
                            <td><?= date('d-m-Y', strtotime($booking['NgayMua'])) ?></td>
                            <td><?=number_format( $booking['GiaVe'], 0, ',', '.') ?>VNĐ</td>
                            <!-- Add more cells with corresponding data as needed -->
                        </tr>
                    <?php endforeach; ?>
                </tbody>
            </table>
    <?php
    } else {
    ?>
        <p>No booking history available.</p>
    <?php
    }
    ?>
</div>
<?
require "footer.php"
?>
