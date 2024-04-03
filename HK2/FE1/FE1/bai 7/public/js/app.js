const start = document.querySelector(".start");
const timeout=document.querySelector(".timeout");
const score=document.querySelector("#score");
let getRndInteger = (min, max) => Math.floor(Math.random() * (max - min)) + min;
start.addEventListener("click", function () {
    for (let i = 0; i <= 15; i++) {
        document.body.insertAdjacentHTML("beforebegin", "<div class='number'>" + i + "</div>");
    }
    const number = document.querySelectorAll(".number");
    let changePosition = () => {
        number.forEach(function (item) {
            item.style.top = getRndInteger(0, 600) + "px";
            item.style.left = getRndInteger(0, 1000) + "px";
        })
    }
    changePosition();
    let point=0;
    let dem=0;
    number.forEach(function(item){
        item.addEventListener("click", function () {
            if(item.innerHTML==dem)
            {
                item.classList.add("pink");
                point+=parseInt(item.textContent);
                dem++;
            }
        })
    })
    setTimeout(() => {
        Timeout();
        score.textContent="Điểm của bạn là: " + point;
    }, 20000);
})
function Timeout()
{
    timeout.style.display="block";
}