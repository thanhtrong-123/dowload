/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package baitapsapxepkhoa;

import java.util.Objects;

/**
 *
 * @author trong
 */
public class Khoa {
    private String maKhoa;
    private String tenKhoa;

    public String getMaKhoa() {
        return maKhoa;
    }

    public void setMaKhoa(String maKhoa) {
        this.maKhoa = maKhoa;
    }

    public String getTenKhoa() {
        return tenKhoa;
    }

    public void setTenKhoa(String tenKhoa) {
        this.tenKhoa = tenKhoa;
    }

    public Khoa(String maKhoa, String tenKhoa) {
        this.maKhoa = maKhoa;
        this.tenKhoa = tenKhoa;
    }

    public Khoa() {
    }

    @Override
    public String toString() {
        return "Khoa{" + "maKhoa=" + maKhoa + ", tenKhoa=" + tenKhoa + '}';
    }    
}
