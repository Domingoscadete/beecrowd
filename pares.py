i=0
r=0
while i<5:
    n1=int(input())
    if n1%2==0:
        r+=1
        i+=1
        n1=0
    else:
        i+=1
        n1=0
print(str(r)+" valores positivos")

