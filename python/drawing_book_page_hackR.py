def pageCount(n, p):
    back_val=0
    res=[i for i in range(n+1)]
    new=[res[i:i+2] for i in range(0,len(res),2)]
    print(new) 
    for i in range(len(new)):
        if p in new[i]:
            front_val=i
        if p in new[::-1][i]:
            back_val=i
            print(back_val) 
                    
    return min([front_val,back_val])



if __name__=="__main__":
    pageCount(6,2)
