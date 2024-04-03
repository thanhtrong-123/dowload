const a = document.querySelector("#a");
const play = document.querySelector(".play");
const stop = document.querySelector(".stop");
let t;
stop.style.display = "none";
stop.addEventListener("click", function () {
    clearInterval(t);
    stop.style.display = "none";
    play.style.display = "block";
})
play.addEventListener("click", function () {
    t = setInterval(c, 1);
    stop.style.display = "block";
    play.style.display = "none";
})
function c() {
    a.style.transform += "rotate(15deg)";
}
const b = document.querySelectorAll(".b");
b.forEach(function (item) {
    item.addEventListener("click", function () {
        a.setAttribute("src", item.getAttribute("src"));
        b.forEach(function (i) {
            if (i.getAttribute("src") == a.getAttribute("src")) {
                i.classList.remove("e");
            }
            else {
                i.classList.add("e");
            }
        })
    })
})