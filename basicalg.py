# 辗转相除
def gcd(x,y):
    if x > y:
        x,y = x%y,y
    while x == 0:
        return y


 





