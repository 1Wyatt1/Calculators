// if the calculator is gonna be simple if-else then it's gonna be as awfully made
// as possible otherwise what's the point
//
// -superleaf1995

#include <exception>
#include <iostream>
#include <sstream>
#include <cmath>

// instead of using a table we use a loop
enum CalculatorOperatorType {
	CALCULATOR_OPERATOR_TYPE_ADDITION,
	CALCULATOR_OPERATOR_TYPE_SUBSTRACTION,
	CALCULATOR_OPERATOR_TYPE_MULTIPLICATION,
	CALCULATOR_OPERATOR_TYPE_DIVISION,
	CALCULATOR_OPERATOR_TYPE_REMAINDER,
};

// polymorphism yikes
class CalculatorException : std::exception {
	std::string buffer;
public:
	CalculatorException(std::stringstream& msg) noexcept {
		buffer = msg.str();
	}
	CalculatorException(std::string msg) noexcept {
		buffer = msg;
	}
	inline const char* what(void) noexcept {
		return buffer.c_str();
	}
};

class CalculatorRequestResult : std::exception {
	long double x, y;
	enum CalculatorOperatorType type;
public:
	CalculatorRequestResult(long double _x, long double _y, enum CalculatorOperatorType _type)
	: x(_x), y(_y), type(_type) { };
	
	inline const char* what(void) {
		std::stringstream str;
		switch(type) {
		case CALCULATOR_OPERATOR_TYPE_ADDITION:
			str << (x + y);
			break;
		case CALCULATOR_OPERATOR_TYPE_SUBSTRACTION:
			str << (x - y);
			break;
		case CALCULATOR_OPERATOR_TYPE_MULTIPLICATION:
			str << (x * y);
			break;
		case CALCULATOR_OPERATOR_TYPE_DIVISION:
			str << (x / y);
			break;
		case CALCULATOR_OPERATOR_TYPE_REMAINDER:
			str << fmodl(x, y);
			break;
		default:
			throw CalculatorException("Invalid operator");
		}
		return str.str().c_str();
	}
};

void CalculatorInstance() {
	char op;
	std::cout << "Operator: "; std::cin >> op;
	
	long double x, y;
	std::cout << "A: "; std::cin >> x;
	std::cout << "B: "; std::cin >> y;
	
	enum CalculatorOperatorType type;
	switch(op) {
	case '+':
		type = CALCULATOR_OPERATOR_TYPE_ADDITION;
		break;
	case '-':
		type = CALCULATOR_OPERATOR_TYPE_SUBSTRACTION;
		break;
	case '*':
		type = CALCULATOR_OPERATOR_TYPE_MULTIPLICATION;
		break;
	case '/':
		type = CALCULATOR_OPERATOR_TYPE_DIVISION;
		break;
	case '%':
		type = CALCULATOR_OPERATOR_TYPE_REMAINDER;
		break;
	default:
		throw CalculatorException("Invalid operator");
	}
	throw CalculatorRequestResult(x, y, type);
}

int main(void) {
	// we will ask this magic function were is all our javascript promises
	// javascript you fucking promised to return a value 3 seconds ago
	// fuck you javascript
	try {
		CalculatorInstance();
	} catch(CalculatorRequestResult& e) {
		std::cout << "Result: " << e.what() << std::endl;
	}
	return 0;
}
