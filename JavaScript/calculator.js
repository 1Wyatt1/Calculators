// Yes I know, this isn't in "console" but this was the best I could do with stock JavaScript. 
function calc(){
    var response = window.prompt("Please enter a valid operation (+,-,*,/)");
    var num1 = window.prompt("Please enter the first number");
    var num2 = window.prompt("Please enter the second number");

    first = Number(num1)
    second = Number(num2)
    
    switch(response){
        case '+':
        total = first + second; // Addition
        alert(total);
            break;
    
        case '-':
        total = first - second; // Subtraction
        alert(total);
            break;
    
        case '*':
        total = first * second; // Multiplication
        alert(total);
            break;
    
        case '/':
        total = first / second // Division
        alert(total);
            break;
    }
}
