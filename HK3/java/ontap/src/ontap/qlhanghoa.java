/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ontap;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.text.ParseException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author LENOVO
 */
public class qlhanghoa {
    private ArrayList<Hanghoa> qlhh=new ArrayList<Hanghoa>();

    public ArrayList<Hanghoa> LayDS(int n) {
        ArrayList<Hanghoa> ds=new ArrayList<Hanghoa>();
        for (Hanghoa hanghoa : qlhh) {
            if(hanghoa.getSl()>n)
            {
                ds.add(hanghoa);
            }
        }
        return ds;
    }

    public qlhanghoa() {
    }

    public ArrayList<Hanghoa> getQlhh() {
        return qlhh;
    }

    public void setQlhh(ArrayList<Hanghoa> qlhh) {
        this.qlhh = qlhh;
    }
    public void AddHH(Hanghoa hh)
    {
        qlhh.add(hh);
    }
    public void Removehh(String ma)
    {
        for (Hanghoa hanghoa : qlhh) {
            if(hanghoa.getMa()==ma)
            {
                qlhh.remove(hanghoa);
                return;
            }
        }
    }
    public void Edithh(int index, Hanghoa hh)
    {
        qlhh.set(index, hh);
    }
    public int TongTien()
    {
        int tongtien=0;
        for (Hanghoa hanghoa : qlhh) {
            tongtien+=hanghoa.getGia();
        }
        return tongtien;
    }
    public void LuuDS() throws IOException
    {
        File f=new File("danhsach_hanghoa.txt");
        FileWriter fw=new FileWriter(f);
        BufferedWriter bw=new BufferedWriter(fw);
        for (Hanghoa hanghoa : qlhh) {
            bw.write(hanghoa.toString());
            bw.newLine();
        }
        bw.close();
    }
    public ArrayList<Hanghoa> DocDuLieu() throws IOException
    {
        ArrayList<Hanghoa> hh=new ArrayList<Hanghoa>();
        File f=new File("danhsach_hanghoa.txt");
        FileReader fr=new FileReader(f);
        BufferedReader br=new BufferedReader(fr);
        String line="";
        while(true)
        {
            line=br.readLine();
            if(line==null)
            {
                break;
            }
            String []t=line.split(" ");          
                try {
                    hh.add(new Hanghoa(t[1],t[2],t[3],Integer.parseInt(t[4]),Integer.parseInt(t[5]),t[6]));
                } catch (ParseException ex) {
                    Logger.getLogger(qlhanghoa.class.getName()).log(Level.SEVERE, null, ex);
                }
        }
        br.close();
        return hh;
    }
    public void SapXepHH()
    {
        Collections.sort(qlhh, new Comparator<Hanghoa>() {
            @Override
            public int compare(Hanghoa o1, Hanghoa o2) {
                int noisx= o1.getNoisx().compareTo(o2.getNoisx());
                if(noisx==0)
                {
                    if(o1.getGia()*o1.getSl()>o2.getGia()*o2.getSl())
                    {
                        return -1;
                    }
                    else if(o1.getGia()*o1.getSl()<o2.getGia()*o2.getSl())
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else{
                    return noisx;
                }
            }
        });
    }
    public Hanghoa Seek(String ma)
    {
        for (Hanghoa hanghoa : qlhh) {
            if(hanghoa.getMa().equals(ma))
            {
                return hanghoa;
            }
        }
        return null;
    }
}
