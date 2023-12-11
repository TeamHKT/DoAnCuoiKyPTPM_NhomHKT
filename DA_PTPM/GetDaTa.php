<?php
// Kiểm tra xem biến $conn đã tồn tại chưa
if (!isset($conn)) {
    // Nếu chưa, thì bao gồm tệp kết nối
    include 'connetdata.php';
}

function getDataSuKien() {
    global $conn; // Sử dụng biến toàn cục

    try {
        // Viết câu truy vấn SQL để lấy dữ liệu từ bảng SuKien
        $sql = "SELECT * FROM SuKien";

        // Chuẩn bị câu truy vấn
        $stmt = $conn->prepare($sql);

        // Thực hiện truy vấn
        $stmt->execute();

        // Lấy kết quả
        $result = $stmt->fetchAll(PDO::FETCH_ASSOC);

        // Kiểm tra xem có dữ liệu trả về không
        if ($result) {
            return $result;
        } else {
            // Trả về mảng rỗng nếu không có dữ liệu
            return array();
        }
    } catch (PDOException $e) {
        // Xử lý lỗi kết nối
        echo "Lỗi truy vấn: " . $e->getMessage();
        return array();
    }
}
function getDataChiTietVe() {
    global $conn; // Sử dụng biến toàn cục

    try {
        // Viết câu truy vấn SQL để lấy dữ liệu từ bảng SuKien
        $sql = "SELECT CT.IdVe, CT.NgayMua, CT.GiaVe, SK.TenSuKien, SK.NgayToChuc
                FROM ChiTietVe CT
                JOIN Ve V ON CT.IdVe = V.Id
                JOIN SuKien SK ON V.idSuKien = SK.Id";
        // Chuẩn bị câu truy vấn
        $stmt = $conn->prepare($sql);

        // Thực hiện truy vấn
        $stmt->execute();

        // Lấy kết quả
        $result = $stmt->fetchAll(PDO::FETCH_ASSOC);

        // Kiểm tra xem có dữ liệu trả về không
        if ($result) {
            return $result;
        } else {
            // Trả về mảng rỗng nếu không có dữ liệu
            return array();
        }
    } catch (PDOException $e) {
        // Xử lý lỗi kết nối
        echo "Lỗi truy vấn: " . $e->getMessage();
        return array();
    }
}
function getDataNguoiDungByTenNguoiDung($tenNguoiDung) {
    global $conn;

    try {
        // Viết câu truy vấn SQL để lấy dữ liệu từ bảng NguoiDung với điều kiện TenNguoiDung
        $sql = "SELECT * FROM NguoiDung WHERE TenNguoiDung = :tenNguoiDung";

        // Chuẩn bị câu truy vấn
        $stmt = $conn->prepare($sql);

        // Bind giá trị
        $stmt->bindParam(':tenNguoiDung', $tenNguoiDung, PDO::PARAM_STR);

        // Thực hiện truy vấn
        $stmt->execute();

        // Lấy kết quả
        $result = $stmt->fetchAll(PDO::FETCH_ASSOC);

        // Kiểm tra xem có dữ liệu trả về không
        if ($result) {
            return $result;
        } else {
            // Trả về mảng rỗng nếu không có dữ liệu
            return array();
        }
    } catch (PDOException $e) {
        // Xử lý lỗi kết nối
        echo "Lỗi truy vấn: " . $e->getMessage();
        return array();
    }
}
function getOneVeBySuKienId($idSuKien) {
    global $conn;

    try {
        // Chuẩn bị câu truy vấn SQL
        $sql = "SELECT TOP 1 * FROM Ve WHERE idSuKien = :idSuKien AND TrangThai = 0 ";

        // Chuẩn bị câu truy vấn
        $stmt = $conn->prepare($sql);

        // Gán giá trị cho tham số
        $stmt->bindParam(':idSuKien', $idSuKien, PDO::PARAM_INT);

        // Thực hiện truy vấn
        $stmt->execute();

        // Lấy kết quả
        $result = $stmt->fetch(PDO::FETCH_ASSOC);

        return $result;
    } catch (PDOException $e) {
        // Xử lý lỗi nếu có
        echo "Lỗi truy vấn: " . $e->getMessage();
        return null;
    }
}

function login( $tenNguoiDung, $matKhau) {
    global $conn; // 
    try {
        // Chuẩn bị truy vấn SQL
        $sql = "SELECT * FROM NguoiDung WHERE TenNguoiDung = :tenNguoiDung AND MatKhau = :matKhau";

        // Chuẩn bị và thực thi truy vấn
        $stmt = $conn->prepare($sql);
        $stmt->bindParam(':tenNguoiDung', $tenNguoiDung, PDO::PARAM_STR);
        $stmt->bindParam(':matKhau', $matKhau, PDO::PARAM_STR);
        $stmt->execute();

        // Lấy dữ liệu
        $result = $stmt->fetch();

        // Kiểm tra kết quả
        if ($result) {
            // Nếu có kết quả, đăng nhập thành công
            return true;
        } else {
            // Nếu không có kết quả, đăng nhập thất bại
            return false;
        }
    } catch (PDOException $e) {
        // Xử lý lỗi truy vấn
        echo "Lỗi truy vấn: " . $e->getMessage();
        return false;
    }
}
?>
