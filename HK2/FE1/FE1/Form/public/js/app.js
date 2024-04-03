function validation() {
    if(check() == true){
        return true;
    }
    alert('loi !!!')
    return false;
    
}
function check() {
    const username = document.querySelector('#username').value;
    if (username != '') {
        return true
    }
        return false;

}
