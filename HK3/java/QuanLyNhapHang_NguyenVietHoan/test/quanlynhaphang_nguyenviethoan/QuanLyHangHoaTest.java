/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package quanlynhaphang_nguyenviethoan;

import java.util.ArrayList;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author Administrator
 */
public class QuanLyHangHoaTest {
    
    public QuanLyHangHoaTest() {
    }
    
    @BeforeClass
    public static void setUpClass() {
    }
    
    @AfterClass
    public static void tearDownClass() {
    }
    
    @Before
    public void setUp() {
    }
    
    @After
    public void tearDown() {
    }

    /**
     * Test of ThemHangHoa method, of class QuanLyHangHoa.
     */
    @Test
    public void testThemHangHoa() {
        System.out.println("Them Hang Hoa");
        HangHoa hh1 = new HangHoa("MH01", "Chén", 10000, 20, "Làng gốm Bát Tràng", "29/12/2022");
        HangHoa hh2= new HangHoa("MH02", "Dĩa", 8000, 10, "Làng gốm Bát Tràng", "23/12/2022");
        HangHoa hh3 = new HangHoa("MH03", "Bát", 15000, 30, "Làng gốm Bát Tràng", "22/12/2022");
        HangHoa hh4 = new HangHoa("MH01", "Muỗng", 5000, 30, "Ninh Bình", "20/12/2022");
        QuanLyHangHoa instance = new QuanLyHangHoa();
        instance.ThemHangHoa(hh1);
        instance.ThemHangHoa(hh2);
        boolean expResult1 = true;
        boolean result1 = instance.ThemHangHoa(hh3);
        boolean expResult2 = false;
        boolean result2 = instance.ThemHangHoa(hh4);
        assertEquals(expResult1, result1);
        assertEquals(expResult2, result2);
    }

    /**
     * Test of SuaHangHoa method, of class QuanLyHangHoa.
     */
    @Test
    public void testSuaHangHoa() {
        System.out.println("Sua Hang Hoa");
        HangHoa hh1 = new HangHoa("MH01", "Chén", 10000, 20, "Làng gốm Bát Tràng", "29/12/2022");
        HangHoa hh2= new HangHoa("MH02", "Dĩa", 8000, 10, "Làng gốm Bát Tràng", "23/12/2022");
        HangHoa hh3 = new HangHoa("MH03", "Bát", 15000, 30, "Làng gốm Bát Tràng", "22/12/2022");
        HangHoa hh4 = new HangHoa("MH01", "Muỗng", 5000, 30, "Ninh Bình", "20/12/2022");
        QuanLyHangHoa instance = new QuanLyHangHoa();
        instance.ThemHangHoa(hh1);
        instance.ThemHangHoa(hh2);
        instance.ThemHangHoa(hh3);
        boolean expResult = true;
        boolean result = instance.SuaHangHoa(hh4);
        assertEquals(expResult, result);
    }

    /**
     * Test of XoaHangHoa method, of class QuanLyHangHoa.
     */
    @Test
    public void testXoaHangHoa() {
        System.out.println("Xoa Hang Hoa");
        HangHoa hh1 = new HangHoa("MH01", "Chén", 10000, 20, "Làng gốm Bát Tràng", "29/12/2022");
        HangHoa hh2= new HangHoa("MH02", "Dĩa", 8000, 10, "Làng gốm Bát Tràng", "23/12/2022");
        HangHoa hh3 = new HangHoa("MH03", "Bát", 15000, 30, "Làng gốm Bát Tràng", "22/12/2022");
        HangHoa hh4 = new HangHoa("MH04", "Muỗng", 5000, 30, "Ninh Bình", "20/12/2022");
        QuanLyHangHoa instance = new QuanLyHangHoa();
        instance.ThemHangHoa(hh1);
        instance.ThemHangHoa(hh2);
        instance.ThemHangHoa(hh3);
        instance.ThemHangHoa(hh4);
        boolean expResult = true;
        boolean result = instance.XoaHangHoa("MH01");
        assertEquals(expResult, result);
    }

    /**
     * Test of XemDanhSachHangHoa method, of class QuanLyHangHoa.
     */
    @Test
    public void testXemDanhSachHangHoa() {
        System.out.println("Xem Danh Sach Hang Hoa");
        int soLuong = 15;
        HangHoa hh1 = new HangHoa("MH01", "Chén", 10000, 20, "Làng gốm Bát Tràng", "29/12/2022");
        HangHoa hh2= new HangHoa("MH02", "Dĩa", 8000, 10, "Làng gốm Bát Tràng", "23/12/2022");
        HangHoa hh3 = new HangHoa("MH03", "Bát", 15000, 30, "Làng gốm Bát Tràng", "22/12/2022");
        HangHoa hh4 = new HangHoa("MH04", "Muỗng", 5000, 30, "Ninh Bình", "20/12/2022");
        QuanLyHangHoa instance1 = new QuanLyHangHoa();
        instance1.ThemHangHoa(hh1);
        instance1.ThemHangHoa(hh2);
        instance1.ThemHangHoa(hh3);
        instance1.ThemHangHoa(hh4);
        QuanLyHangHoa instance2 = new QuanLyHangHoa();
        instance2.ThemHangHoa(hh1);
        instance2.ThemHangHoa(hh3);
        instance2.ThemHangHoa(hh4);
        ArrayList<HangHoa> expResult = instance2.getData();
        ArrayList<HangHoa> result = instance1.XemDanhSachHangHoa(soLuong);
        assertEquals(expResult, result);
    }

    /**
     * Test of SapXepNoiSX method, of class QuanLyHangHoa.
     */
    @Test
    public void testSapXepNoiSX() {
        System.out.println("SapXepNoiSX");
        HangHoa hh1 = new HangHoa("MH01", "Chén", 10000, 20, "Làng gốm Bát Tràng 2", "29/12/2022");
        HangHoa hh2= new HangHoa("MH02", "Dĩa", 8000, 10, "Làng gốm Bát Tràng 1", "23/12/2022");
        HangHoa hh3 = new HangHoa("MH03", "Bát", 15000, 30, "Làng gốm Bát Tràng 3", "22/12/2022");
        HangHoa hh4 = new HangHoa("MH04", "Muỗng", 5000, 30, "Ninh Bình", "20/12/2022");
        QuanLyHangHoa instance = new QuanLyHangHoa();
        instance.ThemHangHoa(hh1);
        instance.ThemHangHoa(hh2);
        instance.ThemHangHoa(hh3);
        instance.ThemHangHoa(hh4);
        instance.SapXepNoiSX();
        assertEquals(hh1.toString(), instance.getData().get(0).toString());
        assertEquals(hh2.toString(), instance.getData().get(0).toString());
        assertEquals(hh3.toString(), instance.getData().get(0).toString());
        assertEquals(hh4.toString(), instance.getData().get(0).toString());
    }

    /**
     * Test of TongTien method, of class QuanLyHangHoa.
     */
    @Test
    public void testTongTien() {
        System.out.println("Tong Tien");
        HangHoa hh1 = new HangHoa("MH01", "Chén", 10000, 20, "Làng gốm Bát Tràng", "29/12/2022");
        HangHoa hh2= new HangHoa("MH02", "Dĩa", 8000, 10, "Làng gốm Bát Tràng", "23/12/2022");
        HangHoa hh3 = new HangHoa("MH03", "Bát", 15000, 30, "Làng gốm Bát Tràng", "22/12/2022");
        HangHoa hh4 = new HangHoa("MH04", "Muỗng", 5000, 30, "Ninh Bình", "20/12/2022");
        QuanLyHangHoa instance = new QuanLyHangHoa();
        instance.ThemHangHoa(hh1);
        instance.ThemHangHoa(hh2);
        instance.ThemHangHoa(hh3);
        instance.ThemHangHoa(hh4);
        double expResult = 880000;
        double result = instance.TongTien();
        assertEquals(expResult, result);
    }

    /**
     * Test of GhiDuLieu method, of class QuanLyHangHoa.
     */
    @Test
    public void testDocGhiDuLieu() {
        System.out.println("Ghi Du Lieu");
        HangHoa hh1 = new HangHoa("MH01", "Chén", 10000, 20, "Làng gốm Bát Tràng", "29/12/2022");
        HangHoa hh2= new HangHoa("MH02", "Dĩa", 8000, 10, "Làng gốm Bát Tràng", "23/12/2022");
        HangHoa hh3 = new HangHoa("MH03", "Bát", 15000, 30, "Làng gốm Bát Tràng", "22/12/2022");
        HangHoa hh4 = new HangHoa("MH04", "Muỗng", 5000, 30, "Ninh Bình", "20/12/2022");
        QuanLyHangHoa instance = new QuanLyHangHoa();
        instance.ThemHangHoa(hh1);
        instance.ThemHangHoa(hh2);
        instance.ThemHangHoa(hh3);
        instance.ThemHangHoa(hh4);
        instance.GhiDuLieu("HangHoa.txt");
        ArrayList<HangHoa> duLieuDoc = instance.DocDuLieu("HangHoa.txt");
        assertEquals(hh1.toString(), duLieuDoc.get(0).toString());
        assertEquals(hh2.toString(), duLieuDoc.get(1).toString());
        assertEquals(hh3.toString(), duLieuDoc.get(2).toString());
        assertEquals(hh4.toString(), duLieuDoc.get(3).toString());
    }
    
}
