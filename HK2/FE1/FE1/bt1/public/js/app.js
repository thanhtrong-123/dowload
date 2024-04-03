const  calBtn=document.querySelectorAll('.cal-btn');
const operator=document.querySelector('#operation');
const result=document.querySelector('#result');

let newOperator=true;
calBtn.forEach(element =>{
    element.addEventListener('click', function(){
        if(this.textContent =='C')
        {
            operator.textContent='';
            result.textContent='';
        }
        else if(this.textContent=='Enter'){
            const resultOperator=eval(operator.textContent);
            result.textContent=resultOperator;
            newOperator = true;
        }
        else
        {
            if(newOperator==true)
            {
                operator.textContent='';
                result.textContent='';
            }
            operator.textContent +=this.textContent;
            newOperator=false;
        }
    });
});