n1=int(input())
n2=int(input())
r=0
while n2<n1:
    if n2%2!=0:
        r+=n2
        n2+=1
    
    n2+=1

while n2>n1:
    if n1%2!=0:
        r+=n1
        n1+=1
    n1+=1
print(r)

