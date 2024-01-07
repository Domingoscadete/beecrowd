n1=int(input())
n2=int(input())
if n1>n2:
    while n1>n2:
        if(n2%5==2):
            print(n2)
           
        elif(n2%5==3):
            print(n2)
         

        n2+=1
elif n1<n2:
    while n1<n2:
        if(n1%5==2):
            print(n1)
            
        elif(n1%5==3):
            print(n1)
           
        n1+=1

      
