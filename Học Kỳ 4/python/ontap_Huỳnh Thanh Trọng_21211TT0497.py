# -*- coding: utf-8 -*-
"""
Created on Fri Jun  9 14:42:41 2023

@author: trong
"""

class Person:
    def __init__(self, ho_ten, dia_chi):
        self.ho_ten = ho_ten
        self.dia_chi = dia_chi
    
    def __str__(self):
        return f"Họ tên: {self.ho_ten}\nĐịa chỉ: {self.dia_chi}"


class Student(Person):
    def __init__(self, ho_ten, dia_chi, diem_mon_hoc1, diem_mon_hoc2):
        super().__init__(ho_ten, dia_chi)
        self.diem_mon_hoc1 = diem_mon_hoc1
        self.diem_mon_hoc2 = diem_mon_hoc2
    
    def tinh_diem_trung_binh(self):
        diem_tb = (self.diem_mon_hoc1 + self.diem_mon_hoc2) / 2
        return diem_tb
    
    def danh_gia(self):
        diem_tb = self.tinh_diem_trung_binh()
        if diem_tb >= 9.0:
            return "Xuất sắc"
        elif diem_tb >= 8.0:
            return "Giỏi"
        elif diem_tb >= 7.0:
            return "Khá"
        elif diem_tb >= 5.0:
            return "Trung bình"
        else:
            return "Yếu"
    
    def __str__(self):
        diem_tb = self.tinh_diem_trung_binh()
        return f"{super().__str__()}\nĐiểm môn học 1: {self.diem_mon_hoc1}\nĐiểm môn học 2: {self.diem_mon_hoc2}\nĐiểm trung bình: {diem_tb}"


class Employee(Person):
    def __init__(self, ho_ten, dia_chi, he_so_luong):
        super().__init__(ho_ten, dia_chi)
        self.he_so_luong = he_so_luong
    
    def tinh_luong(self):
        return self.he_so_luong * 1000000
    
    def danh_gia(self):
        if self.he_so_luong >= 2.0:
            return "Xuất sắc"
        elif self.he_so_luong >= 1.5:
            return "Giỏi"
        elif self.he_so_luong >= 1.0:
            return "Khá"
        else:
            return "Yếu"
    
    def __str__(self):
        luong = self.tinh_luong()
        return f"{super().__str__()}\nHệ số lương: {self.he_so_luong}\nTiền lương: {luong}"


class Customer(Person):
    def __init__(self, ho_ten, dia_chi, ten_cong_ty, tri_gia_hoa_don):
        super().__init__(ho_ten, dia_chi)
        self.ten_cong_ty = ten_cong_ty
        self.tri_gia_hoa_don = tri_gia_hoa_don
    
    def __str__(self):
        return f"{super().__str__()}\nTên công ty: {self.ten_cong_ty}\nTrị giá hóa đơn: {self.tri_gia_hoa_don}"


class Management:
    def __init__(self, n):
        self.danh_sach = []
        self.tong_nguoi_hien_tai = 0
    
    def them_nguoi(self, nguoi):
        self.danh_sach.append(nguoi)
        self.tong_nguoi_hien_tai += 1
    
    def xoa_nguoi(self, ho_ten):
        for nguoi in self.danh_sach:
            if nguoi.ho_ten == ho_ten:
                self.danh_sach.remove(nguoi)
                self.tong_nguoi_hien_tai -= 1
                break
    
    def sap_xep_danh_sach(self):
        self.danh_sach.sort(key=lambda x: x.ho_ten)
    
    def xuat_danh_sach(self):
        for nguoi in self.danh_sach:
            print(nguoi)
            print("------------------------------")

class Test:
    @staticmethod
    def hien_thi_menu():
        print("1. Thêm người")
        print("2. Xóa người")
        print("3. Sắp xếp danh sách theo tên")
        print("4. Hiển thị danh sách")
        print("5. Thoát")

    @staticmethod
    def main():
        quan_ly = Management(5)  # Giới hạn tối đa là 5 người

        while True:
            Test.hien_thi_menu()
            lua_chon = input("Nhập lựa chọn của bạn: ")

            if lua_chon == "1":
                loai_nguoi = input("Nhập loại người (sinh viên/nhân viên/khách hàng): ")

                if loai_nguoi == "sinh viên":
                    ho_ten = input("Nhập họ tên: ")
                    dia_chi = input("Nhập địa chỉ: ")
                    diem_mon_hoc1 = float(input("Nhập điểm môn học 1: "))
                    diem_mon_hoc2 = float(input("Nhập điểm môn học 2: "))
                    sinh_vien = Student(ho_ten, dia_chi, diem_mon_hoc1, diem_mon_hoc2)
                    quan_ly.them_nguoi(sinh_vien)
                elif loai_nguoi == "nhân viên":
                    ho_ten = input("Nhập họ tên: ")
                    dia_chi = input("Nhập địa chỉ: ")
                    he_so_luong = float(input("Nhập hệ số lương: "))
                    nhan_vien = Employee(ho_ten, dia_chi, he_so_luong)
                    quan_ly.them_nguoi(nhan_vien)
                elif loai_nguoi == "khách hàng":
                    ho_ten = input("Nhập họ tên: ")
                    dia_chi = input("Nhập địa chỉ: ")
                    ten_cong_ty = input("Nhập tên công ty: ")
                    tri_gia_hoa_don = float(input("Nhập trị giá hóa đơn: "))
                    khach_hang = Customer(ho_ten, dia_chi, ten_cong_ty, tri_gia_hoa_don)
                    quan_ly.them_nguoi(khach_hang)
                else:
                    print("Loại người không hợp lệ.")
            elif lua_chon == "2":
                ho_ten = input("Nhập tên người cần xóa: ")
                quan_ly.xoa_nguoi(ho_ten)
            elif lua_chon == "3":
                quan_ly.sap_xep_danh_sach()
            elif lua_chon == "4":
                quan_ly.xuat_danh_sach()
            elif lua_chon == "5":
                print("Đang thoát chương trình.")
                break
            else:
                print("Lựa chọn không hợp lệ. Vui lòng thử lại.")


# Chạy chương trình
Test.main()

