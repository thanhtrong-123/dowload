const hoa = document.querySelectorAll(".btn-f");
const dia = document.querySelectorAll(".pot");
const tien = document.querySelector("#cash");
let hoa1 = "";
let price = 0;
let tien1 = tien.innerHTML;
hoa.forEach(function (i) {
    i.addEventListener("click", function () {
        hoa1 = i.getAttribute("id");
        hoa.forEach(function(a){
            if(a.getAttribute("id")==hoa1)
            {
                a.classList.add("a");
            }
            else
            {
                a.classList.remove("a");
            }
        })
        price = i.innerHTML;
        console.log(price);
    })
})
dia.forEach(function (item) {
    item.addEventListener("click", function () {
        if (hoa1 != "") {
            if (item.firstElementChild.getAttribute("src") == "") {
                if (tien1 >= price) {
                    item.firstElementChild.setAttribute("src", "public/images/" + hoa1 + ".png");
                    tien1 -= price;
                    tien.innerHTML = tien1;
                }
                else {
                    alert("bạn không đủ tiền");
                }
            }
            else {
                alert("dĩa đã có hoa rồi vui lòng chọn dĩa khác");
            }
        }
        else
        {
            alert("bạn phải chọn chậu hoa");
        }
    })
})
