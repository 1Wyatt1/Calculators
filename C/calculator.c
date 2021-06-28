#include <stdio.h>
#include <stdlib.h>

int main(void)
{   
    int response;
    int num1;
    int num2;

    printf("Welcome, please enter an operation such as: +,-,*,/ \n");
    response = getchar();

    printf("\nWhat is the first number you want to use? \n");
    scanf(" %d", &num1);
    printf("\nWhat is the second number you want to use? \n");
    scanf(" %d", &num2);

    switch(response){
        case '0':
            break;

        case '+':   // Addition
        printf("\n%i\n",num1+num2);
            break;

        case '-':   // Subtraction
        printf("\n%i\n",num1-num2);
            break;

        case '/':   // Division
        printf("\n%i\n",num1/num2);
            break;
            
        case '*':   // Multiplication
        printf("\n%i\n",num1*num2);
            break;

        default:
        printf("An exception occured, please restart the program. \n");
            break;

    }
    return 0;
}
