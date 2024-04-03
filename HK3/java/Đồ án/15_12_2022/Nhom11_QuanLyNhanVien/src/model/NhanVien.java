/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package model;

/**
 *
 * @author Hoaan
 */
public class NhanVien{
    private String maNV;
    private String hoTen;
    private int namSinh;
    private String gioiTinh;
    private String diaChi;
    private String SDT;
    private String maCV;

    public NhanVien() {
    }

    public NhanVien(String maNV, String hoTen, int namSinh, String gioiTinh, String diaChi, String SDT, String chucVu) {
        this.maNV = maNV;
        this.hoTen = hoTen;
        this.namSinh = namSinh;
        this.gioiTinh = gioiTinh;
        this.diaChi = diaChi;
        this.SDT = SDT;
        this.maCV = chucVu;
    }

    public String getMaNV() {
        return maNV;
    }

    public void setMaNV(String maNV) {
        this.maNV = maNV;
    }

    public String getHoTen() {
        return hoTen;
    }

    public void setHoTen(String hoTen) {
        this.hoTen = hoTen;
    }

    public int getNamSinh() {
        return namSinh;
    }

    public void setNamSinh(int namSinh) {
        this.namSinh = namSinh;
    }

    public String getGioiTinh() {
        return gioiTinh;
    }

    public void setGioiTinh(String gioiTinh) {
        this.gioiTinh = gioiTinh;
    }

    public String getDiaChi() {
        return diaChi;
    }

    public void setDiaChi(String diaChi) {
        this.diaChi = diaChi;
    }

    public String getSDT() {
        return SDT;
    }

    public void setSDT(String SDT) {
        this.SDT = SDT;
    }

    public String getMaCV() {
        return maCV;
    }

    public void setChucVu(String chucVu) {
        this.maCV = chucVu;
    }

    @Override
    public String toString() {
        return "Nhân Viên { " + maNV + " - " + hoTen + " - " + namSinh + " - " + gioiTinh + " - " + diaChi + " - " + SDT + " - " + maCV + "}";
    }
    
}
