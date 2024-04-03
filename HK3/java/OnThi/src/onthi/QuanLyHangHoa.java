/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package onthi;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Collections;

/**
 *
 * @author trong
 */
public class QuanLyHangHoa {
    private ArrayList<HangHoa> data = new ArrayList<HangHoa>();

    public QuanLyHangHoa() {
    }

    public ArrayList<HangHoa> getData() {
        return data;
    }

    public void setData(ArrayList<HangHoa> data) {
        this.data = data;
    }
    public boolean ThemHangHoa(HangHoa hh) {
        for (HangHoa hh1 : data) {
            if (hh1.getMaHang().equals(hh.getMaHang())) {
                System.out.println("Không thể thêm hàng hóa vì trùng mã hàng!");
                return false;
            }
        }
        data.add(hh);
        return true;
    }
    public boolean SuaHangHoa(HangHoa hh) {
        for (HangHoa hh1 : data) {
            if (hh1.getMaHang().equals(hh.getMaHang())) {
                hh1.setTenHang(hh.getTenHang());
                hh1.setGiaTien(hh.getGiaTien());
                hh1.setSoLuong(hh.getSoLuong());
                hh1.setNoiSanXuat(hh.getNoiSanXuat());
                hh1.setNgaySanXuat(hh.getNgaySanXuat());
                return true;
            }
        }
        return false;
    }
    public boolean XoaHangHoa(String maHang) {
        for (HangHoa hh : data) {
            if (hh.getMaHang().equals(maHang)) {
                data.remove(hh);
                return true;
            }
        }
        return false;
    }
    public ArrayList<HangHoa> XemDanhSachHangHoa(int soLuong) {
        ArrayList<HangHoa> hangHoaSoLuongLonHon = new ArrayList<HangHoa>();
        for (HangHoa hh : data) {
            if (hh.getSoLuong() > soLuong) {
                hangHoaSoLuongLonHon.add(hh);
            }
        }
        return hangHoaSoLuongLonHon;
    }
    public void SapXepNoiSX() {
        
        Collections.sort(data);
    }

    public double TongTien() {
        double tongTien = 0;
        for (HangHoa hh : data) {
            tongTien += (hh.getGiaTien() * hh.getSoLuong());
        }
        return tongTien;
    }
    public void GhiDuLieu(String filename) {
        File file = new File(filename);
        try {
            FileWriter fw = new FileWriter(file);
            BufferedWriter bw = new BufferedWriter(fw);
            for (HangHoa hh : data) {
                bw.write(hh.toString());
                bw.newLine();
            }
            bw.close();
            fw.close();           
        } catch (IOException ex) {
            System.out.println("Lỗi File " + ex);
        }
    }
    public ArrayList<HangHoa> DocDuLieu(String filename) {
        ArrayList<HangHoa> duLieuHH = new ArrayList<>();
        File file = new File(filename);
        try {
            FileReader fileReader = new FileReader(file);
            BufferedReader bufferedReader = new BufferedReader(fileReader);
            String line = "";
            while ((line = bufferedReader.readLine()) != null) {
                String[] item = line.split("-");
                System.out.println(item[1]);
                HangHoa hh = new HangHoa(item[1], item[2], Double.parseDouble(item[3]), Integer.parseInt(item[4]), item[5], item[6]);
                duLieuHH.add(hh);
            }
        } catch (FileNotFoundException ex) {
            System.out.println("Không tìm thấy file" + ex);
        } catch (IOException ex) {
            System.out.println("Lỗi file" + ex);
        }
        return duLieuHH;
    }
}
