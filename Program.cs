void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
}

void SortingArray (string [] array){
    
     string[] Newarray = new string[array.Length];

     for (int i = 0; i < array.Length; i++){      
        if(array[i].Length <= 3){
        array[i] = array[i];
        Console.Write(array[i] + " "); 
        }
     }
}