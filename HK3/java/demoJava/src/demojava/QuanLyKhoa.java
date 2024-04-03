/*

 */
package demojava;

import java.util.ArrayList;

/**
 *
 * @author trong
 */
public class QuanLyKhoa {

    private ArrayList<Khoa> data;

    public QuanLyKhoa() {
    }

    public QuanLyKhoa(ArrayList<Khoa> data) {
        this.data = data;
    }

    public ArrayList<Khoa> getData() {
        return data;
    }

    public void setData(ArrayList<Khoa> data) {
        this.data = data;
    }

    public void Them(Khoa kh1) {
        data.add(kh1);
    }

    public void Xoa(String maKhoa) {
        for (Khoa kh : data) {
            if (kh.getMaKhoa().equals(maKhoa)) {
                data.remove(kh);
                return;
            }

        }
    }

    public void Sua(String maKhoa, String tenKhoa) {
        for (Khoa kh : data) {
            if (kh.getMaKhoa().equals(maKhoa)) {
                kh.setTenKhoa(tenKhoa);
                return;
            }
        }
    }

    public Khoa TimKiem(String maKhoa) {
        for (Khoa kh : data) {
            if (kh.getMaKhoa().equals(maKhoa)) {
                return kh;
            }
        }
        return null;
    }
}
