/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Other/File.java to edit this template
 */
package com.mycompany.dmojava;

import java.math.BigInteger;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author admin
 */
public class testOperator {

    @Text
    public void testCongHaiSoNguyenLon(){
        BigInteger a=new BigInteger("123456789");
        BigInteger b=new BigInteger("987654321");        
        Operator bigInt=new Operator(a);
        BigInteger actual=bigInt.congHaiSo(b);
        BigInteger expected=new BigInteger("1111111110");
        assertEquals(expected, actual);
    }
    @Test
    public void testTruHaiSoNguyenLon(){
        BigInteger a=new BigInteger("123456789");
        BigInteger b=new BigInteger("987654321");        
        Operator bigInt=new Operator(a);
        BigInteger actual=bigInt.truHaiSo(b);
        BigInteger expected=new BigInteger("-864197532");
        assertEquals(expected, actual);
    }

}
