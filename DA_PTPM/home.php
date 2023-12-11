<?
    require_once("header.php");
    require "GetDaTa.php";
// Sử dụng hàm để lấy dữ liệu
$suKienData = getDataSuKien();



?>
 <div class="spacer "style="height: 56px;"></div>

<div class="row">
  <?php foreach ($suKienData as $suKien): ?>
    <div class="col-md-3 mb-3">
        <div class="card" style="width: 18rem;">
            <img src="./img/<?= $suKien['HinhAnh']; ?>" class="card-img-top" alt="Hình ảnh sự kiện">
            <div class="card-body">
                <h5 class="card-title"><?= $suKien['TenSuKien']; ?></h5>
                <p class="card-text"><?= $suKien['DiaDiem']; ?></p>
                <p class="card-text">Số Lượng Vé: <?= $suKien['SoLuongVe']; ?></p>
                <p class="card-text">Ngày Tổ Chức: <?= $suKien['NgayToChuc']; ?></p>
                <a href="datve.php?id=<?=$suKien['Id']?>" class="btn btn-primary btn-datve">
                    Đặt vé
                </a>
            </div>
        </div>
    </div>
  <?php endforeach; ?>
</div>


<?
    require_once("footer.php");
?>1