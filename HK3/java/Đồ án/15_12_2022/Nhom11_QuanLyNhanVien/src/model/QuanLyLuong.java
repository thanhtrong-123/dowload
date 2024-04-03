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
public class QuanLyLuong {

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

    public ArrayList<Luong> DocDuLieu() {
        try {
            ArrayList<Luong> data = new ArrayList<>();
            Connection con = getConnection();
            System.out.println("Thông tin lương:");
            String sql = "SELECT * FROM tbluong";
            ResultSet rs = con.createStatement().executeQuery(sql);
            while (rs.next()) {
                String maNV = rs.getString("maNV");
                String maBL = rs.getString("maBL");
                float luongCB = rs.getFloat("luongCB");
                float luongThuong = rs.getFloat("luongThuong");
                float heSL = rs.getFloat("heSL");
                int thang = rs.getInt("thang");
                int nam = rs.getInt("nam");
                float tongLT = rs.getFloat("tongLT");
                int tinhTrang = rs.getInt("tinhTrang");
                Luong luong = new Luong(maNV, maBL, luongCB, luongThuong, heSL, thang, nam, tongLT, tinhTrang);
                data.add(luong);
            }
            return data;
        } catch (ClassNotFoundException ex) {
            System.out.println("Chưa có thư viện!");
            Logger.getLogger(QuanLyLuong.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            System.out.println("Lỗi kết nối!");
            Logger.getLogger(QuanLyLuong.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
    }

    public int ThemDuLieu(Luong luong) {
        try {
            Connection con = getConnection();
            String sql = "INSERT INTO tbluong VALUES ('" + luong.getMaNV()
                    + "','" + luong.getMaBL()
                    + "','" + luong.getLuongCB()
                    + "','" + luong.getLuongThuong()
                    + "','" + luong.getHeSL()
                    + "','" + luong.getThang()
                    + "','" + luong.getNam()
                    + "','" + luong.getTongLT()
                    + "','" + luong.getTinhTrang()
                    + "')";
            return con.createStatement().executeUpdate(sql);
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(QuanLyLuong.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            Logger.getLogger(QuanLyLuong.class.getName()).log(Level.SEVERE, null, ex);
        }
        return 0;
    }

    public int SuaDuLieu(Luong luong) {
        try {
            Connection con = getConnection();
            String sql = "UPDATE tbluong SET "
                    + "luongCB = '" + luong.getLuongCB()
                    + "', luongThuong = '" + luong.getLuongThuong()
                    + "', heSL = '" + luong.getHeSL()
                    + "', thang = '" + luong.getThang()
                    + "', nam = '" + luong.getNam()
                    + "', tongLT = '" + luong.getTongLT()
                    + "', tinhTrang = '" + luong.getTinhTrang()
                    + "' WHERE maNV = '" + luong.getMaNV() + "'AND maBL = '" + luong.getMaBL() + "'";
            System.out.println(sql);
            return con.createStatement().executeUpdate(sql);
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(QuanLyLuong.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            Logger.getLogger(QuanLyLuong.class.getName()).log(Level.SEVERE, null, ex);
        }
        return 0;
    }

    public int SuaTinhTrang(String maBL) {
        try {
            Connection con = getConnection();
            int tinhTrangLuong = 1;
            String sql = "UPDATE tbluong SET "
                    + "tinhTrang = '" + tinhTrangLuong
                    + "' WHERE maBL = '" + maBL + "'";
            System.out.println(sql);
            return con.createStatement().executeUpdate(sql);
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(QuanLyLuong.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            Logger.getLogger(QuanLyLuong.class.getName()).log(Level.SEVERE, null, ex);
        }
        return 0;
    }

    public int XoaDuLieu(String maBL) {
        try {
            Connection con = getConnection();
            String sql = "DELETE FROM tbluong "
                    + " WHERE maBL = '" + maBL + "'";
            System.out.println(sql);
            return con.createStatement().executeUpdate(sql);
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(QuanLyLuong.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            Logger.getLogger(QuanLyLuong.class.getName()).log(Level.SEVERE, null, ex);
        }
        return 0;
    }

    public ArrayList<Luong> TimKiemBL(String maNVTimKiem) {
        try {
            ArrayList<Luong> data = new ArrayList<>();
            Connection con = getConnection();
            System.out.println("Thông tin lương:");
            String sql = "SELECT * FROM tbluong WHERE maNV LIKE '%" + maNVTimKiem + "%'";
            ResultSet rs = con.createStatement().executeQuery(sql);
            while (rs.next()) {
                String maNV = rs.getString("maNV");
                String maBL = rs.getString("maBL");
                float luongCB = rs.getFloat("luongCB");
                float luongThuong = rs.getFloat("luongThuong");
                float heSL = rs.getFloat("heSL");
                int thang = rs.getInt("thang");
                int nam = rs.getInt("nam");
                float tongLT = rs.getFloat("tongLT");
                int tinhTrang = rs.getInt("tinhTrang");
                Luong luong = new Luong(maNV, maBL, luongCB, luongThuong, heSL, thang, nam, tongLT, tinhTrang);
                data.add(luong);
            }
            return data;
        } catch (ClassNotFoundException ex) {
            System.out.println("Chưa có thư viện!");
            Logger.getLogger(QuanLyLuong.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            System.out.println("Lỗi kết nối!");
            Logger.getLogger(QuanLyLuong.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
    }

    public ArrayList<Luong> TimKiemBLThang(String thangTimKiem, String namTimKiem) {
        try {
            ArrayList<Luong> data = new ArrayList<>();
            Connection con = getConnection();
            System.out.println("Thông tin lương:");
            String sql = "SELECT * FROM tbluong WHERE thang = '" + thangTimKiem + "' AND nam = '" + namTimKiem + "'";
            ResultSet rs = con.createStatement().executeQuery(sql);
            while (rs.next()) {
                String maNV = rs.getString("maNV");
                String maBL = rs.getString("maBL");
                float luongCB = rs.getFloat("luongCB");
                float luongThuong = rs.getFloat("luongThuong");
                float heSL = rs.getFloat("heSL");
                int thang = rs.getInt("thang");
                int nam = rs.getInt("nam");
                float tongLT = rs.getFloat("tongLT");
                int tinhTrang = rs.getInt("tinhTrang");
                Luong luong = new Luong(maNV, maBL, luongCB, luongThuong, heSL, thang, nam, tongLT, tinhTrang);
                data.add(luong);
            }
            return data;
        } catch (ClassNotFoundException ex) {
            System.out.println("Chưa có thư viện!");
            Logger.getLogger(QuanLyLuong.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            System.out.println("Lỗi kết nối!");
            Logger.getLogger(QuanLyLuong.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
    }
}
