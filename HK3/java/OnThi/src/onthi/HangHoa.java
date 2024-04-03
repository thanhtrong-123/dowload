/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package onthi;


/**
 *
 * @author trong
 */
public class HangHoa implements Comparable<HangHoa> {
    private String maHang;
    private String tenHang;
    private double giaTien;
    private int soLuong;
    private String noiSanXuat;
    private String ngaySanXuat;

    public HangHoa() {
    }

    public HangHoa(String maHang, String tenHang, double giaTien, int soLuong, String noiSanXuat, String ngaySanXuat){
        this.maHang = maHang;
        this.tenHang = tenHang;
        this.giaTien = giaTien;
        this.soLuong = soLuong;
        this.noiSanXuat = noiSanXuat;
        this.ngaySanXuat = ngaySanXuat;
    }

    public String getMaHang() {
        return maHang;
    }

    public void setMaHang(String maHang) {
        this.maHang = maHang;
    }

    public String getTenHang() {
        return tenHang;
    }

    public void setTenHang(String tenHang) {
        this.tenHang = tenHang;
    }

    public double getGiaTien() {
        return giaTien;
    }

    public void setGiaTien(double giaTien) {
        this.giaTien = giaTien;
    }

    public int getSoLuong() {
        return soLuong;
    }

    public void setSoLuong(int soLuong) {
        this.soLuong = soLuong;
    }

    public String getNoiSanXuat() {
        return noiSanXuat;
    }

    public void setNoiSanXuat(String noiSanXuat) {
        this.noiSanXuat = noiSanXuat;
    }

    public String getNgaySanXuat() {
        return ngaySanXuat;
    }

    public void setNgaySanXuat(String ngaySanXuat) {
        this.ngaySanXuat = ngaySanXuat;
    }

    @Override
    public String toString() {
        return "HangHoa{" + "maHang=" + maHang + ", tenHang=" + tenHang + ", giaTien=" + giaTien + ", soLuong=" + soLuong + ", noiSanXuat=" + noiSanXuat + ", ngaySanXuat=" + ngaySanXuat + '}';
    }
    @Override
    public int compareTo(HangHoa hh) {
        return noiSanXuat.compareTo(hh.getNoiSanXuat());
    }
    
}
