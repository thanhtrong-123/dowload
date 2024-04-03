/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package model;

/**
 *
 * @author Hoaan
 */
public class Luong {

    private String maNV;
    private String maBL;
    private float luongCB;
    private float luongThuong;
    private float heSL;
    private int thang;
    private int nam;
    private float tongLT;
    private int tinhTrang;

    public int getTinhTrang() {
        return tinhTrang;
    }

    public void setTinhTrang(int tinhTrang) {
        this.tinhTrang = tinhTrang;
    }

    public Luong() {
    }

    public Luong(String maNV, String maBL, float luongCB, float luongThuong, float heSL, int thang, int nam, float tongLT, int tinhTrang) {
        this.maNV = maNV;
        this.maBL = maBL;
        this.luongCB = luongCB;
        this.luongThuong = luongThuong;
        this.heSL = heSL;
        this.thang = thang;
        this.nam = nam;
        this.tongLT = tongLT;
        this.tinhTrang = tinhTrang;
    }

    public String getMaNV() {
        return maNV;
    }

    public void setMaNV(String maNV) {
        this.maNV = maNV;
    }

    public String getMaBL() {
        return maBL;
    }

    public void setMaBL(String maBL) {
        this.maBL = maBL;
    }

    public float getLuongCB() {
        return luongCB;
    }

    public void setLuongCB(float luongCB) {
        this.luongCB = luongCB;
    }

    public float getLuongThuong() {
        return luongThuong;
    }

    public void setLuongThuong(float luongThuong) {
        this.luongThuong = luongThuong;
    }

    public float getHeSL() {
        return heSL;
    }

    public void setHeSL(float heSL) {
        this.heSL = heSL;
    }

    public int getThang() {
        return thang;
    }

    public void setThang(int thang) {
        this.thang = thang;
    }

    public int getNam() {
        return nam;
    }

    public void setNam(int nam) {
        this.nam = nam;
    }

    public float getTongLT() {
        return tongLT;
    }

    public void setTongLT(float tongLT) {
        this.tongLT = tongLT;
    }

    @Override
    public String toString() {
        return "Luong{" + "maNV=" + maNV + ", maBL=" + maBL + ", luongCB=" + luongCB + ", luongThuong=" + luongThuong + ", heSL=" + heSL + ", thang=" + thang + ", nam=" + nam + ", tongLT=" + tongLT + ", tinhTrang =" + tinhTrang + '}';
    }
}
