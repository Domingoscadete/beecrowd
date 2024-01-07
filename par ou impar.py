n1=int(input())
n2=0
for i in range(1,n1+1):
    n2=int(input())
    if n2<0 and n2%2!=0:
        print("ODD NEGATIVE")
        i+=1
    
      
    elif n2<0 and n2%2==0:
        print("EVEN NEGATIVE")
        i+=1
      
    
    elif n2>0 and n2%2!=0:
        print("ODD POSITIVE")
        i+=1
       
    elif n2>0 and n2%2==0:
        print("EVEN POSITIVE")
        i+=1
         
    elif n2==0:
        print("NULL")
        i+=1