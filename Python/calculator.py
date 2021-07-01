while True:
    expression = input('Expression: ')
    for char in expression:
        if not char in "0123456789+-/9%":
            continue
    eval(expression)
