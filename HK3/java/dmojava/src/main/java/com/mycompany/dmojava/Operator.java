/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Other/File.java to edit this template
 */
package com.mycompany.dmojava;
import java.math.BigInteger;
/**
 *
 * @author admin
 */
public class Operator {
    private BigInteger soA;

    public Operator(BigInteger soA) {
        this.soA = soA;
    }
    public BigInteger congHaiSo(BigInteger other)
    {
        BigInteger sum;
        sum=this.soA.add(other);
        return sum;
    }
    public BigInteger truHaiSo(BigInteger other)
    {
        BigInteger sum;
        sum=this.soA.subtract(other);
        return sum;
    }
}
