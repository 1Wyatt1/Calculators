while True:
    expression = input('Expression: ')

    if expression == 'exit' or expression == 'quit':
        exit()

    for char in expression: # Looks through every char in expression without splitting
        if not char in '1234567890+-*/%': # There is no single `/` because `//` is an operator in Python
        # and using `/` and `//` separately would be a waste since `/` is already in `//`
            continue

    print(eval(expression))
