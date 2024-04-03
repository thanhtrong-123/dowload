# -*- coding: utf-8 -*-
"""
Created on Fri Jun  9 13:15:38 2023

@author: trong
"""

class Person:
    def __init__(self, hoTen, diaChi):    
        self.hoTen = hoTen
        self.diaChi = diaChi
    def info(self):
        print(self.hoTen + "," + self.diaChi)
        
class Student(Person):
    def __init__(self, hoTen, diaChi, diemMonHoc1, diemMonHoc2):
        super().__init__(hoTen, diaChi)
        self.diemMonHoc1 = diemMonHoc1
        self.diemMonHoc2 = diemMonHoc2
    def tinh_diem_trung_binh(self):
        return (self.diemMonHoc1 + self.diemMonHoc2) / 2
    
    def danh_gia_diem_trung_binh(self):
        diemTB = self.tinh_diem_trung_binh()
        
        if diemTB >= 9.0:
            danh_gia = "Xuất sắc"
        elif diemTB >= 8.0:
            danh_gia = "Giỏi"
        elif diemTB >= 7.0:
            danh_gia = "Khá"
        elif diemTB >= 5.0:
            danh_gia = "Trung bình"
        else:
            danh_gia = "Yếu"
        return danh_gia
    def toString(self):
        diemTB = self.tinh_diem_trung_binh()
        diemTB = str(diemTB)
        danh_gia = self.danh_gia_diem_trung_binh()
        print(super().toString() + "\điểm môn học 1: " + str(self.diemMonHoc1) + "\điểm môn học 2: " + str(self.diemMonHoc2) + "\nAverage: " + diemTB + "\nEvaluation: " + danh_gia)

class Employee(Person):
    def __init__(self, hoTen, diaChi, hsLuong):
        super().__init__(hoTen, diaChi)
        self.hsLuong = hsLuong

    def TinhLuong(self):
        luongCB = 1000
        return self.hsLuong * luongCB

    def DanhGia(self):
        luong = self.TinhLuong()
        if luong >= 2000:
            return "Cao"
        elif luong >= 1500:
            return "Trung Bình"
        else:
            return ""

    def toString(self):
        salary = self.calculate_salary()
        return f"{super().toString()}\nSalary Coefficient: {self.salary_coefficient}\nSalary: {salary}\nEvaluation: {self.evaluate()}"
    def toString(self):
        luong = self.TinhLuong()
        print(super().toString() + "\n Hệ số lương: " + str(self.hsLuong) + "\nLương: " + str(luong) + "\n Đánh Giá: " + self.DanhGia()

class Customer(Person):
    def __init__(self, hoTen, diaChi, tenCT, triGiaHoaDon):
        super().__init__(hoTen, diaChi)
        self.tenCT = tenCT
        self.triGiaHoaDon = triGiaHoaDon

    def DanhGia(self):
        if self.triGiaHoaDon >= 1000:
            return "Cao"
        elif self.triGiaHoaDon >= 500:
            return "Trung bình"
        else:
            return "Thấp"

    def toString(self):
        return super().toString() + "\nTên Công ty: " + self.tenCT + "\nGiá trị hóa đơn: " + str(self.triGiaHoaDon) + "\nĐánh giá: " + self.DanhGia()


class Management:
    def __init__(self, n):
        self.persons = []
        self.total_count = 0
        self.n = n

    def add_person(self, person):
        if self.total_count < self.n:
            self.persons.append(person)
            self.total_count += 1
            print("người đã thêm:", person.hoTen)
        else:
            print("Không thể thêm người khác. Đã đạt đến giới hạn tối đa.")

    def remove_person(self, hoTen):
        for person in self.persons:
            if person.hoTen == hoTen:
                self.persons.remove(person)
                self.total_count -= 1
                print("người bị xóa:", hoTen)
                return
        print("người có tên", hoTen, "không tìm thấy.")

    def sort_by_name(self):
        self.persons.sort(key=lambda x: x.hoTen)

    def display_list(self):
        if self.total_count == 0:
            print("Không có người trong danh sách.")
        else:
            for person in self.persons:
                person.info()
                print("---------------")

class Test:
    @staticmethod
    def display_menu():
        print("1. Thêm một người")
        print("2. Xóa một người")
        print("3. Sắp xếp danh sách theo tên")
        print("4. Hiển thị danh sách")
        print("5. Thoát")

    @staticmethod
    def main():
        management = Management(5)  # Giới hạn tối đa 5 người

        while True:
            Test.display_menu()
            choice = input("Nhập lựa chọn của bạn: ")

            if choice == "1":
                person_type = input("Nhập loại người (student/employee/customer): ")

                if person_type == "student":
                    name = input("Nhập tên: ")
                    address = input("Nhập địa chỉ: ")
                    subject1 = float(input("Nhập điểm môn học 1: "))
                    subject2 = float(input("Nhập điểm môn học 2: "))
                    student = Student(name, address, subject1, subject2)
                    management.add_person(student)
                elif person_type == "employee":
                    name = input("Nhập tên: ")
                    address = input("Nhập địa chỉ: ")
                    salary_coefficient = float(input("Nhập hệ số lương: "))
                    employee = Employee(name, address, salary_coefficient)
                    management.add_person(employee)
                elif person_type == "customer":
                    name = input("Nhập tên: ")
                    address = input("Nhập địa chỉ: ")
                    company_name = input("Nhập tên công ty: ")
                    bill_value = float(input("Nhập giá trị hóa đơn: "))
                    customer = Customer(name, address, company_name, bill_value)
                    management.add_person(customer)
                else:
                    print("Loại người không hợp lệ.")
            elif choice == "2":
                name = input("Nhập tên người cần xóa: ")
                management.remove_person(name)
            elif choice == "3":
                management.sort_by_name()
            elif choice == "4":
                management.display_list()
            elif choice == "5":
                print("Đang thoát chương trình.")
                break
            else:
                print("Lựa chọn không hợp lệ. Vui lòng thử lại.")


# Chạy chương trình
Test.main()

    
    
    
    
          
        
    