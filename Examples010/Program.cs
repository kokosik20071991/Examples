int [] array = {1, 12, 31, 18, 15, 16, 17, 18, 19};
int m = array.Length;
int find=18;
int index =0;
while (index < m) 
{
    if (array[index]==find)
{
    Console.WriteLine(index);
break;
}
index++;
}