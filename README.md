# NetProgram-Basic
## I. Cú pháp, kiểu dữ liệu...

1. Viết chương trình tìm ước số chung lớn nhất, bội số chung nhỏ nhất của hai số tự nhiên

2. Viết chương trình tìm tổng các chữ số của một số nguyên

3. Viết chương trình nhận vào một số nguyên và trả về cách phân tích số đó ra tích của thừa số nguyên tố. Ví dụ nhập vào 600 thì cần phải trả về `2 * 2 * 2 * 3 * 5 * 5`

4. Số fibonaci là dãy số bắt đầu từ 1 1 và sau đó, số tiếp theo bằng 2 số trước cộng lại. Tức là `1 1 2 3 5 8 ....`. Nhập vào số nguyên n, xuất ra danh sách những số fibonaci không lớn hơn n.

5. Viết phương trình giải phương trình bậc 2: 

    ![Phương trình bậc 2](https://latex.codecogs.com/gif.latex?ax^{2}&plus;bx&plus;c=0)

6. Viết phương trình nhập vào n và in ra tổng của dãy số
    ![Dãy số](https://latex.codecogs.com/gif.latex?1*2&plus;2*3&plus;3*4&plus;...&plus;n(n&plus;1))

7. Viết phương trình tính giai thừa `n!` của một số

8. Viết chương trình tính pi với độ sai số 0.0001 bằng công thức
    ![Pi](https://wikimedia.org/api/rest_v1/media/math/render/svg/e9e3959cd2d0ec735e7a6a1917df784842b76706)

9. Viết chương trình tính căn bậc 2 của một số thực không âm bất kỳ bằng phương pháp chia đôi.

Với f(n) lúc đầu = a

10. Tìm những số nguyên n có m chữ số thỏa mãn điều kiện: tổng của các chữ số của n khi lũy thừa hệ số m thì đúng bằng n. Ví dụ n=153 là hợp lệ vì m=3, 1^3 + 5^3 + 3^3 = 153 (Giới hạn 2<=m<=5).

## II. Bài tập về mảng

1. Viết chương trình tìm những số xuất hiện trên 2 lần trong một mảng số nguyên

2. Viết chương trình tìm tìm tổng của 3 số lớn nhất trong một mảng số nguyên

3. Viết chương trình tìm tổng của các số chẵn và trừ đi tổng các số lẻ trong một mảng số nguyên

4. Viết chương trình tính tổng của các số nguyên tố trong một mảng số nguyên

5. Viết chương trình tìm mãng con liên tiếp tăng dần dài nhất từ một mảng số nguyên

6. Viết chương trình sử dụng phương pháp tìm kiếm nhị phân để tìm kiếm một số nguyên từ một mảng số nguyên đã sắp xếp (tăng dần hoặc giảm dần), trả về vị trí nếu tìm thấy hoặc -1 nếu không tìm thấy

7. Viết chương trình chia một mảng số nguyên thành n mảng con có số lượng phần tử bằng nhau (Riêng mảng cuối cùng có thể có số phần tử ít hơn)

8. Viết chương trình đếm xem có bao nhiêu số chia hết cho 3 nhưng không chia hết cho 5 trong 1 mảng 1 chiều

9. Viết chương trình tạo ngẫu nhiên một mảng gồm n số nguyên có giá trị từ 1 - n mà có các giá trị theo thứ tự 

10. Viết chương trình tính tổng các số chính phương từ mảng 1 chiều

## III. String


Viết chương trình xử lý một chuổi ký tự (String)

1. Viết chương trình chuyển hoá một tên biến từ UpperCase về snake_case. Ví dụ `MyProgram` thành `my_program`

2. Viết chương trình chuyển hoá một tên biến từ snake_case về UpperCase

3. Viết chương trình đảo ngược thứ tự của các ký tự trong chuỗi.

4. Tính tổng của các số nguyên trong chuỗi. Ví dụ `abc 123 def 33 mn 3.221` sẽ in ra 380 với 380 = 123+33+3+221

5. Kiểm tra chuỗi ký tự có đối xứng hay không. (Ví dụ abcdcba là đối xứng)

6. Nhận vào một chuổi ký tự chứa toàn các chữ cái (a-z, A-Z). Rút gọn chuỗi bằng cách ở những nơi chữ cái lặp lại, ta viết số lần lặp. Ví dụ `abcccceeeeeefd` sẽ viết thành `abc4e6fd`, `abbbbbbbbbbbbbc` viết là `ab13c`

7. Nhận vào chuổi đã được viết gọn ở câu 9, dịch nó thành chuỗi lúc đầu.

8. Nhận tham một string, xóa các ký tự giống nhau liên tiếp và giữ lại một. 
    Ví dụ `abbbbbbccccd eeffffddbc` thành --> `abcd efdbc`

9. Một [Barcode EAN 13](https://vi.wikipedia.org/wiki/EAN-13) có 13 con số được coi là hợp lệ nếu: tổng của các số ở vị trí lẻ + 3*(tổng các số ở vị trí chẳn) là một số chia hết cho 10.

Ví dụ mã barcode `8938505974194` ta có (8+3+5+5+7+1+4) + 3 * (9+8+0+9+4+9) = 150. 150 chia hết cho 10 nên mã `8938505974194` là hợp lệ.

Viết chương trình kiểm tra tính hợp lệ của một barcode.

