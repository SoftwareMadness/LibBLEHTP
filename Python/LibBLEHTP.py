# Copyright AnthonyOpenSource 2021

def CalculatePower(number, powerOf):
    if (powerOf < 0):
        res = number
        x = 0
        while True:
            res /= 10
            if not x < (0 - powerOf):
                break
            x+=1

        return res
    else:
        return number ** powerOf

def decode(data):
    exponent = data[0]
    mantissa = (data[1] * 65536) + (data[2] * 256) + (data[3])
    result = CalculatePower(mantissa, exponent)
    result
