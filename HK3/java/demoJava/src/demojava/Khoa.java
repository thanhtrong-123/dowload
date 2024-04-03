/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package demojava;

import java.util.Scanner;

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

    public Khoa() {
    }

    public Khoa(String maKhoa, String tenKhoa) {
        this.maKhoa = maKhoa;
        this.tenKhoa = tenKhoa;
    }
    public void Nhap(){
        Scanner input = new Scanner(System.in);
        System.out.println("nhap Khoa");
            System.out.println("nhap ma khoa:");
            maKhoa = input.nextLine();
            System.out.println("nhap ten khoa:");
            tenKhoa = input.nextLine();
    }
    @Override
    public String toString() {
        String str = "Khoa";
        str +=" - " + maKhoa;
        str +=" - " + tenKhoa + "\n";
        return str; //To change body of generated methods, choose Tools | Templates.
    }
}
