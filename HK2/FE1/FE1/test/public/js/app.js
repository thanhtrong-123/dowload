// let a = 10, phone =['samsung','apple','nokia','oppo'];
// phone.forEach(element => {
//     console.log(element);
// });
// let student ={
//     fullName: 'LE THANH SON',
//     dob: '21/11/2003',
//     id:'21211TT0497',
//     mark: [7,8,9,10,9,7]
// }
// function tinhDiemTrungBinh(arrMark)
// {
//    let sum = 0;
//    arrMark.forEach(element => {
//        sum += element;
//    });
//     return avg = sum / arrMark.length;
// }
// console.log(tinhDiemTrungBinh(student.mark));
const box=document.querySelectorAll('.box');
box.forEach(element=>{
    element.addEventListener('click',function(){ 
    alert(1);      
    });
});
box.forEach(element=>{
    element.addEventListener('click',function(){
    CircleClick(this)
    });
});
function CircleClick(e){
    if(e.dataset.win==1){
        alert('Thang roi!!')
    }
    else{
        alert('Thua roi!!')
    }
}