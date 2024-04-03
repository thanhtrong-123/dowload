package tdc.edu.vn.abc1;

import java.io.Serializable;

public class SanPham implements Serializable {
    private String ten,sl;

    public SanPham() {
    }

    @Override
    public String toString() {
        return "SanPham{" +
                "ten='" + ten + '\'' +
                ", sl='" + sl + '\'' +
                '}';
    }

    public String getTen() {
        return ten;
    }

    public void setTen(String ten) {
        this.ten = ten;
    }

    public String getSl() {
        return sl;
    }

    public void setSl(String sl) {
        this.sl = sl;
    }

    public SanPham(String ten, String sl) {
        this.ten = ten;
        this.sl = sl;
    }
}
