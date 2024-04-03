/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ontap;

import java.text.ParseException;
import java.util.ArrayList;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author LENOVO
 */
public class qlhanghoaTest {

    public qlhanghoaTest() {
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
     * Test of LayDS method, of class qlhanghoa.
     */
    @Test
    public void testLayDS() throws ParseException {
        System.out.println("LayDS");
        int n = 2;
        Hanghoa hh = new Hanghoa("a", "a", "a", 1, 4, "11/11/1111");
        Hanghoa hh1 = new Hanghoa("a1", "a", "a", 1, 5, "11/11/1111");

        qlhanghoa instance = new qlhanghoa();
        instance.AddHH(hh);
        instance.AddHH(hh1);
        int expect = 2;
        assertEquals(2, instance.LayDS(n).size());
        // TODO review the generated test code and remove the default call to fail.

    }

    /**
     * Test of AddHH method, of class qlhanghoa.
     */
    @Test
    public void testAddHH() throws ParseException {
        System.out.println("AddHH");
        Hanghoa hh = new Hanghoa("a", "a", "a", 1, 4, "11/11/1111");
        qlhanghoa instance = new qlhanghoa();
        instance.AddHH(hh);
        assertEquals(1, instance.getQlhh().size());
        // TODO review the generated test code and remove the default call to fail.
    }

    /**
     * Test of Removehh method, of class qlhanghoa.
     */
    @Test
    public void testRemovehh() throws ParseException {
        System.out.println("Removehh");
        String ma = "a";
        Hanghoa hh = new Hanghoa("a", "a", "a", 1, 4, "11/11/1111");

        qlhanghoa instance = new qlhanghoa();
        instance.AddHH(hh);
        instance.Removehh(ma);
        // TODO review the generated test code and remove the default call to fail.
        assertEquals(0, instance.getQlhh().size());
    }

    /**
     * Test of Edithh method, of class qlhanghoa.
     */
    @Test
    public void testEdithh() throws ParseException {
        System.out.println("Edithh");
        int index = 0;
        Hanghoa hh = new Hanghoa("a", "a", "a", 1, 4, "11/11/1111");
        qlhanghoa instance = new qlhanghoa();
        instance.AddHH(hh);
        Hanghoa hh1 = new Hanghoa("a", "aaaaa", "a", 1, 4, "11/11/1111");
        instance.Edithh(index, hh1);
        // TODO review the generated test code and remove the default call to fail.
        assertEquals("aaaaa", instance.getQlhh().get(0).getTen());
    }

    /**
     * Test of TongTien method, of class qlhanghoa.
     */
    @Test
    public void testTongTien() throws ParseException {
        System.out.println("TongTien");
        Hanghoa hh = new Hanghoa("a", "a", "a", 1, 4, "11/11/1111");
        Hanghoa hh1 = new Hanghoa("a1", "a", "a", 1, 4, "11/11/1111");
        qlhanghoa instance = new qlhanghoa();
        instance.AddHH(hh);
        instance.AddHH(hh1);
        int expResult = 2;
        int result = instance.TongTien();
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.

    }

    /**
     * Test of LuuDS method, of class qlhanghoa.
     */
    @Test
    public void testLuuDS() throws Exception {
        System.out.println("LuuDS");
        Hanghoa hh = new Hanghoa("a", "a", "a", 1, 4, "11/11/1111");
        Hanghoa hh1 = new Hanghoa("a1", "a", "a", 1, 4, "11/11/1111");
        qlhanghoa instance = new qlhanghoa();
        instance.AddHH(hh);
        instance.AddHH(hh1);
        instance.LuuDS();

        // TODO review the generated test code and remove the default call to fail.
        assertEquals(2, instance.DocDuLieu().size());
    }

    /**
     * Test of DocDuLieu method, of class qlhanghoa.
     */
    @Test
    public void testDocDuLieu() throws Exception {
        System.out.println("DocDuLieu");
        Hanghoa hh = new Hanghoa("a", "a", "a", 1, 4, "11/11/1111");
        Hanghoa hh1 = new Hanghoa("a1", "a", "a", 1, 4, "11/11/1111");
        qlhanghoa instance = new qlhanghoa();
        instance.AddHH(hh);
        instance.AddHH(hh1);
        instance.LuuDS();
        instance.DocDuLieu();
        // TODO review the generated test code and remove the default call to fail.
        assertEquals("a", instance.DocDuLieu().get(0).getMa());
    }

    /**
     * Test of SapXepHH method, of class qlhanghoa.
     */
    @Test
    public void testSapXepHH() throws ParseException {
        System.out.println("SapXepHH");
        Hanghoa hh = new Hanghoa("a", "a", "abc", 1, 4, "11/11/1111");
        Hanghoa hh1 = new Hanghoa("a1", "a", "a", 1, 4, "11/11/1111");
        Hanghoa hh2 = new Hanghoa("a2", "a", "abc", 1, 10, "11/11/1111");
        qlhanghoa instance = new qlhanghoa();
        instance.AddHH(hh);
        instance.AddHH(hh1);
        instance.AddHH(hh2);
        instance.SapXepHH();
        // TODO review the generated test code and remove the default call to fail.
        assertEquals("Hanghoa a1 a a 1 4 11/11/1111", instance.getQlhh().get(0).toString());
        assertEquals("Hanghoa a2 a abc 1 10 11/11/1111", instance.getQlhh().get(1).toString());
        assertEquals("Hanghoa a a abc 1 4 11/11/1111", instance.getQlhh().get(2).toString());
    }

}
