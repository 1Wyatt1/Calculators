print('Please separate all numbers and operators with a space')
print('I.e. `8 + 2` not `8+2`')
print('Possible operators: +, -, *, /, %, //')

while True:
    expression = input('Expression: ')

    expression = expression.split(' ')

    if expression[1] == '+':
        print(str(float(expression[0]) + float(expression[2])))
    elif expression[1] == '-':
        print(str(float(expression[0]) - float(expression[2])))
    elif expression[1] == '*':
        print(str(float(expression[0]) * float(expression[2])))
    elif expression[1] == '/':
        print(str(float(expression[0]) / float(expression[2])))
    elif expression[1] == '%':
            print(str(float(expression[0]) % float(expression[2])))
    elif expression[1] == '//':
            print(str(float(expression[0]) // float(expression[2])))
        
