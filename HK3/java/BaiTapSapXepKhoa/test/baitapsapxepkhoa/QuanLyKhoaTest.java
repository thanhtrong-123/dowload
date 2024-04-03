/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit4TestClass.java to edit this template
 */
package baitapsapxepkhoa;

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
public class QuanLyKhoaTest {
    
    public QuanLyKhoaTest() {
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
     * Test of getData method, of class QuanLyKhoa.
     */
    @Test
    public void testGetData() {
        System.out.println("getData");
        QuanLyKhoa instance = new QuanLyKhoa();
        ArrayList<Khoa> expResult = null;
        ArrayList<Khoa> result = instance.getData();
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of setData method, of class QuanLyKhoa.
     */
    @Test
    public void testSetData() {
        System.out.println("setData");
        ArrayList<Khoa> data = null;
        QuanLyKhoa instance = new QuanLyKhoa();
        instance.setData(data);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of Them method, of class QuanLyKhoa.
     */
    @Test
    public void testThem() {
        System.out.println("Them");
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
        int expected = 5;
        int result = qlk.getData().size();
        assertEquals(expected,result);
    }

    /**
     * Test of Sua method, of class QuanLyKhoa.
     */
    @Test
    public void testSua() {
        System.out.println("Sua");
        String maKhoa = "";
        String tenKhoa = "";
        QuanLyKhoa instance = new QuanLyKhoa();
        instance.Sua(maKhoa, tenKhoa);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of Xoa method, of class QuanLyKhoa.
     */
    @Test
    public void testXoa() {
        System.out.println("Xoa");
        String maKhoa = "";
        QuanLyKhoa instance = new QuanLyKhoa();
        instance.Xoa(maKhoa);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of TimKiemMH method, of class QuanLyKhoa.
     */
    @Test
    public void testTimKiemMH() {
        System.out.println("TimKiemMH");
        String maKhoa = "";
        QuanLyKhoa instance = new QuanLyKhoa();
        Khoa expResult = null;
        Khoa result = instance.TimKiemMH(maKhoa);
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of SapXepKhoa method, of class QuanLyKhoa.
     */
    @Test
    public void testSapXepKhoa() {
        System.out.println("SapXepKhoa");
        QuanLyKhoa instance = new QuanLyKhoa();
        instance.SapXepKhoa();
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of XuatTT method, of class QuanLyKhoa.
     */
    @Test
    public void testXuatTT() {
        System.out.println("XuatTT");
        QuanLyKhoa instance = new QuanLyKhoa();
        instance.XuatTT();
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }
    
}
