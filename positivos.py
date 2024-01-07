import math
i=0
r=0
t=0
while i<6:
    n1=float(input())
    if n1>0.0:
        r+=1
        t+=n1
        n1=0
        i+=1
    else: 
        n1=0
        i+=1

print(str(r)+" valores positivos")
print(round((t/r),1))
    
