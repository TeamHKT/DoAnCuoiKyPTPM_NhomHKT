<?php
require "connetdata.php";

try {
    // Lấy dữ liệu từ Session
    session_start();
    $userName = $_SESSION['userName'];

    // Lấy idNguoiDung từ CSDL dựa trên userName
    $stmt = $conn->prepare("SELECT Id FROM NguoiDung WHERE TenNguoiDung = :userName");
    $stmt->bindParam(':userName', $userName);
    $stmt->execute();
    $result = $stmt->fetch(PDO::FETCH_ASSOC);

    // Kiểm tra xem có dữ liệu không
    if ($result) {
        $idNguoiDung = $result['Id'];

        // Lấy ngày hiện tại
        $ngayMua = date('Y-m-d');

        // Lấy idVe từ request GET
        $idVe = isset($_GET['idVe']) ? intval($_GET['idVe']) : 0;

        // Kiểm tra xem có tồn tại idVe không
        if ($idVe !== 0) {
            // Bắt đầu một giao dịch để đảm bảo tính nhất quán của dữ liệu
            $conn->beginTransaction();

            try {
                // Lấy thông tin số lượng vé và id sự kiện từ bảng Ve và SuKien
                $stmtVe = $conn->prepare("
                    SELECT Ve.GiaVe, SuKien.SoLuongVe AS SoLuongVeSuKien, Ve.idSuKien
                    FROM Ve
                    INNER JOIN SuKien ON Ve.idSuKien = SuKien.Id
                    WHERE Ve.Id = :idVe
                ");
                $stmtVe->bindParam(':idVe', $idVe);
                $stmtVe->execute();
                $resultVe = $stmtVe->fetch(PDO::FETCH_ASSOC);

                if ($resultVe) {
                    $soLuongVeSuKien = $resultVe['SoLuongVeSuKien'];
                    $idSuKien = $resultVe['idSuKien'];

                    // Kiểm tra xem còn vé khả dụng không
                    if ($soLuongVeSuKien > 0) {
                        // Trừ số lượng vé trong bảng SuKien
                        $stmtSuKien = $conn->prepare("UPDATE SuKien SET SoLuongVe = SoLuongVe - 1 WHERE Id = :idSuKien");
                        $stmtSuKien->bindParam(':idSuKien', $idSuKien);
                        $stmtSuKien->execute();

                        // Cập nhật TrangThai trong bảng Ve
                        $stmtUpdateVe = $conn->prepare("UPDATE Ve SET TrangThai = 1 WHERE Id = :idVe");
                        $stmtUpdateVe->bindParam(':idVe', $idVe);
                        $stmtUpdateVe->execute();

                        // Thêm dữ liệu vào bảng ChiTietVe
                        $stmtChiTietVe = $conn->prepare("INSERT INTO ChiTietVe (NgayMua, IdNguoiDung, IdVe, GiaVe)
                            VALUES (:ngayMua, :idNguoiDung, :idVe, :giaVe)");
                        $stmtChiTietVe->bindParam(':ngayMua', $ngayMua);
                        $stmtChiTietVe->bindParam(':idNguoiDung', $idNguoiDung);
                        $stmtChiTietVe->bindParam(':idVe', $idVe);
                        $stmtChiTietVe->bindParam(':giaVe', $resultVe['GiaVe']);
                        $stmtChiTietVe->execute();

                        // Commit giao dịch nếu mọi thứ thành công
                        $conn->commit();

                        echo "Thêm dữ liệu thành công.";
                        header("location:Home.php");
                    } else {
                        echo "Không còn vé khả dụng cho sự kiện này.";
                    }
                } else {
                    echo "Không tìm thấy thông tin vé.";
                }
            } catch (PDOException $e) {
                // Rollback nếu có lỗi
                $conn->rollBack();
                echo "Lỗi: " . $e->getMessage();
            }
        } else {
            echo "Không tìm thấy idVe.";
        }
    } else {
        echo "Không tìm thấy người dùng.";
    }
} catch (PDOException $e) {
    echo "Lỗi: " . $e->getMessage();
}

// Đóng kết nối CSDL
$conn = null;
?>
