/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package baitapsapxepkhoa;

import java.util.ArrayList;
import java.util.Collections;

/**
 *
 * @author trong
 */
public class QuanLyKhoa {
    private ArrayList<Khoa> data = new ArrayList<Khoa>();

    public QuanLyKhoa() {
    }

    public ArrayList<Khoa> getData() {
        return data;
    }

    public void setData(ArrayList<Khoa> data) {
        this.data = data;
    }
    public void Them(Khoa kh) {
        data.add(kh);
    }

    public void Sua(String maKhoa , String tenKhoa) {
        for (Khoa kh: data) {
            if (kh.getMaKhoa().equals(maKhoa)) {
                kh.setTenKhoa(tenKhoa);
            }
        }
    }

    public void Xoa(String maKhoa) {
        for (Khoa kh : data) {
            if (kh.getMaKhoa().equals(maKhoa)) {
                data.remove(kh);
                return;
            }
        }
    }

    public Khoa TimKiemMH(String maKhoa) {
        for (Khoa kh : data) {
            if (kh.getMaKhoa().equals(maKhoa)) {
                return kh;
            }
        }
        return null;
    }
    public void SapXepKhoa() {
        Collections.sort(data);
    }
    public void XuatTT() {
        for (Khoa kh : data) {
            System.out.println(kh.toString());
        }
    }
}
