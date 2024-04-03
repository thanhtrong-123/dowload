/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package baitapsapxepkhoa;

/**
 *
 * @author trong
 */
public class BaiTapSapXepKhoa {

    /**
     * @param args the command line arguments
     */
        public static void main(String[] args) {
        Khoa kh1 = new Khoa("KH1", "CNTT");
        Khoa kh2 = new Khoa("KH2", "TA");
        Khoa kh3 = new Khoa("KH3", "CK");
        Khoa kh4 = new Khoa("KH4", "OT");
        Khoa kh5 = new Khoa("KH5", "QTKD");
        QuanLyKhoa qlk = new QuanLyKhoa();
        qlk.Them(kh1);
        qlk.Them(kh2);
        qlk.Them(kh3);
        qlk.Them(kh4);
        qlk.Them(kh5);
        System.out.println("\n" + "danh sach mon hoc");
        qlk.XuatTT();
        System.out.println("\n" + "sap xep mon hoc");
        qlk.SapXepKhoa();
        qlk.XuatTT();
    }
}
