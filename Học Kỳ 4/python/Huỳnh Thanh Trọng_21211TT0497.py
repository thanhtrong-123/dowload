# -*- coding: utf-8 -*-
"""
Created on Fri May 26 14:31:15 2023

@author: Administrator
"""

class Student:
    def __init__(self, name, number):
        self.name = name
        self.number = number
        self.score = [0] * number

    def getName(self):
        return self.name

    def getScore(self, i):
        return self.score[i]

    def inputScore(self):
        for i in range(self.number):
            self.score[i] = float(input("Nhập điểm môn thi thứ {}: ".format(i+1)))

    def getAverage(self):
        total = sum(self.score)
        average = total / self.number
        return average

    def getHighScore(self):
        return max(self.score)

    def hasScholarship(self):
        average = self.getAverage()
        if average >= 8.0 and all(score >= 4.0 for score in self.score):
            return True
        else:
            return False

    def __str__(self):
        return "Tên sinh viên: {}\nĐiểm: {}".format(self.name, self.score)

print("Cau 1:")    
# Tạo một đối tượng Student
student = Student("Nguyễn Văn A", 5)

# Nhập điểm các môn thi
student.inputScore()

# In thông tin sinh viên
print(student)

# In tên sinh viên
print("Tên sinh viên:", student.getName())

# In điểm môn thi thứ 3
print("Điểm môn thi thứ 3:", student.getScore(2))

# In điểm trung bình
print("Điểm trung bình:", student.getAverage())

# In điểm cao nhất
print("Điểm cao nhất:", student.getHighScore())

# Kiểm tra xem có được học bổng không
if student.hasScholarship():
    print("Được học bổng")
else:
    print("Không được học bổng")
    
print("\n")
print("\n")
print("\n")

print("Cau 2")

class MyComplexNumber:
    def __init__(self, real, imaginary):
        self.real = real
        self.imaginary = imaginary

    def __str__(self):
        if self.imaginary >= 0:
            return "{} + {}i".format(self.real, self.imaginary)
        else:
            return "{} - {}i".format(self.real, abs(self.imaginary))

    def input(self):
        self.real = float(input("Nhập phần thực: "))
        self.imaginary = float(input("Nhập phần ảo: "))

    def my_addition(self, other):
        real = self.real + other.real
        imaginary = self.imaginary + other.imaginary
        return MyComplexNumber(real, imaginary)

    def my_subtract(self, other):
        real = self.real - other.real
        imaginary = self.imaginary - other.imaginary
        return MyComplexNumber(real, imaginary)

    def my_multi(self, other):
        real = self.real * other.real - self.imaginary * other.imaginary
        imaginary = self.real * other.imaginary + self.imaginary * other.real
        return MyComplexNumber(real, imaginary)

    def my_division(self, other):
        denominator = other.real**2 + other.imaginary**2
        real = (self.real * other.real + self.imaginary * other.imaginary) / denominator
        imaginary = (self.imaginary * other.real - self.real * other.imaginary) / denominator
        return MyComplexNumber(real, imaginary)

    def __add__(self, other):
        return self.my_addition(other)

    def __sub__(self, other):
        return self.my_subtract(other)

    def __mul__(self, other):
        return self.my_multi(other)

    def __truediv__(self, other):
        return self.my_division(other)

    def modulus(self):
        return (self.real**2 + self.imaginary**2)**0.5

    def compare(self, other):
        if self.modulus() == other.modulus():
            return "Hai số phức có độ lớn bằng nhau."
        elif self.modulus() < other.modulus():
            return "Số phức thứ nhất có độ lớn nhỏ hơn số phức thứ hai."
        else:
            return "Số phức thứ nhất có độ lớn lớn hơn số phức thứ hai."

    def __eq__(self, other):
        return self.modulus() == other.modulus()

    def __lt__(self, other):
        return self.modulus() < other.modulus()

    def __gt__(self, other):
        return self.modulus() > other.modulus()
    
# Tạo hai đối tượng số phức
complex1 = MyComplexNumber(3, 2)
complex2 = MyComplexNumber(1, 5)

# In hai số phức
print(complex1)
print(complex2)



# Tính tổng hai số phức
sum_complex = complex1 + complex2
print("Tổng hai số phức:", sum_complex)

# Tính hiệu hai số phức
diff_complex = complex1 - complex2
print("Hiệu hai số phức:", diff_complex)

# Tính tích hai số phức
product_complex = complex1 * complex2
print("Tích hai số phức:", product_complex)

# Tính thương hai số phức
division_complex = complex1 / complex2
print("Thương hai số phức:", division_complex)

# Tính độ lớn của số phức
modulus = complex1.modulus()
print("Độ lớn của số phức:", modulus)

# So sánh hai số phức
comparison = complex1.compare(complex2)
print(comparison)

# Kiểm tra xem hai số phức có bằng nhau, lớn hơn hay nhỏ hơn nhau
print("Hai số phức có bằng nhau:", complex1 == complex2)
print("Số phức thứ nhất có độ lớn nhỏ hơn số phức thứ hai:", complex1 < complex2)
print("Số phức thứ nhất có độ lớn lớn hơn số phức thứ hai:", complex1 > complex2)

print("\n")
print("\n")
print("\n")

print("Cau 5")

class Employee:
    
    def __init__(self, ID, FullName, BirthDay, Phone, Email, Employee_type):
        self.ID = ID
        self.FullName = FullName
        self.BirthDay = self.validate_birthday(BirthDay)
        self.Phone = self.validate_phone(Phone)
        self.Email = self.validate_email(Email)
        self.Employee_type = Employee_type
        self.Employee_count = 1

    def show_info(self):
        print("ID:", self.ID)
        print("Full Name:", self.FullName)
        print("BirthDay:", self.BirthDay)
        print("Phone:", self.Phone)
        print("Email:", self.Email)
        print("Employee Type:", self.Employee_type)

    def validate_birthday(self, birthday):
        # Kiểm tra tính hợp lệ của ngày sinh
        # Thực hiện logic kiểm tra ở đây
        return birthday

    def validate_phone(self, phone):
        # Kiểm tra tính hợp lệ của số điện thoại
        # Thực hiện logic kiểm tra ở đây
        return phone

    def validate_email(self, email):
        # Kiểm tra tính hợp lệ của email
        # Thực hiện logic kiểm tra ở đây
        return email

class Experience(Employee):
    def __init__(self, ID, FullName, BirthDay, Phone, Email, ExpInYear, ProSkill):
        super().__init__(ID, FullName, BirthDay, Phone, Email, 0)
        self.ExpInYear = ExpInYear
        self.ProSkill = ProSkill

    def show_info(self):
        super().show_info()
        print("Experience in Years:", self.ExpInYear)
        print("Professional Skill:", self.ProSkill)

class Fresher(Employee):
    def __init__(self, ID, FullName, BirthDay, Phone, Email, Graduation_date, Graduation_rank, Education):
        super().__init__(ID, FullName, BirthDay, Phone, Email, 1)
        self.Graduation_date = Graduation_date
        self.Graduation_rank = Graduation_rank
        self.Education = Education

    def show_info(self):
        super().show_info()
        print("Graduation Date:", self.Graduation_date)
        print("Graduation Rank:", self.Graduation_rank)
        print("Education:", self.Education)

class Intern(Employee):
    def __init__(self, ID, FullName, BirthDay, Phone, Email, Majors, Semester, University_name):
        super().__init__(ID, FullName, BirthDay, Phone, Email, 2)
        self.Majors = Majors
        self.Semester = Semester
        self.University_name = University_name

    def show_info(self):
        super().show_info()
        print("Majors:", self.Majors)
        print("Semester:", self.Semester)
        print("University Name:", self.University_name)
        
def display_all_employees(Employee):
    print("Toàn bộ thông tin tất cả nhân viên:")
    for employee in Employee:
        employee.show_info()
def test():
    # Tạo một số nhân viên để kiểm tra
    experience_employee = Experience("001", "John Doe", "1990-01-01", "123456789", "john.doe@example.com", 10, "Python")
    fresher_employee = Fresher("002", "Jane Smith", "1995-05-05", "987654321", "jane.smith@example.com", "2020-06-30", "Good", "ABC University")
    intern_employee = Intern("003", "David Johnson", "2000-10-10", "456789123", "david.johnson@example.com", "Computer Science", "Spring 2023", "XYZ University")

    # Hiển thị thông tin của từng nhân viên
    experience_employee.show_info()
    print()
    fresher_employee.show_info()
    print()
    intern_employee.show_info()

    # Thêm nhân viên mới
    new_fresher = Fresher("004", "Mary Brown", "1998-12-12", "567891234", "mary.brown@example.com", "2022-12-31", "Excellent", "DEF University")
    
    # Thông tin toàn bộ nhân viên
    print("\n")
    print("\n")
    print("\n")
    employees = [experience_employee, fresher_employee, intern_employee, new_fresher]
    display_all_employees(employees)
    
    # Hiển thị thông tin của nhân viên mới
    print("\n")
    print("\n")
    print("\n")
    print("thông tin của nhân viên mới")
    new_fresher.show_info()

    # Tìm tất cả nhân viên intern
    employees = [experience_employee, fresher_employee, intern_employee, new_fresher]
    interns = [emp for emp in employees if isinstance(emp, Intern)]
    print("\nIntern Employees:")
    for intern in interns:
        intern.show_info()

    # Tìm tất cả nhân viên experience
    experiences = [emp for emp in employees if isinstance(emp, Experience)]
    print("\nExperience Employees:")
    for exp in experiences:
        exp.show_info()

    # Tìm tất cả nhân viên fresher
    freshers = [emp for emp in employees if isinstance(emp, Fresher)]
    print("\nFresher Employees:")
    for fresher in freshers:
        fresher.show_info()

test()


