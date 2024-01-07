
def pri(n1):
    res=0
    for i in range(1,n1+1):
        if n1%i==0:
            res+=1
            i+=1
        i+=1  
    if res==2:
        return "eh primo"
    elif res!=2:
        return "nao eh primo"
n2=int(input())
n=0
while n<n2:
    n3=int(input())
    print(str(n3)+" "+pri(n3))
    n3=0
    n+=1


