/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package model;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Hoaan
 */
public class QuanLyNhanVien {

    public static Connection c;
    private static String db_url = "jdbc:mysql://localhost:3306/quanlynhanvien";
    private static String username = "root";
    private static String password = "vertrigo";

    public static Connection getConnection() throws ClassNotFoundException, SQLException {
        if (c == null) {
            Class.forName("com.mysql.jdbc.Driver");// Từ Java 6 sẽ tự tìm Driver
            c = DriverManager.getConnection(db_url, username, password);
        }
        return c;
    }

    public ArrayList<NhanVien> DocDuLieu() {
        try {
            ArrayList<NhanVien> data = new ArrayList<>();
            Connection con = getConnection();
            System.out.println("Thông tin nhân viên:");
            String sql = "SELECT * FROM tbnhanvien";
            ResultSet rs = con.createStatement().executeQuery(sql);
            while (rs.next()) {
                String maNV = rs.getString("maNV");
                String hoTen = rs.getString("hoTen");
                int namSinh = rs.getInt("namSinh");
                String gioiTinh = rs.getString("gioiTinh");
                String diaChi = rs.getString("diaChi");
                String SDT = rs.getString("SDT");
                String maCV = rs.getString("maCV");
                NhanVien nv = new NhanVien(maNV, hoTen, namSinh, gioiTinh, diaChi, SDT, maCV);
                data.add(nv);
            }
            return data;
        } catch (ClassNotFoundException ex) {
            System.out.println("Chưa có thư viện!");
            Logger.getLogger(QuanLyNhanVien.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            System.out.println("Lỗi kết nối!");
            Logger.getLogger(QuanLyNhanVien.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
    }

    public int ThemDuLieu(NhanVien nv) {
        try {
            Connection con = getConnection();
            String sql = "INSERT INTO tbnhanvien VALUES ('" + nv.getMaNV()
                    + "','" + nv.getHoTen()
                    + "','" + nv.getNamSinh()
                    + "','" + nv.getGioiTinh()
                    + "','" + nv.getDiaChi()
                    + "','" + nv.getSDT()
                    + "','" + nv.getMaCV()
                    + "')";
            System.out.println(sql);
            return con.createStatement().executeUpdate(sql);
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(QuanLyNhanVien.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            Logger.getLogger(QuanLyNhanVien.class.getName()).log(Level.SEVERE, null, ex);
        }
        return 0;
    }

    public int SuaDuLieu(NhanVien nv) {
        try {
            Connection con = getConnection();
            String sql = "UPDATE tbnhanvien SET " 
                    + "hoTen = '" + nv.getHoTen()
                    + "', namSinh = '" + nv.getNamSinh()
                    + "', gioiTinh = '" + nv.getGioiTinh()
                    + "', diaChi = '" + nv.getDiaChi()
                    + "', SDT = '" + nv.getSDT()
                    + "', maCV = '" + nv.getMaCV()
                    + "' WHERE maNV = '" + nv.getMaNV() + "'";
            System.out.println(sql);
            return con.createStatement().executeUpdate(sql);
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(QuanLyNhanVien.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            Logger.getLogger(QuanLyNhanVien.class.getName()).log(Level.SEVERE, null, ex);
        }
        return 0;
    }

    public int XoaDuLieu(String maNV) {
        try {
            Connection con = getConnection();
            String sql = "DELETE FROM tbnhanvien "
                    + " WHERE maNV = '" + maNV + "'";
            System.out.println(sql);
            return con.createStatement().executeUpdate(sql);
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(QuanLyNhanVien.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            Logger.getLogger(QuanLyNhanVien.class.getName()).log(Level.SEVERE, null, ex);
        }
        return 0;
    }
    
    public ArrayList<NhanVien> TimKiemNV(String keyword) {
        try {
            ArrayList<NhanVien> data = new ArrayList<>();
            Connection con = getConnection();
            System.out.println("Thông tin nhân viên:");
            String sql = "SELECT * FROM tbnhanvien WHERE maNV LIKE '%" + keyword + "%'";
            ResultSet rs = con.createStatement().executeQuery(sql);
            while (rs.next()) {
                String maNV = rs.getString("maNV");
                String hoTen = rs.getString("hoTen");
                int namSinh = rs.getInt("namSinh");
                String gioiTinh = rs.getString("gioiTinh");
                String diaChi = rs.getString("diaChi");
                String SDT = rs.getString("SDT");
                String maCV = rs.getString("maCV");
                NhanVien nv = new NhanVien(maNV, hoTen, namSinh, gioiTinh, diaChi, SDT, maCV);
                data.add(nv);
            }
            return data;
        } catch (ClassNotFoundException ex) {
            System.out.println("Chưa có thư viện!");
            Logger.getLogger(QuanLyNhanVien.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            System.out.println("Lỗi kết nối!");
            Logger.getLogger(QuanLyNhanVien.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
    }
}
