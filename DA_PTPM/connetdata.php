<?php

    $serverName = "103.183.121.70"; 
    $connectionOptions = array(
        "Database" => "QuanLySuKien", 
        "Uid" => "admin_event",      
        "PWD" => "123"       
    );

    try {
        $conn = new PDO("sqlsrv:Server=$serverName;Database=".$connectionOptions['Database'], $connectionOptions['Uid'], $connectionOptions['PWD']);

        // Thiết lập chế độ lỗi để bật chế độ báo lỗi của PDO
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        return $conn;
    } catch (PDOException $e) {
        echo "Kết nối thất bại: " . $e->getMessage();
        return null;
    }
?>
