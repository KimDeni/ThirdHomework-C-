void palindrome(int num){
    int arrayLength = 5;
    int[] array = new int [arrayLength];
    bool flag = true;

    
    for(int i = 4; i >= 0; i--){
        array[i] = num % 10;
        num = num / 10;
    }


    for( int i = 0; i < 2; i++){
        if (array[i] != array[arrayLength - 1 - i]){
            flag = false;
            break;
        }
    }

    if (flag == true){
        Console.WriteLine("Число является палиндромом");
    }
    else{
        Console.WriteLine("Число не является палиндромом");
    }
}

int number = Convert.ToInt32(Console.ReadLine());

palindrome(number);
