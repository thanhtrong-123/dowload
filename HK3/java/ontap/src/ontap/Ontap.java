/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ontap;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;

/**
 *
 * @author LENOVO
 */
public class Ontap {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws ParseException {    
        // TODO code application logic here
        
        Hanghoa hh=new Hanghoa("a2", "a", "abc", 1, 10, "11/11/1111");
        System.out.println(hh.toString());
    }
    
}
