/*  print unique elements from given array
 *
 *
 */
 
#include <stdio.h>

void main()
{
  int ary[5]={1,2,3,3,2};
  int i;
  for(i=0;i<5;i++)
  {
     printf("%d\n",ary[i]);
  }
  int j,flag;
  for(i=0;i<5;i++)
  {
     flag=0;
      for(j=1;j<5;j++)
      {
         if(ary[i]==ary[j])
		 flag=1;
      
      }
      if(flag==0)
	      printf("unique elements: %d \n",ary[i]);
  
  }

}
