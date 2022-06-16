void cubeSearch(int x){
    
    int cube = 0;
    for (int i = 1; i <= x; i++){
        cube = i * i * i;
        Console.WriteLine(cube);
    }
}


Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());
 cubeSearch(cube);