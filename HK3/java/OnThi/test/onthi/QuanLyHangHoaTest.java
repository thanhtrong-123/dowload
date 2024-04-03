/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit4TestClass.java to edit this template
 */
package onthi;

import java.util.ArrayList;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author trong
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
     * Test of getData method, of class QuanLyHangHoa.
     */
    @Test
    public void testGetData() {
        System.out.println("getData");
        QuanLyHangHoa instance = new QuanLyHangHoa();
        ArrayList<HangHoa> expResult = null;
        ArrayList<HangHoa> result = instance.getData();
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of setData method, of class QuanLyHangHoa.
     */
    @Test
    public void testSetData() {
        System.out.println("setData");
        ArrayList<HangHoa> data = null;
        QuanLyHangHoa instance = new QuanLyHangHoa();
        instance.setData(data);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of ThemHangHoa method, of class QuanLyHangHoa.
     */
    @Test
    public void testThemHangHoa() {
        System.out.println("ThemHangHoa");
        HangHoa hh = null;
        QuanLyHangHoa instance = new QuanLyHangHoa();
        boolean expResult = false;
        boolean result = instance.ThemHangHoa(hh);
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of SuaHangHoa method, of class QuanLyHangHoa.
     */
    @Test
    public void testSuaHangHoa() {
        System.out.println("SuaHangHoa");
        HangHoa hh = null;
        QuanLyHangHoa instance = new QuanLyHangHoa();
        boolean expResult = false;
        boolean result = instance.SuaHangHoa(hh);
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of XoaHangHoa method, of class QuanLyHangHoa.
     */
    @Test
    public void testXoaHangHoa() {
        System.out.println("XoaHangHoa");
        String maHang = "";
        QuanLyHangHoa instance = new QuanLyHangHoa();
        boolean expResult = false;
        boolean result = instance.XoaHangHoa(maHang);
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of XemDanhSachHangHoa method, of class QuanLyHangHoa.
     */
    @Test
    public void testXemDanhSachHangHoa() {
        System.out.println("XemDanhSachHangHoa");
        int soLuong = 0;
        QuanLyHangHoa instance = new QuanLyHangHoa();
        ArrayList<HangHoa> expResult = null;
        ArrayList<HangHoa> result = instance.XemDanhSachHangHoa(soLuong);
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of SapXepNoiSX method, of class QuanLyHangHoa.
     */
    @Test
    public void testSapXepNoiSX() {
        System.out.println("SapXepNoiSX");
        QuanLyHangHoa instance = new QuanLyHangHoa();
        instance.SapXepNoiSX();
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of TongTien method, of class QuanLyHangHoa.
     */
    @Test
    public void testTongTien() {
        System.out.println("TongTien");
        QuanLyHangHoa instance = new QuanLyHangHoa();
        double expResult = 0.0;
        double result = instance.TongTien();
        assertEquals(expResult, result, 0);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of GhiDuLieu method, of class QuanLyHangHoa.
     */
    @Test
    public void testGhiDuLieu() {
        System.out.println("GhiDuLieu");
        String filename = "";
        QuanLyHangHoa instance = new QuanLyHangHoa();
        instance.GhiDuLieu(filename);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of DocDuLieu method, of class QuanLyHangHoa.
     */
    @Test
    public void testDocDuLieu() {
        System.out.println("DocDuLieu");
        String filename = "";
        QuanLyHangHoa instance = new QuanLyHangHoa();
        ArrayList<HangHoa> expResult = null;
        ArrayList<HangHoa> result = instance.DocDuLieu(filename);
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }
    
}
