/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.dmojava;
import java.math.BigInteger;
import java.util.Scanner;
/**
 *
 * @author admin
 */
public class Dmojava {

    public static void main(String[] args) {
        Scanner input=new Scanner(System.in);
        System.out.println("Nhap vao so A");
        BigInteger a=input.nextBigInteger();
        System.out.println("Nhap vao so B");
        BigInteger b=input.nextBigInteger();
        Operator cong=new Operator(a);
        cong.congHaiSo(b);
        System.out.println(a +" + "+b +" = "+cong.congHaiSo(b));
        cong.truHaiSo(b);
        System.out.println(a +" - "+b +" = "+cong.truHaiSo(b));
    }
}
