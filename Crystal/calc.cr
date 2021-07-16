puts("Please enter a valid operator (+,-,/,*)")
op = gets
puts("Please enter your first number")
one = gets
puts("Please enter your second number")
twonum = gets

numero = one.to_i # Converts string to int (cause why not)
uno = twonum.to_i

if op = '+' # Apparently a case (aka Switch statement) didn't work in this case so just standard if's were used. (No pun intended)
    puts("#{numero + uno}")
elsif op = '-'
    puts("#{numero - uno}")
elsif op = '*'
    puts("#{numero * uno}")
elsif op = '/'
    puts("#{numero / uno}")
end
