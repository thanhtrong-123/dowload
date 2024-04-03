/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ontap;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

/**
 *
 * @author LENOVO
 */
public class Hanghoa {
    private String ma, ten, noisx;
    private int gia, sl;
    private Date ngaysx;
    SimpleDateFormat df=new SimpleDateFormat("dd/MM/yyyy");
    @Override
    public String toString() {
        return "Hanghoa" + " " + ma + " " + ten + " " + noisx + " " + gia + " " + sl + " " + df.format(ngaysx);
    }

    public String getMa() {
        return ma;
    }

    public void setMa(String ma) {
        this.ma = ma;
    }

    public String getTen() {
        return ten;
    }

    public void setTen(String ten) {
        this.ten = ten;
    }

    public String getNoisx() {
        return noisx;
    }

    public void setNoisx(String noisx) {
        this.noisx = noisx;
    }

    public int getGia() {
        return gia;
    }

    public void setGia(int gia) {
        this.gia = gia;
    }

    public int getSl() {
        return sl;
    }

    public void setSl(int sl) {
        this.sl = sl;
    }

    public Date getNgaysx() {
        return ngaysx;
    }

    public void setNgaysx(Date ngaysx) {
        this.ngaysx = ngaysx;
    }

    public Hanghoa(String ma, String ten, String noisx, int gia, int sl, String ngaysx) throws ParseException {
        this.ma = ma;
        this.ten = ten;
        this.noisx = noisx;
        this.gia = gia;
        this.sl = sl;
        this.ngaysx = df.parse(ngaysx);
    }
}
