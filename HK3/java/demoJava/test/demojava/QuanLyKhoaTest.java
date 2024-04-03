/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit4TestClass.java to edit this template
 */
package demojava;

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
        Khoa kh1 = null;
        QuanLyKhoa instance = new QuanLyKhoa();
        instance.Them(kh1);
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
     * Test of TimKiem method, of class QuanLyKhoa.
     */
    @Test
    public void testTimKiem() {
        System.out.println("TimKiem");
        String maKhoa = "";
        QuanLyKhoa instance = new QuanLyKhoa();
        Khoa expResult = null;
        Khoa result = instance.TimKiem(maKhoa);
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }
    
}
