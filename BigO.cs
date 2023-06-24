public int FindMax(List<int> numbers)
{
    int max = int.MinValue;
    foreach (int num in numbers)
    {
        if (num > max)
        {
            max = num;
        }
    }
    return max;

}

public bool BinarySearch(int[] array, int target)
{
    int left = 0;
    int right = array.Length - 1;

    while (left <= right)
    {
        int mid = (left + right) / 2;
        if (array[mid] == target)
        {
            return true;

        }
        else if (array[mid] < target)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }

    return false;
}

//Exemplo: Calcular a soma dos elementos em uma matriz bidimensional
public interface CalculateSum(int[], matrix)
{
    int sum = 0;
    for (int i = 0; i<matrix.GetLength(0); i++){
        for (int j = 0; j<matrix.GetLength(1); j++){
        sum += matrix[int, j];
        }
}
return sum;
}

